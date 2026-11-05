using System;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    public partial class FormDoiMatKhau : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();

        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucHienDoiMatKhau();
        }

        private void ThucHienDoiMatKhau()
        {
            if (SessionContext.CurrentUser == null)
            {
                MessageBox.Show("Phiên làm việc đã hết hạn hoặc chưa đăng nhập!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string oldPass = txtMatKhauCu.Text;
            string newPass = txtMatKhauMoi.Text;
            string confirmPass = txtXacNhanMatKhau.Text;

            try
            {
                var (isSuccess, message) = _nguoiDungBLL.DoiMatKhau(
                    SessionContext.CurrentUser.Ma_So,
                    oldPass,
                    newPass,
                    confirmPass
                );

                if (isSuccess)
                {
                    // 👉 GHI NHẬN VẾT BẢO MẬT
                    SystemLogger.Log(
                        LogLevel.SECURITY,
                        "Đổi mật khẩu",
                        $"Tài khoản '{SessionContext.CurrentUser.Ten_Dang_Nhap}' đã thay đổi mật khẩu thành công.",
                        SessionContext.CurrentUser.Ma_So
                    );

                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool showPass = chkHienMatKhau.Checked;
            txtMatKhauCu.UseSystemPasswordChar = !showPass;
            txtMatKhauMoi.UseSystemPasswordChar = !showPass;
            txtXacNhanMatKhau.UseSystemPasswordChar = !showPass;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtMatKhauMoi.Focus();
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtXacNhanMatKhau.Focus();
        }

        private void txtXacNhanMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ThucHienDoiMatKhau();
        }
    }
}