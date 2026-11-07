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
            catch (Exception)
            {
                MessageBox.Show($"Không thể tạo mã thủ thư tự động. Vui lòng thử lại sau!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string counter = cboQuayPhuTrach.SelectedItem?.ToString() ?? "Quầy Mượn - Trả số 1";

            var (isSuccess, message, maThuThu, matKhauKhoiTao) = _nguoiDungBLL.ThemThuThu(
                username,
                fullName,
                phone,
                email,
                counter
            );

            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.SECURITY,
                    "Thêm mới nhân sự",
                    $"Tạo tài khoản thủ thư mới '{username}' (Mã: {maThuThu}, Họ tên: {fullName}, Quầy: {counter}).",
                    SessionContext.CurrentUser?.Ma_So
                );
                // Tự động sao chép mật khẩu tạm vào Clipboard
                Clipboard.SetText(matKhauKhoiTao);

                MessageBox.Show(
                    $"{message}\n\n" +
                    $"Mã thủ thư: {maThuThu}\n" +
                    $"Tài khoản: {username}\n" +
                    $"Mật khẩu tạm thời: {matKhauKhoiTao}\n\n" +
                    $"(Mật khẩu đã được copy vào Clipboard để gửi cho nhân viên).",
                    "Cấp Tài Khoản Thành Công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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