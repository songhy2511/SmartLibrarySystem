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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnThuTienPhat = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuBienBan = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.dtpNgayHenNop = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHenNop = new System.Windows.Forms.Label();
            this.txtSoTienPhat = new System.Windows.Forms.TextBox();
            this.lblSoTienPhat = new System.Windows.Forms.Label();
            this.nudSoNgayTre = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.cboSachViPham = new System.Windows.Forms.ComboBox();
            this.lblSachViPham = new System.Windows.Forms.Label();
            this.cboLoaiViPham = new System.Windows.Forms.ComboBox();
            this.lblLoaiViPham = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtCanBoLap = new System.Windows.Forms.TextBox();
            this.lblCanBoLap = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.txtMaBienBan = new System.Windows.Forms.TextBox();
            this.lblMaBienBan = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvBienBanViPham = new System.Windows.Forms.DataGridView();
            this.colMaBienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDoViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanBoLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayTre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            this.lblTieuDe.Location = new System.Drawing.Point(22, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(262, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LẬP BIÊN BẢN VI PHẠM";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhuDe.Location = new System.Drawing.Point(24, 38);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(575, 17);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Tự động tính toán bồi thường theo % giá bìa tài liệu, tiền phạt quá hạn và thu nộp ngân quỹ tại quầy";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.btnThuTienPhat);
            this.grpThongTin.Controls.Add(this.btnHuyBo);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnLuuBienBan);
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.dtpNgayHenNop);
            this.grpThongTin.Controls.Add(this.lblNgayHenNop);
            this.grpThongTin.Controls.Add(this.txtSoTienPhat);
            this.grpThongTin.Controls.Add(this.lblSoTienPhat);
            this.grpThongTin.Controls.Add(this.nudSoNgayTre);
            this.grpThongTin.Controls.Add(this.lblSoNgayTre);
            this.grpThongTin.Controls.Add(this.cboSachViPham);
            this.grpThongTin.Controls.Add(this.lblSachViPham);
            this.grpThongTin.Controls.Add(this.cboLoaiViPham);
            this.grpThongTin.Controls.Add(this.lblLoaiViPham);
            this.grpThongTin.Controls.Add(this.dtpNgayLap);
            this.grpThongTin.Controls.Add(this.lblNgayLap);
            this.grpThongTin.Controls.Add(this.txtCanBoLap);
            this.grpThongTin.Controls.Add(this.lblCanBoLap);
            this.grpThongTin.Controls.Add(this.cboDocGia);
            this.grpThongTin.Controls.Add(this.lblDocGia);
            this.grpThongTin.Controls.Add(this.txtMaBienBan);
            this.grpThongTin.Controls.Add(this.lblMaBienBan);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpThongTin.Location = new System.Drawing.Point(24, 62);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Size = new System.Drawing.Size(950, 195);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = " Thiết lập biên bản xử lý & Định mức đền bù ";
            // 
            // btnThuTienPhat
            // 
            this.btnThuTienPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuTienPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btnThuTienPhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuTienPhat.FlatAppearance.BorderSize = 0;
            this.btnThuTienPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThuTienPhat.ForeColor = System.Drawing.Color.White;
            this.btnThuTienPhat.Location = new System.Drawing.Point(765, 145);
            this.btnThuTienPhat.Name = "btnThuTienPhat";
            this.btnThuTienPhat.Size = new System.Drawing.Size(165, 38);
            this.btnThuTienPhat.TabIndex = 23;
            this.btnThuTienPhat.Text = "💵 THU TIỀN PHẠT";
            this.btnThuTienPhat.UseVisualStyleBackColor = false;
            this.btnThuTienPhat.Click += new System.EventHandler(this.btnThuTienPhat_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHuyBo.Location = new System.Drawing.Point(310, 145);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(95, 38);
            this.btnHuyBo.TabIndex = 22;
            this.btnHuyBo.Text = "❌ HỦY BỎ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnLamMoi.Location = new System.Drawing.Point(200, 145);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 38);
            this.btnLamMoi.TabIndex = 21;
            this.btnLamMoi.Text = "🔄 LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuBienBan
            // 
            this.btnLuuBienBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnLuuBienBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuBienBan.FlatAppearance.BorderSize = 0;
            this.btnLuuBienBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuBienBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuBienBan.ForeColor = System.Drawing.Color.White;
            this.btnLuuBienBan.Location = new System.Drawing.Point(20, 145);
            this.btnLuuBienBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuBienBan.Name = "btnLuuBienBan";
            this.btnLuuBienBan.Size = new System.Drawing.Size(170, 38);
            this.btnLuuBienBan.TabIndex = 20;
            this.btnLuuBienBan.Text = "💾 LƯU BIÊN BẢN";
            this.btnLuuBienBan.UseVisualStyleBackColor = false;
            this.btnLuuBienBan.Click += new System.EventHandler(this.btnLuuBienBan_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(620, 92);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(310, 42);
            this.txtMoTa.TabIndex = 19;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.Location = new System.Drawing.Point(620, 72);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(126, 15);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô tả chi tiết vi phạm:";
            // 
            // dtpNgayHenNop
            // 
            this.dtpNgayHenNop.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHenNop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHenNop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHenNop.Location = new System.Drawing.Point(490, 92);
            this.dtpNgayHenNop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayHenNop.Name = "dtpNgayHenNop";
            this.dtpNgayHenNop.Size = new System.Drawing.Size(120, 23);
            this.dtpNgayHenNop.TabIndex = 17;
            // 
            // lblNgayHenNop
            // 
            this.lblNgayHenNop.AutoSize = true;
            this.lblNgayHenNop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayHenNop.Location = new System.Drawing.Point(490, 72);
            this.lblNgayHenNop.Name = "lblNgayHenNop";
            this.lblNgayHenNop.Size = new System.Drawing.Size(106, 15);
            this.lblNgayHenNop.TabIndex = 16;
            this.lblNgayHenNop.Text = "Hạn nộp tiền phạt:";
            // 
            // txtSoTienPhat
            // 
            this.txtSoTienPhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoTienPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSoTienPhat.Location = new System.Drawing.Point(355, 92);
            this.txtSoTienPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienPhat.Name = "txtSoTienPhat";
            this.txtSoTienPhat.Size = new System.Drawing.Size(125, 25);
            this.txtSoTienPhat.TabIndex = 15;
            this.txtSoTienPhat.Text = "0";
            // 
            // lblSoTienPhat
            // 
            this.lblSoTienPhat.AutoSize = true;
            this.lblSoTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoTienPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblSoTienPhat.Location = new System.Drawing.Point(355, 72);
            this.lblSoTienPhat.Name = "lblSoTienPhat";
            this.lblSoTienPhat.Size = new System.Drawing.Size(111, 15);
            this.lblSoTienPhat.TabIndex = 14;
            this.lblSoTienPhat.Text = "Tiền phạt tự tính (đ):";
            // 
            // nudSoNgayTre
            // 
            this.nudSoNgayTre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.nudSoNgayTre.Location = new System.Drawing.Point(260, 92);
            this.nudSoNgayTre.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.nudSoNgayTre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoNgayTre.Name = "nudSoNgayTre";
            this.nudSoNgayTre.Size = new System.Drawing.Size(85, 24);
            this.nudSoNgayTre.TabIndex = 13;
            this.nudSoNgayTre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoNgayTre.ValueChanged += new System.EventHandler(this.nudSoNgayTre_ValueChanged);
            // 
            // lblSoNgayTre
            // 
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoNgayTre.Location = new System.Drawing.Point(260, 72);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(71, 15);
            this.lblSoNgayTre.TabIndex = 12;
            this.lblSoNgayTre.Text = "Số ngày trễ:";
            // 
            // cboSachViPham
            // 
            this.cboSachViPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSachViPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboSachViPham.FormattingEnabled = true;
            this.cboSachViPham.Location = new System.Drawing.Point(400, 42);
            this.cboSachViPham.Name = "cboSachViPham";
            this.cboSachViPham.Size = new System.Drawing.Size(275, 23);
            this.cboSachViPham.TabIndex = 11;
            this.cboSachViPham.SelectedIndexChanged += new System.EventHandler(this.cboSachViPham_SelectedIndexChanged);
            // 
            // lblSachViPham
            // 
            this.lblSachViPham.AutoSize = true;
            this.lblSachViPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSachViPham.Location = new System.Drawing.Point(400, 22);
            this.lblSachViPham.Name = "lblSachViPham";
            this.lblSachViPham.Size = new System.Drawing.Size(119, 15);
            this.lblSachViPham.TabIndex = 10;
            this.lblSachViPham.Text = "Tài liệu vi phạm (*):";
            // 
            // cboLoaiViPham
            // 
            this.cboLoaiViPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiViPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiViPham.FormattingEnabled = true;
            this.cboLoaiViPham.Location = new System.Drawing.Point(20, 92);
            this.cboLoaiViPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiViPham.Name = "cboLoaiViPham";
            this.cboLoaiViPham.Size = new System.Drawing.Size(230, 23);
            this.cboLoaiViPham.TabIndex = 9;
            this.cboLoaiViPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiViPham_SelectedIndexChanged);
            // 
            // lblLoaiViPham
            // 
            this.lblLoaiViPham.AutoSize = true;
            this.lblLoaiViPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiViPham.Location = new System.Drawing.Point(20, 72);
            this.lblLoaiViPham.Name = "lblLoaiViPham";
            this.lblLoaiViPham.Size = new System.Drawing.Size(94, 15);
            this.lblLoaiViPham.TabIndex = 8;
            this.lblLoaiViPham.Text = "Loại vi phạm (*):";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(825, 42);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(105, 23);
            this.dtpNgayLap.TabIndex = 7;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayLap.Location = new System.Drawing.Point(825, 22);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(57, 15);
            this.lblNgayLap.TabIndex = 6;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // txtCanBoLap
            // 
            this.txtCanBoLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCanBoLap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtCanBoLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCanBoLap.Location = new System.Drawing.Point(690, 42);
            this.txtCanBoLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCanBoLap.Name = "txtCanBoLap";
            this.txtCanBoLap.ReadOnly = true;
            this.txtCanBoLap.Size = new System.Drawing.Size(120, 23);
            this.txtCanBoLap.TabIndex = 5;
            // 
            // lblCanBoLap
            // 
            this.lblCanBoLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanBoLap.AutoSize = true;
            this.lblCanBoLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCanBoLap.Location = new System.Drawing.Point(690, 22);
            this.lblCanBoLap.Name = "lblCanBoLap";
            this.lblCanBoLap.Size = new System.Drawing.Size(67, 15);
            this.lblCanBoLap.TabIndex = 4;
            this.lblCanBoLap.Text = "Cán bộ lập:";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(155, 42);
            this.cboDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(230, 23);
            this.cboDocGia.TabIndex = 3;
            this.cboDocGia.SelectedIndexChanged += new System.EventHandler(this.cboDocGia_SelectedIndexChanged);
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDocGia.Location = new System.Drawing.Point(155, 22);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(112, 15);
            this.lblDocGia.TabIndex = 2;
            this.lblDocGia.Text = "Độc giả vi phạm (*):";
            // 
            // txtMaBienBan
            // 
            this.txtMaBienBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtMaBienBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaBienBan.Location = new System.Drawing.Point(20, 42);
            this.txtMaBienBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBienBan.Name = "txtMaBienBan";
            this.txtMaBienBan.ReadOnly = true;
            this.txtMaBienBan.Size = new System.Drawing.Size(120, 23);
            this.txtMaBienBan.TabIndex = 1;
            this.txtMaBienBan.Text = "Tự động sinh";
            // 
            // lblMaBienBan
            // 
            this.lblMaBienBan.AutoSize = true;
            this.lblMaBienBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaBienBan.Location = new System.Drawing.Point(20, 22);
            this.lblMaBienBan.Name = "lblMaBienBan";
            this.lblMaBienBan.Size = new System.Drawing.Size(76, 15);
            this.lblMaBienBan.TabIndex = 0;
            this.lblMaBienBan.Text = "Mã biên bản:";
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            this.lblDanhSach.Location = new System.Drawing.Point(24, 270);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(345, 20);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "DANH SÁCH BIÊN BẢN VI PHẠM ĐÃ THIẾT LẬP";
            // 
            // dgvBienBanViPham
            // 
            this.dgvBienBanViPham.AllowUserToAddRows = false;
            this.dgvBienBanViPham.AllowUserToDeleteRows = false;
            this.dgvBienBanViPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBienBanViPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvBienBanViPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBienBanViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienBanViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBienBan,
            this.colMaDocGia,
            this.colTenDocGia,
            this.colTenSach,
            this.colLyDoViPham,
            this.colSoTienPhat,
            this.colNgayLap,
            this.colTrangThai,
            this.colCanBoLap});
            this.dgvBienBanViPham.Location = new System.Drawing.Point(24, 295);
            this.dgvBienBanViPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBienBanViPham.Name = "dgvBienBanViPham";
            this.dgvBienBanViPham.ReadOnly = true;
            this.dgvBienBanViPham.RowHeadersVisible = false;
            this.dgvBienBanViPham.RowHeadersWidth = 51;
            this.dgvBienBanViPham.Size = new System.Drawing.Size(950, 320);
            this.dgvBienBanViPham.TabIndex = 4;
            this.dgvBienBanViPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBienBanViPham_CellFormatting);
            // 
            // colMaBienBan
            // 
            this.colMaBienBan.DataPropertyName = "MaBienBan";
            this.colMaBienBan.FillWeight = 50F;
            this.colMaBienBan.HeaderText = "Mã BB";
            this.colMaBienBan.Name = "colMaBienBan";
            this.colMaBienBan.ReadOnly = true;
            this.colMaBienBan.Width = 65;
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.DataPropertyName = "MaDocGia";
            this.colMaDocGia.FillWeight = 65F;
            this.colMaDocGia.HeaderText = "Mã ĐG";
            this.colMaDocGia.Name = "colMaDocGia";
            this.colMaDocGia.ReadOnly = true;
            this.colMaDocGia.Width = 80;
            // 
            // colTenDocGia
            // 
            this.colTenDocGia.DataPropertyName = "TenDocGia";
            this.colTenDocGia.FillWeight = 110F;
            this.colTenDocGia.HeaderText = "Tên Độc Giả";
            this.colTenDocGia.Name = "colTenDocGia";
            this.colTenDocGia.ReadOnly = true;
            this.colTenDocGia.Width = 135;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.FillWeight = 130F;
            this.colTenSach.HeaderText = "Tài Liệu Vi Phạm";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            this.colTenSach.Width = 160;
            // 
            // colLyDoViPham
            // 
            this.colLyDoViPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLyDoViPham.DataPropertyName = "LyDoViPham";
            this.colLyDoViPham.FillWeight = 170F;
            this.colLyDoViPham.HeaderText = "Lý Do / Chi Tiết Vi Phạm";
            this.colLyDoViPham.Name = "colLyDoViPham";
            this.colLyDoViPham.ReadOnly = true;
            // 
            // colSoTienPhat
            // 
            this.colSoTienPhat.DataPropertyName = "SoTienPhat";
            this.colSoTienPhat.FillWeight = 85F;
            this.colSoTienPhat.HeaderText = "Tiền Phạt (đ)";
            this.colSoTienPhat.Name = "colSoTienPhat";
            this.colSoTienPhat.ReadOnly = true;
            this.colSoTienPhat.Width = 105;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.FillWeight = 95F;
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Width = 120;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 75F;
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 90;
            // 
            // colCanBoLap
            // 
            this.colCanBoLap.DataPropertyName = "CanBoLap";
            this.colCanBoLap.FillWeight = 90F;
            this.colCanBoLap.HeaderText = "Cán Bộ Lập";
            this.colCanBoLap.Name = "colCanBoLap";
            this.colCanBoLap.ReadOnly = true;
            this.colCanBoLap.Width = 110;
            // 
            // FormLapBienBanViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.dgvBienBanViPham);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblPhuDe);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLapBienBanViPham";
            this.Text = "Lập Biên Bản Vi Phạm";
            this.Load += new System.EventHandler(this.FormLapBienBanViPham_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayTre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienBanViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaBienBan;
        private System.Windows.Forms.TextBox txtMaBienBan;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblCanBoLap;
        private System.Windows.Forms.TextBox txtCanBoLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblLoaiViPham;
        private System.Windows.Forms.ComboBox cboLoaiViPham;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.NumericUpDown nudSoNgayTre;
        private System.Windows.Forms.Label lblSoTienPhat;
        private System.Windows.Forms.TextBox txtSoTienPhat;
        private System.Windows.Forms.Label lblNgayHenNop;
        private System.Windows.Forms.DateTimePicker dtpNgayHenNop;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnLuuBienBan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvBienBanViPham;
        private System.Windows.Forms.Label lblSachViPham;
        private System.Windows.Forms.ComboBox cboSachViPham;
        private System.Windows.Forms.Button btnThuTienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDoViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanBoLap;
    }
}