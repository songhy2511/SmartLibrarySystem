namespace Library.UI
{
    partial class FormDangNhap
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
            pnlBanner = new System.Windows.Forms.Panel();
            lblSubTitleApp = new System.Windows.Forms.Label();
            lblTitleApp = new System.Windows.Forms.Label();
            lblBrand = new System.Windows.Forms.Label();
            pnlLoginArea = new System.Windows.Forms.Panel();
            btnThoat = new System.Windows.Forms.Button();
            btnDangNhap = new System.Windows.Forms.Button();
            chkHienMatKhau = new System.Windows.Forms.CheckBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            lblMatKhau = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            lblTenDangNhap = new System.Windows.Forms.Label();
            lblHuongDan = new System.Windows.Forms.Label();
            lblTieuDe = new System.Windows.Forms.Label();
            pnlBanner.SuspendLayout();
            pnlLoginArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlBanner.Controls.Add(lblSubTitleApp);
            pnlBanner.Controls.Add(lblTitleApp);
            pnlBanner.Controls.Add(lblBrand);
            pnlBanner.Dock = System.Windows.Forms.DockStyle.Left;
            pnlBanner.Location = new System.Drawing.Point(0, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new System.Drawing.Size(280, 420);
            pnlBanner.TabIndex = 0;
            // 
            // lblSubTitleApp
            // 
            lblSubTitleApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitleApp.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubTitleApp.Location = new System.Drawing.Point(20, 230);
            lblSubTitleApp.Name = "lblSubTitleApp";
            lblSubTitleApp.Size = new System.Drawing.Size(240, 50);
            lblSubTitleApp.TabIndex = 2;
            lblSubTitleApp.Text = "Hệ thống quản lý mượn trả, kiểm kê kho sách và điều hành nhân sự tập trung.";
            // 
            // lblTitleApp
            // 
            lblTitleApp.AutoSize = true;
            lblTitleApp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitleApp.ForeColor = System.Drawing.Color.White;
            lblTitleApp.Location = new System.Drawing.Point(20, 190);
            lblTitleApp.Name = "lblTitleApp";
            lblTitleApp.Size = new System.Drawing.Size(186, 30);
            lblTitleApp.TabIndex = 1;
            lblTitleApp.Text = "SMART LIBRARY";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblBrand.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            lblBrand.Location = new System.Drawing.Point(15, 115);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new System.Drawing.Size(107, 65);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "📚";
            // 
            // pnlLoginArea
            // 
            pnlLoginArea.BackColor = System.Drawing.Color.White;
            pnlLoginArea.Controls.Add(btnThoat);
            pnlLoginArea.Controls.Add(btnDangNhap);
            pnlLoginArea.Controls.Add(chkHienMatKhau);
            pnlLoginArea.Controls.Add(txtMatKhau);
            pnlLoginArea.Controls.Add(lblMatKhau);
            pnlLoginArea.Controls.Add(txtTenDangNhap);
            pnlLoginArea.Controls.Add(lblTenDangNhap);
            pnlLoginArea.Controls.Add(lblHuongDan);
            pnlLoginArea.Controls.Add(lblTieuDe);
            pnlLoginArea.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLoginArea.Location = new System.Drawing.Point(280, 0);
            pnlLoginArea.Name = "pnlLoginArea";
            pnlLoginArea.Padding = new System.Windows.Forms.Padding(40);
            pnlLoginArea.Size = new System.Drawing.Size(444, 420);
            pnlLoginArea.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            btnThoat.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnThoat.Location = new System.Drawing.Point(45, 335);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(350, 38);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDangNhap.ForeColor = System.Drawing.Color.White;
            btnDangNhap.Location = new System.Drawing.Point(45, 285);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(350, 42);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            chkHienMatKhau.Location = new System.Drawing.Point(45, 245);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new System.Drawing.Size(121, 19);
            chkHienMatKhau.TabIndex = 4;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtMatKhau.Location = new System.Drawing.Point(45, 205);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new System.Drawing.Size(350, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMatKhau.Location = new System.Drawing.Point(45, 180);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(66, 17);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new System.Drawing.Point(45, 135);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(350, 27);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTenDangNhap.Location = new System.Drawing.Point(45, 110);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(100, 17);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblHuongDan
            // 
            lblHuongDan.AutoSize = true;
            lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblHuongDan.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblHuongDan.Location = new System.Drawing.Point(45, 75);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new System.Drawing.Size(263, 15);
            lblHuongDan.TabIndex = 1;
            lblHuongDan.Text = "Đăng nhập tài khoản Quản trị viên hoặc Thủ thư";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTieuDe.Location = new System.Drawing.Point(40, 40);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new System.Drawing.Size(155, 31);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(724, 420);
            Controls.Add(pnlLoginArea);
            Controls.Add(pnlBanner);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Smart Library - Đăng nhập hệ thống";
            pnlBanner.ResumeLayout(false);
            pnlBanner.PerformLayout();
            pnlLoginArea.ResumeLayout(false);
            pnlLoginArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitleApp;
        private System.Windows.Forms.Label lblSubTitleApp;
        private System.Windows.Forms.Panel pnlLoginArea;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}