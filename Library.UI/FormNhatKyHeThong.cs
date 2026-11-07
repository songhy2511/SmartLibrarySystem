using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormNhatKyHeThong : Form
    {
        private readonly NhatKyHeThongBLL _bll = new NhatKyHeThongBLL();

        public FormNhatKyHeThong()
        {
            InitializeComponent();
        }

        private void FormNhatKyHeThong_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = today.AddDays(-7);
            dtpDenNgay.Value = today;

            NapBoLoc();
            TaiDanhSachNhatKy();
            dgvNhatKy.EnableDoubleBuffered(true);
        }

        private void NapBoLoc()
        {
            try
            {
                cboMucDo.DataSource = _bll.LayDanhSachMucDo();
                cboMucDo.SelectedIndex = 0;

                cboHanhDong.DataSource = _bll.LayDanhSachBoLocHanhDong();
                cboHanhDong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải bộ lọc: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachNhatKy()
        {
            try
            {
                string mucDo = cboMucDo.SelectedIndex > 0 ? cboMucDo.SelectedItem?.ToString() ?? "" : "";
                string hanhDong = cboHanhDong.SelectedIndex > 0 ? cboHanhDong.SelectedItem?.ToString() ?? "" : "";
                string tuKhoa = txtTuKhoa.Text.Trim();

                var list = _bll.TraCuu(dtpTuNgay.Value, dtpDenNgay.Value, mucDo, hanhDong, tuKhoa);

                dgvNhatKy.AutoGenerateColumns = false;
                dgvNhatKy.DataSource = null;
                dgvNhatKy.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show($"Không thể tải dữ liệu nhật ký hoạt động của hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            TaiDanhSachNhatKy();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboMucDo.SelectedIndex = 0;
            cboHanhDong.SelectedIndex = 0;
            TaiDanhSachNhatKy();
        }

        private void btnMoThuMucLog_Click(object sender, EventArgs e)
        {
            try
            {
                string logFolder = SystemLogger.LayThuMucLog();
                Process.Start(new ProcessStartInfo
                {
                    FileName = logFolder,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception)
            {
                MessageBox.Show($"Thư mục chứa tệp nhật ký chưa được khởi tạo hoặc không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhatKy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvNhatKy.Rows.Count) return;
            if (dgvNhatKy.Rows[e.RowIndex].DataBoundItem is not NhatKyHeThongDTO item) return;

            string colName = dgvNhatKy.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colThoiGian" && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy HH:mm:ss");
                e.FormattingApplied = true;
            }
            else if (colName == "colMucDo")
            {
                switch (item.Muc_Do)
                {
                    case "SECURITY":
                        e.Value = "🛡 SECURITY";
                        if (e.CellStyle != null) { e.CellStyle.ForeColor = Color.FromArgb(124, 58, 237); e.CellStyle.Font = new Font(dgvNhatKy.Font, FontStyle.Bold); }
                        break;
                    case "WARNING":
                        e.Value = "⚠ WARNING";
                        if (e.CellStyle != null) { e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6); e.CellStyle.Font = new Font(dgvNhatKy.Font, FontStyle.Bold); }
                        break;
                    case "ERROR":
                        e.Value = "❌ ERROR";
                        if (e.CellStyle != null) { e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72); e.CellStyle.Font = new Font(dgvNhatKy.Font, FontStyle.Bold); }
                        break;
                    default:
                        e.Value = "ℹ INFO";
                        if (e.CellStyle != null) { e.CellStyle.ForeColor = Color.FromArgb(2, 132, 199); }
                        break;
                }
                e.FormattingApplied = true;
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}