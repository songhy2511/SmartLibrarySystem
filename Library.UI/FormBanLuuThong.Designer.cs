using System.Drawing;
using System.Windows.Forms;
namespace Library.UI
{
    partial class FormBanLuuThong
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
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHenHan = new System.Windows.Forms.DateTimePicker();
            this.dgvSachDangMuon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieuMuon = new System.Windows.Forms.Button();
            this.btnXacNhanTra = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(202, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÀN LƯU THÔNG";
            // 
            // cboDocGia
            // 
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(36, 110);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(260, 23);
            this.cboDocGia.TabIndex = 1;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(340, 110);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(150, 23);
            this.dtpNgayMuon.TabIndex = 2;
            // 
            // dtpNgayHenHan
            // 
            this.dtpNgayHenHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHenHan.Location = new System.Drawing.Point(510, 110);
            this.dtpNgayHenHan.Name = "dtpNgayHenHan";
            this.dtpNgayHenHan.Size = new System.Drawing.Size(150, 23);
            this.dtpNgayHenHan.TabIndex = 3;
            // 
            // dgvSachDangMuon
            // 
            this.dgvSachDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDangMuon.Location = new System.Drawing.Point(510, 190);
            this.dgvSachDangMuon.Name = "dgvSachDangMuon";
            this.dgvSachDangMuon.Size = new System.Drawing.Size(430, 250);
            this.dgvSachDangMuon.TabIndex = 4;
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLapPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(36, 460);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(140, 45);
            this.btnLapPhieuMuon.TabIndex = 5;
            this.btnLapPhieuMuon.Text = "LẬP PHIẾU MƯỢN";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // btnXacNhanTra
            // 
            this.btnXacNhanTra.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXacNhanTra.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanTra.Location = new System.Drawing.Point(800, 460);
            this.btnXacNhanTra.Name = "btnXacNhanTra";
            this.btnXacNhanTra.Size = new System.Drawing.Size(140, 45);
            this.btnXacNhanTra.TabIndex = 6;
            this.btnXacNhanTra.Text = "XÁC NHẬN TRẢ";
            this.btnXacNhanTra.UseVisualStyleBackColor = false;
            this.btnXacNhanTra.Click += new System.EventHandler(this.btnXacNhanTra_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnGiaHan.Location = new System.Drawing.Point(645, 460);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(140, 45);
            this.btnGiaHan.TabIndex = 7;
            this.btnGiaHan.Text = "GIA HẠN";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(190, 460);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 45);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(36, 160);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(200, 23);
            this.txtTimKiemSach.TabIndex = 9;
            this.txtTimKiemSach.Text = "Nhập mã sách hoặc tên sách...";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(245, 160);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // FormBanLuuThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 531);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiemSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnXacNhanTra);
            this.Controls.Add(this.btnLapPhieuMuon);
            this.Controls.Add(this.dgvSachDangMuon);
            this.Controls.Add(this.dtpNgayHenHan);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.cboDocGia);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FormBanLuuThong";
            this.Text = "Smart Library - Bàn lưu thông";
            this.Load += new System.EventHandler(this.FormBanLuuThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDangMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayHenHan;
        private System.Windows.Forms.DataGridView dgvSachDangMuon;
        private System.Windows.Forms.Button btnLapPhieuMuon;
        private System.Windows.Forms.Button btnXacNhanTra;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnTimKiem;
    }
}