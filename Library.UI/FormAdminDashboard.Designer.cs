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
            pnlSidebar = new System.Windows.Forms.Panel();
            btnDangXuat = new System.Windows.Forms.Button();
            btnDoiMatKhau = new System.Windows.Forms.Button();
            btnBaoCao = new System.Windows.Forms.Button();
            btnNhatKy = new System.Windows.Forms.Button();
            btnQuyChe = new System.Windows.Forms.Button();
            btnCaTruc = new System.Windows.Forms.Button();
            btnChiNhanh = new System.Windows.Forms.Button();
            btnNhanSu = new System.Windows.Forms.Button();
            btnTongQuan = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            lblBadgeRole = new System.Windows.Forms.Label();
            lblLogoTitle = new System.Windows.Forms.Label();
            pnlTopBar = new System.Windows.Forms.Panel();
            lblSessionInfo = new System.Windows.Forms.Label();
            lblCurrentPageTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnBaoCao);
            pnlSidebar.Controls.Add(btnNhatKy);
            pnlSidebar.Controls.Add(btnQuyChe);
            pnlSidebar.Controls.Add(btnCaTruc);
            pnlSidebar.Controls.Add(btnChiNhanh);
            pnlSidebar.Controls.Add(btnNhanSu);
            pnlSidebar.Controls.Add(btnTongQuan);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(230, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(0, 675);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(230, 45);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "🚪 Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnDoiMatKhau.Location = new System.Drawing.Point(0, 410);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnDoiMatKhau.Size = new System.Drawing.Size(230, 45);
            btnDoiMatKhau.TabIndex = 8;
            btnDoiMatKhau.Text = "🔑 Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnBaoCao.Location = new System.Drawing.Point(0, 365);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnBaoCao.Size = new System.Drawing.Size(230, 45);
            btnBaoCao.TabIndex = 7;
            btnBaoCao.Text = "📊 Báo Cáo Thống Kê";
            btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnNhatKy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNhatKy.Dock = System.Windows.Forms.DockStyle.Top;
            btnNhatKy.FlatAppearance.BorderSize = 0;
            btnNhatKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhatKy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnNhatKy.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnNhatKy.Location = new System.Drawing.Point(0, 320);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnNhatKy.Size = new System.Drawing.Size(230, 45);
            btnNhatKy.TabIndex = 6;
            btnNhatKy.Text = "📑 Nhật Ký Hệ Thống";
            btnNhatKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhatKy.UseVisualStyleBackColor = false;
            btnNhatKy.Click += btnNhatKy_Click;
            // 
            // btnQuyChe
            // 
            btnQuyChe.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnQuyChe.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuyChe.Dock = System.Windows.Forms.DockStyle.Top;
            btnQuyChe.FlatAppearance.BorderSize = 0;
            btnQuyChe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuyChe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnQuyChe.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuyChe.Location = new System.Drawing.Point(0, 275);
            btnQuyChe.Name = "btnQuyChe";
            btnQuyChe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnQuyChe.Size = new System.Drawing.Size(230, 45);
            btnQuyChe.TabIndex = 5;
            btnQuyChe.Text = "⚙ Quy Chế Tham Số";
            btnQuyChe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuyChe.UseVisualStyleBackColor = false;
            btnQuyChe.Click += btnQuyChe_Click;
            // 
            // btnCaTruc
            // 
            btnCaTruc.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnCaTruc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCaTruc.Dock = System.Windows.Forms.DockStyle.Top;
            btnCaTruc.FlatAppearance.BorderSize = 0;
            btnCaTruc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCaTruc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnCaTruc.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCaTruc.Location = new System.Drawing.Point(0, 230);
            btnCaTruc.Name = "btnCaTruc";
            btnCaTruc.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnCaTruc.Size = new System.Drawing.Size(230, 45);
            btnCaTruc.TabIndex = 4;
            btnCaTruc.Text = "📅 Phân Ca Đối Soát";
            btnCaTruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCaTruc.UseVisualStyleBackColor = false;
            btnCaTruc.Click += btnCaTruc_Click;
            // 
            // btnChiNhanh
            // 
            btnChiNhanh.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnChiNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            btnChiNhanh.FlatAppearance.BorderSize = 0;
            btnChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnChiNhanh.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnChiNhanh.Location = new System.Drawing.Point(0, 185);
            btnChiNhanh.Name = "btnChiNhanh";
            btnChiNhanh.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnChiNhanh.Size = new System.Drawing.Size(230, 45);
            btnChiNhanh.TabIndex = 3;
            btnChiNhanh.Text = "🏢 Quản Lý Chi Nhánh";
            btnChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnChiNhanh.UseVisualStyleBackColor = false;
            btnChiNhanh.Click += btnChiNhanh_Click;
            // 
            // btnNhanSu
            // 
            btnNhanSu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            btnNhanSu.FlatAppearance.BorderSize = 0;
            btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhanSu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnNhanSu.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnNhanSu.Location = new System.Drawing.Point(0, 140);
            btnNhanSu.Name = "btnNhanSu";
            btnNhanSu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnNhanSu.Size = new System.Drawing.Size(230, 45);
            btnNhanSu.TabIndex = 2;
            btnNhanSu.Text = "👥 Quản Lý Nhân Sự";
            btnNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhanSu.UseVisualStyleBackColor = false;
            btnNhanSu.Click += btnNhanSu_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTongQuan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnTongQuan.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnTongQuan.Location = new System.Drawing.Point(0, 95);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btnTongQuan.Size = new System.Drawing.Size(230, 45);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "📊 Tổng Quan Hệ Thống";
            btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            btnTongQuan.Click += btnTongQuan_Click_1;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(2, 6, 23);
            pnlLogo.Controls.Add(lblBadgeRole);
            pnlLogo.Controls.Add(lblLogoTitle);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(230, 95);
            pnlLogo.TabIndex = 0;
            // 
            // lblBadgeRole
            // 
            lblBadgeRole.AutoSize = true;
            lblBadgeRole.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            lblBadgeRole.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblBadgeRole.ForeColor = System.Drawing.Color.White;
            lblBadgeRole.Location = new System.Drawing.Point(18, 55);
            lblBadgeRole.Name = "lblBadgeRole";
            lblBadgeRole.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            lblBadgeRole.Size = new System.Drawing.Size(94, 16);
            lblBadgeRole.TabIndex = 1;
            lblBadgeRole.Text = "ADMINISTRATOR";
            // 
            // lblLogoTitle
            // 
            lblLogoTitle.AutoSize = true;
            lblLogoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblLogoTitle.ForeColor = System.Drawing.Color.White;
            lblLogoTitle.Location = new System.Drawing.Point(16, 22);
            lblLogoTitle.Name = "lblLogoTitle";
            lblLogoTitle.Size = new System.Drawing.Size(142, 21);
            lblLogoTitle.TabIndex = 0;
            lblLogoTitle.Text = "SMART LIBRARY";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = System.Drawing.Color.White;
            pnlTopBar.Controls.Add(lblSessionInfo);
            pnlTopBar.Controls.Add(lblCurrentPageTitle);
            pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopBar.Location = new System.Drawing.Point(230, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new System.Drawing.Size(1050, 60);
            pnlTopBar.TabIndex = 1;
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSessionInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSessionInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSessionInfo.Location = new System.Drawing.Point(438, 20);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.Size = new System.Drawing.Size(600, 20);
            lblSessionInfo.TabIndex = 1;
            lblSessionInfo.Text = "Quản trị viên: admin | Đăng nhập lúc: 00:00:00";
            lblSessionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentPageTitle
            // 
            lblCurrentPageTitle.AutoSize = true;
            lblCurrentPageTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            lblCurrentPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblCurrentPageTitle.Location = new System.Drawing.Point(20, 20);
            lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            lblCurrentPageTitle.Size = new System.Drawing.Size(177, 20);
            lblCurrentPageTitle.TabIndex = 0;
            lblCurrentPageTitle.Text = "TỔNG QUAN QUẢN TRỊ";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(230, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1050, 660);
            pnlContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblWelcome.Location = new System.Drawing.Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(1050, 660);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng bạn quay trở lại Trung Tâm Điều Hành Quản Trị Hệ Thống!";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1280, 720);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            MinimumSize = new System.Drawing.Size(1024, 600);
            Name = "FormAdminDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblCurrentPageTitle;
        private System.Windows.Forms.Label lblSessionInfo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
    }
}