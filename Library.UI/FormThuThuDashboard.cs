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
        // ... Các mã nguồn hiện có của Form ...

        /// <summary>
        /// Sự kiện mở Form Quản Lý Độc Giả
        /// </summary>
        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button);
            OpenChildForm(new FormQuanLyDocGia());
        }

        /// <summary>
        /// Sự kiện mở Form Quản Lý Kho Sách
        /// </summary>
        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button);
            OpenChildForm(new FormQuanLySach());
        }

        /// <summary>
        /// Hàm hỗ trợ đổi màu nút đang được chọn (active)
        /// </summary>
        private void HighlightActiveButton(Button? activeBtn)
        {
            if (activeBtn == null) return;

            // Đặt lại màu mặc định cho các nút trong sidebar
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = System.Drawing.Color.Transparent;
                }
            }

            // Đổi màu làm nổi bật nút đang được nhấp chọn
            activeBtn.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
        }
        private Form? activeForm = null;

        /// <summary>
        /// Hàm nạp Form con lồng vào Panel hiển thị chính của Dashboard
        /// </summary>
        private void OpenChildForm(Form childForm)
        {
            // 1. Đóng Form con đang mở trước đó (nếu có)
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            // 2. Thiết lập thuộc tính hiển thị lồng trong Panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. Nạp Form con vào Panel hiển thị (Lưu ý: Thay 'pnlContent' bằng tên Panel chính bên phải trên Form của bạn nếu tên khác)
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}