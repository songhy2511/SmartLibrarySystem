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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            grpThongTin = new GroupBox();
            btnHuyBo = new Button();
            btnLamMoi = new Button();
            btnLuuBienBan = new Button();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            dtpNgayHenNop = new DateTimePicker();
            lblNgayHenNop = new Label();
            txtSoTienPhat = new TextBox();
            lblSoTienPhat = new Label();
            cboLoaiViPham = new ComboBox();
            lblLoaiViPham = new Label();
            dtpNgayLap = new DateTimePicker();
            lblNgayLap = new Label();
            txtCanBoLap = new TextBox();
            lblCanBoLap = new Label();
            cboDocGia = new ComboBox();
            lblDocGia = new Label();
            txtMaBienBan = new TextBox();
            lblMaBienBan = new Label();
            lblDanhSach = new Label();
            dgvBienBanViPham = new DataGridView();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBienBanViPham).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(19, 78, 74);
            lblTieuDe.Location = new Point(22, 11);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(262, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "LẬP BIÊN BẢN VI PHẠM";
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = true;
            lblPhuDe.Font = new Font("Segoe UI", 9.5F);
            lblPhuDe.ForeColor = Color.FromArgb(100, 116, 139);
            lblPhuDe.Location = new Point(24, 39);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(399, 17);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Xử lý bồi thường sách hư hỏng, mất tài liệu và các vi phạm quy chế";
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnLuuBienBan);
            grpThongTin.Controls.Add(txtMoTa);
            grpThongTin.Controls.Add(lblMoTa);
            grpThongTin.Controls.Add(dtpNgayHenNop);
            grpThongTin.Controls.Add(lblNgayHenNop);
            grpThongTin.Controls.Add(txtSoTienPhat);
            grpThongTin.Controls.Add(lblSoTienPhat);
            grpThongTin.Controls.Add(cboLoaiViPham);
            grpThongTin.Controls.Add(lblLoaiViPham);
            grpThongTin.Controls.Add(dtpNgayLap);
            grpThongTin.Controls.Add(lblNgayLap);
            grpThongTin.Controls.Add(txtCanBoLap);
            grpThongTin.Controls.Add(lblCanBoLap);
            grpThongTin.Controls.Add(cboDocGia);
            grpThongTin.Controls.Add(lblDocGia);
            grpThongTin.Controls.Add(txtMaBienBan);
            grpThongTin.Controls.Add(lblMaBienBan);
            grpThongTin.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.FromArgb(30, 41, 59);
            grpThongTin.Location = new Point(24, 64);
            grpThongTin.Margin = new Padding(3, 2, 3, 2);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 2, 3, 2);
            grpThongTin.Size = new Size(879, 176);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = " Thông tin biên bản xử lý ";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(254, 242, 242);
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(185, 28, 28);
            btnHuyBo.Location = new Point(774, 131);
            btnHuyBo.Margin = new Padding(3, 2, 3, 2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(88, 36);
            btnHuyBo.TabIndex = 18;
            btnHuyBo.Text = "❌ HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(30, 41, 59);
            btnLamMoi.Location = new Point(678, 131);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(88, 36);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "🔄 LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuuBienBan
            // 
            btnLuuBienBan.BackColor = Color.FromArgb(15, 118, 110);
            btnLuuBienBan.Cursor = Cursors.Hand;
            btnLuuBienBan.FlatAppearance.BorderSize = 0;
            btnLuuBienBan.FlatStyle = FlatStyle.Flat;
            btnLuuBienBan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnLuuBienBan.ForeColor = Color.White;
            btnLuuBienBan.Location = new Point(542, 131);
            btnLuuBienBan.Margin = new Padding(3, 2, 3, 2);
            btnLuuBienBan.Name = "btnLuuBienBan";
            btnLuuBienBan.Size = new Size(127, 36);
            btnLuuBienBan.TabIndex = 16;
            btnLuuBienBan.Text = "💾 LƯU BIÊN BẢN";
            btnLuuBienBan.UseVisualStyleBackColor = false;
            btnLuuBienBan.Click += btnLuuBienBan_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 9F);
            txtMoTa.Location = new Point(18, 134);
            txtMoTa.Margin = new Padding(3, 2, 3, 2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(508, 35);
            txtMoTa.TabIndex = 15;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 9F);
            lblMoTa.Location = new Point(18, 116);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(126, 15);
            lblMoTa.TabIndex = 14;
            lblMoTa.Text = "Mô tả chi tiết vi phạm:";
            // 
            // dtpNgayHenNop
            // 
            dtpNgayHenNop.CustomFormat = "dd/MM/yyyy";
            dtpNgayHenNop.Font = new Font("Segoe UI", 9F);
            dtpNgayHenNop.Format = DateTimePickerFormat.Custom;
            dtpNgayHenNop.Location = new Point(438, 88);
            dtpNgayHenNop.Margin = new Padding(3, 2, 3, 2);
            dtpNgayHenNop.Name = "dtpNgayHenNop";
            dtpNgayHenNop.Size = new Size(193, 23);
            dtpNgayHenNop.TabIndex = 13;
            // 
            // lblNgayHenNop
            // 
            lblNgayHenNop.AutoSize = true;
            lblNgayHenNop.Font = new Font("Segoe UI", 9F);
            lblNgayHenNop.Location = new Point(438, 71);
            lblNgayHenNop.Name = "lblNgayHenNop";
            lblNgayHenNop.Size = new Size(106, 15);
            lblNgayHenNop.TabIndex = 12;
            lblNgayHenNop.Text = "Hạn nộp tiền phạt:";
            // 
            // txtSoTienPhat
            // 
            txtSoTienPhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSoTienPhat.ForeColor = Color.FromArgb(185, 28, 28);
            txtSoTienPhat.Location = new Point(254, 88);
            txtSoTienPhat.Margin = new Padding(3, 2, 3, 2);
            txtSoTienPhat.Name = "txtSoTienPhat";
            txtSoTienPhat.Size = new Size(167, 23);
            txtSoTienPhat.TabIndex = 11;
            txtSoTienPhat.Text = "0";
            // 
            // lblSoTienPhat
            // 
            lblSoTienPhat.AutoSize = true;
            lblSoTienPhat.Font = new Font("Segoe UI", 9F);
            lblSoTienPhat.Location = new Point(254, 71);
            lblSoTienPhat.Name = "lblSoTienPhat";
            lblSoTienPhat.Size = new Size(108, 15);
            lblSoTienPhat.TabIndex = 10;
            lblSoTienPhat.Text = "Số tiền phạt (VNĐ):";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiViPham.Font = new Font("Segoe UI", 9F);
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Items.AddRange(new object[] { "Làm mất sách", "Làm rách / hư hỏng sách", "Quá hạn mượn kéo dài", "Vi phạm nội quy thư viện" });
            cboLoaiViPham.Location = new Point(18, 88);
            cboLoaiViPham.Margin = new Padding(3, 2, 3, 2);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(219, 23);
            cboLoaiViPham.TabIndex = 9;
            // 
            // lblLoaiViPham
            // 
            lblLoaiViPham.AutoSize = true;
            lblLoaiViPham.Font = new Font("Segoe UI", 9F);
            lblLoaiViPham.Location = new Point(18, 71);
            lblLoaiViPham.Name = "lblLoaiViPham";
            lblLoaiViPham.Size = new Size(94, 15);
            lblLoaiViPham.TabIndex = 8;
            lblLoaiViPham.Text = "Loại vi phạm (*):";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Font = new Font("Segoe UI", 9F);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(648, 41);
            dtpNgayLap.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(215, 23);
            dtpNgayLap.TabIndex = 7;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 9F);
            lblNgayLap.Location = new Point(648, 24);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(57, 15);
            lblNgayLap.TabIndex = 6;
            lblNgayLap.Text = "Ngày lập:";
            // 
            // txtCanBoLap
            // 
            txtCanBoLap.BackColor = Color.FromArgb(241, 245, 249);
            txtCanBoLap.Font = new Font("Segoe UI", 9F);
            txtCanBoLap.Location = new Point(438, 41);
            txtCanBoLap.Margin = new Padding(3, 2, 3, 2);
            txtCanBoLap.Name = "txtCanBoLap";
            txtCanBoLap.ReadOnly = true;
            txtCanBoLap.Size = new Size(193, 23);
            txtCanBoLap.TabIndex = 5;
            // 
            // lblCanBoLap
            // 
            lblCanBoLap.AutoSize = true;
            lblCanBoLap.Font = new Font("Segoe UI", 9F);
            lblCanBoLap.Location = new Point(438, 24);
            lblCanBoLap.Name = "lblCanBoLap";
            lblCanBoLap.Size = new Size(67, 15);
            lblCanBoLap.TabIndex = 4;
            lblCanBoLap.Text = "Cán bộ lập:";
            // 
            // cboDocGia
            // 
            cboDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocGia.Font = new Font("Segoe UI", 9F);
            cboDocGia.FormattingEnabled = true;
            cboDocGia.Location = new Point(184, 41);
            cboDocGia.Margin = new Padding(3, 2, 3, 2);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(237, 23);
            cboDocGia.TabIndex = 3;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Segoe UI", 9F);
            lblDocGia.Location = new Point(184, 24);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(112, 15);
            lblDocGia.TabIndex = 2;
            lblDocGia.Text = "Độc giả vi phạm (*):";
            // 
            // txtMaBienBan
            // 
            txtMaBienBan.BackColor = Color.FromArgb(241, 245, 249);
            txtMaBienBan.Font = new Font("Segoe UI", 9F);
            txtMaBienBan.Location = new Point(18, 41);
            txtMaBienBan.Margin = new Padding(3, 2, 3, 2);
            txtMaBienBan.Name = "txtMaBienBan";
            txtMaBienBan.ReadOnly = true;
            txtMaBienBan.Size = new Size(149, 23);
            txtMaBienBan.TabIndex = 1;
            txtMaBienBan.Text = "Tự động sinh";
            // 
            // lblMaBienBan
            // 
            lblMaBienBan.AutoSize = true;
            lblMaBienBan.Font = new Font("Segoe UI", 9F);
            lblMaBienBan.Location = new Point(18, 24);
            lblMaBienBan.Name = "lblMaBienBan";
            lblMaBienBan.Size = new Size(76, 15);
            lblMaBienBan.TabIndex = 0;
            lblMaBienBan.Text = "Mã biên bản:";
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDanhSach.ForeColor = Color.FromArgb(19, 78, 74);
            lblDanhSach.Location = new Point(24, 251);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(345, 20);
            lblDanhSach.TabIndex = 3;
            lblDanhSach.Text = "DANH SÁCH BIÊN BẢN VI PHẠM ĐÃ THIẾT LẬP";
            // 
            // dgvBienBanViPham
            // 
            dgvBienBanViPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBienBanViPham.BackgroundColor = Color.White;
            dgvBienBanViPham.BorderStyle = BorderStyle.None;
            dgvBienBanViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBienBanViPham.Location = new Point(24, 274);
            dgvBienBanViPham.Margin = new Padding(3, 2, 3, 2);
            dgvBienBanViPham.Name = "dgvBienBanViPham";
            dgvBienBanViPham.RowHeadersWidth = 51;
            dgvBienBanViPham.Size = new Size(879, 218);
            dgvBienBanViPham.TabIndex = 4;
            // 
            // FormLapBienBanViPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(928, 510);
            Controls.Add(dgvBienBanViPham);
            Controls.Add(lblDanhSach);
            Controls.Add(grpThongTin);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLapBienBanViPham";
            Text = "Lập Biên Bản Vi Phạm";
            Load += FormLapBienBanViPham_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBienBanViPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private GroupBox grpThongTin;
        private Label lblMaBienBan;
        private TextBox txtMaBienBan;
        private Label lblDocGia;
        private ComboBox cboDocGia;
        private Label lblCanBoLap;
        private TextBox txtCanBoLap;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private Label lblLoaiViPham;
        private ComboBox cboLoaiViPham;
        private Label lblSoTienPhat;
        private TextBox txtSoTienPhat;
        private Label lblNgayHenNop;
        private DateTimePicker dtpNgayHenNop;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Button btnLuuBienBan;
        private Button btnLamMoi;
        private Button btnHuyBo;
        private Label lblDanhSach;
        private DataGridView dgvBienBanViPham;
    }
}