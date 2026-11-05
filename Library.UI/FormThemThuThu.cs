using System;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    public partial class FormThemThuThu : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();

        public FormThemThuThu()
        {
            InitializeComponent();
        }

        private void FormThemThuThu_Load(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị trước mã TT0xxx tự sinh kế tiếp
                txtMaThuThu.Text = _nguoiDungBLL.LayMaThuThuTiepTheo();
                cboQuayPhuTrach.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi sinh mã thủ thư: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string counter = cboQuayPhuTrach.SelectedItem?.ToString() ?? "Quầy Mượn - Trả số 1";

            var (isSuccess, message, _) = _nguoiDungBLL.ThemThuThu(
                username,
                fullName,
                phone,
                email,
                counter
            );

            if (isSuccess)
            {
                MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}