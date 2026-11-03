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
            btnNhatKy = new System.Windows.Forms.Button();
            btnQuyChe = new System.Windows.Forms.Button();
            btnCaTruc = new System.Windows.Forms.Button();
            btnNhanSu = new System.Windows.Forms.Button();
            btnTongQuan = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            lblRoleTag = new System.Windows.Forms.Label();
            lblAdminTitle = new System.Windows.Forms.Label();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSessionInfo = new System.Windows.Forms.Label();
            lblCurrentPageTitle = new System.Windows.Forms.Label();
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
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(btnDoiMatKhau);
            pnlSidebar.Controls.Add(btnNhatKy);
            pnlSidebar.Controls.Add(btnQuyChe);
            pnlSidebar.Controls.Add(btnCaTruc);
            pnlSidebar.Controls.Add(btnNhanSu);
            pnlSidebar.Controls.Add(btnTongQuan);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(230, 680);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(0, 635);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(230, 45);
            btnDangXuat.TabIndex = 7;
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
            btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoiMatKhau.Location = new System.Drawing.Point(0, 310);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnDoiMatKhau.Size = new System.Drawing.Size(230, 45);
            btnDoiMatKhau.TabIndex = 6;
            btnDoiMatKhau.Text = "🔑  Đổi Mật Khẩu";
            btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnNhatKy
            // 
            btnNhatKy.Dock = System.Windows.Forms.DockStyle.Top;
            btnNhatKy.FlatAppearance.BorderSize = 0;
            btnNhatKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhatKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNhatKy.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnNhatKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhatKy.Location = new System.Drawing.Point(0, 265);
            btnNhatKy.Name = "btnNhatKy";
            btnNhatKy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnNhatKy.Size = new System.Drawing.Size(230, 45);
            btnNhatKy.TabIndex = 5;
            btnNhatKy.Text = "📋  Nhật Ký Hệ Thống";
            btnNhatKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhatKy.UseVisualStyleBackColor = true;
            // 
            // btnQuyChe
            // 
            btnQuyChe.Dock = System.Windows.Forms.DockStyle.Top;
            btnQuyChe.FlatAppearance.BorderSize = 0;
            btnQuyChe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuyChe.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnQuyChe.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnQuyChe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuyChe.Location = new System.Drawing.Point(0, 220);
            btnQuyChe.Name = "btnQuyChe";
            btnQuyChe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnQuyChe.Size = new System.Drawing.Size(230, 45);
            btnQuyChe.TabIndex = 4;
            btnQuyChe.Text = "⚙️  Quy Chế & Tham Số";
            btnQuyChe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuyChe.UseVisualStyleBackColor = true;
            // 
            // btnCaTruc
            // 
            btnCaTruc.Dock = System.Windows.Forms.DockStyle.Top;
            btnCaTruc.FlatAppearance.BorderSize = 0;
            btnCaTruc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCaTruc.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnCaTruc.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCaTruc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCaTruc.Location = new System.Drawing.Point(0, 175);
            btnCaTruc.Name = "btnCaTruc";
            btnCaTruc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnCaTruc.Size = new System.Drawing.Size(230, 45);
            btnCaTruc.TabIndex = 3;
            btnCaTruc.Text = "📅  Phân Ca & Đối Soát";
            btnCaTruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCaTruc.UseVisualStyleBackColor = true;
            // 
            // btnNhanSu
            // 
            btnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            btnNhanSu.FlatAppearance.BorderSize = 0;
            btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNhanSu.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnNhanSu.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhanSu.Location = new System.Drawing.Point(0, 130);
            btnNhanSu.Name = "btnNhanSu";
            btnNhanSu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnNhanSu.Size = new System.Drawing.Size(230, 45);
            btnNhanSu.TabIndex = 2;
            btnNhanSu.Text = "👥  Quản Lý Nhân Sự";
            btnNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNhanSu.UseVisualStyleBackColor = true;
            // 
            // btnTongQuan
            // 
            btnTongQuan.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTongQuan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            btnTongQuan.ForeColor = System.Drawing.Color.White;
            btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTongQuan.Location = new System.Drawing.Point(0, 85);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btnTongQuan.Size = new System.Drawing.Size(230, 45);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "📊  Tổng Quan Hệ Thống";
            btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(2, 6, 23);
            pnlLogo.Controls.Add(lblRoleTag);
            pnlLogo.Controls.Add(lblAdminTitle);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(230, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblRoleTag
            // 
            lblRoleTag.AutoSize = true;
            lblRoleTag.BackColor = System.Drawing.Color.FromArgb(3, 105, 161);
            lblRoleTag.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblRoleTag.ForeColor = System.Drawing.Color.White;
            lblRoleTag.Location = new System.Drawing.Point(20, 50);
            lblRoleTag.Name = "lblRoleTag";
            lblRoleTag.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            lblRoleTag.Size = new System.Drawing.Size(107, 17);
            lblRoleTag.TabIndex = 1;
            lblRoleTag.Text = "ADMINISTRATOR";
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblAdminTitle.ForeColor = System.Drawing.Color.White;
            lblAdminTitle.Location = new System.Drawing.Point(20, 20);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new System.Drawing.Size(134, 21);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "SMART LIBRARY";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblSessionInfo);
            pnlHeader.Controls.Add(lblCurrentPageTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(230, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(874, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSessionInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSessionInfo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSessionInfo.Location = new System.Drawing.Point(420, 20);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblSessionInfo.Size = new System.Drawing.Size(430, 25);
            lblSessionInfo.TabIndex = 1;
            lblSessionInfo.Text = "Người dùng: admin | Đăng nhập lúc: --:--:--";
            lblSessionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentPageTitle
            // 
            lblCurrentPageTitle.AutoSize = true;
            lblCurrentPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblCurrentPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblCurrentPageTitle.Location = new System.Drawing.Point(25, 18);
            lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            lblCurrentPageTitle.Size = new System.Drawing.Size(199, 25);
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
            lblWelcome.Size = new System.Drawing.Size(430, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hệ thống quản trị hoạt động bình thường. Chọn menu để thao tác.";
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1104, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new System.Drawing.Size(1000, 600);
            Name = "FormAdminDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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