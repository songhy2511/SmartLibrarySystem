using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormPhanCaTruc : Form
    {
        private readonly CaTrucBLL _caTrucBLL = new CaTrucBLL();
        private List<ThuThuDTO> _danhSachThuThu = new List<ThuThuDTO>();
        private List<ChiNhanhDTO> _danhSachChiNhanh = new List<ChiNhanhDTO>();

        public FormPhanCaTruc()
        {
            InitializeComponent();
        }

        private void FormPhanCaTruc_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            // Mặc định lọc ca trực từ đầu tuần đến cuối tuần
            dtpTuNgay.Value = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
            dtpDenNgay.Value = dtpTuNgay.Value.AddDays(6);
            dtpNgayTruc.Value = today;

            cboTenCa.SelectedIndex = 0; // Mặc định Ca Sáng
            CapNhatKhungGioMacDinh();

            TaiDanhSachChiNhanh();
            TaiDanhSachThuThu();
            TaiDanhSachCaTruc();
            dgvCaTruc.EnableDoubleBuffered(true);
        }

        private void TaiDanhSachChiNhanh()
        {
            try
            {
                _danhSachChiNhanh = _caTrucBLL.LayDanhSachChiNhanhDangHoatDong();
                cboChiNhanh.DataSource = _danhSachChiNhanh;
                cboChiNhanh.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanh.ValueMember = "Ma_So";

                cboChiNhanh.Format += (s, e) => {
                    if (e.ListItem is ChiNhanhDTO cn)
                    {
                        e.Value = $"[{cn.Ma_Chi_Nhanh}] {cn.Ten_Chi_Nhanh}";
                    }
                };

                if (_danhSachChiNhanh.Count > 0)
                {
                    cboChiNhanh.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách chi nhánh: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachThuThu()
        {
            try
            {
                _danhSachThuThu = _caTrucBLL.LayDanhSachThuThuDangHoatDong();
                cboThuThu.DataSource = _danhSachThuThu;
                cboThuThu.DisplayMember = "Ho_Ten";
                cboThuThu.ValueMember = "Ma_So";

                cboThuThu.Format += (s, e) => {
                    if (e.ListItem is ThuThuDTO tt)
                    {
                        e.Value = $"{tt.Ma_Thu_Thu} - {tt.Ho_Ten} ({tt.Quay_Phu_Trach})";
                    }
                };

                if (_danhSachThuThu.Count > 0)
                {
                    cboThuThu.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách thủ thư: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachCaTruc()
        {
            try
            {
                var list = _caTrucBLL.LayDanhSachCaTruc(dtpTuNgay.Value, dtpDenNgay.Value);
                dgvCaTruc.AutoGenerateColumns = false;
                dgvCaTruc.DataSource = null;
                dgvCaTruc.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show($"Không thể tải danh sách ca làm việc trong khoảng thời gian này!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatKhungGioMacDinh();
        }

        private void CapNhatKhungGioMacDinh()
        {
            if (cboTenCa.SelectedIndex == 0) // Ca Sáng
            {
                dtpGioBatDau.Value = DateTime.Today.Add(new TimeSpan(7, 30, 0));
                dtpGioKetThuc.Value = DateTime.Today.Add(new TimeSpan(12, 0, 0));
            }
            else // Ca Chiều
            {
                dtpGioBatDau.Value = DateTime.Today.Add(new TimeSpan(13, 0, 0));
                dtpGioKetThuc.Value = DateTime.Today.Add(new TimeSpan(17, 30, 0));
            }
        }

        private void btnLuuCa_Click(object sender, EventArgs e)
        {
            if (cboChiNhanh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh làm việc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboThuThu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân sự thủ thư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int chiNhanhMaSo = Convert.ToInt32(cboChiNhanh.SelectedValue);
            int thuThuMaSo = Convert.ToInt32(cboThuThu.SelectedValue);
            DateTime ngayTruc = dtpNgayTruc.Value.Date;
            string tenCa = cboTenCa.SelectedIndex == 0 ? "Ca Sáng" : "Ca Chiều";
            TimeSpan gioBatDau = dtpGioBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
            decimal tienDauCa = nudTienDauCa.Value;
            string ghiChu = txtGhiChu.Text.Trim();

            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(
                thuThuMaSo,
                chiNhanhMaSo,
                ngayTruc,
                tenCa,
                gioBatDau,
                gioKetThuc,
                tienDauCa,
                ghiChu
            );

            if (isSuccess)
            {
                // 👉 GHI LOG PHÂN CA THÀNH CÔNG (Mức INFO)
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Phân ca trực",
                    $"Phân công thủ thư '{cboThuThu.Text}' trực {tenCa} ngày {ngayTruc:dd/MM/yyyy} tại {cboChiNhanh.Text} (Tiền đầu ca: {tienDauCa:N0}đ).",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Clear();
                TaiDanhSachCaTruc();
            }
            else
            {
                // 👉 GHI LOG KHI PHÂN CA BỊ TRÙNG HOẶC THẤT BẠI (Mức WARNING)
                SystemLogger.Log(
                    LogLevel.WARNING,
                    "Phân ca thất bại",
                    $"Không thể phân ca cho '{cboThuThu.Text}' ({tenCa} ngày {ngayTruc:dd/MM/yyyy}). Lý do: {message}",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(message, "Cảnh báo phân ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (dgvCaTruc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một ca trực từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCaTruc.CurrentRow.DataBoundItem is not CaTrucDTO selected) return;

            if (selected.Trang_Thai != "Chưa bắt đầu")
            {
                MessageBox.Show($"Không thể xóa ca trực có trạng thái '{selected.Trang_Thai}'!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn hủy phân công {selected.Ten_Ca} ngày {selected.Ngay_Truc:dd/MM/yyyy} tại chi nhánh '{selected.Ten_Chi_Nhanh}' của thủ thư '{selected.Ho_Ten}'?",
                "Xác nhận xóa ca trực",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            var (isSuccess, message) = _caTrucBLL.XoaCaTruc(selected.Ma_So);
            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.WARNING,
                    "Hủy phân ca trực",
                    $"Quản trị viên đã hủy ca trực #{selected.Ma_So} ({selected.Ten_Ca} ngày {selected.Ngay_Truc:dd/MM/yyyy}) của thủ thư '{selected.Ho_Ten}' tại {selected.Ten_Chi_Nhanh}.",
                    SessionContext.CurrentUser?.Ma_So
                );
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachCaTruc();
            }
            else
            {
                MessageBox.Show(message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            TaiDanhSachCaTruc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiDanhSachCaTruc();
        }

        private void dgvCaTruc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvCaTruc.Rows.Count) return;
            var item = dgvCaTruc.Rows[e.RowIndex].DataBoundItem as CaTrucDTO;
            if (item == null) return;

            string colName = dgvCaTruc.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colNgayTruc" && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
            else if (colName == "colGioTruc")
            {
                e.Value = $"{item.Gio_Bat_Dau:hh\\:mm} - {item.Gio_Ket_Thuc:hh\\:mm}";
                e.FormattingApplied = true;
            }
            else if (colName == "colTienDauCa" && e.Value != null)
            {
                e.Value = $"{Convert.ToDecimal(e.Value):N0} đ";
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
                else if (status == "Đã kết ca")
                {
                    e.Value = "🟢 Đã kết ca";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                }
                else
                {
                    e.Value = "⚪ Chưa bắt đầu";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139);
                }
                e.FormattingApplied = true;
            }
        }
    }
}