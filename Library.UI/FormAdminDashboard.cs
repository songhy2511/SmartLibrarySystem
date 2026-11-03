using System;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            if (SessionContext.CurrentUser == null || !SessionContext.IsAdmin)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào phân hệ Quản trị viên!", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            lblSessionInfo.Text = $"Quản trị viên: {SessionContext.CurrentUser.Ten_Dang_Nhap} | Đăng nhập lúc: {SessionContext.LoginTime:HH:mm:ss dd/MM/yyyy}";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using var form = new FormDoiMatKhau();
            form.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản quản trị?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SessionContext.Clear();
                this.Hide();
                new FormDangNhap().Show();
            }
        }

        private void FormAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionContext.CurrentUser != null)
            {
                Application.Exit();
            }
        }
    }
}