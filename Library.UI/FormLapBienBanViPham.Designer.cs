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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            grpThongTin = new GroupBox();
            btnThuTienPhat = new Button();
            btnHuyBo = new Button();
            btnLamMoi = new Button();
            btnLuuBienBan = new Button();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            dtpNgayHenNop = new DateTimePicker();
            lblNgayHenNop = new Label();
            txtSoTienPhat = new TextBox();
            lblSoTienPhat = new Label();
            cboSachViPham = new ComboBox();
            lblSachViPham = new Label();
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
            colMaBienBan = new DataGridViewTextBoxColumn();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colTenDocGia = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colLyDoViPham = new DataGridViewTextBoxColumn();
            colSoTienPhat = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colCanBoLap = new DataGridViewTextBoxColumn();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBienBanViPham).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(19, 78, 74);
            lblTieuDe.Location = new Point(22, 10);
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
            lblPhuDe.Location = new Point(24, 38);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(575, 17);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Tự động tính toán bồi thường theo % giá bìa tài liệu, tiền phạt quá hạn và thu nộp ngân quỹ tại quầy";
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(btnThuTienPhat);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnLuuBienBan);
            grpThongTin.Controls.Add(txtMoTa);
            grpThongTin.Controls.Add(lblMoTa);
            grpThongTin.Controls.Add(dtpNgayHenNop);
            grpThongTin.Controls.Add(lblNgayHenNop);
            grpThongTin.Controls.Add(txtSoTienPhat);
            grpThongTin.Controls.Add(lblSoTienPhat);
            grpThongTin.Controls.Add(cboSachViPham);
            grpThongTin.Controls.Add(lblSachViPham);
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
            grpThongTin.Location = new Point(24, 62);
            grpThongTin.Margin = new Padding(3, 2, 3, 2);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 2, 3, 2);
            grpThongTin.Size = new Size(950, 195);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = " Thiết lập biên bản xử lý & Định mức đền bù ";
            // 
            // btnThuTienPhat
            // 
            btnThuTienPhat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThuTienPhat.BackColor = Color.FromArgb(22, 101, 52);
            btnThuTienPhat.Cursor = Cursors.Hand;
            btnThuTienPhat.FlatAppearance.BorderSize = 0;
            btnThuTienPhat.FlatStyle = FlatStyle.Flat;
            btnThuTienPhat.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnThuTienPhat.ForeColor = Color.White;
            btnThuTienPhat.Location = new Point(765, 145);
            btnThuTienPhat.Name = "btnThuTienPhat";
            btnThuTienPhat.Size = new Size(165, 38);
            btnThuTienPhat.TabIndex = 21;
            btnThuTienPhat.Text = "💵 THU TIỀN PHẠT";
            btnThuTienPhat.UseVisualStyleBackColor = false;
            btnThuTienPhat.Click += btnThuTienPhat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(254, 242, 242);
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(185, 28, 28);
            btnHuyBo.Location = new Point(310, 145);
            btnHuyBo.Margin = new Padding(3, 2, 3, 2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(95, 38);
            btnHuyBo.TabIndex = 20;
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
            btnLamMoi.Location = new Point(200, 145);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 38);
            btnLamMoi.TabIndex = 19;
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
            btnLuuBienBan.Location = new Point(20, 145);
            btnLuuBienBan.Margin = new Padding(3, 2, 3, 2);
            btnLuuBienBan.Name = "btnLuuBienBan";
            btnLuuBienBan.Size = new Size(170, 38);
            btnLuuBienBan.TabIndex = 18;
            btnLuuBienBan.Text = "💾 LƯU BIÊN BẢN";
            btnLuuBienBan.UseVisualStyleBackColor = false;
            btnLuuBienBan.Click += btnLuuBienBan_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMoTa.Font = new Font("Segoe UI", 9F);
            txtMoTa.Location = new Point(605, 92);
            txtMoTa.Margin = new Padding(3, 2, 3, 2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(325, 42);
            txtMoTa.TabIndex = 17;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 9F);
            lblMoTa.Location = new Point(605, 72);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(126, 15);
            lblMoTa.TabIndex = 16;
            lblMoTa.Text = "Mô tả chi tiết vi phạm:";
            // 
            // dtpNgayHenNop
            // 
            dtpNgayHenNop.CustomFormat = "dd/MM/yyyy";
            dtpNgayHenNop.Font = new Font("Segoe UI", 9F);
            dtpNgayHenNop.Format = DateTimePickerFormat.Custom;
            dtpNgayHenNop.Location = new Point(450, 92);
            dtpNgayHenNop.Margin = new Padding(3, 2, 3, 2);
            dtpNgayHenNop.Name = "dtpNgayHenNop";
            dtpNgayHenNop.Size = new Size(140, 23);
            dtpNgayHenNop.TabIndex = 15;
            // 
            // lblNgayHenNop
            // 
            lblNgayHenNop.AutoSize = true;
            lblNgayHenNop.Font = new Font("Segoe UI", 9F);
            lblNgayHenNop.Location = new Point(450, 72);
            lblNgayHenNop.Name = "lblNgayHenNop";
            lblNgayHenNop.Size = new Size(106, 15);
            lblNgayHenNop.TabIndex = 14;
            lblNgayHenNop.Text = "Hạn nộp tiền phạt:";
            // 
            // txtSoTienPhat
            // 
            txtSoTienPhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSoTienPhat.ForeColor = Color.FromArgb(185, 28, 28);
            txtSoTienPhat.Location = new Point(295, 92);
            txtSoTienPhat.Margin = new Padding(3, 2, 3, 2);
            txtSoTienPhat.Name = "txtSoTienPhat";
            txtSoTienPhat.Size = new Size(140, 25);
            txtSoTienPhat.TabIndex = 13;
            txtSoTienPhat.Text = "0";
            // 
            // lblSoTienPhat
            // 
            lblSoTienPhat.AutoSize = true;
            lblSoTienPhat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoTienPhat.ForeColor = Color.FromArgb(185, 28, 28);
            lblSoTienPhat.Location = new Point(295, 72);
            lblSoTienPhat.Name = "lblSoTienPhat";
            lblSoTienPhat.Size = new Size(111, 15);
            lblSoTienPhat.TabIndex = 12;
            lblSoTienPhat.Text = "Tiền phạt tự tính (đ):";
            // 
            // cboSachViPham
            // 
            cboSachViPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSachViPham.Font = new Font("Segoe UI", 9F);
            cboSachViPham.FormattingEnabled = true;
            cboSachViPham.Location = new Point(400, 42);
            cboSachViPham.Name = "cboSachViPham";
            cboSachViPham.Size = new Size(275, 23);
            cboSachViPham.TabIndex = 11;
            cboSachViPham.SelectedIndexChanged += cboSachViPham_SelectedIndexChanged;
            // 
            // lblSachViPham
            // 
            lblSachViPham.AutoSize = true;
            lblSachViPham.Font = new Font("Segoe UI", 9F);
            lblSachViPham.Location = new Point(400, 22);
            lblSachViPham.Name = "lblSachViPham";
            lblSachViPham.Size = new Size(119, 15);
            lblSachViPham.TabIndex = 10;
            lblSachViPham.Text = "Tài liệu vi phạm (*):";
            // 
            // cboLoaiViPham
            // 
            cboLoaiViPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiViPham.Font = new Font("Segoe UI", 9F);
            cboLoaiViPham.FormattingEnabled = true;
            cboLoaiViPham.Location = new Point(20, 92);
            cboLoaiViPham.Margin = new Padding(3, 2, 3, 2);
            cboLoaiViPham.Name = "cboLoaiViPham";
            cboLoaiViPham.Size = new Size(260, 23);
            cboLoaiViPham.TabIndex = 9;
            cboLoaiViPham.SelectedIndexChanged += cboLoaiViPham_SelectedIndexChanged;
            // 
            // lblLoaiViPham
            // 
            lblLoaiViPham.AutoSize = true;
            lblLoaiViPham.Font = new Font("Segoe UI", 9F);
            lblLoaiViPham.Location = new Point(20, 72);
            lblLoaiViPham.Name = "lblLoaiViPham";
            lblLoaiViPham.Size = new Size(94, 15);
            lblLoaiViPham.TabIndex = 8;
            lblLoaiViPham.Text = "Loại vi phạm (*):";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Enabled = false;
            dtpNgayLap.Font = new Font("Segoe UI", 9F);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(825, 42);
            dtpNgayLap.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(105, 23);
            dtpNgayLap.TabIndex = 7;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 9F);
            lblNgayLap.Location = new Point(825, 22);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(57, 15);
            lblNgayLap.TabIndex = 6;
            lblNgayLap.Text = "Ngày lập:";
            // 
            // txtCanBoLap
            // 
            txtCanBoLap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCanBoLap.BackColor = Color.FromArgb(241, 245, 249);
            txtCanBoLap.Font = new Font("Segoe UI", 9F);
            txtCanBoLap.Location = new Point(690, 42);
            txtCanBoLap.Margin = new Padding(3, 2, 3, 2);
            txtCanBoLap.Name = "txtCanBoLap";
            txtCanBoLap.ReadOnly = true;
            txtCanBoLap.Size = new Size(120, 23);
            txtCanBoLap.TabIndex = 5;
            // 
            // lblCanBoLap
            // 
            lblCanBoLap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCanBoLap.AutoSize = true;
            lblCanBoLap.Font = new Font("Segoe UI", 9F);
            lblCanBoLap.Location = new Point(690, 22);
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
            cboDocGia.Location = new Point(155, 42);
            cboDocGia.Margin = new Padding(3, 2, 3, 2);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(230, 23);
            cboDocGia.TabIndex = 3;
            cboDocGia.SelectedIndexChanged += cboDocGia_SelectedIndexChanged;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Segoe UI", 9F);
            lblDocGia.Location = new Point(155, 22);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(112, 15);
            lblDocGia.TabIndex = 2;
            lblDocGia.Text = "Độc giả vi phạm (*):";
            // 
            // txtMaBienBan
            // 
            txtMaBienBan.BackColor = Color.FromArgb(241, 245, 249);
            txtMaBienBan.Font = new Font("Segoe UI", 9F);
            txtMaBienBan.Location = new Point(20, 42);
            txtMaBienBan.Margin = new Padding(3, 2, 3, 2);
            txtMaBienBan.Name = "txtMaBienBan";
            txtMaBienBan.ReadOnly = true;
            txtMaBienBan.Size = new Size(120, 23);
            txtMaBienBan.TabIndex = 1;
            txtMaBienBan.Text = "Tự động sinh";
            // 
            // lblMaBienBan
            // 
            lblMaBienBan.AutoSize = true;
            lblMaBienBan.Font = new Font("Segoe UI", 9F);
            lblMaBienBan.Location = new Point(20, 22);
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
            lblDanhSach.Location = new Point(24, 270);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(345, 20);
            lblDanhSach.TabIndex = 3;
            lblDanhSach.Text = "DANH SÁCH BIÊN BẢN VI PHẠM ĐÃ THIẾT LẬP";
            // 
            // dgvBienBanViPham
            // 
            dgvBienBanViPham.AllowUserToAddRows = false;
            dgvBienBanViPham.AllowUserToDeleteRows = false;
            dgvBienBanViPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBienBanViPham.BackgroundColor = Color.White;
            dgvBienBanViPham.BorderStyle = BorderStyle.None;
            dgvBienBanViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBienBanViPham.Columns.AddRange(new DataGridViewColumn[] { colMaBienBan, colMaDocGia, colTenDocGia, colTenSach, colLyDoViPham, colSoTienPhat, colNgayLap, colTrangThai, colCanBoLap });
            dgvBienBanViPham.Location = new Point(24, 295);
            dgvBienBanViPham.Margin = new Padding(3, 2, 3, 2);
            dgvBienBanViPham.Name = "dgvBienBanViPham";
            dgvBienBanViPham.ReadOnly = true;
            dgvBienBanViPham.RowHeadersVisible = false;
            dgvBienBanViPham.RowHeadersWidth = 51;
            dgvBienBanViPham.Size = new Size(950, 320);
            dgvBienBanViPham.TabIndex = 4;
            dgvBienBanViPham.CellFormatting += dgvBienBanViPham_CellFormatting;
            // 
            // colMaBienBan
            // 
            colMaBienBan.DataPropertyName = "MaBienBan";
            colMaBienBan.FillWeight = 50F;
            colMaBienBan.HeaderText = "Mã BB";
            colMaBienBan.Name = "colMaBienBan";
            colMaBienBan.ReadOnly = true;
            colMaBienBan.Width = 65;
            // 
            // colMaDocGia
            // 
            colMaDocGia.DataPropertyName = "MaDocGia";
            colMaDocGia.FillWeight = 65F;
            colMaDocGia.HeaderText = "Mã ĐG";
            colMaDocGia.Name = "colMaDocGia";
            colMaDocGia.ReadOnly = true;
            colMaDocGia.Width = 80;
            // 
            // colTenDocGia
            // 
            colTenDocGia.DataPropertyName = "TenDocGia";
            colTenDocGia.FillWeight = 110F;
            colTenDocGia.HeaderText = "Tên Độc Giả";
            colTenDocGia.Name = "colTenDocGia";
            colTenDocGia.ReadOnly = true;
            colTenDocGia.Width = 135;
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.FillWeight = 130F;
            colTenSach.HeaderText = "Tài Liệu Vi Phạm";
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            colTenSach.Width = 160;
            // 
            // colLyDoViPham
            // 
            colLyDoViPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLyDoViPham.DataPropertyName = "LyDoViPham";
            colLyDoViPham.FillWeight = 170F;
            colLyDoViPham.HeaderText = "Lý Do / Chi Tiết Vi Phạm";
            colLyDoViPham.Name = "colLyDoViPham";
            colLyDoViPham.ReadOnly = true;
            // 
            // colSoTienPhat
            // 
            colSoTienPhat.DataPropertyName = "SoTienPhat";
            colSoTienPhat.FillWeight = 85F;
            colSoTienPhat.HeaderText = "Tiền Phạt (đ)";
            colSoTienPhat.Name = "colSoTienPhat";
            colSoTienPhat.ReadOnly = true;
            colSoTienPhat.Width = 105;
            // 
            // colNgayLap
            // 
            colNgayLap.DataPropertyName = "NgayLap";
            colNgayLap.FillWeight = 95F;
            colNgayLap.HeaderText = "Ngày Lập";
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            colNgayLap.Width = 120;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 75F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 90;
            // 
            // colCanBoLap
            // 
            colCanBoLap.DataPropertyName = "CanBoLap";
            colCanBoLap.FillWeight = 90F;
            colCanBoLap.HeaderText = "Cán Bộ Lập";
            colCanBoLap.Name = "colCanBoLap";
            colCanBoLap.ReadOnly = true;
            colCanBoLap.Width = 110;
            // 
            // FormLapBienBanViPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1000, 630);
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
        private Label lblSachViPham;
        private ComboBox cboSachViPham;
        private Button btnThuTienPhat;
        private DataGridViewTextBoxColumn colMaBienBan;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colTenDocGia;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colLyDoViPham;
        private DataGridViewTextBoxColumn colSoTienPhat;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colCanBoLap;
    }
}