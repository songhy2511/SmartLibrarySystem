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
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 680);
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
            btnDangXuat.Location = new Point(0, 635);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(230, 45);
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
            btnDoiMatKhau.Location = new Point(0, 220);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(20, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(230, 45);
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
            btnLichTruc.Location = new Point(0, 175);
            btnLichTruc.Name = "btnLichTruc";
            btnLichTruc.Padding = new Padding(20, 0, 0, 0);
            btnLichTruc.Size = new Size(230, 45);
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
            btnXuLyViPham.Location = new Point(0, 130);
            btnXuLyViPham.Name = "btnXuLyViPham";
            btnXuLyViPham.Padding = new Padding(20, 0, 0, 0);
            btnXuLyViPham.Size = new Size(230, 45);
            btnXuLyViPham.TabIndex = 2;
            btnXuLyViPham.Text = "⚠️  Xử Lý Vi Phạm & Phạt";
            btnXuLyViPham.TextAlign = ContentAlignment.MiddleLeft;
            btnXuLyViPham.UseVisualStyleBackColor = true;
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
            btnBanLuuThong.Location = new Point(0, 85);
            btnBanLuuThong.Name = "btnBanLuuThong";
            btnBanLuuThong.Padding = new Padding(20, 0, 0, 0);
            btnBanLuuThong.Size = new Size(230, 45);
            btnBanLuuThong.TabIndex = 1;
            btnBanLuuThong.Text = "🔄  Bàn Lưu Thông (Mượn/Trả)";
            btnBanLuuThong.TextAlign = ContentAlignment.MiddleLeft;
            btnBanLuuThong.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 94, 89);
            pnlLogo.Controls.Add(lblLibrarianRole);
            pnlLogo.Controls.Add(lblAppTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblLibrarianRole
            // 
            lblLibrarianRole.AutoSize = true;
            lblLibrarianRole.BackColor = Color.FromArgb(13, 148, 136);
            lblLibrarianRole.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLibrarianRole.ForeColor = Color.White;
            lblLibrarianRole.Location = new Point(20, 50);
            lblLibrarianRole.Name = "lblLibrarianRole";
            lblLibrarianRole.Padding = new Padding(6, 2, 6, 2);
            lblLibrarianRole.Size = new Size(101, 17);
            lblLibrarianRole.TabIndex = 1;
            lblLibrarianRole.Text = "QUẦY THỦ THƯ";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(20, 20);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(132, 21);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "SMART LIBRARY";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblLibrarianInfo);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(230, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(874, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblLibrarianInfo
            // 
            lblLibrarianInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLibrarianInfo.Font = new Font("Segoe UI", 9.5F);
            lblLibrarianInfo.ForeColor = Color.FromArgb(71, 85, 105);
            lblLibrarianInfo.Location = new Point(380, 20);
            lblLibrarianInfo.Name = "lblLibrarianInfo";
            lblLibrarianInfo.Size = new Size(470, 25);
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
            lblPageTitle.Size = new Size(275, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "BÀN TÁC NGHIỆP LƯU THÔNG";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(230, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30);
            pnlContent.Size = new Size(874, 620);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(544, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Quầy trực sẵn sàng. Chọn chức năng Mượn / Trả sách để phục vụ bạn đọc.";
            // 
            // FormThuThuDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 600);
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
            // 1. Khởi tạo đối tượng
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();

            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.Dock = System.Windows.Forms.DockStyle.Top; // Hoặc dùng Location nếu không dùng Dock
            this.btnQuanLyDocGia.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110))))); // Màu hover xanh đậm
            this.btnQuanLyDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyDocGia.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(0, 150); // Điền vị trí Y phù hợp
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLyDocGia.TabIndex = 4;
            this.btnQuanLyDocGia.Text = "  🪪  Quản Lý Độc Giả";
            this.btnQuanLyDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyDocGia.UseVisualStyleBackColor = true;
            this.btnQuanLyDocGia.Click += new System.EventHandler(this.btnQuanLyDocGia_Click);

            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.Dock = System.Windows.Forms.DockStyle.Top; // Hoặc dùng Location nếu không dùng Dock
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110))))); // Màu hover xanh đậm
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySach.Location = new System.Drawing.Point(0, 195); // Điền vị trí Y phù hợp
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnQuanLySach.Size = new System.Drawing.Size(200, 45);
            this.btnQuanLySach.TabIndex = 5;
            this.btnQuanLySach.Text = "  📚  Quản Lý Kho Sách";
            this.btnQuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);

            // 2. Thêm 2 nút vào Panel Sidebar (ví dụ pnlSidebar)
            // Thêm theo đúng thứ tự từ DƯỚI LÊN TÊN PANEL (để hiển thị từ TRÊN XUỐNG DƯỚI)
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnDoiMatKhau);
            this.pnlSidebar.Controls.Add(this.btnLichTruc);
            this.pnlSidebar.Controls.Add(this.btnXuLyViPham);
            this.pnlSidebar.Controls.Add(this.btnBanLuuThong);
            this.pnlSidebar.Controls.Add(this.btnQuanLySach);    // Đặt trên Bàn Lưu Thông
            this.pnlSidebar.Controls.Add(this.btnQuanLyDocGia);  // Đặt trên Quản Lý Kho Sách
            this.pnlSidebar.Controls.Add(this.pnlLogo);    // Banner tiêu đề ở trên cùng
        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLibrarianRole;
        private System.Windows.Forms.Button btnQuanLyDocGia;
        private System.Windows.Forms.Button btnQuanLySach;
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