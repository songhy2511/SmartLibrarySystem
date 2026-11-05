namespace Library.UI
{
    partial class FormAdminDashboard
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
            btnNhatKy = new Button();
            btnQuyChe = new Button();
            btnCaTruc = new Button();
            btnChiNhanh = new Button();
            btnNhanSu = new Button();
            btnTongQuan = new Button();
            pnlLogo = new Panel();
            lblBadgeRole = new Label();
            lblLogoTitle = new Label();
            pnlTopBar = new Panel();
            lblSessionInfo = new Label();
            lblCurrentPageTitle = new Label();
            pnlContent = new Panel();
            lblWelcome = new Label();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnNhatKy);
            pnlSidebar.Controls.Add(btnQuyChe);
            pnlSidebar.Controls.Add(btnCaTruc);
            pnlSidebar.Controls.Add(btnChiNhanh);
            pnlSidebar.Controls.Add(btnNhanSu);
            pnlSidebar.Controls.Add(btnTongQuan);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(263, 960);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(225, 29, 72);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 900);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(263, 60);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "🚪 Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.FromArgb(15, 23, 42);
            btnDoiMatKhau.Cursor = Cursors.Hand;
            btnDoiMatKhau.Dock = DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.FromArgb(203, 213, 225);
            btnDoiMatKhau.Location = new Point(0, 487);
            btnDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(18, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(263, 60);
            btnDoiMatKhau.TabIndex = 7;
            btnDoiMatKhau.Text = "🔑 Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.BackColor = Color.FromArgb(15, 23, 42);
            btnNhatKy.Cursor = Cursors.Hand;
            btnNhatKy.Dock = DockStyle.Top;
            btnNhatKy.FlatAppearance.BorderSize = 0;
            btnNhatKy.FlatStyle = FlatStyle.Flat;
            btnNhatKy.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnNhatKy.ForeColor = Color.FromArgb(203, 213, 225);
            btnNhatKy.Location = new Point(0, 427);
            btnNhatKy.Margin = new Padding(3, 4, 3, 4);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Padding = new Padding(18, 0, 0, 0);
            btnNhatKy.Size = new Size(263, 60);
            btnNhatKy.TabIndex = 6;
            btnNhatKy.Text = "📑 Nhật Ký Hệ Thống";
            btnNhatKy.TextAlign = ContentAlignment.MiddleLeft;
            btnNhatKy.UseVisualStyleBackColor = false;
            btnNhatKy.Click += btnNhatKy_Click;
            // 
            // btnQuyChe
            // 
            btnQuyChe.BackColor = Color.FromArgb(15, 23, 42);
            btnQuyChe.Cursor = Cursors.Hand;
            btnQuyChe.Dock = DockStyle.Top;
            btnQuyChe.FlatAppearance.BorderSize = 0;
            btnQuyChe.FlatStyle = FlatStyle.Flat;
            btnQuyChe.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnQuyChe.ForeColor = Color.FromArgb(203, 213, 225);
            btnQuyChe.Location = new Point(0, 367);
            btnQuyChe.Margin = new Padding(3, 4, 3, 4);
            btnQuyChe.Name = "btnQuyChe";
            btnQuyChe.Padding = new Padding(18, 0, 0, 0);
            btnQuyChe.Size = new Size(263, 60);
            btnQuyChe.TabIndex = 5;
            btnQuyChe.Text = "⚙ Quy Chế Tham Số";
            btnQuyChe.TextAlign = ContentAlignment.MiddleLeft;
            btnQuyChe.UseVisualStyleBackColor = false;
            btnQuyChe.Click += btnQuyChe_Click;
            // 
            // btnCaTruc
            // 
            btnCaTruc.BackColor = Color.FromArgb(15, 23, 42);
            btnCaTruc.Cursor = Cursors.Hand;
            btnCaTruc.Dock = DockStyle.Top;
            btnCaTruc.FlatAppearance.BorderSize = 0;
            btnCaTruc.FlatStyle = FlatStyle.Flat;
            btnCaTruc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCaTruc.ForeColor = Color.FromArgb(203, 213, 225);
            btnCaTruc.Location = new Point(0, 307);
            btnCaTruc.Margin = new Padding(3, 4, 3, 4);
            btnCaTruc.Name = "btnCaTruc";
            btnCaTruc.Padding = new Padding(18, 0, 0, 0);
            btnCaTruc.Size = new Size(263, 60);
            btnCaTruc.TabIndex = 4;
            btnCaTruc.Text = "📅 Phân Ca Đối Soát";
            btnCaTruc.TextAlign = ContentAlignment.MiddleLeft;
            btnCaTruc.UseVisualStyleBackColor = false;
            btnCaTruc.Click += btnCaTruc_Click;
            // 
            // btnChiNhanh
            // 
            btnChiNhanh.BackColor = Color.FromArgb(15, 23, 42);
            btnChiNhanh.Cursor = Cursors.Hand;
            btnChiNhanh.Dock = DockStyle.Top;
            btnChiNhanh.FlatAppearance.BorderSize = 0;
            btnChiNhanh.FlatStyle = FlatStyle.Flat;
            btnChiNhanh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnChiNhanh.ForeColor = Color.FromArgb(203, 213, 225);
            btnChiNhanh.Location = new Point(0, 247);
            btnChiNhanh.Margin = new Padding(3, 4, 3, 4);
            btnChiNhanh.Name = "btnChiNhanh";
            btnChiNhanh.Padding = new Padding(18, 0, 0, 0);
            btnChiNhanh.Size = new Size(263, 60);
            btnChiNhanh.TabIndex = 3;
            btnChiNhanh.Text = "🏢 Quản Lý Chi Nhánh";
            btnChiNhanh.TextAlign = ContentAlignment.MiddleLeft;
            btnChiNhanh.UseVisualStyleBackColor = false;
            btnChiNhanh.Click += btnChiNhanh_Click;
            // 
            // btnNhanSu
            // 
            btnNhanSu.BackColor = Color.FromArgb(15, 23, 42);
            btnNhanSu.Cursor = Cursors.Hand;
            btnNhanSu.Dock = DockStyle.Top;
            btnNhanSu.FlatAppearance.BorderSize = 0;
            btnNhanSu.FlatStyle = FlatStyle.Flat;
            btnNhanSu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnNhanSu.ForeColor = Color.FromArgb(203, 213, 225);
            btnNhanSu.Location = new Point(0, 187);
            btnNhanSu.Margin = new Padding(3, 4, 3, 4);
            btnNhanSu.Name = "btnNhanSu";
            btnNhanSu.Padding = new Padding(18, 0, 0, 0);
            btnNhanSu.Size = new Size(263, 60);
            btnNhanSu.TabIndex = 2;
            btnNhanSu.Text = "👥 Quản Lý Nhân Sự";
            btnNhanSu.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanSu.UseVisualStyleBackColor = false;
            btnNhanSu.Click += btnNhanSu_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.BackColor = Color.FromArgb(15, 23, 42);
            btnTongQuan.Cursor = Cursors.Hand;
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnTongQuan.ForeColor = Color.FromArgb(203, 213, 225);
            btnTongQuan.Location = new Point(0, 127);
            btnTongQuan.Margin = new Padding(3, 4, 3, 4);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(18, 0, 0, 0);
            btnTongQuan.Size = new Size(263, 60);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "📊 Tổng Quan Hệ Thống";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(2, 6, 23);
            pnlLogo.Controls.Add(lblBadgeRole);
            pnlLogo.Controls.Add(lblLogoTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(263, 127);
            pnlLogo.TabIndex = 0;
            // 
            // lblBadgeRole
            // 
            lblBadgeRole.AutoSize = true;
            lblBadgeRole.BackColor = Color.FromArgb(2, 132, 199);
            lblBadgeRole.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblBadgeRole.ForeColor = Color.White;
            lblBadgeRole.Location = new Point(21, 73);
            lblBadgeRole.Name = "lblBadgeRole";
            lblBadgeRole.Padding = new Padding(5, 3, 5, 3);
            lblBadgeRole.Size = new Size(124, 23);
            lblBadgeRole.TabIndex = 1;
            lblBadgeRole.Text = "ADMINISTRATOR";
            // 
            // lblLogoTitle
            // 
            lblLogoTitle.AutoSize = true;
            lblLogoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogoTitle.ForeColor = Color.White;
            lblLogoTitle.Location = new Point(18, 29);
            lblLogoTitle.Name = "lblLogoTitle";
            lblLogoTitle.Size = new Size(168, 28);
            lblLogoTitle.TabIndex = 0;
            lblLogoTitle.Text = "SMART LIBRARY";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblSessionInfo);
            pnlTopBar.Controls.Add(lblCurrentPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(263, 0);
            pnlTopBar.Margin = new Padding(3, 4, 3, 4);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1200, 80);
            pnlTopBar.TabIndex = 1;
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSessionInfo.Font = new Font("Segoe UI", 9F);
            lblSessionInfo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSessionInfo.Location = new Point(501, 27);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.Size = new Size(686, 27);
            lblSessionInfo.TabIndex = 1;
            lblSessionInfo.Text = "Quản trị viên: admin | Đăng nhập lúc: 00:00:00";
            lblSessionInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentPageTitle
            // 
            lblCurrentPageTitle.AutoSize = true;
            lblCurrentPageTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCurrentPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblCurrentPageTitle.Location = new Point(23, 27);
            lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            lblCurrentPageTitle.Size = new Size(222, 25);
            lblCurrentPageTitle.TabIndex = 0;
            lblCurrentPageTitle.Text = "TỔNG QUAN QUẢN TRỊ";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(263, 80);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1200, 880);
            pnlContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 14F);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1200, 880);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng bạn quay trở lại Trung Tâm Điều Hành Quản Trị Hệ Thống!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1463, 960);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1168, 784);
            Name = "FormAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Library System - Quản Trị Hệ Thống";
            FormClosing += FormAdminDashboard_FormClosing;
            Load += FormAdminDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoTitle;
        private System.Windows.Forms.Label lblBadgeRole;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnNhanSu;
        private System.Windows.Forms.Button btnChiNhanh;
        private System.Windows.Forms.Button btnCaTruc;
        private System.Windows.Forms.Button btnQuyChe;
        private System.Windows.Forms.Button btnNhatKy;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblCurrentPageTitle;
        private System.Windows.Forms.Label lblSessionInfo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
    }
}