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
            pnlSidebar = new System.Windows.Forms.Panel();
            btnDangXuat = new System.Windows.Forms.Button();
            btnDoiMatKhau = new System.Windows.Forms.Button();
            btnLichTruc = new System.Windows.Forms.Button();
            btnXuLyViPham = new System.Windows.Forms.Button();
            btnBanLuuThong = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            lblLibrarianRole = new System.Windows.Forms.Label();
            lblAppTitle = new System.Windows.Forms.Label();
            pnlHeader = new System.Windows.Forms.Panel();
            lblLibrarianInfo = new System.Windows.Forms.Label();
            lblPageTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(19, 78, 74);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnLichTruc);
            pnlSidebar.Controls.Add(btnXuLyViPham);
            pnlSidebar.Controls.Add(btnBanLuuThong);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(230, 680);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(0, 635);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(230, 45);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "🚪 Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(204, 251, 241);
            btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoiMatKhau.Location = new System.Drawing.Point(0, 220);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnDoiMatKhau.Size = new System.Drawing.Size(230, 45);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "🔑  Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnLichTruc
            // 
            btnLichTruc.Dock = System.Windows.Forms.DockStyle.Top;
            btnLichTruc.FlatAppearance.BorderSize = 0;
            btnLichTruc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLichTruc.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnLichTruc.ForeColor = System.Drawing.Color.FromArgb(204, 251, 241);
            btnLichTruc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLichTruc.Location = new System.Drawing.Point(0, 175);
            btnLichTruc.Name = "btnLichTruc";
            btnLichTruc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnLichTruc.Size = new System.Drawing.Size(230, 45);
            btnLichTruc.TabIndex = 3;
            btnLichTruc.Text = "📅  Lịch Trực Của Tôi";
            btnLichTruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLichTruc.UseVisualStyleBackColor = true;
            // 
            // btnXuLyViPham
            // 
            btnXuLyViPham.Dock = System.Windows.Forms.DockStyle.Top;
            btnXuLyViPham.FlatAppearance.BorderSize = 0;
            btnXuLyViPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuLyViPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnXuLyViPham.ForeColor = System.Drawing.Color.FromArgb(204, 251, 241);
            btnXuLyViPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnXuLyViPham.Location = new System.Drawing.Point(0, 130);
            btnXuLyViPham.Name = "btnXuLyViPham";
            btnXuLyViPham.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnXuLyViPham.Size = new System.Drawing.Size(230, 45);
            btnXuLyViPham.TabIndex = 2;
            btnXuLyViPham.Text = "⚠️  Xử Lý Vi Phạm & Phạt";
            btnXuLyViPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnXuLyViPham.UseVisualStyleBackColor = true;
            // 
            // btnBanLuuThong
            // 
            btnBanLuuThong.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
            btnBanLuuThong.Dock = System.Windows.Forms.DockStyle.Top;
            btnBanLuuThong.FlatAppearance.BorderSize = 0;
            btnBanLuuThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBanLuuThong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            btnBanLuuThong.ForeColor = System.Drawing.Color.White;
            btnBanLuuThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBanLuuThong.Location = new System.Drawing.Point(0, 85);
            btnBanLuuThong.Name = "btnBanLuuThong";
            btnBanLuuThong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnBanLuuThong.Size = new System.Drawing.Size(230, 45);
            btnBanLuuThong.TabIndex = 1;
            btnBanLuuThong.Text = "🔄  Bàn Lưu Thông (Mượn/Trả)";
            btnBanLuuThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBanLuuThong.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(17, 94, 89);
            pnlLogo.Controls.Add(lblLibrarianRole);
            pnlLogo.Controls.Add(lblAppTitle);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(230, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblLibrarianRole
            // 
            lblLibrarianRole.AutoSize = true;
            lblLibrarianRole.BackColor = System.Drawing.Color.FromArgb(13, 148, 136);
            lblLibrarianRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblLibrarianRole.ForeColor = System.Drawing.Color.White;
            lblLibrarianRole.Location = new System.Drawing.Point(20, 50);
            lblLibrarianRole.Name = "lblLibrarianRole";
            lblLibrarianRole.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            lblLibrarianRole.Size = new System.Drawing.Size(117, 17);
            lblLibrarianRole.TabIndex = 1;
            lblLibrarianRole.Text = "QUẦY THỦ THƯ";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblAppTitle.ForeColor = System.Drawing.Color.White;
            lblAppTitle.Location = new System.Drawing.Point(20, 20);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new System.Drawing.Size(134, 21);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "SMART LIBRARY";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblLibrarianInfo);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(230, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(874, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblLibrarianInfo
            // 
            lblLibrarianInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblLibrarianInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblLibrarianInfo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblLibrarianInfo.Location = new System.Drawing.Point(380, 20);
            lblLibrarianInfo.Name = "lblLibrarianInfo";
            lblLibrarianInfo.Size = new System.Drawing.Size(470, 25);
            lblLibrarianInfo.TabIndex = 1;
            lblLibrarianInfo.Text = "Thủ thư: -- | Quầy: --";
            lblLibrarianInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(19, 78, 74);
            lblPageTitle.Location = new System.Drawing.Point(25, 18);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(193, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "BÀN TÁC NGHIỆP LƯU THÔNG";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(230, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(30);
            pnlContent.Size = new System.Drawing.Size(874, 620);
            pnlContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new System.Drawing.Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(465, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Quầy trực sẵn sàng. Chọn chức năng Mượn / Trả sách để phục vụ bạn đọc.";
            // 
            // FormThuThuDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1104, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new System.Drawing.Size(1000, 600);
            Name = "FormThuThuDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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