namespace Library.UI
{
    partial class FormThemThuThu
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubTitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            lblGhiChuMatKhau = new System.Windows.Forms.Label();
            btnHuy = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            cboQuayPhuTrach = new System.Windows.Forms.ComboBox();
            lblQuayPhuTrach = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtSoDienThoai = new System.Windows.Forms.TextBox();
            lblSoDienThoai = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            lblTenDangNhap = new System.Windows.Forms.Label();
            txtMaThuThu = new System.Windows.Forms.TextBox();
            lblMaThuThu = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(460, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubTitle.Location = new System.Drawing.Point(24, 45);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(273, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Hệ thống tự động cấp mã định danh TT0xxx duy nhất";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(22, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(242, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÊM THỦ THƯ MỚI";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.White;
            pnlContent.Controls.Add(lblGhiChuMatKhau);
            pnlContent.Controls.Add(btnHuy);
            pnlContent.Controls.Add(btnLuu);
            pnlContent.Controls.Add(cboQuayPhuTrach);
            pnlContent.Controls.Add(lblQuayPhuTrach);
            pnlContent.Controls.Add(txtEmail);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(txtSoDienThoai);
            pnlContent.Controls.Add(lblSoDienThoai);
            pnlContent.Controls.Add(txtHoTen);
            pnlContent.Controls.Add(lblHoTen);
            pnlContent.Controls.Add(txtTenDangNhap);
            pnlContent.Controls.Add(lblTenDangNhap);
            pnlContent.Controls.Add(txtMaThuThu);
            pnlContent.Controls.Add(lblMaThuThu);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 75);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(25);
            pnlContent.Size = new System.Drawing.Size(460, 445);
            pnlContent.TabIndex = 1;
            // 
            // lblGhiChuMatKhau
            // 
            lblGhiChuMatKhau.AutoSize = true;
            lblGhiChuMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            lblGhiChuMatKhau.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblGhiChuMatKhau.Location = new System.Drawing.Point(30, 345);
            lblGhiChuMatKhau.Name = "lblGhiChuMatKhau";
            lblGhiChuMatKhau.Size = new System.Drawing.Size(268, 15);
            lblGhiChuMatKhau.TabIndex = 12;
            lblGhiChuMatKhau.Text = "* Mật khẩu khởi tạo mặc định là: Librarian@123";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnHuy.Location = new System.Drawing.Point(235, 380);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(195, 38);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy Bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Location = new System.Drawing.Point(30, 380);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(195, 38);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "TẠO THỦ THƯ";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboQuayPhuTrach
            // 
            cboQuayPhuTrach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboQuayPhuTrach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboQuayPhuTrach.FormattingEnabled = true;
            cboQuayPhuTrach.Items.AddRange(new object[] { "Quầy Mượn - Trả số 1", "Quầy Mượn - Trả số 2", "Quầy Quản lý Kho & Kiểm kê", "Quầy Tiếp nhận & Xử lý vi phạm" });
            cboQuayPhuTrach.Location = new System.Drawing.Point(30, 305);
            cboQuayPhuTrach.Name = "cboQuayPhuTrach";
            cboQuayPhuTrach.Size = new System.Drawing.Size(400, 25);
            cboQuayPhuTrach.TabIndex = 11;
            // 
            // lblQuayPhuTrach
            // 
            lblQuayPhuTrach.AutoSize = true;
            lblQuayPhuTrach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblQuayPhuTrach.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblQuayPhuTrach.Location = new System.Drawing.Point(30, 283);
            lblQuayPhuTrach.Name = "lblQuayPhuTrach";
            lblQuayPhuTrach.Size = new System.Drawing.Size(99, 17);
            lblQuayPhuTrach.TabIndex = 10;
            lblQuayPhuTrach.Text = "Quầy phụ trách";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtEmail.Location = new System.Drawing.Point(30, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nhanvien@smartlibrary.vn";
            txtEmail.Size = new System.Drawing.Size(400, 24);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblEmail.Location = new System.Drawing.Point(30, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(40, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSoDienThoai.Location = new System.Drawing.Point(30, 185);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "098xxxxxxx";
            txtSoDienThoai.Size = new System.Drawing.Size(400, 24);
            txtSoDienThoai.TabIndex = 7;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSoDienThoai.Location = new System.Drawing.Point(30, 163);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new System.Drawing.Size(88, 17);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtHoTen.Location = new System.Drawing.Point(30, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Nguyễn Văn A";
            txtHoTen.Size = new System.Drawing.Size(400, 24);
            txtHoTen.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblHoTen.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblHoTen.Location = new System.Drawing.Point(30, 103);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(85, 17);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ và tên (*)";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTenDangNhap.Location = new System.Drawing.Point(210, 32);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "thuthu3";
            txtTenDangNhap.Size = new System.Drawing.Size(220, 24);
            txtTenDangNhap.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTenDangNhap.Location = new System.Drawing.Point(210, 10);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(117, 17);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập (*)";
            // 
            // txtMaThuThu
            // 
            txtMaThuThu.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            txtMaThuThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            txtMaThuThu.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);
            txtMaThuThu.Location = new System.Drawing.Point(30, 32);
            txtMaThuThu.Name = "txtMaThuThu";
            txtMaThuThu.ReadOnly = true;
            txtMaThuThu.Size = new System.Drawing.Size(160, 24);
            txtMaThuThu.TabIndex = 1;
            // 
            // lblMaThuThu
            // 
            lblMaThuThu.AutoSize = true;
            lblMaThuThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblMaThuThu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMaThuThu.Location = new System.Drawing.Point(30, 10);
            lblMaThuThu.Name = "lblMaThuThu";
            lblMaThuThu.Size = new System.Drawing.Size(120, 17);
            lblMaThuThu.TabIndex = 0;
            lblMaThuThu.Text = "Mã tự sinh (TT0xxx)";
            // 
            // FormThemThuThu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(460, 520);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemThuThu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Smart Library - Thêm thủ thư mới";
            Load += FormThemThuThu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblMaThuThu;
        private System.Windows.Forms.TextBox txtMaThuThu;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblQuayPhuTrach;
        private System.Windows.Forms.ComboBox cboQuayPhuTrach;
        private System.Windows.Forms.Label lblGhiChuMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}