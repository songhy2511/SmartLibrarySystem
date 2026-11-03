namespace Library.UI
{
    partial class FormDoiMatKhau
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
            btnHuy = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            chkHienMatKhau = new System.Windows.Forms.CheckBox();
            txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            lblXacNhanMatKhau = new System.Windows.Forms.Label();
            txtMatKhauMoi = new System.Windows.Forms.TextBox();
            lblMatKhauMoi = new System.Windows.Forms.Label();
            txtMatKhauCu = new System.Windows.Forms.TextBox();
            lblMatKhauCu = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(460, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSubTitle.Location = new System.Drawing.Point(24, 46);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(306, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Cập nhật mật khẩu mới có độ dài tối thiểu từ 6 ký tự trở lên";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(22, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(161, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.White;
            pnlContent.Controls.Add(btnHuy);
            pnlContent.Controls.Add(btnLuu);
            pnlContent.Controls.Add(chkHienMatKhau);
            pnlContent.Controls.Add(txtXacNhanMatKhau);
            pnlContent.Controls.Add(lblXacNhanMatKhau);
            pnlContent.Controls.Add(txtMatKhauMoi);
            pnlContent.Controls.Add(lblMatKhauMoi);
            pnlContent.Controls.Add(txtMatKhauCu);
            pnlContent.Controls.Add(lblMatKhauCu);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(25);
            pnlContent.Size = new System.Drawing.Size(460, 340);
            pnlContent.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnHuy.Location = new System.Drawing.Point(235, 270);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(195, 38);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Đóng";
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
            btnLuu.Location = new System.Drawing.Point(30, 270);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(195, 38);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "LƯU THAY ĐỔI";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            chkHienMatKhau.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            chkHienMatKhau.Location = new System.Drawing.Point(30, 230);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new System.Drawing.Size(121, 19);
            chkHienMatKhau.TabIndex = 6;
            chkHienMatKhau.Text = "Hiển thị mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtXacNhanMatKhau.Location = new System.Drawing.Point(30, 190);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new System.Drawing.Size(400, 26);
            txtXacNhanMatKhau.TabIndex = 5;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.KeyDown += txtXacNhanMatKhau_KeyDown;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblXacNhanMatKhau.Location = new System.Drawing.Point(30, 168);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new System.Drawing.Size(151, 17);
            lblXacNhanMatKhau.TabIndex = 4;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtMatKhauMoi.Location = new System.Drawing.Point(30, 122);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new System.Drawing.Size(400, 26);
            txtMatKhauMoi.TabIndex = 3;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtMatKhauMoi.KeyDown += txtMatKhauMoi_KeyDown;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMatKhauMoi.Location = new System.Drawing.Point(30, 100);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new System.Drawing.Size(93, 17);
            lblMatKhauMoi.TabIndex = 2;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtMatKhauCu.Location = new System.Drawing.Point(30, 55);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new System.Drawing.Size(400, 26);
            txtMatKhauCu.TabIndex = 1;
            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauCu.KeyDown += txtMatKhauCu_KeyDown;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMatKhauCu.Location = new System.Drawing.Point(30, 33);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new System.Drawing.Size(115, 17);
            lblMatKhauCu.TabIndex = 0;
            lblMatKhauCu.Text = "Mật khẩu hiện tại";
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(460, 420);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDoiMatKhau";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Smart Library - Đổi Mật Khẩu";
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
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}