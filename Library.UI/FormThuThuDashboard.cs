using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    public partial class FormThuThuDashboard : Form
    {
        private Form? currentFormChild = null;

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
            lblLibrarianInfo.Text = $"Thủ thư: {librarianName} | {desk} | Giờ vào: {SessionContext.LoginTime:HH:mm:ss}";

            // Mặc định khi vừa đăng nhập -> Mở Bàn Lưu Thông
            btnBanLuuThong.PerformClick();
        }

        private void SetActiveMenu(Button activeButton, string pageTitle)
        {
            // Reset màu toàn bộ nút trên Sidebar
            btnBanLuuThong.BackColor = Color.FromArgb(19, 78, 74);
            btnXuLyViPham.BackColor = Color.FromArgb(19, 78, 74);
            btnLichTruc.BackColor = Color.FromArgb(19, 78, 74);
            btnDoiMatKhau.BackColor = Color.FromArgb(19, 78, 74);

            // Đánh dấu nút được chọn
            activeButton.BackColor = Color.FromArgb(15, 118, 110);
            lblPageTitle.Text = pageTitle;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBanLuuThong_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnBanLuuThong, "BÀN TÁC NGHIỆP LƯU THÔNG (MƯỢN - TRẢ SÁCH)");
            OpenChildForm(new FormBanLuuThong());
        }

        private void btnXuLyViPham_Click(object sender, EventArgs e)
        {
            SetActiveMenu(btnXuLyViPham, "QUẢN LÝ VI PHẠM & XỬ LÝ PHẠT");
            OpenChildForm(new FormLapBienBanViPham());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using var form = new FormDoiMatKhau();
            form.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc ca trực và đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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