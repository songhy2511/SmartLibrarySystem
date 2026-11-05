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
            btnDoiMatKhau = new Button();
            btnLichTruc = new Button();
            btnXuLyViPham = new Button();
            btnBanLuuThong = new Button();
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
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnLichTruc);
            pnlSidebar.Controls.Add(btnXuLyViPham);
            pnlSidebar.Controls.Add(btnBanLuuThong);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(263, 737);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(185, 28, 28);
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 677);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(263, 60);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "🚪 Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F);
            btnDoiMatKhau.ForeColor = Color.FromArgb(204, 251, 241);
            btnDoiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.Location = new Point(0, 293);
            btnDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(23, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(263, 60);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "🔑  Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnLichTruc
            // 
            btnLichTruc.Dock = DockStyle.Top;
            btnLichTruc.FlatAppearance.BorderSize = 0;
            btnLichTruc.FlatStyle = FlatStyle.Flat;
            btnLichTruc.Font = new Font("Segoe UI", 10F);
            btnLichTruc.ForeColor = Color.FromArgb(204, 251, 241);
            btnLichTruc.ImageAlign = ContentAlignment.MiddleLeft;
            btnLichTruc.Location = new Point(0, 233);
            btnLichTruc.Margin = new Padding(3, 4, 3, 4);
            btnLichTruc.Name = "btnLichTruc";
            btnLichTruc.Padding = new Padding(23, 0, 0, 0);
            btnLichTruc.Size = new Size(263, 60);
            btnLichTruc.TabIndex = 3;
            btnLichTruc.Text = "📅  Lịch Trực Của Tôi";
            btnLichTruc.TextAlign = ContentAlignment.MiddleLeft;
            btnLichTruc.UseVisualStyleBackColor = true;
            // 
            // btnXuLyViPham
            // 
            btnXuLyViPham.Dock = DockStyle.Top;
            btnXuLyViPham.FlatAppearance.BorderSize = 0;
            btnXuLyViPham.FlatStyle = FlatStyle.Flat;
            btnXuLyViPham.Font = new Font("Segoe UI", 10F);
            btnXuLyViPham.ForeColor = Color.FromArgb(204, 251, 241);
            btnXuLyViPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuLyViPham.Location = new Point(0, 173);
            btnXuLyViPham.Margin = new Padding(3, 4, 3, 4);
            btnXuLyViPham.Name = "btnXuLyViPham";
            btnXuLyViPham.Padding = new Padding(23, 0, 0, 0);
            btnXuLyViPham.Size = new Size(263, 60);
            btnXuLyViPham.TabIndex = 2;
            btnXuLyViPham.Text = "⚠️  Xử Lý Vi Phạm & Phạt";
            btnXuLyViPham.TextAlign = ContentAlignment.MiddleLeft;
            btnXuLyViPham.UseVisualStyleBackColor = true;
            btnXuLyViPham.Click += btnXuLyViPham_Click;
            // 
            // btnBanLuuThong
            // 
            btnBanLuuThong.BackColor = Color.FromArgb(15, 118, 110);
            btnBanLuuThong.Dock = DockStyle.Top;
            btnBanLuuThong.FlatAppearance.BorderSize = 0;
            btnBanLuuThong.FlatStyle = FlatStyle.Flat;
            btnBanLuuThong.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBanLuuThong.ForeColor = Color.White;
            btnBanLuuThong.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanLuuThong.Location = new Point(0, 113);
            btnBanLuuThong.Margin = new Padding(3, 4, 3, 4);
            btnBanLuuThong.Name = "btnBanLuuThong";
            btnBanLuuThong.Padding = new Padding(23, 0, 0, 0);
            btnBanLuuThong.Size = new Size(263, 60);
            btnBanLuuThong.TabIndex = 1;
            btnBanLuuThong.Text = "🔄  Bàn Lưu Thông (Mượn/Trả)";
            btnBanLuuThong.TextAlign = ContentAlignment.MiddleLeft;
            btnBanLuuThong.UseVisualStyleBackColor = false;
            btnBanLuuThong.Click += btnBanLuuThong_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 94, 89);
            pnlLogo.Controls.Add(lblLibrarianRole);
            pnlLogo.Controls.Add(lblAppTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(263, 113);
            pnlLogo.TabIndex = 0;
            // 
            // lblLibrarianRole
            // 
            lblLibrarianRole.AutoSize = true;
            lblLibrarianRole.BackColor = Color.FromArgb(13, 148, 136);
            lblLibrarianRole.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLibrarianRole.ForeColor = Color.White;
            lblLibrarianRole.Location = new Point(23, 67);
            lblLibrarianRole.Name = "lblLibrarianRole";
            lblLibrarianRole.Padding = new Padding(7, 3, 7, 3);
            lblLibrarianRole.Size = new Size(130, 25);
            lblLibrarianRole.TabIndex = 1;
            lblLibrarianRole.Text = "QUẦY THỦ THƯ";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(23, 27);
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
            pnlHeader.Location = new Point(263, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(859, 80);
            pnlHeader.TabIndex = 1;
            // 
            // lblLibrarianInfo
            // 
            lblLibrarianInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLibrarianInfo.Font = new Font("Segoe UI", 9.5F);
            lblLibrarianInfo.ForeColor = Color.FromArgb(71, 85, 105);
            lblLibrarianInfo.Location = new Point(294, 27);
            lblLibrarianInfo.Name = "lblLibrarianInfo";
            lblLibrarianInfo.Size = new Size(537, 33);
            lblLibrarianInfo.TabIndex = 1;
            lblLibrarianInfo.Text = "Thủ thư: -- | Quầy: --";
            lblLibrarianInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(19, 78, 74);
            lblPageTitle.Location = new Point(29, 24);
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
            pnlContent.Location = new Point(263, 80);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(34, 40, 34, 40);
            pnlContent.Size = new Size(859, 657);
            pnlContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(34, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(689, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Quầy trực sẵn sàng. Chọn chức năng Mượn / Trả sách để phục vụ bạn đọc.";
            // 
            // FormThuThuDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 737);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
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

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLibrarianRole;
        private System.Windows.Forms.Button btnBanLuuThong;
        private System.Windows.Forms.Button btnXuLyViPham;
        private System.Windows.Forms.Button btnLichTruc;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblLibrarianInfo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
    }
}