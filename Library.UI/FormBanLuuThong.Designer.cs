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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            grpMuonSach = new GroupBox();
            lblDocGia = new Label();
            cboDocGia = new ComboBox();
            lblMaSach = new Label();
            txtMaSach = new TextBox();
            lblNgayMuon = new Label();
            dtpNgayMuon = new DateTimePicker();
            lblNgayHenHan = new Label();
            dtpNgayHenHan = new DateTimePicker();
            btnLapPhieuMuon = new Button();
            btnLamMoi = new Button();
            grpDanhSach = new GroupBox();
            dgvSachDangMuon = new DataGridView();
            btnGiaHan = new Button();
            btnXacNhanTra = new Button();
            grpMuonSach.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(19, 78, 74);
            lblTieuDe.Location = new Point(25, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(248, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀN LƯU THÔNG";
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = true;
            lblPhuDe.Font = new Font("Segoe UI", 9.5F);
            lblPhuDe.ForeColor = Color.FromArgb(100, 116, 139);
            lblPhuDe.Location = new Point(27, 52);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(512, 21);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Thực hiện thủ tục cấp mượn sách, nhận trả tài liệu và gia hạn cho độc giả";
            // 
            // grpMuonSach
            // 
            grpMuonSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpMuonSach.Controls.Add(btnLamMoi);
            grpMuonSach.Controls.Add(btnLapPhieuMuon);
            grpMuonSach.Controls.Add(dtpNgayHenHan);
            grpMuonSach.Controls.Add(lblNgayHenHan);
            grpMuonSach.Controls.Add(dtpNgayMuon);
            grpMuonSach.Controls.Add(lblNgayMuon);
            grpMuonSach.Controls.Add(txtMaSach);
            grpMuonSach.Controls.Add(lblMaSach);
            grpMuonSach.Controls.Add(cboDocGia);
            grpMuonSach.Controls.Add(lblDocGia);
            grpMuonSach.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpMuonSach.ForeColor = Color.FromArgb(30, 41, 59);
            grpMuonSach.Location = new Point(27, 85);
            grpMuonSach.Name = "grpMuonSach";
            grpMuonSach.Size = new Size(1005, 150);
            grpMuonSach.TabIndex = 2;
            grpMuonSach.TabStop = false;
            grpMuonSach.Text = " Thiết lập phiếu mượn mới ";
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Segoe UI", 9F);
            lblDocGia.Location = new Point(20, 28);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(95, 20);
            lblDocGia.TabIndex = 0;
            lblDocGia.Text = "Độc giả (*):";
            // 
            // cboDocGia
            // 
            cboDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocGia.Font = new Font("Segoe UI", 9F);
            cboDocGia.FormattingEnabled = true;
            cboDocGia.Location = new Point(20, 50);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(260, 28);
            cboDocGia.TabIndex = 1;
            cboDocGia.SelectedIndexChanged += cboDocGia_SelectedIndexChanged;
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Font = new Font("Segoe UI", 9F);
            lblMaSach.Location = new Point(300, 28);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(153, 20);
            lblMaSach.TabIndex = 2;
            lblMaSach.Text = "Mã sách / Mã vạch (*):";
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI", 9F);
            txtMaSach.Location = new Point(300, 50);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.PlaceholderText = "Nhập mã sách hoặc quét barcode...";
            txtMaSach.Size = new Size(240, 27);
            txtMaSach.TabIndex = 3;
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Font = new Font("Segoe UI", 9F);
            lblNgayMuon.Location = new Point(560, 28);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(90, 20);
            lblNgayMuon.TabIndex = 4;
            lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Font = new Font("Segoe UI", 9F);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(560, 50);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(140, 27);
            dtpNgayMuon.TabIndex = 5;
            // 
            // lblNgayHenHan
            // 
            lblNgayHenHan.AutoSize = true;
            lblNgayHenHan.Font = new Font("Segoe UI", 9F);
            lblNgayHenHan.Location = new Point(720, 28);
            lblNgayHenHan.Name = "lblNgayHenHan";
            lblNgayHenHan.Size = new Size(100, 20);
            lblNgayHenHan.TabIndex = 6;
            lblNgayHenHan.Text = "Ngày hẹn trả:";
            // 
            // dtpNgayHenHan
            // 
            dtpNgayHenHan.CustomFormat = "dd/MM/yyyy";
            dtpNgayHenHan.Font = new Font("Segoe UI", 9F);
            dtpNgayHenHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHenHan.Location = new Point(720, 50);
            dtpNgayHenHan.Name = "dtpNgayHenHan";
            dtpNgayHenHan.Size = new Size(140, 27);
            dtpNgayHenHan.TabIndex = 7;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.BackColor = Color.FromArgb(15, 118, 110);
            btnLapPhieuMuon.Cursor = Cursors.Hand;
            btnLapPhieuMuon.FlatAppearance.BorderSize = 0;
            btnLapPhieuMuon.FlatStyle = FlatStyle.Flat;
            btnLapPhieuMuon.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnLapPhieuMuon.ForeColor = Color.White;
            btnLapPhieuMuon.Location = new Point(20, 92);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(180, 42);
            btnLapPhieuMuon.TabIndex = 8;
            btnLapPhieuMuon.Text = "📖 CHO MƯỢN SÁCH";
            btnLapPhieuMuon.UseVisualStyleBackColor = false;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(30, 41, 59);
            btnLamMoi.Location = new Point(210, 92);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 42);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄 LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(btnXacNhanTra);
            grpDanhSach.Controls.Add(btnGiaHan);
            grpDanhSach.Controls.Add(dgvSachDangMuon);
            grpDanhSach.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.FromArgb(19, 78, 74);
            grpDanhSach.Location = new Point(27, 245);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1005, 410);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = " Danh mục sách độc giả đang mượn ";
            // 
            // dgvSachDangMuon
            // 
            dgvSachDangMuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSachDangMuon.BackgroundColor = Color.White;
            dgvSachDangMuon.BorderStyle = BorderStyle.None;
            dgvSachDangMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachDangMuon.Location = new Point(15, 30);
            dgvSachDangMuon.Name = "dgvSachDangMuon";
            dgvSachDangMuon.RowHeadersWidth = 51;
            dgvSachDangMuon.Size = new Size(975, 315);
            dgvSachDangMuon.TabIndex = 0;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGiaHan.BackColor = Color.FromArgb(234, 88, 12);
            btnGiaHan.Cursor = Cursors.Hand;
            btnGiaHan.FlatAppearance.BorderSize = 0;
            btnGiaHan.FlatStyle = FlatStyle.Flat;
            btnGiaHan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(620, 355);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(175, 45);
            btnGiaHan.TabIndex = 1;
            btnGiaHan.Text = "⏳ GIA HẠN (+7 NGÀY)";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnXacNhanTra
            // 
            btnXacNhanTra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacNhanTra.BackColor = Color.FromArgb(22, 101, 52);
            btnXacNhanTra.Cursor = Cursors.Hand;
            btnXacNhanTra.FlatAppearance.BorderSize = 0;
            btnXacNhanTra.FlatStyle = FlatStyle.Flat;
            btnXacNhanTra.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnXacNhanTra.ForeColor = Color.White;
            btnXacNhanTra.Location = new Point(810, 355);
            btnXacNhanTra.Name = "btnXacNhanTra";
            btnXacNhanTra.Size = new Size(180, 45);
            btnXacNhanTra.TabIndex = 2;
            btnXacNhanTra.Text = "✅ XÁC NHẬN TRẢ SÁCH";
            btnXacNhanTra.UseVisualStyleBackColor = false;
            btnXacNhanTra.Click += btnXacNhanTra_Click;
            // 
            // FormBanLuuThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1060, 680);
            Controls.Add(grpDanhSach);
            Controls.Add(grpMuonSach);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBanLuuThong";
            Text = "Bàn Lưu Thông";
            Load += FormBanLuuThong_Load;
            grpMuonSach.ResumeLayout(false);
            grpMuonSach.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private GroupBox grpMuonSach;
        private Label lblDocGia;
        private ComboBox cboDocGia;
        private Label lblMaSach;
        private TextBox txtMaSach;
        private Label lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private Label lblNgayHenHan;
        private DateTimePicker dtpNgayHenHan;
        private Button btnLapPhieuMuon;
        private Button btnLamMoi;
        private GroupBox grpDanhSach;
        private DataGridView dgvSachDangMuon;
        private Button btnGiaHan;
        private Button btnXacNhanTra;
    }
}