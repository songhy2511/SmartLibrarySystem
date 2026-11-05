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
            btnNhanSu = new Button();
            btnTongQuan = new Button();
            pnlLogo = new Panel();
            lblRoleTag = new Label();
            lblAdminTitle = new Label();
            pnlHeader = new Panel();
            lblSessionInfo = new Label();
            lblCurrentPageTitle = new Label();
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
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnNhatKy);
            pnlSidebar.Controls.Add(btnQuyChe);
            pnlSidebar.Controls.Add(btnCaTruc);
            pnlSidebar.Controls.Add(btnNhanSu);
            pnlSidebar.Controls.Add(btnTongQuan);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 680);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(225, 29, 72);
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 635);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(230, 45);
            btnDangXuat.TabIndex = 7;
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
            btnDoiMatKhau.ForeColor = Color.FromArgb(203, 213, 225);
            btnDoiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.Location = new Point(0, 310);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(20, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(230, 45);
            btnDoiMatKhau.TabIndex = 6;
            btnDoiMatKhau.Text = "🔑  Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.Dock = DockStyle.Top;
            btnNhatKy.FlatAppearance.BorderSize = 0;
            btnNhatKy.FlatStyle = FlatStyle.Flat;
            btnNhatKy.Font = new Font("Segoe UI", 10F);
            btnNhatKy.ForeColor = Color.FromArgb(203, 213, 225);
            btnNhatKy.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhatKy.Location = new Point(0, 265);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Padding = new Padding(20, 0, 0, 0);
            btnNhatKy.Size = new Size(230, 45);
            btnNhatKy.TabIndex = 5;
            btnNhatKy.Text = "📋  Nhật Ký Hệ Thống";
            btnNhatKy.TextAlign = ContentAlignment.MiddleLeft;
            btnNhatKy.UseVisualStyleBackColor = true;
            btnNhatKy.Click += btnNhatKy_Click;
            // 
            // btnQuyChe
            // 
            btnQuyChe.Dock = DockStyle.Top;
            btnQuyChe.FlatAppearance.BorderSize = 0;
            btnQuyChe.FlatStyle = FlatStyle.Flat;
            btnQuyChe.Font = new Font("Segoe UI", 10F);
            btnQuyChe.ForeColor = Color.FromArgb(203, 213, 225);
            btnQuyChe.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuyChe.Location = new Point(0, 220);
            btnQuyChe.Name = "btnQuyChe";
            btnQuyChe.Padding = new Padding(20, 0, 0, 0);
            btnQuyChe.Size = new Size(230, 45);
            btnQuyChe.TabIndex = 4;
            btnQuyChe.Text = "⚙️  Quy Chế & Tham Số";
            btnQuyChe.TextAlign = ContentAlignment.MiddleLeft;
            btnQuyChe.UseVisualStyleBackColor = true;
            btnQuyChe.Click += btnQuyChe_Click;
            // 
            // btnCaTruc
            // 
            btnCaTruc.Dock = DockStyle.Top;
            btnCaTruc.FlatAppearance.BorderSize = 0;
            btnCaTruc.FlatStyle = FlatStyle.Flat;
            btnCaTruc.Font = new Font("Segoe UI", 10F);
            btnCaTruc.ForeColor = Color.FromArgb(203, 213, 225);
            btnCaTruc.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaTruc.Location = new Point(0, 175);
            btnCaTruc.Name = "btnCaTruc";
            btnCaTruc.Padding = new Padding(20, 0, 0, 0);
            btnCaTruc.Size = new Size(230, 45);
            btnCaTruc.TabIndex = 3;
            btnCaTruc.Text = "📅  Phân Ca & Đối Soát";
            btnCaTruc.TextAlign = ContentAlignment.MiddleLeft;
            btnCaTruc.UseVisualStyleBackColor = true;
            btnCaTruc.Click += btnCaTruc_Click;
            // 
            // btnNhanSu
            // 
            btnNhanSu.Dock = DockStyle.Top;
            btnNhanSu.FlatAppearance.BorderSize = 0;
            btnNhanSu.FlatStyle = FlatStyle.Flat;
            btnNhanSu.Font = new Font("Segoe UI", 10F);
            btnNhanSu.ForeColor = Color.FromArgb(203, 213, 225);
            btnNhanSu.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanSu.Location = new Point(0, 130);
            btnNhanSu.Name = "btnNhanSu";
            btnNhanSu.Padding = new Padding(20, 0, 0, 0);
            btnNhanSu.Size = new Size(230, 45);
            btnNhanSu.TabIndex = 2;
            btnNhanSu.Text = "👥  Quản Lý Nhân Sự";
            btnNhanSu.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanSu.UseVisualStyleBackColor = true;
            btnNhanSu.Click += btnNhanSu_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.BackColor = Color.FromArgb(30, 41, 59);
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnTongQuan.ForeColor = Color.White;
            btnTongQuan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.Location = new Point(0, 85);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(20, 0, 0, 0);
            btnTongQuan.Size = new Size(230, 45);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "📊  Tổng Quan Hệ Thống";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            btnTongQuan.Click += btnTongQuan_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(2, 6, 23);
            pnlLogo.Controls.Add(lblRoleTag);
            pnlLogo.Controls.Add(lblAdminTitle);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblRoleTag
            // 
            lblRoleTag.AutoSize = true;
            lblRoleTag.BackColor = Color.FromArgb(3, 105, 161);
            lblRoleTag.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblRoleTag.ForeColor = Color.White;
            lblRoleTag.Location = new Point(20, 50);
            lblRoleTag.Name = "lblRoleTag";
            lblRoleTag.Padding = new Padding(6, 2, 6, 2);
            lblRoleTag.Size = new Size(108, 17);
            lblRoleTag.TabIndex = 1;
            lblRoleTag.Text = "ADMINISTRATOR";
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdminTitle.ForeColor = Color.White;
            lblAdminTitle.Location = new Point(20, 20);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(132, 21);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "SMART LIBRARY";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSessionInfo);
            pnlHeader.Controls.Add(lblCurrentPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(230, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(874, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSessionInfo.Font = new Font("Segoe UI", 9.5F);
            lblSessionInfo.ForeColor = Color.FromArgb(71, 85, 105);
            lblSessionInfo.Location = new Point(420, 20);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.RightToLeft = RightToLeft.No;
            lblSessionInfo.Size = new Size(430, 25);
            lblSessionInfo.TabIndex = 1;
            lblSessionInfo.Text = "Người dùng: admin | Đăng nhập lúc: --:--:--";
            lblSessionInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentPageTitle
            // 
            lblCurrentPageTitle.AutoSize = true;
            lblCurrentPageTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCurrentPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblCurrentPageTitle.Location = new Point(25, 18);
            lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            lblCurrentPageTitle.Size = new Size(216, 25);
            lblCurrentPageTitle.TabIndex = 0;
            lblCurrentPageTitle.Text = "TỔNG QUAN QUẢN TRỊ";
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
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(494, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hệ thống quản trị hoạt động bình thường. Chọn menu để thao tác.";
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 600);
            Name = "FormAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Library System - Quản Trị Hệ Thống";
            FormClosing += FormAdminDashboard_FormClosing;
            Load += FormAdminDashboard_Load;
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
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Label lblRoleTag;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnNhanSu;
        private System.Windows.Forms.Button btnCaTruc;
        private System.Windows.Forms.Button btnQuyChe;
        private System.Windows.Forms.Button btnNhatKy;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCurrentPageTitle;
        private System.Windows.Forms.Label lblSessionInfo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
    }
}