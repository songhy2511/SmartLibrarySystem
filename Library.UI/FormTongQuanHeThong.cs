using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormTongQuanHeThong : Form
    {
        private readonly ThongKeBLL _thongKeBLL = new ThongKeBLL();

        public FormTongQuanHeThong()
        {
            InitializeComponent();
        }

        private void FormTongQuanHeThong_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
            dtpDenNgay.Value = dtpTuNgay.Value.AddDays(6);

            TaiDanhSachChiNhanh();
            NapTheKPI();
            TaiBangDoiSoat();
        }

        private void TaiDanhSachChiNhanh()
        {
            try
            {
                var branches = _thongKeBLL.LayDanhSachChiNhanhBoLoc();
                cboChiNhanh.DataSource = branches;
                cboChiNhanh.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanh.ValueMember = "Ma_So";
                cboChiNhanh.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục chi nhánh: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapTheKPI()
        {
            try
            {
                var kpi = _thongKeBLL.LayDuLieuKPI();
                lblKpiDocGiaVal.Text = kpi.TongDocGia.ToString("N0");
                lblKpiSachVal.Text = kpi.SachSanCo.ToString("N0");
                lblKpiMuonVal.Text = kpi.LuotDangMuon.ToString("N0");
                lblKpiTienVal.Text = $"{kpi.TongTienPhatDaThu:N0} đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật KPI: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiBangDoiSoat()
        {
            try
            {
                int chiNhanhMaSo = Convert.ToInt32(cboChiNhanh.SelectedValue ?? 0);
                var list = _thongKeBLL.LayDuLieuDoiSoat(chiNhanhMaSo, dtpTuNgay.Value, dtpDenNgay.Value);

                dgvDoiSoat.AutoGenerateColumns = false;
                dgvDoiSoat.DataSource = null;
                dgvDoiSoat.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp bảng đối soát: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            TaiBangDoiSoat();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NapTheKPI();
            TaiBangDoiSoat();
        }

        private void dgvDoiSoat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDoiSoat.Rows.Count) return;
            if (dgvDoiSoat.Rows[e.RowIndex].DataBoundItem is not DoiSoatTienMatDTO item) return;

            string colName = dgvDoiSoat.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colNgayTruc" && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
            else if (colName == "colTienDauCa" || colName == "colTienThu" || colName == "colTienLyThuyet")
            {
                if (e.Value != null)
                {
                    e.Value = $"{Convert.ToDecimal(e.Value):N0} đ";
                    e.FormattingApplied = true;
                }
            }
            else if (colName == "colTienKetCa")
            {
                if (item.Tien_Ket_Ca.HasValue)
                {
                    e.Value = $"{item.Tien_Ket_Ca.Value:N0} đ";
                }
                else
                {
                    e.Value = "- - -";
                }
                e.FormattingApplied = true;
            }
            else if (colName == "colChenhLech")
            {
                if (!item.Chenh_Lech.HasValue)
                {
                    e.Value = "- - -";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                }
                else if (item.Chenh_Lech.Value == 0)
                {
                    e.Value = "✔ Khớp (0 đ)";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                }
                else if (item.Chenh_Lech.Value < 0)
                {
                    e.Value = $"▼ Thiếu ({Math.Abs(item.Chenh_Lech.Value):N0} đ)";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72);
                }
                else
                {
                    e.Value = $"▲ Thừa (+{item.Chenh_Lech.Value:N0} đ)";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6);
                }
                e.FormattingApplied = true;
            }
            else if (colName == "colTrangThai" && e.Value != null)
            {
                string status = e.Value.ToString()!;
                if (status == "Đã kết ca")
                {
                    e.Value = "🟢 Đã kết ca";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                }
                else if (status == "Đang trực")
                {
                    e.Value = "🔵 Đang trực";
                    if (e.CellStyle != null) e.CellStyle.ForeColor = Color.FromArgb(2, 132, 199);
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