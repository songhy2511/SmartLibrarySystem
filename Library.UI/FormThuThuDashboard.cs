using Library.BLL;
using System;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormThuThuDashboard : Form
    {
        private Form? currentFormChild = null; // Thêm dấu ? để khai báo đây là kiểu nullable
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

        private void OpenChildForm(Form childForm)
        {
            // Nếu đang có form con hiển thị thì đóng lại để giải phóng bộ nhớ
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;                  // Biến form con thành dạng control
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa bỏ viền cửa sổ của form con
            childForm.Dock = DockStyle.Fill;             // Phủ kín vùng panel chứa bên phải

            // Thay thế 'pnlNoiDung' bằng tên Panel chứa nội dung bên phải sẵn có của bạn
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // Khi người dùng bấm vào mục "Bàn Lưu Thông" trên menu sẵn có
        private void btnBanLuuThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanLuuThong());
        }

        // Khi người dùng bấm vào mục "Xử Lý Vi Phạm Phạt" trên menu sẵn có
        private void btnXuLyViPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapBienBanViPham());
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
                this.Close();
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