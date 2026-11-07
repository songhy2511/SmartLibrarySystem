namespace Library.UI
{
    partial class FormChotCaTruc
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTenCa = new System.Windows.Forms.Label();
            this.lblTienDauCaTitle = new System.Windows.Forms.Label();
            this.lblTienDauCaVal = new System.Windows.Forms.Label();
            this.lblThuPhatTitle = new System.Windows.Forms.Label();
            this.lblThuPhatVal = new System.Windows.Forms.Label();
            this.lblLyThuyetTitle = new System.Windows.Forms.Label();
            this.lblLyThuyetVal = new System.Windows.Forms.Label();
            this.lblThucTeTitle = new System.Windows.Forms.Label();
            this.nudThucTeVal = new System.Windows.Forms.NumericUpDown();
            this.lblChenhLechTitle = new System.Windows.Forms.Label();
            this.lblChenhLechVal = new System.Windows.Forms.Label();
            this.btnChotCa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThucTeVal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(325, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "BÀN GIAO CA & ĐỐI SOÁT QUỸ TỜI";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Controls.Add(this.lblTenCa);
            this.pnlContent.Controls.Add(this.lblTienDauCaTitle);
            this.pnlContent.Controls.Add(this.lblTienDauCaVal);
            this.pnlContent.Controls.Add(this.lblThuPhatTitle);
            this.pnlContent.Controls.Add(this.lblThuPhatVal);
            this.pnlContent.Controls.Add(this.lblLyThuyetTitle);
            this.pnlContent.Controls.Add(this.lblLyThuyetVal);
            this.pnlContent.Controls.Add(this.lblThucTeTitle);
            this.pnlContent.Controls.Add(this.nudThucTeVal);
            this.pnlContent.Controls.Add(this.lblChenhLechTitle);
            this.pnlContent.Controls.Add(this.lblChenhLechVal);
            this.pnlContent.Location = new System.Drawing.Point(25, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(430, 270);
            this.pnlContent.TabIndex = 1;
            // 
            // lblTenCa
            // 
            this.lblTenCa.AutoSize = true;
            this.lblTenCa.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lblTenCa.Location = new System.Drawing.Point(20, 15);
            this.lblTenCa.Name = "lblTenCa";
            this.lblTenCa.Size = new System.Drawing.Size(155, 20);
            this.lblTenCa.TabIndex = 0;
            this.lblTenCa.Text = "Ca trực: Đang tải...";
            // 
            // lblTienDauCaTitle
            // 
            this.lblTienDauCaTitle.AutoSize = true;
            this.lblTienDauCaTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTienDauCaTitle.Location = new System.Drawing.Point(20, 55);
            this.lblTienDauCaTitle.Name = "lblTienDauCaTitle";
            this.lblTienDauCaTitle.Size = new System.Drawing.Size(125, 19);
            this.lblTienDauCaTitle.TabIndex = 1;
            this.lblTienDauCaTitle.Text = "Tiền nhận đầu ca:";
            // 
            // lblTienDauCaVal
            // 
            this.lblTienDauCaVal.AutoSize = true;
            this.lblTienDauCaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTienDauCaVal.Location = new System.Drawing.Point(280, 55);
            this.lblTienDauCaVal.Name = "lblTienDauCaVal";
            this.lblTienDauCaVal.Size = new System.Drawing.Size(29, 19);
            this.lblTienDauCaVal.TabIndex = 2;
            this.lblTienDauCaVal.Text = "0 đ";
            // 
            // lblThuPhatTitle
            // 
            this.lblThuPhatTitle.AutoSize = true;
            this.lblThuPhatTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThuPhatTitle.Location = new System.Drawing.Point(20, 85);
            this.lblThuPhatTitle.Name = "lblThuPhatTitle";
            this.lblThuPhatTitle.Size = new System.Drawing.Size(193, 19);
            this.lblThuPhatTitle.TabIndex = 3;
            this.lblThuPhatTitle.Text = "Tổng phạt thu được trong ca (+):";
            // 
            // lblThuPhatVal
            // 
            this.lblThuPhatVal.AutoSize = true;
            this.lblThuPhatVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblThuPhatVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblThuPhatVal.Location = new System.Drawing.Point(280, 85);
            this.lblThuPhatVal.Name = "lblThuPhatVal";
            this.lblThuPhatVal.Size = new System.Drawing.Size(29, 19);
            this.lblThuPhatVal.TabIndex = 4;
            this.lblThuPhatVal.Text = "0 đ";
            // 
            // lblLyThuyetTitle
            // 
            this.lblLyThuyetTitle.AutoSize = true;
            this.lblLyThuyetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLyThuyetTitle.Location = new System.Drawing.Point(20, 125);
            this.lblLyThuyetTitle.Name = "lblLyThuyetTitle";
            this.lblLyThuyetTitle.Size = new System.Drawing.Size(189, 19);
            this.lblLyThuyetTitle.TabIndex = 5;
            this.lblLyThuyetTitle.Text = "TỔNG TIỀN MẶT LÝ THUYẾT:";
            // 
            // lblLyThuyetVal
            // 
            this.lblLyThuyetVal.AutoSize = true;
            this.lblLyThuyetVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLyThuyetVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLyThuyetVal.Location = new System.Drawing.Point(280, 123);
            this.lblLyThuyetVal.Name = "lblLyThuyetVal";
            this.lblLyThuyetVal.Size = new System.Drawing.Size(34, 21);
            this.lblLyThuyetVal.TabIndex = 6;
            this.lblLyThuyetVal.Text = "0 đ";
            // 
            // lblThucTeTitle
            // 
            this.lblThucTeTitle.AutoSize = true;
            this.lblThucTeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblThucTeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblThucTeTitle.Location = new System.Drawing.Point(20, 175);
            this.lblThucTeTitle.Name = "lblThucTeTitle";
            this.lblThucTeTitle.Size = new System.Drawing.Size(225, 19);
            this.lblThucTeTitle.TabIndex = 7;
            this.lblThucTeTitle.Text = "TIỀN MẶT THỰC TẾ KIỂM ĐẾM (*):";
            // 
            // nudThucTeVal
            // 
            this.nudThucTeVal.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.nudThucTeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.nudThucTeVal.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudThucTeVal.Location = new System.Drawing.Point(255, 170);
            this.nudThucTeVal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudThucTeVal.Name = "nudThucTeVal";
            this.nudThucTeVal.Size = new System.Drawing.Size(155, 28);
            this.nudThucTeVal.TabIndex = 8;
            this.nudThucTeVal.ThousandsSeparator = true;
            this.nudThucTeVal.ValueChanged += new System.EventHandler(this.nudThucTeVal_ValueChanged);
            // 
            // lblChenhLechTitle
            // 
            this.lblChenhLechTitle.AutoSize = true;
            this.lblChenhLechTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChenhLechTitle.Location = new System.Drawing.Point(20, 225);
            this.lblChenhLechTitle.Name = "lblChenhLechTitle";
            this.lblChenhLechTitle.Size = new System.Drawing.Size(130, 19);
            this.lblChenhLechTitle.TabIndex = 9;
            this.lblChenhLechTitle.Text = "Chênh lệch đối soát:";
            // 
            // lblChenhLechVal
            // 
            this.lblChenhLechVal.AutoSize = true;
            this.lblChenhLechVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblChenhLechVal.Location = new System.Drawing.Point(255, 225);
            this.lblChenhLechVal.Name = "lblChenhLechVal";
            this.lblChenhLechVal.Size = new System.Drawing.Size(29, 19);
            this.lblChenhLechVal.TabIndex = 10;
            this.lblChenhLechVal.Text = "0 đ";
            // 
            // btnChotCa
            // 
            this.btnChotCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnChotCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChotCa.FlatAppearance.BorderSize = 0;
            this.btnChotCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChotCa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnChotCa.ForeColor = System.Drawing.Color.White;
            this.btnChotCa.Location = new System.Drawing.Point(25, 340);
            this.btnChotCa.Name = "btnChotCa";
            this.btnChotCa.Size = new System.Drawing.Size(240, 42);
            this.btnChotCa.TabIndex = 2;
            this.btnChotCa.Text = "🔒 CHỐT CA VÀ ĐĂNG XUẤT";
            this.btnChotCa.UseVisualStyleBackColor = false;
            this.btnChotCa.Click += new System.EventHandler(this.btnChotCa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnHuy.Location = new System.Drawing.Point(280, 340);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(175, 42);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "HỦY ĐĂNG XUẤT";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormChotCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChotCa);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChotCaTruc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chốt Ca Trực";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThucTeVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTenCa;
        private System.Windows.Forms.Label lblTienDauCaTitle;
        private System.Windows.Forms.Label lblTienDauCaVal;
        private System.Windows.Forms.Label lblThuPhatTitle;
        private System.Windows.Forms.Label lblThuPhatVal;
        private System.Windows.Forms.Label lblLyThuyetTitle;
        private System.Windows.Forms.Label lblLyThuyetVal;
        private System.Windows.Forms.Label lblThucTeTitle;
        private System.Windows.Forms.NumericUpDown nudThucTeVal;
        private System.Windows.Forms.Label lblChenhLechTitle;
        private System.Windows.Forms.Label lblChenhLechVal;
        private System.Windows.Forms.Button btnChotCa;
        private System.Windows.Forms.Button btnHuy;
    }
}