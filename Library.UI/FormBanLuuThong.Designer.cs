using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormBanLuuThong
    {
        private System.ComponentModel.IContainer components = null;

        // Các controls cho Form
        private TabControl tabControlMain;
        private TabPage tabMuonSach;
        private TabPage tabTraSach;

        // Controls Tab Mượn Sách
        private Label lblMaDocGia;
        private TextBox txtMaDocGia;
        private ComboBox cboDocGia;
        private Label lblMaSach;
        private TextBox txtMaSach;
        private Label lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private Label lblNgayHenHan;
        private DateTimePicker dtpNgayHenHan;
        private Button btnKiemTraDieuKien;
        private Button btnXacNhanMuon;
        private Label lblTrangThaiThe;

        // Controls Tab Trả Sách
        private Label lblNgayTra;
        private DateTimePicker dtpNgayTra;
        private Button btnXacNhanTra;
        private Button btnMoFormBiEnBan;
        private Label lblTongTienThu;
        private DataGridView dgvPhieuMuon;

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
            this.tabControlMain = new TabControl();
            this.tabMuonSach = new TabPage();
            this.tabTraSach = new TabPage();

            this.SuspendLayout();

            // 1. Cấu hình Form chính
            this.ClientSize = new Size(880, 520);
            this.Text = "Bàn Lưu Thông - Quản Lý Mượn Trả Sách";
            this.StartPosition = FormStartPosition.CenterScreen;

            // 2. TabControl
            this.tabControlMain.Dock = DockStyle.Fill;
            this.tabControlMain.Controls.Add(this.tabMuonSach);
            this.tabControlMain.Controls.Add(this.tabTraSach);
            this.Controls.Add(this.tabControlMain);

            // ==========================================
            // TAB 1: MƯỢN SÁCH
            // ==========================================
            this.tabMuonSach.Text = "Mượn Sách";
            this.tabMuonSach.Padding = new Padding(15);

            this.lblMaDocGia = new Label { Text = "Mã độc giả:", Location = new Point(20, 25), AutoSize = true };
            this.txtMaDocGia = new TextBox { Location = new Point(120, 22), Width = 150 };

            this.cboDocGia = new ComboBox { Location = new Point(280, 22), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            this.btnKiemTraDieuKien = new Button { Text = "Kiểm tra thẻ", Location = new Point(490, 20), Width = 110, Height = 27 };
            this.lblTrangThaiThe = new Label { Text = "Trạng thái: Chưa kiểm tra", Location = new Point(610, 25), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };

            this.lblMaSach = new Label { Text = "Mã sách mượn:", Location = new Point(20, 65), AutoSize = true };
            this.txtMaSach = new TextBox { Location = new Point(120, 62), Width = 360 };

            this.lblNgayMuon = new Label { Text = "Ngày mượn:", Location = new Point(20, 105), AutoSize = true };
            this.dtpNgayMuon = new DateTimePicker { Location = new Point(120, 102), Width = 150, Format = DateTimePickerFormat.Short };

            this.lblNgayHenHan = new Label { Text = "Ngày hẹn trả:", Location = new Point(290, 105), AutoSize = true };
            this.dtpNgayHenHan = new DateTimePicker { Location = new Point(380, 102), Width = 150, Format = DateTimePickerFormat.Short };

            this.btnXacNhanMuon = new Button { Text = "Xác Nhận Mượn Sách", Location = new Point(120, 150), Width = 180, Height = 35, BackColor = Color.LightGreen };
            this.btnXacNhanMuon.Click += new System.EventHandler(this.btnXacNhanMuon_Click);
            this.btnKiemTraDieuKien.Click += new System.EventHandler(this.btnKiemTraDieuKien_Click);

            this.tabMuonSach.Controls.AddRange(new Control[] {
                lblMaDocGia, txtMaDocGia, cboDocGia, btnKiemTraDieuKien, lblTrangThaiThe,
                lblMaSach, txtMaSach, lblNgayMuon, dtpNgayMuon, lblNgayHenHan, dtpNgayHenHan, btnXacNhanMuon
            });

            // ==========================================
            // TAB 2: TRẢ SÁCH & GIA HẠN
            // ==========================================
            this.tabTraSach.Text = "Trả Sách / Gia Hạn";
            this.tabTraSach.Padding = new Padding(15);

            this.lblNgayTra = new Label { Text = "Ngày trả thực tế:", Location = new Point(20, 20), AutoSize = true };
            this.dtpNgayTra = new DateTimePicker { Location = new Point(130, 17), Width = 150, Format = DateTimePickerFormat.Short };

            this.btnXacNhanTra = new Button { Text = "Xác Nhận Trả Sách", Location = new Point(300, 15), Width = 150, Height = 30, BackColor = Color.LightSkyBlue };
            this.btnMoFormBiEnBan = new Button { Text = "Lập Biên Bản Vi Phạm", Location = new Point(460, 15), Width = 160, Height = 30, BackColor = Color.LightCoral };

            this.lblTongTienThu = new Label { Text = "Tiền phạt: 0 VNĐ", Location = new Point(640, 20), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold), ForeColor = Color.Red };

            this.dgvPhieuMuon = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(820, 390),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true
            };

            this.btnXacNhanTra.Click += new System.EventHandler(this.btnXacNhanTra_Click);
            this.btnMoFormBiEnBan.Click += new System.EventHandler(this.btnMoFormBiEnBan_Click);

            this.tabTraSach.Controls.AddRange(new Control[] {
                lblNgayTra, dtpNgayTra, btnXacNhanTra, btnMoFormBiEnBan, lblTongTienThu, dgvPhieuMuon
            });

            this.ResumeLayout(false);
        }
    }
}