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
            lblTieuDe = new Label();
            cboDocGia = new ComboBox();
            dtpNgayMuon = new DateTimePicker();
            dtpNgayHenHan = new DateTimePicker();
            dgvSachDangMuon = new DataGridView();
            btnLapPhieuMuon = new Button();
            btnXacNhanTra = new Button();
            btnGiaHan = new Button();
            btnLamMoi = new Button();
            txtTimKiemSach = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.Location = new Point(34, 27);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(268, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀN LƯU THÔNG";
            // 
            // cboDocGia
            // 
            cboDocGia.FormattingEnabled = true;
            cboDocGia.Location = new Point(41, 147);
            cboDocGia.Margin = new Padding(3, 4, 3, 4);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(297, 28);
            cboDocGia.TabIndex = 1;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(389, 147);
            dtpNgayMuon.Margin = new Padding(3, 4, 3, 4);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(171, 27);
            dtpNgayMuon.TabIndex = 2;
            // 
            // dtpNgayHenHan
            // 
            dtpNgayHenHan.Format = DateTimePickerFormat.Short;
            dtpNgayHenHan.Location = new Point(583, 147);
            dtpNgayHenHan.Margin = new Padding(3, 4, 3, 4);
            dtpNgayHenHan.Name = "dtpNgayHenHan";
            dtpNgayHenHan.Size = new Size(171, 27);
            dtpNgayHenHan.TabIndex = 3;
            // 
            // dgvSachDangMuon
            // 
            dgvSachDangMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachDangMuon.Location = new Point(133, 279);
            dgvSachDangMuon.Margin = new Padding(3, 4, 3, 4);
            dgvSachDangMuon.Name = "dgvSachDangMuon";
            dgvSachDangMuon.RowHeadersWidth = 51;
            dgvSachDangMuon.Size = new Size(941, 307);
            dgvSachDangMuon.TabIndex = 4;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.BackColor = Color.DodgerBlue;
            btnLapPhieuMuon.ForeColor = Color.White;
            btnLapPhieuMuon.Location = new Point(41, 613);
            btnLapPhieuMuon.Margin = new Padding(3, 4, 3, 4);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(160, 60);
            btnLapPhieuMuon.TabIndex = 5;
            btnLapPhieuMuon.Text = "LẬP PHIẾU MƯỢN";
            btnLapPhieuMuon.UseVisualStyleBackColor = false;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // btnXacNhanTra
            // 
            btnXacNhanTra.BackColor = Color.ForestGreen;
            btnXacNhanTra.ForeColor = Color.White;
            btnXacNhanTra.Location = new Point(914, 613);
            btnXacNhanTra.Margin = new Padding(3, 4, 3, 4);
            btnXacNhanTra.Name = "btnXacNhanTra";
            btnXacNhanTra.Size = new Size(160, 60);
            btnXacNhanTra.TabIndex = 6;
            btnXacNhanTra.Text = "XÁC NHẬN TRẢ";
            btnXacNhanTra.UseVisualStyleBackColor = false;
            btnXacNhanTra.Click += btnXacNhanTra_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = Color.DarkOrange;
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(737, 613);
            btnGiaHan.Margin = new Padding(3, 4, 3, 4);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(160, 60);
            btnGiaHan.TabIndex = 7;
            btnGiaHan.Text = "GIA HẠN";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(217, 613);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(114, 60);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSach
            // 
            txtTimKiemSach.Location = new Point(41, 213);
            txtTimKiemSach.Margin = new Padding(3, 4, 3, 4);
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.Size = new Size(228, 27);
            txtTimKiemSach.TabIndex = 9;
            txtTimKiemSach.Text = "Nhập mã sách hoặc tên sách...";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(280, 213);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 33);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // FormBanLuuThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 708);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiemSach);
            Controls.Add(btnLamMoi);
            Controls.Add(btnGiaHan);
            Controls.Add(btnXacNhanTra);
            Controls.Add(btnLapPhieuMuon);
            Controls.Add(dgvSachDangMuon);
            Controls.Add(dtpNgayHenHan);
            Controls.Add(dtpNgayMuon);
            Controls.Add(cboDocGia);
            Controls.Add(lblTieuDe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBanLuuThong";
            Text = "Smart Library - Bàn lưu thông";
            Load += FormBanLuuThong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
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