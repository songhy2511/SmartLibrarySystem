using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    /// <summary>
    /// Khung làm việc của Thủ thư. Cùng kiểu nhúng form con như Admin, nhưng menu là nghiệp vụ quầy:
    /// bạn đọc, kho sách, mượn-trả, biên bản phạt, lịch trực.
    /// Khác Admin: trước khi đăng xuất, nếu còn ca chưa chốt thì bắt mở FormChotCaTruc.
    /// </summary>
    public partial class FormThuThuDashboard : Form
    {
        private Form? activeForm = null; // Form con đang hiển thị trong pnlContent

        public FormThuThuDashboard()
        {
            InitializeComponent();
        }

        /// <summary>Chặn người không phải thủ thư, hiện tên + quầy, rồi mở sẵn bàn mượn-trả.</summary>
        private void FormThuThuDashboard_Load(object sender, EventArgs e)
        {
            SetupSidebarHoverEffects();

            if (SessionContext.CurrentUser == null || !SessionContext.IsLibrarian)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào bàn làm việc của Thủ thư!", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            string librarianName = SessionContext.CurrentLibrarian?.Ho_Ten ?? SessionContext.CurrentUser.Ten_Dang_Nhap;
            string desk = SessionContext.CurrentLibrarian?.Quay_Phu_Trach ?? "Quầy số 1";
            lblLibrarianInfo.Text = $"Thủ thư: {librarianName} | {desk} | Đăng nhập: {SessionContext.LoginTime:HH:mm:ss}";

            // Mặc định khi vừa đăng nhập -> Mở Bàn Lưu Thông
            btnBanLuuThong.PerformClick();
        }

        /// <summary>Đổi màu nền khi rê chuột: nút chức năng màu teal, nút đăng xuất màu đỏ.</summary>
        private void SetupSidebarHoverEffects()
        {
            Color hoverColor = Color.FromArgb(15, 118, 110);
            Color downColor = Color.FromArgb(13, 148, 136);

            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn && btn != btnDangXuat)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = hoverColor;
                    btn.FlatAppearance.MouseDownBackColor = downColor;
                }
            }

            if (btnDangXuat != null)
            {
                btnDangXuat.FlatStyle = FlatStyle.Flat;
                btnDangXuat.FlatAppearance.BorderSize = 0;
                btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
                btnDangXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 27, 27);
            }
        }

        /// <summary>Tô đậm nút đang chọn và ghi tiêu đề trang lên thanh trên.</summary>
        private void HighlightActiveButton(Button? activeBtn, string pageTitle)
        {
            if (activeBtn == null) return;

            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn && btn != btnDangXuat)
                {
                    btn.BackColor = Color.Transparent;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    btn.ForeColor = Color.FromArgb(204, 251, 241);
                }
            }

            activeBtn.BackColor = Color.FromArgb(15, 118, 110);
            activeBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            activeBtn.ForeColor = Color.White;
            lblPageTitle.Text = pageTitle;
        }

        /// <summary>Đóng màn con cũ rồi nhúng màn mới vào pnlContent (không viền, chiếm hết panel).</summary>
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>Cấp thẻ, khóa thẻ, gia hạn thẻ bạn đọc.</summary>
        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "QUẢN LÝ BẠN ĐỌC & HỒ SƠ ĐỘC GIẢ");
            OpenChildForm(new FormQuanLyDocGia());
        }

        /// <summary>Tra kho chi nhánh, sửa vị trí kệ, đề xuất thanh lý bản sao hỏng.</summary>
        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "QUẢN LÝ KHO SÁCH CHI NHÁNH & DANH MỤC BIỂU GHI");
            OpenChildForm(new FormQuanLySach());
        }

        /// <summary>Màn chính của quầy: lập phiếu mượn, gia hạn, nhận trả, sửa số điện thoại.</summary>
        private void btnBanLuuThong_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "BÀN TÁC NGHIỆP LƯU THÔNG (MƯỢN - TRẢ SÁCH)");
            OpenChildForm(new FormBanLuuThong());
        }

        /// <summary>Lập biên bản rách/hỏng/mất và thu tiền phạt vào quỹ ca.</summary>
        private void btnXuLyViPham_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "QUẢN LÝ VI PHẠM & XỬ LÝ PHẠT");
            OpenChildForm(new FormLapBienBanViPham());
        }

        /// <summary>Xem lịch phân công của chính thủ thư đang đăng nhập (tuần hoặc tháng).</summary>
        private void btnLichTruc_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "LỊCH TRỰC CÁ NHÂN & BÀN GIAO CA");
            OpenChildForm(new FormLichTrucThuThu());
        }

        /// <summary>Mở cùng form báo cáo mà Admin dùng, dạng hộp thoại.</summary>
        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "BÁO CÁO & THỐNG KÊ");
            try
            {
                using (var form = new FormBaoCaoThongKe())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở màn hình báo cáo: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Thủ thư tự đổi mật khẩu; phải nhập đúng mật khẩu cũ.</summary>
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender as Button, "ĐỔI MẬT KHẨU");
            using var form = new FormDoiMatKhau();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Đăng xuất có kiểm quỹ. Nếu CaTrucBLL báo còn ca chưa chốt thì phải hoàn tất FormChotCaTruc
        /// (DialogResult.OK) rồi mới được thoát. Hủy form chốt ca thì ở lại dashboard.
        /// </summary>
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Bắt lỗi mất session
            if (SessionContext.CurrentLibrarian == null)
            {
                SessionContext.Clear();
                this.Close();
                return;
            }

            int thuThuId = SessionContext.CurrentLibrarian.Ma_So;
            var bll = new CaTrucBLL();
            var caTruc = bll.LayCaTrucHienTai(thuThuId);

            // Nếu thủ thư đang có ca trực chưa chốt
            if (caTruc.HasShift)
            {
                using var formChotCa = new FormChotCaTruc(caTruc.CaTrucId, caTruc.TenCa, caTruc.TienDauCa, caTruc.TienThuPhat);
                if (formChotCa.ShowDialog(this) != DialogResult.OK)
                {
                    return; // Hủy thao tác đăng xuất nếu thủ thư tắt form chốt ca
                }
            }
            else
            {
                // Nếu không có ca trực nào cần chốt (hoặc đã chốt rồi), hỏi đăng xuất bình thường
                var confirm = MessageBox.Show(
                    "Bạn có muốn đăng xuất khỏi tài khoản?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;
            }

            SystemLogger.Log(
                LogLevel.SECURITY,
                "Đăng xuất",
                $"Thủ thư '{SessionContext.CurrentLibrarian.Ho_Ten}' đã đăng xuất.",
                SessionContext.CurrentUser?.Ma_So
            );

            SessionContext.Clear();
            this.Close();
        }

        /// <summary>Bấm X khi còn phiên thì thoát app. Đăng xuất đã Clear() phiên nên không vào nhánh này.</summary>
        private void FormThuThuDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && SessionContext.CurrentUser != null)
            {
                Application.Exit();
            }
        }
    }
}