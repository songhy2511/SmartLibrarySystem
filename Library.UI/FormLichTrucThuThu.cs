using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormLichTrucThuThu : Form
    {
        private readonly CaTrucBLL _caTrucBLL = new CaTrucBLL();
        private DateTime _currentDate = DateTime.Today;

        public FormLichTrucThuThu()
        {
            InitializeComponent();
        }

        private void FormLichTrucThuThu_Load(object sender, EventArgs e)
        {
            cboCheDoXem.SelectedIndex = 0; // Mặc định xem theo Tuần
            CapNhatKhoangThoiGian();
            TaiLichTruc();
            dgvLichTruc.EnableDoubleBuffered(true);
        }

        private void CapNhatKhoangThoiGian()
        {
            if (cboCheDoXem.SelectedIndex == 0) // Xem theo Tuần
            {
                int diff = (7 + (int)_currentDate.DayOfWeek - (int)DayOfWeek.Monday) % 7;
                DateTime monday = _currentDate.AddDays(-diff).Date;
                DateTime sunday = monday.AddDays(6).Date;

                dtpTuNgay.Value = monday;
                dtpDenNgay.Value = sunday;
                lblKhoangThoiGian.Text = $"Tuần: {monday:dd/MM/yyyy} - {sunday:dd/MM/yyyy}";

                dtpTuNgay.Visible = false;
                dtpDenNgay.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                btnLoc.Visible = false;
                lblKhoangThoiGian.Visible = true;
            }
            else if (cboCheDoXem.SelectedIndex == 1) // Xem theo Tháng
            {
                DateTime firstDay = new DateTime(_currentDate.Year, _currentDate.Month, 1);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                dtpTuNgay.Value = firstDay;
                dtpDenNgay.Value = lastDay;
                lblKhoangThoiGian.Text = $"Tháng {_currentDate.Month:D2}/{_currentDate.Year}";

                dtpTuNgay.Visible = false;
                dtpDenNgay.Visible = false;
                lblTuNgay.Visible = false;
                lblDenNgay.Visible = false;
                btnLoc.Visible = false;
                lblKhoangThoiGian.Visible = true;
            }
            else // Tùy chọn ngày
            {
                lblKhoangThoiGian.Visible = false;
                dtpTuNgay.Visible = true;
                dtpDenNgay.Visible = true;
                lblTuNgay.Visible = true;
                lblDenNgay.Visible = true;
                btnLoc.Visible = true;
            }
        }

        private void TaiLichTruc()
        {
            try
            {
                // Lấy mã số thủ thư từ phiên đăng nhập (nếu không có thì mặc định thủ thư số 1)
                int thuThuMaSo = SessionContext.CurrentLibrarian?.Ma_So ?? 1;

                var list = _caTrucBLL.LayLichTrucThuThu(thuThuMaSo, dtpTuNgay.Value, dtpDenNgay.Value);
                dgvLichTruc.AutoGenerateColumns = false;
                dgvLichTruc.DataSource = null;
                dgvLichTruc.DataSource = list;

                // Cập nhật thẻ tóm tắt ca trực hôm nay
                var todayShift = list.FirstOrDefault(x => x.Ngay_Truc.Date == DateTime.Today);
                if (todayShift != null)
                {
                    lblTodayContent.Text = $"{todayShift.Ten_Ca} ({todayShift.Gio_Bat_Dau:hh\\:mm} - {todayShift.Gio_Ket_Thuc:hh\\:mm}) tại {todayShift.Ten_Chi_Nhanh} - {todayShift.Quay_Phu_Trach} | Tiền đầu ca: {todayShift.Tien_Dau_Ca:N0} đ | Trạng thái: {todayShift.Trang_Thai}";
                    lblTodayContent.ForeColor = Color.FromArgb(15, 118, 110);
                }
                else
                {
                    lblTodayContent.Text = "Hôm nay bạn không có lịch trực. Hãy nghỉ ngơi hoặc liên hệ Quản lý nếu cần bổ sung phân ca.";
                    lblTodayContent.ForeColor = Color.FromArgb(100, 116, 139);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải lịch trực: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCheDoXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatKhoangThoiGian();
            TaiLichTruc();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (cboCheDoXem.SelectedIndex == 0)
                _currentDate = _currentDate.AddDays(-7);
            else if (cboCheDoXem.SelectedIndex == 1)
                _currentDate = _currentDate.AddMonths(-1);

            CapNhatKhoangThoiGian();
            TaiLichTruc();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (cboCheDoXem.SelectedIndex == 0)
                _currentDate = _currentDate.AddDays(7);
            else if (cboCheDoXem.SelectedIndex == 1)
                _currentDate = _currentDate.AddMonths(1);

            CapNhatKhoangThoiGian();
            TaiLichTruc();
        }

        private void btnHienTai_Click(object sender, EventArgs e)
        {
            _currentDate = DateTime.Today;
            CapNhatKhoangThoiGian();
            TaiLichTruc();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            TaiLichTruc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiLichTruc();
        }

        private void dgvLichTruc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvLichTruc.Rows.Count) return;
            if (dgvLichTruc.Rows[e.RowIndex].DataBoundItem is not CaTrucDTO item) return;

            string colName = dgvLichTruc.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colNgayTruc" && e.Value != null)
            {
                var dt = (DateTime)e.Value;
                var ci = new CultureInfo("vi-VN");
                string dayName = ci.DateTimeFormat.GetDayName(dt.DayOfWeek);
                dayName = char.ToUpper(dayName[0]) + dayName.Substring(1);
                e.Value = $"{dayName}, {dt:dd/MM/yyyy}";
                e.FormattingApplied = true;
            }
            else if (colName == "colKhungGio")
            {
                e.Value = $"{item.Gio_Bat_Dau:hh\\:mm} - {item.Gio_Ket_Thuc:hh\\:mm}";
                e.FormattingApplied = true;
            }
            else if (colName == "colTienDauCa" && e.Value != null)
            {
                e.Value = $"{Convert.ToDecimal(e.Value):N0} đ";
                e.FormattingApplied = true;
            }
            else if (colName == "colTienKetCa")
            {
                e.Value = e.Value == null || e.Value == DBNull.Value ? "--" : $"{Convert.ToDecimal(e.Value):N0} đ";
                e.FormattingApplied = true;
            }
            else if (colName == "colTrangThai" && e.Value != null)
            {
                string status = e.Value.ToString()!;
                if (status == "Đang trực")
                {
                    e.Value = "🔵 Đang trực";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(2, 132, 199);
                }
                else if (status == "Đã kết ca" || status == "Đã hoàn thành")
                {
                    e.Value = "🟢 Đã hoàn thành";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                }
                else
                {
                    e.Value = "⚪ Chưa trực";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139);
                }
                e.FormattingApplied = true;
            }
        }
    }
}