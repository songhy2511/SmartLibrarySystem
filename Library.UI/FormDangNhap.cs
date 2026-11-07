using System;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormDangNhap : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        private void ThucHienDangNhap()
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                var (isSuccess, message, user, librarian) = _nguoiDungBLL.DangNhap(username, password);

                // 1. Đăng nhập thất bại (ghi log WARNING)
                if (!isSuccess || user == null)
                {
                    SystemLogger.Log(
                        LogLevel.WARNING,
                        "Đăng nhập thất bại",
                        $"Cảnh báo đăng nhập thất bại cho tài khoản '{username}'. Lý do: {message}"
                    );

                    MessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                // 2. Đăng nhập thành công (ghi log SECURITY)
                SystemLogger.Log(
                    LogLevel.SECURITY,
                    "Đăng nhập",
                    $"Tài khoản '{user.Ten_Dang_Nhap}' đăng nhập thành công với vai trò '{user.Vai_Tro}'.",
                    user.Ma_So
                );

                // Lưu thông tin phiên làm việc
                SessionContext.CurrentUser = user;
                SessionContext.CurrentLibrarian = librarian;
                SessionContext.LoginTime = DateTime.Now;

                // 3. Điều hướng mở Form theo vai trò
                if (user.Vai_Tro == "Admin")
                {
                    FormAdminDashboard adminDashboard = new FormAdminDashboard();
                    this.Hide();
                    adminDashboard.ShowDialog();
                    this.Show();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
                else // Vai trò "Librarian" hoặc bất kỳ tài khoản thủ thư nào
                {
                    FormThuThuDashboard thuThuDashboard = new FormThuThuDashboard();
                    this.Hide();
                    thuThuDashboard.ShowDialog();
                    this.Show();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                SystemLogger.Log(
                    LogLevel.ERROR,
                    "Lỗi hệ thống",
                    $"Ngoại lệ khi thực hiện đăng nhập tài khoản '{username}': {ex.Message}"
                );

                MessageBox.Show("Không thể kết nối đến máy chủ cơ sở dữ liệu. Vui lòng kiểm tra đường truyền mạng hoặc liên hệ Quản trị viên!",
                "Sự cố kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDangNhap();
            }
        }

        private void pnlLoginArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBanner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}