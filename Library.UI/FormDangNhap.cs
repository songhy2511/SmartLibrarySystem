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

                if (!isSuccess || user == null)
                {
                    MessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                // 1. Lưu phiên làm việc toàn cục
                SessionContext.CurrentUser = user;
                SessionContext.CurrentLibrarian = librarian;
                SessionContext.LoginTime = DateTime.Now;

                // 2. Phân quyền và điều hướng giao diện tương ứng
                if (user.Vai_Tro == "Admin")
                {
                    var adminForm = new FormAdminDashboard();
                    adminForm.Show();
                    this.Hide();
                }
                else if (user.Vai_Tro == "Librarian")
                {
                    var librarianForm = new FormThuThuDashboard();
                    librarianForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vai trò người dùng không hợp lệ trong hệ thống!", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối CSDL: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}