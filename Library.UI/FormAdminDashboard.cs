using Library.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    /// <summary>
    /// Khung làm việc của Admin: thanh bên trái chọn chức năng, vùng pnlContent nhúng form con.
    /// Form con (tổng quan, nhân sự, chi nhánh...) không phải cửa sổ riêng; chúng được Dock.fill vào panel.
    /// Báo cáo và đổi mật khẩu là hộp thoại riêng (ShowDialog), không nhúng vào panel.
    /// </summary>
    public partial class FormAdminDashboard : Form
    {
        private Form? _activeChildForm = null;      // Form đang nằm trong vùng nội dung
        private Button? _currentActiveButton = null; // Nút sidebar đang được tô sáng

        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        /// <summary>Chặn người không phải Admin, hiện tên tài khoản, rồi mở sẵn màn Tổng quan.</summary>
        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            if (SessionContext.CurrentUser == null || !SessionContext.IsAdmin)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào phân hệ Quản trị viên!", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            lblSessionInfo.Text = $"Quản trị viên: {SessionContext.CurrentUser.Ten_Dang_Nhap} | Đăng nhập lúc: {SessionContext.LoginTime:HH:mm:ss dd/MM/yyyy}";

            // Mặc định ban đầu chọn tab Tổng quan
            HighlightButton(btnTongQuan);
            btnTongQuan.PerformClick();
        }

        /// <summary>
        /// Đưa mọi nút sidebar về màu tối, rồi tô sáng nút đang chọn.
        /// Nút Báo cáo và Đổi mật khẩu không được tô vì chúng mở popup, không đổi trang nội dung.
        /// </summary>
        private void HighlightButton(Button selectedButton)
        {
            // Reset toàn bộ các nút về màu Sidebar mặc định
            btnTongQuan.BackColor = Color.FromArgb(15, 23, 42);
            btnTongQuan.ForeColor = Color.FromArgb(203, 213, 225);

            btnNhanSu.BackColor = Color.FromArgb(15, 23, 42);
            btnNhanSu.ForeColor = Color.FromArgb(203, 213, 225);

            btnChiNhanh.BackColor = Color.FromArgb(15, 23, 42);
            btnChiNhanh.ForeColor = Color.FromArgb(203, 213, 225);

            btnCaTruc.BackColor = Color.FromArgb(15, 23, 42);
            btnCaTruc.ForeColor = Color.FromArgb(203, 213, 225);

            btnQuyChe.BackColor = Color.FromArgb(15, 23, 42);
            btnQuyChe.ForeColor = Color.FromArgb(203, 213, 225);

            btnNhatKy.BackColor = Color.FromArgb(15, 23, 42);
            btnNhatKy.ForeColor = Color.FromArgb(203, 213, 225);

            // Bật màu Active cho nút đang bấm (nếu không phải nút popup)
            if (selectedButton != btnBaoCao && selectedButton != btnDoiMatKhau)
            {
                _currentActiveButton = selectedButton;
                _currentActiveButton.BackColor = Color.FromArgb(30, 41, 59);
                _currentActiveButton.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Đóng form con cũ, nhúng form mới vào pnlContent và đổi tiêu đề trang.
        /// TopLevel = false là điều kiện để một Form được đặt bên trong control khác.
        /// </summary>
        private void LoadChildForm(Form childForm, string pageTitle, Button senderButton)
        {
            if (_activeChildForm != null)
            {
                _activeChildForm.Close();
            }

            HighlightButton(senderButton);

            _activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblCurrentPageTitle.Text = pageTitle;
        }

        /// <summary>KPI toàn hệ thống: số bạn đọc, đầu sách, sách đang mượn, tiền phạt chưa thu.</summary>
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormTongQuanHeThong(), "TỔNG QUAN HỆ THỐNG & ĐỐI SOÁT KPI", (Button)sender);
        }

        /// <summary>Thêm, sửa, khóa tài khoản và cấp lại mật khẩu thủ thư.</summary>
        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormQuanLyNhanSu(), "QUẢN LÝ NHÂN SỰ VÀ TÀI KHOẢN", (Button)sender);
        }

        /// <summary>Thêm chi nhánh mới (mã CN01, CN02... sinh tự động).</summary>
        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormQuanLyChiNhanh(), "QUẢN LÝ HỆ THỐNG CHI NHÁNH", (Button)sender);
        }

        /// <summary>Phân ca sáng/chiều cho thủ thư theo từng chi nhánh.</summary>
        private void btnCaTruc_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormPhanCaTruc(), "PHÂN CÔNG CA LÀM VIỆC & ĐỐI SOÁT", (Button)sender);
        }

        /// <summary>Sửa tham số động: số sách tối đa, số ngày mượn, tiền phạt/ngày, tỷ lệ đền bù.</summary>
        private void btnQuyChe_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormQuyCheThamSo(), "QUY CHẾ & CẤU HÌNH THAM SỐ ĐỘNG", (Button)sender);
        }

        /// <summary>Xem nhật ký kiểm toán (INFO, WARNING, ERROR, SECURITY) đã ghi vào SQL.</summary>
        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormNhatKyHeThong(), "NHẬT KÝ HOẠT ĐỘNG HỆ THỐNG", (Button)sender);
        }

        /// <summary>Mở báo cáo dạng hộp thoại. using giải phóng form ngay khi đóng.</summary>
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            using var form = new FormBaoCaoThongKe();
            form.ShowDialog(this);
        }

        /// <summary>Admin tự đổi mật khẩu của chính tài khoản đang đăng nhập.</summary>
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using var form = new FormDoiMatKhau();
            form.ShowDialog(this);
        }

        /// <summary>Ghi log SECURITY, xóa user khỏi phiên rồi đóng dashboard để form đăng nhập hiện lại.</summary>
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (SessionContext.CurrentUser != null)
                {
                    SystemLogger.Log(
                        LogLevel.SECURITY,
                        "Đăng xuất",
                        $"Tài khoản '{SessionContext.CurrentUser.Ten_Dang_Nhap}' đã đăng xuất khỏi hệ thống.",
                        SessionContext.CurrentUser.Ma_So
                    );
                }

                SessionContext.CurrentUser = null;
                this.Close();
            }
        }

        /// <summary>
        /// Bấm nút X trên cửa sổ (UserClosing) khi vẫn còn phiên thì thoát cả app.
        /// Đăng xuất thì CurrentUser đã được gán null trước khi Close, nên nhánh này không chạy.
        /// </summary>
        private void FormAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionContext.CurrentUser != null)
            {
                Application.Exit();
            }
        }
    }
}