using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormAdminDashboard : Form
    {
        private Form? _activeChildForm = null;
        private Button? _currentActiveButton = null;

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

            // Mặc định ban đầu chọn tab Tổng quan
            HighlightButton(btnTongQuan);
            btnTongQuan.PerformClick();
        }

        // Hàm cập nhật màu sắc nút Sidebar khi được chọn
        private void HighlightButton(Button selectedButton)
        {
            // Reset toàn bộ các nút về màu Sidebar mặc định
            btnTongQuan.BackColor = Color.FromArgb(15, 23, 42);
            btnTongQuan.ForeColor = Color.FromArgb(203, 213, 225);

            btnNhanSu.BackColor = Color.FromArgb(15, 23, 42);
            btnNhanSu.ForeColor = Color.FromArgb(203, 213, 225);

            btnCaTruc.BackColor = Color.FromArgb(15, 23, 42);
            btnCaTruc.ForeColor = Color.FromArgb(203, 213, 225);

            btnQuyChe.BackColor = Color.FromArgb(15, 23, 42);
            btnQuyChe.ForeColor = Color.FromArgb(203, 213, 225);

            btnNhatKy.BackColor = Color.FromArgb(15, 23, 42);
            btnNhatKy.ForeColor = Color.FromArgb(203, 213, 225);

            // Bật màu Active cho nút đang bấm
            _currentActiveButton = selectedButton;
            _currentActiveButton.BackColor = Color.FromArgb(30, 41, 59);
            _currentActiveButton.ForeColor = Color.White;
        }

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

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTongQuan);
            lblCurrentPageTitle.Text = "TỔNG QUAN QUẢN TRỊ";
            if (_activeChildForm != null)
            {
                _activeChildForm.Close();
                _activeChildForm = null;
            }
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(lblWelcome);
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormQuanLyNhanSu(), "QUẢN LÝ NHÂN SỰ VÀ TÀI KHOẢN", (Button)sender);
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

        private void btnCaTruc_Click(object sender, EventArgs e)
        {
            LoadChildForm(new FormPhanCaTruc(), "PHÂN CÔNG CA LÀM VIỆC & ĐỐI SOÁT", (Button)sender);
        }

        private void btnTongQuan_Click_1(object sender, EventArgs e)
        {
            LoadChildForm(new FormTongQuanHeThong(), "TỔNG QUAN HỆ THỐNG & ĐỐI SOÁT KPI", (Button)sender);
        }
    }
}   