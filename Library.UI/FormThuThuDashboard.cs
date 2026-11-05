using Library.BLL;
using System;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormThuThuDashboard : Form
    {
        public FormThuThuDashboard()
        {
            InitializeComponent();
        }

        private void FormThuThuDashboard_Load(object sender, EventArgs e)
        {
            if (SessionContext.CurrentUser == null || !SessionContext.IsLibrarian)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào bàn làm việc của Thủ thư!", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            string librarianName = SessionContext.CurrentLibrarian?.Ho_Ten ?? SessionContext.CurrentUser.Ten_Dang_Nhap;
            string desk = SessionContext.CurrentLibrarian?.Quay_Phu_Trach ?? "Quầy số 1";
            lblLibrarianInfo.Text = $"Thủ thư: {librarianName} | {desk} | Đăng nhập: {SessionContext.LoginTime:HH:mm:ss}";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using var form = new FormDoiMatKhau();
            form.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Bạn có muốn kết thúc ca trực và đăng xuất tài khoản?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                // 👉 GHI LOG ĐĂNG XUẤT CỦA THỦ THƯ
                if (SessionContext.CurrentUser != null)
                {
                    SystemLogger.Log(
                        LogLevel.SECURITY,
                        "Đăng xuất",
                        $"Thủ thư '{SessionContext.CurrentLibrarian?.Ho_Ten ?? SessionContext.CurrentUser.Ten_Dang_Nhap}' đã đăng xuất.",
                        SessionContext.CurrentUser.Ma_So
                    );
                }

                SessionContext.Clear();
                this.Hide();
                new FormDangNhap().Show();
            }
        }

        private void FormThuThuDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionContext.CurrentUser != null)
            {
                Application.Exit();
            }
        }
    }
}