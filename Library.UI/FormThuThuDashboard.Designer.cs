using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormThuThuDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnDangXuat = new Button();
            btnBaoCaoThongKe = new Button();
            btnDoiMatKhau = new Button();
            btnLichTruc = new Button();
            btnXuLyViPham = new Button();
            btnBanLuuThong = new Button();
            btnQuanLySach = new Button();
            btnQuanLyDocGia = new Button();
            pnlLogo = new Panel();
            lblLibrarianRole = new Label();
            lblAppTitle = new Label();
            pnlHeader = new Panel();
            lblLibrarianInfo = new Label();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            lblWelcome = new Label();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(19, 78, 74);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnBaoCaoThongKe);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnLichTruc);
            pnlSidebar.Controls.Add(btnXuLyViPham);
            pnlSidebar.Controls.Add(btnBanLuuThong);
            pnlSidebar.Controls.Add(btnQuanLySach);
            pnlSidebar.Controls.Add(btnQuanLyDocGia);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(185, 28, 28);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnDangXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 27, 27);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 665);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(240, 55);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "🚪 Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnBaoCaoThongKe
            // 
            btnBaoCaoThongKe.Cursor = Cursors.Hand;
            btnBaoCaoThongKe.Dock = DockStyle.Top;
            btnBaoCaoThongKe.FlatAppearance.BorderSize = 0;
            btnBaoCaoThongKe.FlatStyle = FlatStyle.Flat;
            btnBaoCaoThongKe.Font = new Font("Segoe UI", 10F);
            btnBaoCaoThongKe.ForeColor = Color.FromArgb(204, 251, 241);
            btnBaoCaoThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.Location = new Point(0, 405);
            btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            btnBaoCaoThongKe.Padding = new Padding(20, 0, 0, 0);
            btnBaoCaoThongKe.Size = new Size(240, 50);
            btnBaoCaoThongKe.TabIndex = 6;
            btnBaoCaoThongKe.Text = "📊  Báo Cáo & Thống Kê";
            btnBaoCaoThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.UseVisualStyleBackColor = true;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Cursor = Cursors.Hand;
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F);
            btnDoiMatKhau.ForeColor = Color.FromArgb(204, 251, 241);
            btnDoiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.Location = new Point(0, 355);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(20, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(240, 50);
            btnDoiMatKhau.TabIndex = 5;
            btnDoiMatKhau.Text = "🔑  Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnLichTruc
            // 
            btnLichTruc.Cursor = Cursors.Hand;
            btnLichTruc.Dock = DockStyle.Top;
            btnLichTruc.FlatAppearance.BorderSize = 0;
            btnLichTruc.FlatStyle = FlatStyle.Flat;
            btnLichTruc.Font = new Font("Segoe UI", 10F);
            btnLichTruc.ForeColor = Color.FromArgb(204, 251, 241);
            btnLichTruc.ImageAlign = ContentAlignment.MiddleLeft;
            btnLichTruc.Location = new Point(0, 305);
            btnLichTruc.Name = "btnLichTruc";
            btnLichTruc.Padding = new Padding(20, 0, 0, 0);
            btnLichTruc.Size = new Size(240, 50);
            btnLichTruc.TabIndex = 4;
            btnLichTruc.Text = "📅  Lịch Trực Của Tôi";
            btnLichTruc.TextAlign = ContentAlignment.MiddleLeft;
            btnLichTruc.UseVisualStyleBackColor = true;
            btnLichTruc.Click += btnLichTruc_Click;
            // 
            // btnXuLyViPham
            // 
            btnXuLyViPham.Cursor = Cursors.Hand;
            btnXuLyViPham.Dock = DockStyle.Top;
            btnXuLyViPham.FlatAppearance.BorderSize = 0;
            btnXuLyViPham.FlatStyle = FlatStyle.Flat;
            btnXuLyViPham.Font = new Font("Segoe UI", 10F);
            btnXuLyViPham.ForeColor = Color.FromArgb(204, 251, 241);
            btnXuLyViPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuLyViPham.Location = new Point(0, 255);
            btnXuLyViPham.Name = "btnXuLyViPham";
            btnXuLyViPham.Padding = new Padding(20, 0, 0, 0);
            btnXuLyViPham.Size = new Size(240, 50);
            btnXuLyViPham.TabIndex = 3;
            btnXuLyViPham.Text = "⚠️  Xử Lý Vi Phạt";
            btnXuLyViPham.TextAlign = ContentAlignment.MiddleLeft;
            btnXuLyViPham.UseVisualStyleBackColor = true;
            btnXuLyViPham.Click += btnXuLyViPham_Click;
            // 
            // btnBanLuuThong
            // 
            btnBanLuuThong.Cursor = Cursors.Hand;
            btnBanLuuThong.Dock = DockStyle.Top;
            btnBanLuuThong.FlatAppearance.BorderSize = 0;
            btnBanLuuThong.FlatStyle = FlatStyle.Flat;
            btnBanLuuThong.Font = new Font("Segoe UI", 10F);
            btnBanLuuThong.ForeColor = Color.FromArgb(204, 251, 241);
            btnBanLuuThong.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanLuuThong.Location = new Point(0, 205);
            btnBanLuuThong.Name = "btnBanLuuThong";
            btnBanLuuThong.Padding = new Padding(20, 0, 0, 0);
            btnBanLuuThong.Size = new Size(240, 50);
            btnBanLuuThong.TabIndex = 2;
            btnBanLuuThong.Text = "🔄  Bàn Lưu Thông (Mượn/Trả)";
            btnBanLuuThong.TextAlign = ContentAlignment.MiddleLeft;
            btnBanLuuThong.UseVisualStyleBackColor = true;
            btnBanLuuThong.Click += btnBanLuuThong_Click;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.Cursor = Cursors.Hand;
            btnQuanLySach.Dock = DockStyle.Top;
            btnQuanLySach.FlatAppearance.BorderSize = 0;
            btnQuanLySach.FlatStyle = FlatStyle.Flat;
            btnQuanLySach.Font = new Font("Segoe UI", 10F);
            btnQuanLySach.ForeColor = Color.FromArgb(204, 251, 241);
            btnQuanLySach.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLySach.Location = new Point(0, 155);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Padding = new Padding(20, 0, 0, 0);
            btnQuanLySach.Size = new Size(240, 50);
            btnQuanLySach.TabIndex = 1;
            btnQuanLySach.Text = "📚  Quản Lý Kho Sách";
            btnQuanLySach.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLySach.UseVisualStyleBackColor = true;
            btnQuanLySach.Click += btnQuanLySach_Click;
            // 
            // btnQuanLyDocGia
            // 
            btnQuanLyDocGia.Cursor = Cursors.Hand;
            btnQuanLyDocGia.Dock = DockStyle.Top;
            btnQuanLyDocGia.FlatAppearance.BorderSize = 0;
            btnQuanLyDocGia.FlatStyle = FlatStyle.Flat;
            btnQuanLyDocGia.Font = new Font("Segoe UI", 10F);
            btnQuanLyDocGia.ForeColor = Color.FromArgb(204, 251, 241);
            btnQuanLyDocGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDocGia.Location = new Point(0, 105);
            btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            btnQuanLyDocGia.Padding = new Padding(20, 0, 0, 0);
            btnQuanLyDocGia.Size = new Size(240, 50);
            btnQuanLyDocGia.TabIndex = 0;
            btnQuanLyDocGia.Text = "🪪  Quản Lý Độc Giả";
            btnQuanLyDocGia.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDocGia.UseVisualStyleBackColor = true;
            btnQuanLyDocGia.Click += btnQuanLyDocGia_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 94, 89);
            pnlLogo.Controls.Add(lblLibrarianRole);
            pnlLogo.Controls.Add(lblAppTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(240, 105);
            pnlLogo.TabIndex = 0;
            // 
            // lblLibrarianRole
            // 
            lblLibrarianRole.AutoSize = true;
            lblLibrarianRole.BackColor = Color.FromArgb(13, 148, 136);
            lblLibrarianRole.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLibrarianRole.ForeColor = Color.White;
            lblLibrarianRole.Location = new Point(20, 65);
            lblLibrarianRole.Name = "lblLibrarianRole";
            lblLibrarianRole.Padding = new Padding(6, 2, 6, 2);
            lblLibrarianRole.Size = new Size(111, 21);
            lblLibrarianRole.TabIndex = 1;
            lblLibrarianRole.Text = "QUẦY THỦ THƯ";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(20, 24);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(168, 28);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "SMART LIBRARY";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblLibrarianInfo);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(240, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(914, 65);
            pnlHeader.TabIndex = 1;
            // 
            // lblLibrarianInfo
            // 
            lblLibrarianInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLibrarianInfo.Font = new Font("Segoe UI", 9.5F);
            lblLibrarianInfo.ForeColor = Color.FromArgb(71, 85, 105);
            lblLibrarianInfo.Location = new Point(410, 20);
            lblLibrarianInfo.Name = "lblLibrarianInfo";
            lblLibrarianInfo.Size = new Size(490, 25);
            lblLibrarianInfo.TabIndex = 1;
            lblLibrarianInfo.Text = "Thủ thư: -- | Quầy: --";
            lblLibrarianInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(19, 78, 74);
            lblPageTitle.Location = new Point(25, 18);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(331, 30);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "BÀN TÁC NGHIỆP LƯU THÔNG";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(240, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30);
            pnlContent.Size = new Size(914, 655);
            pnlContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(689, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Quầy trực sẵn sàng. Chọn chức năng Mượn / Trả sách để phục vụ bạn đọc.";
            // 
            // FormThuThuDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 720);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1050, 650);
            Name = "FormThuThuDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Library System - Bàn Phục Vụ Bạn Đọc";
            FormClosing += FormThuThuDashboard_FormClosing;
            Load += FormThuThuDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlLogo;
        private Label lblAppTitle;
        private Label lblLibrarianRole;
        private Button btnQuanLyDocGia;
        private Button btnQuanLySach;
        private Button btnBanLuuThong;
        private Button btnXuLyViPham;
        private Button btnLichTruc;
        private Button btnDoiMatKhau;
        private Button btnBaoCaoThongKe;
        private Button btnDangXuat;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label lblLibrarianInfo;
        private Panel pnlContent;
        private Label lblWelcome;
    }
}