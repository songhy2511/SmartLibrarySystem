namespace Library.UI
{
    partial class FormSuaThuThu
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
            cboQuayPhuTrach = new System.Windows.Forms.ComboBox();
            lblQuayPhuTrach = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtSoDienThoai = new System.Windows.Forms.TextBox();
            lblSoDienThoai = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
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
            lblSubTitle.Size = new System.Drawing.Size(262, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Chỉnh sửa thông tin hồ sơ và quầy trực thủ thư";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(22, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(262, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT HỒ SƠ THỦ THƯ";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.White;
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
            pnlContent.Controls.Add(txtMaThuThu);
            pnlContent.Controls.Add(lblMaThuThu);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 75);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(25);
            pnlContent.Size = new System.Drawing.Size(460, 395);
            pnlContent.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnHuy.Location = new System.Drawing.Point(235, 335);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(195, 38);
            btnHuy.TabIndex = 11;
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
            btnLuu.Location = new System.Drawing.Point(30, 335);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(195, 38);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "LƯU THAY ĐỔI";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboQuayPhuTrach
            // 
            cboQuayPhuTrach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboQuayPhuTrach.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboQuayPhuTrach.FormattingEnabled = true;
            cboQuayPhuTrach.Items.AddRange(new object[] { "Quầy Mượn - Trả số 1", "Quầy Mượn - Trả số 2", "Quầy Quản lý Kho & Kiểm kê", "Quầy Tiếp nhận & Xử lý vi phạm" });
            cboQuayPhuTrach.Location = new System.Drawing.Point(30, 280);
            cboQuayPhuTrach.Name = "cboQuayPhuTrach";
            cboQuayPhuTrach.Size = new System.Drawing.Size(400, 25);
            cboQuayPhuTrach.TabIndex = 9;
            // 
            // lblQuayPhuTrach
            // 
            lblQuayPhuTrach.AutoSize = true;
            lblQuayPhuTrach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblQuayPhuTrach.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblQuayPhuTrach.Location = new System.Drawing.Point(30, 258);
            lblQuayPhuTrach.Name = "lblQuayPhuTrach";
            lblQuayPhuTrach.Size = new System.Drawing.Size(99, 17);
            lblQuayPhuTrach.TabIndex = 8;
            lblQuayPhuTrach.Text = "Quầy phụ trách";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.Location = new System.Drawing.Point(30, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(400, 25);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblEmail.Location = new System.Drawing.Point(30, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(40, 17);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new System.Drawing.Point(30, 155);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new System.Drawing.Size(400, 25);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSoDienThoai.Location = new System.Drawing.Point(30, 133);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new System.Drawing.Size(88, 17);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtHoTen.Location = new System.Drawing.Point(30, 93);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(400, 25);
            txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblHoTen.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblHoTen.Location = new System.Drawing.Point(30, 71);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(68, 17);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên";
            // 
            // txtMaThuThu
            // 
            txtMaThuThu.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            txtMaThuThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtMaThuThu.Location = new System.Drawing.Point(30, 32);
            txtMaThuThu.Name = "txtMaThuThu";
            txtMaThuThu.ReadOnly = true;
            txtMaThuThu.Size = new System.Drawing.Size(400, 25);
            txtMaThuThu.TabIndex = 1;
            // 
            // lblMaThuThu
            // 
            lblMaThuThu.AutoSize = true;
            lblMaThuThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblMaThuThu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMaThuThu.Location = new System.Drawing.Point(30, 10);
            lblMaThuThu.Name = "lblMaThuThu";
            lblMaThuThu.Size = new System.Drawing.Size(77, 17);
            lblMaThuThu.TabIndex = 0;
            lblMaThuThu.Text = "Mã thủ thư";
            // 
            // FormSuaThuThu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(460, 470);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSuaThuThu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Smart Library - Sửa thông tin thủ thư";
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
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblQuayPhuTrach;
        private System.Windows.Forms.ComboBox cboQuayPhuTrach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}