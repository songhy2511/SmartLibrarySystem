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
            pnlBanner = new Panel();
            lblSubTitleApp = new Label();
            lblTitleApp = new Label();
            lblBrand = new Label();
            pnlLoginArea = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkHienMatKhau = new CheckBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            lblHuongDan = new Label();
            lblTieuDe = new Label();
            pnlBanner.SuspendLayout();
            pnlLoginArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.FromArgb(30, 41, 59);
            pnlBanner.Controls.Add(lblSubTitleApp);
            pnlBanner.Controls.Add(lblTitleApp);
            pnlBanner.Controls.Add(lblBrand);
            pnlBanner.Dock = DockStyle.Left;
            pnlBanner.Location = new Point(0, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(280, 420);
            pnlBanner.TabIndex = 0;
            // 
            // lblSubTitleApp
            // 
            lblSubTitleApp.Font = new Font("Segoe UI", 9F);
            lblSubTitleApp.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubTitleApp.Location = new Point(20, 230);
            lblSubTitleApp.Name = "lblSubTitleApp";
            lblSubTitleApp.Size = new Size(240, 50);
            lblSubTitleApp.TabIndex = 2;
            lblSubTitleApp.Text = "Hệ thống quản lý mượn trả, kiểm kê kho sách và điều hành nhân sự tập trung.";
            // 
            // lblTitleApp
            // 
            lblTitleApp.AutoSize = true;
            lblTitleApp.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitleApp.ForeColor = Color.White;
            lblTitleApp.Location = new Point(20, 190);
            lblTitleApp.Name = "lblTitleApp";
            lblTitleApp.Size = new Size(182, 30);
            lblTitleApp.TabIndex = 1;
            lblTitleApp.Text = "SMART LIBRARY";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(56, 189, 248);
            lblBrand.Location = new Point(15, 115);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(95, 65);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "📚";
            // 
            // pnlLoginArea
            // 
            pnlLoginArea.BackColor = Color.White;
            pnlLoginArea.Controls.Add(btnThoat);
            pnlLoginArea.Controls.Add(btnDangNhap);
            pnlLoginArea.Controls.Add(chkHienMatKhau);
            pnlLoginArea.Controls.Add(txtMatKhau);
            pnlLoginArea.Controls.Add(lblMatKhau);
            pnlLoginArea.Controls.Add(txtTenDangNhap);
            pnlLoginArea.Controls.Add(lblTenDangNhap);
            pnlLoginArea.Controls.Add(lblHuongDan);
            pnlLoginArea.Controls.Add(lblTieuDe);
            pnlLoginArea.Dock = DockStyle.Fill;
            pnlLoginArea.Location = new Point(280, 0);
            pnlLoginArea.Name = "pnlLoginArea";
            pnlLoginArea.Padding = new Padding(40);
            pnlLoginArea.Size = new Size(444, 420);
            pnlLoginArea.TabIndex = 1;
            pnlLoginArea.Paint += pnlLoginArea_Paint;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(241, 245, 249);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 85, 105);
            btnThoat.Location = new Point(45, 335);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(350, 38);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(2, 132, 199);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(45, 285);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(350, 42);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 9F);
            chkHienMatKhau.ForeColor = Color.FromArgb(100, 116, 139);
            chkHienMatKhau.Location = new Point(45, 245);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(121, 19);
            chkHienMatKhau.TabIndex = 4;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(45, 205);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(350, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.FromArgb(51, 65, 85);
            lblMatKhau.Location = new Point(45, 180);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(66, 17);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(45, 135);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(350, 27);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTenDangNhap.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenDangNhap.Location = new Point(45, 110);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(99, 17);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblHuongDan
            // 
            lblHuongDan.AutoSize = true;
            lblHuongDan.Font = new Font("Segoe UI", 9F);
            lblHuongDan.ForeColor = Color.FromArgb(100, 116, 139);
            lblHuongDan.Location = new Point(45, 75);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(262, 15);
            lblHuongDan.TabIndex = 1;
            lblHuongDan.Text = "Đăng nhập tài khoản Quản trị viên hoặc Thủ thư";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(15, 23, 42);
            lblTieuDe.Location = new Point(40, 40);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(153, 31);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 420);
            Controls.Add(pnlLoginArea);
            Controls.Add(pnlBanner);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
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