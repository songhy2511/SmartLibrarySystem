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
            lblTieuDe = new Label();
            txtMaBienBan = new TextBox();
            dtpNgayLap = new DateTimePicker();
            txtCanBoLap = new TextBox();
            cboLoaiViPham = new ComboBox();
            txtSoTienPhat = new TextBox();
            dtpNgayHenNop = new DateTimePicker();
            txtMoTa = new TextBox();
            btnLuuBienBan = new Button();
            btnLamMoi = new Button();
            btnHuyBo = new Button();
            dgvBienBanViPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBienBanViPham).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.Location = new Point(34, 27);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(358, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "LẬP BIÊN BẢN VI PHẠM";
            // 
            // txtMaBienBan
            // 
            txtMaBienBan.Location = new Point(514, 107);
            txtMaBienBan.Margin = new Padding(3, 4, 3, 4);
            txtMaBienBan.Name = "txtMaBienBan";
            txtMaBienBan.Size = new Size(228, 27);
            txtMaBienBan.TabIndex = 1;
            txtMaBienBan.Text = "BBVP00125";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(514, 160);
            dtpNgayLap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(228, 27);
            dtpNgayLap.TabIndex = 2;
            // 
            // txtCanBoLap
            // 
            txtCanBoLap.Location = new Point(514, 213);
            txtCanBoLap.Margin = new Padding(3, 4, 3, 4);
            txtCanBoLap.Name = "txtCanBoLap";
            txtCanBoLap.Size = new Size(228, 27);
            txtCanBoLap.TabIndex = 3;
            txtCanBoLap.Text = "Nguyễn Thị Hoa";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Items.AddRange(new object[] { "Mất sách", "Trễ hạn", "Làm hư sách" });
            cboLoaiViPham.Location = new Point(171, 293);
            cboLoaiViPham.Margin = new Padding(3, 4, 3, 4);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(228, 28);
            cboLoaiViPham.TabIndex = 4;
            cboLoaiViPham.Text = "Mất sách";
            // 
            // txtSoTienPhat
            // 
            txtSoTienPhat.Location = new Point(857, 160);
            txtSoTienPhat.Margin = new Padding(3, 4, 3, 4);
            txtSoTienPhat.Name = "txtSoTienPhat";
            txtSoTienPhat.Size = new Size(205, 27);
            txtSoTienPhat.TabIndex = 5;
            txtSoTienPhat.Text = "100000";
            // 
            // dtpNgayHenNop
            // 
            dtpNgayHenNop.Format = DateTimePickerFormat.Short;
            dtpNgayHenNop.Location = new Point(857, 213);
            dtpNgayHenNop.Margin = new Padding(3, 4, 3, 4);
            dtpNgayHenNop.Name = "dtpNgayHenNop";
            dtpNgayHenNop.Size = new Size(205, 27);
            dtpNgayHenNop.TabIndex = 6;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(171, 347);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(457, 79);
            txtMoTa.TabIndex = 7;
            txtMoTa.Text = "Làm mất sách \"Lập trình C#\" sau khi mượn.";
            // 
            // btnLuuBienBan
            // 
            btnLuuBienBan.BackColor = Color.DodgerBlue;
            btnLuuBienBan.ForeColor = Color.White;
            btnLuuBienBan.Location = new Point(594, 447);
            btnLuuBienBan.Margin = new Padding(3, 4, 3, 4);
            btnLuuBienBan.Name = "btnLuuBienBan";
            btnLuuBienBan.Size = new Size(160, 53);
            btnLuuBienBan.TabIndex = 8;
            btnLuuBienBan.Text = "LƯU BIÊN BẢN";
            btnLuuBienBan.UseVisualStyleBackColor = false;
            btnLuuBienBan.Click += btnLuuBienBan_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(771, 447);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(126, 53);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Crimson;
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(457, 447);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(126, 53);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dgvBienBanViPham
            // 
            dgvBienBanViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBienBanViPham.Location = new Point(34, 533);
            dgvBienBanViPham.Margin = new Padding(3, 4, 3, 4);
            dgvBienBanViPham.Name = "dgvBienBanViPham";
            dgvBienBanViPham.RowHeadersWidth = 51;
            dgvBienBanViPham.Size = new Size(1029, 240);
            dgvBienBanViPham.TabIndex = 11;
            // 
            // FormLapBienBanViPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 800);
            Controls.Add(dgvBienBanViPham);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuuBienBan);
            Controls.Add(txtMoTa);
            Controls.Add(dtpNgayHenNop);
            Controls.Add(txtSoTienPhat);
            Controls.Add(cboLoaiViPham);
            Controls.Add(txtCanBoLap);
            Controls.Add(dtpNgayLap);
            Controls.Add(txtMaBienBan);
            Controls.Add(lblTieuDe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLapBienBanViPham";
            Text = "Smart Library - Lập biên bản vi phạm";
            Load += FormLapBienBanViPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBienBanViPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
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