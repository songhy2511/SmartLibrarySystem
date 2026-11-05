using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormLapBienBanViPham
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

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtMaBienBan = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtCanBoLap = new System.Windows.Forms.TextBox();
            this.cboLoaiViPham = new System.Windows.Forms.ComboBox();
            this.txtSoTienPhat = new System.Windows.Forms.TextBox();
            this.dtpNgayHenNop = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnLuuBienBan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.dgvBienBanViPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(325, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LẬP BIÊN BẢN VI PHẠM";
            // 
            // txtMaBienBan
            // 
            this.txtMaBienBan.Location = new System.Drawing.Point(450, 80);
            this.txtMaBienBan.Name = "txtMaBienBan";
            this.txtMaBienBan.Size = new System.Drawing.Size(200, 23);
            this.txtMaBienBan.TabIndex = 1;
            this.txtMaBienBan.Text = "BBVP00125";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(450, 120);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // txtCanBoLap
            // 
            this.txtCanBoLap.Location = new System.Drawing.Point(450, 160);
            this.txtCanBoLap.Name = "txtCanBoLap";
            this.txtCanBoLap.Size = new System.Drawing.Size(200, 23);
            this.txtCanBoLap.TabIndex = 3;
            this.txtCanBoLap.Text = "Nguyễn Thị Hoa";
            // 
            // cboLoaiViPham
            // 
            this.cboLoaiViPham.FormattingEnabled = true;
            this.cboLoaiViPham.Items.AddRange(new object[] {
            "Mất sách",
            "Trễ hạn",
            "Làm hư sách"});
            this.cboLoaiViPham.Location = new System.Drawing.Point(150, 220);
            this.cboLoaiViPham.Name = "cboLoaiViPham";
            this.cboLoaiViPham.Size = new System.Drawing.Size(200, 23);
            this.cboLoaiViPham.TabIndex = 4;
            this.cboLoaiViPham.Text = "Mất sách";
            // 
            // txtSoTienPhat
            // 
            this.txtSoTienPhat.Location = new System.Drawing.Point(750, 120);
            this.txtSoTienPhat.Name = "txtSoTienPhat";
            this.txtSoTienPhat.Size = new System.Drawing.Size(180, 23);
            this.txtSoTienPhat.TabIndex = 5;
            this.txtSoTienPhat.Text = "100000";
            // 
            // dtpNgayHenNop
            // 
            this.dtpNgayHenNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHenNop.Location = new System.Drawing.Point(750, 160);
            this.dtpNgayHenNop.Name = "dtpNgayHenNop";
            this.dtpNgayHenNop.Size = new System.Drawing.Size(180, 23);
            this.dtpNgayHenNop.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(150, 260);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(400, 60);
            this.txtMoTa.TabIndex = 7;
            this.txtMoTa.Text = "Làm mất sách \"Lập trình C#\" sau khi mượn.";
            // 
            // btnLuuBienBan
            // 
            this.btnLuuBienBan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuuBienBan.ForeColor = System.Drawing.Color.White;
            this.btnLuuBienBan.Location = new System.Drawing.Point(520, 335);
            this.btnLuuBienBan.Name = "btnLuuBienBan";
            this.btnLuuBienBan.Size = new System.Drawing.Size(140, 40);
            this.btnLuuBienBan.TabIndex = 8;
            this.btnLuuBienBan.Text = "LƯU BIÊN BẢN";
            this.btnLuuBienBan.UseVisualStyleBackColor = false;
            this.btnLuuBienBan.Click += new System.EventHandler(this.btnLuuBienBan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(675, 335);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 40);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Crimson;
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.Location = new System.Drawing.Point(400, 335);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(110, 40);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "HỦY BỎ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // dgvBienBanViPham
            // 
            this.dgvBienBanViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienBanViPham.Location = new System.Drawing.Point(30, 400);
            this.dgvBienBanViPham.Name = "dgvBienBanViPham";
            this.dgvBienBanViPham.Size = new System.Drawing.Size(900, 180);
            this.dgvBienBanViPham.TabIndex = 11;
            // 
            // FormLapBienBanViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 600);
            this.Controls.Add(this.dgvBienBanViPham);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuuBienBan);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.dtpNgayHenNop);
            this.Controls.Add(this.txtSoTienPhat);
            this.Controls.Add(this.cboLoaiViPham);
            this.Controls.Add(this.txtCanBoLap);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txtMaBienBan);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FormLapBienBanViPham";
            this.Text = "Smart Library - Lập biên bản vi phạm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtMaBienBan;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtCanBoLap;
        private System.Windows.Forms.ComboBox cboLoaiViPham;
        private System.Windows.Forms.TextBox txtSoTienPhat;
        private System.Windows.Forms.DateTimePicker dtpNgayHenNop;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnLuuBienBan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.DataGridView dgvBienBanViPham;
    }
}