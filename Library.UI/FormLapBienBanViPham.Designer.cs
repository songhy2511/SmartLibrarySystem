using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormLapBienBanViPham
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblMaBiEnBan;
        private TextBox txtMaBiEnBan;
        private Label lblMaPhieuMuon;
        private TextBox txtMaPhieuMuon;
        private Label lblMaDocGia;
        private TextBox txtMaDocGia;
        private Label lblLyDoPhat;
        private ComboBox cboLyDoPhat;
        private Label lblSoTienPhat;
        private TextBox txtSoTienPhat;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private CheckBox chkDaThanhToan;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Button btnXacNhanPhat;
        private Button btnHuy;

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
            lblMaBiEnBan = new Label();
            txtMaBiEnBan = new TextBox();
            lblMaPhieuMuon = new Label();
            txtMaPhieuMuon = new TextBox();
            lblMaDocGia = new Label();
            txtMaDocGia = new TextBox();
            lblLyDoPhat = new Label();
            cboLyDoPhat = new ComboBox();
            lblSoTienPhat = new Label();
            txtSoTienPhat = new TextBox();
            lblNgayLap = new Label();
            dtpNgayLap = new DateTimePicker();
            chkDaThanhToan = new CheckBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnXacNhanPhat = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblMaBiEnBan
            // 
            lblMaBiEnBan.Location = new Point(0, 0);
            lblMaBiEnBan.Name = "lblMaBiEnBan";
            lblMaBiEnBan.Size = new Size(100, 23);
            lblMaBiEnBan.TabIndex = 0;
            // 
            // txtMaBiEnBan
            // 
            txtMaBiEnBan.Location = new Point(0, 0);
            txtMaBiEnBan.Name = "txtMaBiEnBan";
            txtMaBiEnBan.Size = new Size(100, 27);
            txtMaBiEnBan.TabIndex = 1;
            // 
            // lblMaPhieuMuon
            // 
            lblMaPhieuMuon.Location = new Point(0, 0);
            lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            lblMaPhieuMuon.Size = new Size(100, 23);
            lblMaPhieuMuon.TabIndex = 2;
            // 
            // txtMaPhieuMuon
            // 
            txtMaPhieuMuon.Location = new Point(0, 0);
            txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            txtMaPhieuMuon.Size = new Size(100, 27);
            txtMaPhieuMuon.TabIndex = 3;
            // 
            // lblMaDocGia
            // 
            lblMaDocGia.Location = new Point(0, 0);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(100, 23);
            lblMaDocGia.TabIndex = 4;
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Location = new Point(0, 0);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(100, 27);
            txtMaDocGia.TabIndex = 5;
            // 
            // lblLyDoPhat
            // 
            lblLyDoPhat.Location = new Point(0, 0);
            lblLyDoPhat.Name = "lblLyDoPhat";
            lblLyDoPhat.Size = new Size(100, 23);
            lblLyDoPhat.TabIndex = 6;
            // 
            // cboLyDoPhat
            // 
            cboLyDoPhat.Location = new Point(0, 0);
            cboLyDoPhat.Name = "cboLyDoPhat";
            cboLyDoPhat.Size = new Size(121, 28);
            cboLyDoPhat.TabIndex = 7;
            cboLyDoPhat.SelectedIndexChanged += cboLyDoPhat_SelectedIndexChanged;
            // 
            // lblSoTienPhat
            // 
            lblSoTienPhat.Location = new Point(0, 0);
            lblSoTienPhat.Name = "lblSoTienPhat";
            lblSoTienPhat.Size = new Size(100, 23);
            lblSoTienPhat.TabIndex = 8;
            // 
            // txtSoTienPhat
            // 
            txtSoTienPhat.Location = new Point(0, 0);
            txtSoTienPhat.Name = "txtSoTienPhat";
            txtSoTienPhat.Size = new Size(100, 27);
            txtSoTienPhat.TabIndex = 9;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Location = new Point(0, 0);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(100, 23);
            lblNgayLap.TabIndex = 10;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(0, 0);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 27);
            dtpNgayLap.TabIndex = 11;
            // 
            // chkDaThanhToan
            // 
            chkDaThanhToan.Location = new Point(0, 0);
            chkDaThanhToan.Name = "chkDaThanhToan";
            chkDaThanhToan.Size = new Size(104, 24);
            chkDaThanhToan.TabIndex = 12;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(0, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(0, 0);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(100, 27);
            txtGhiChu.TabIndex = 14;
            // 
            // btnXacNhanPhat
            // 
            btnXacNhanPhat.Location = new Point(0, 0);
            btnXacNhanPhat.Name = "btnXacNhanPhat";
            btnXacNhanPhat.Size = new Size(75, 23);
            btnXacNhanPhat.TabIndex = 15;
            btnXacNhanPhat.Click += btnXacNhanPhat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(0, 0);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 16;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormLapBienBanViPham
            // 
            ClientSize = new Size(570, 401);
            Controls.Add(lblMaBiEnBan);
            Controls.Add(txtMaBiEnBan);
            Controls.Add(lblMaPhieuMuon);
            Controls.Add(txtMaPhieuMuon);
            Controls.Add(lblMaDocGia);
            Controls.Add(txtMaDocGia);
            Controls.Add(lblLyDoPhat);
            Controls.Add(cboLyDoPhat);
            Controls.Add(lblSoTienPhat);
            Controls.Add(txtSoTienPhat);
            Controls.Add(lblNgayLap);
            Controls.Add(dtpNgayLap);
            Controls.Add(chkDaThanhToan);
            Controls.Add(lblGhiChu);
            Controls.Add(txtGhiChu);
            Controls.Add(btnXacNhanPhat);
            Controls.Add(btnHuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLapBienBanViPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lập Biên Bản Vi Phạm & Thu Tiền Phạt";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}