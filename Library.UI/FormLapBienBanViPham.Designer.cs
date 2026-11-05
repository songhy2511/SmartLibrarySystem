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
            this.SuspendLayout();

            // Cấu hình Form biên bản
            this.ClientSize = new Size(480, 400);
            this.Text = "Lập Biên Bản Vi Phạm & Thu Tiền Phạt";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.lblMaBiEnBan = new Label { Text = "Mã biên bản:", Location = new Point(30, 25), AutoSize = true };
            this.txtMaBiEnBan = new TextBox { Location = new Point(140, 22), Width = 280, ReadOnly = true };

            this.lblMaPhieuMuon = new Label { Text = "Mã phiếu mượn:", Location = new Point(30, 65), AutoSize = true };
            this.txtMaPhieuMuon = new TextBox { Location = new Point(140, 62), Width = 280 };

            this.lblMaDocGia = new Label { Text = "Mã độc giả:", Location = new Point(30, 105), AutoSize = true };
            this.txtMaDocGia = new TextBox { Location = new Point(140, 102), Width = 280 };

            this.lblLyDoPhat = new Label { Text = "Lý do vi phạm:", Location = new Point(30, 145), AutoSize = true };
            this.cboLyDoPhat = new ComboBox { Location = new Point(140, 142), Width = 280, DropDownStyle = ComboBoxStyle.DropDownList };
            this.cboLyDoPhat.SelectedIndexChanged += new System.EventHandler(this.cboLyDoPhat_SelectedIndexChanged);

            this.lblSoTienPhat = new Label { Text = "Số tiền phạt (VNĐ):", Location = new Point(30, 185), AutoSize = true };
            this.txtSoTienPhat = new TextBox { Location = new Point(140, 182), Width = 280 };

            this.lblNgayLap = new Label { Text = "Ngày lập BB:", Location = new Point(30, 225), AutoSize = true };
            this.dtpNgayLap = new DateTimePicker { Location = new Point(140, 222), Width = 160, Format = DateTimePickerFormat.Short };

            this.chkDaThanhToan = new CheckBox { Text = "Đã thu tiền tại quầy", Location = new Point(310, 224), AutoSize = true, Checked = true };

            this.lblGhiChu = new Label { Text = "Ghi chú:", Location = new Point(30, 265), AutoSize = true };
            this.txtGhiChu = new TextBox { Location = new Point(140, 262), Width = 280, Multiline = true, Height = 50 };

            this.btnXacNhanPhat = new Button { Text = "Lưu Biên Bản", Location = new Point(140, 330), Width = 130, Height = 35, BackColor = Color.LightGreen };
            this.btnHuy = new Button { Text = "Hủy Bỏ", Location = new Point(290, 330), Width = 130, Height = 35 };

            this.btnXacNhanPhat.Click += new System.EventHandler(this.btnXacNhanPhat_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.Controls.AddRange(new Control[] {
                lblMaBiEnBan, txtMaBiEnBan,
                lblMaPhieuMuon, txtMaPhieuMuon,
                lblMaDocGia, txtMaDocGia,
                lblLyDoPhat, cboLyDoPhat,
                lblSoTienPhat, txtSoTienPhat,
                lblNgayLap, dtpNgayLap, chkDaThanhToan,
                lblGhiChu, txtGhiChu,
                btnXacNhanPhat, btnHuy
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}