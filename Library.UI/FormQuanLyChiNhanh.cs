using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    public partial class FormQuanLyChiNhanh : Form
    {
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();

        public FormQuanLyChiNhanh()
        {
            InitializeComponent();
        }

        private void FormQuanLyChiNhanh_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            dgvChiNhanh.EnableDoubleBuffered(true);
        }

        private void TaiDuLieu()
        {
            try
            {
                txtMaChiNhanh.Text = _chiNhanhBLL.LayMaChiNhanhTiepTheo();
                var list = _chiNhanhBLL.LayDanhSachChiNhanh();
                dgvChiNhanh.AutoGenerateColumns = false;
                dgvChiNhanh.DataSource = null;
                dgvChiNhanh.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu chi nhánh: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenChiNhanh = txtTenChiNhanh.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            var (isSuccess, message) = _chiNhanhBLL.ThemChiNhanh(tenChiNhanh, diaChi, soDienThoai);
            if (isSuccess)
            {
                // 👉 GHI NHẬN NHẬT KÝ KIỂM TOÁN
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Thêm chi nhánh",
                    $"Quản trị viên đã tạo mới chi nhánh '{tenChiNhanh}' (Địa chỉ: {diaChi}, SĐT: {soDienThoai}).",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChiNhanh.Clear();
                txtDiaChi.Clear();
                txtSoDienThoai.Clear();
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show(message, "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}