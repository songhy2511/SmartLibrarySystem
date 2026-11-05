namespace Library.UI
{
    partial class FormPhanCaTruc
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubTitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlInput = new System.Windows.Forms.Panel();
            btnXoaCa = new System.Windows.Forms.Button();
            btnLuuCa = new System.Windows.Forms.Button();
            txtGhiChu = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            nudTienDauCa = new System.Windows.Forms.NumericUpDown();
            lblTienDauCa = new System.Windows.Forms.Label();
            dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            lblGioKetThuc = new System.Windows.Forms.Label();
            dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            lblGioBatDau = new System.Windows.Forms.Label();
            cboTenCa = new System.Windows.Forms.ComboBox();
            lblTenCa = new System.Windows.Forms.Label();
            cboThuThu = new System.Windows.Forms.ComboBox();
            lblThuThu = new System.Windows.Forms.Label();
            cboChiNhanh = new System.Windows.Forms.ComboBox();
            lblChiNhanh = new System.Windows.Forms.Label();
            dtpNgayTruc = new System.Windows.Forms.DateTimePicker();
            lblNgayTruc = new System.Windows.Forms.Label();
            pnlMain = new System.Windows.Forms.Panel();
            dgvCaTruc = new System.Windows.Forms.DataGridView();
            colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNgayTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGioTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMaThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTienDauCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlFilter = new System.Windows.Forms.Panel();
            btnLamMoi = new System.Windows.Forms.Button();
            btnLoc = new System.Windows.Forms.Button();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            lblDenNgay = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblTuNgay = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTienDauCa).BeginInit();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCaTruc).BeginInit();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            pnlHeader.Size = new System.Drawing.Size(1000, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(25, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(515, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Lập lịch phân ca làm việc đa chi nhánh, định mức giờ trực và số dư tiền mặt bàn giao đầu ca";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(342, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHÂN CHIA CA LÀM VIỆC THEO CHI NHÁNH";
            // 
            // pnlInput
            // 
            pnlInput.BackColor = System.Drawing.Color.White;
            pnlInput.Controls.Add(btnXoaCa);
            pnlInput.Controls.Add(btnLuuCa);
            pnlInput.Controls.Add(txtGhiChu);
            pnlInput.Controls.Add(lblGhiChu);
            pnlInput.Controls.Add(nudTienDauCa);
            pnlInput.Controls.Add(lblTienDauCa);
            pnlInput.Controls.Add(dtpGioKetThuc);
            pnlInput.Controls.Add(lblGioKetThuc);
            pnlInput.Controls.Add(dtpGioBatDau);
            pnlInput.Controls.Add(lblGioBatDau);
            pnlInput.Controls.Add(cboTenCa);
            pnlInput.Controls.Add(lblTenCa);
            pnlInput.Controls.Add(cboThuThu);
            pnlInput.Controls.Add(lblThuThu);
            pnlInput.Controls.Add(cboChiNhanh);
            pnlInput.Controls.Add(lblChiNhanh);
            pnlInput.Controls.Add(dtpNgayTruc);
            pnlInput.Controls.Add(lblNgayTruc);
            pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            pnlInput.Location = new System.Drawing.Point(0, 65);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new System.Windows.Forms.Padding(20);
            pnlInput.Size = new System.Drawing.Size(330, 555);
            pnlInput.TabIndex = 1;
            // 
            // btnXoaCa
            // 
            btnXoaCa.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnXoaCa.FlatAppearance.BorderSize = 0;
            btnXoaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnXoaCa.ForeColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnXoaCa.Location = new System.Drawing.Point(20, 505);
            btnXoaCa.Name = "btnXoaCa";
            btnXoaCa.Size = new System.Drawing.Size(290, 36);
            btnXoaCa.TabIndex = 17;
            btnXoaCa.Text = "🗑️ Hủy Ca Đang Chọn";
            btnXoaCa.UseVisualStyleBackColor = false;
            btnXoaCa.Click += btnXoaCa_Click;
            // 
            // btnLuuCa
            // 
            btnLuuCa.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnLuuCa.FlatAppearance.BorderSize = 0;
            btnLuuCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuuCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnLuuCa.ForeColor = System.Drawing.Color.White;
            btnLuuCa.Location = new System.Drawing.Point(20, 460);
            btnLuuCa.Name = "btnLuuCa";
            btnLuuCa.Size = new System.Drawing.Size(290, 38);
            btnLuuCa.TabIndex = 16;
            btnLuuCa.Text = "➕ PHÂN CÔNG CA TRỰC";
            btnLuuCa.UseVisualStyleBackColor = false;
            btnLuuCa.Click += btnLuuCa_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtGhiChu.Location = new System.Drawing.Point(20, 420);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú phân công...";
            txtGhiChu.Size = new System.Drawing.Size(290, 24);
            txtGhiChu.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblGhiChu.Location = new System.Drawing.Point(20, 400);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(51, 15);
            lblGhiChu.TabIndex = 14;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // nudTienDauCa
            // 
            nudTienDauCa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            nudTienDauCa.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudTienDauCa.Location = new System.Drawing.Point(20, 365);
            nudTienDauCa.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudTienDauCa.Name = "nudTienDauCa";
            nudTienDauCa.Size = new System.Drawing.Size(290, 24);
            nudTienDauCa.TabIndex = 13;
            nudTienDauCa.ThousandsSeparator = true;
            nudTienDauCa.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // lblTienDauCa
            // 
            lblTienDauCa.AutoSize = true;
            lblTienDauCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTienDauCa.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTienDauCa.Location = new System.Drawing.Point(20, 345);
            lblTienDauCa.Name = "lblTienDauCa";
            lblTienDauCa.Size = new System.Drawing.Size(138, 15);
            lblTienDauCa.TabIndex = 12;
            lblTienDauCa.Text = "Tiền bàn giao đầu ca (đ):";
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.CustomFormat = "HH:mm";
            dtpGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpGioKetThuc.Location = new System.Drawing.Point(170, 310);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new System.Drawing.Size(140, 24);
            dtpGioKetThuc.TabIndex = 11;
            // 
            // lblGioKetThuc
            // 
            lblGioKetThuc.AutoSize = true;
            lblGioKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblGioKetThuc.Location = new System.Drawing.Point(170, 290);
            lblGioKetThuc.Name = "lblGioKetThuc";
            lblGioKetThuc.Size = new System.Drawing.Size(55, 15);
            lblGioKetThuc.TabIndex = 10;
            lblGioKetThuc.Text = "Kết thúc:";
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.CustomFormat = "HH:mm";
            dtpGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpGioBatDau.Location = new System.Drawing.Point(20, 310);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new System.Drawing.Size(140, 24);
            dtpGioBatDau.TabIndex = 9;
            // 
            // lblGioBatDau
            // 
            lblGioBatDau.AutoSize = true;
            lblGioBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblGioBatDau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblGioBatDau.Location = new System.Drawing.Point(20, 290);
            lblGioBatDau.Name = "lblGioBatDau";
            lblGioBatDau.Size = new System.Drawing.Size(51, 15);
            lblGioBatDau.TabIndex = 8;
            lblGioBatDau.Text = "Bắt đầu:";
            // 
            // cboTenCa
            // 
            cboTenCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTenCa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboTenCa.FormattingEnabled = true;
            cboTenCa.Items.AddRange(new object[] { "Ca Sáng (07:30 - 12:00)", "Ca Chiều (13:00 - 17:30)" });
            cboTenCa.Location = new System.Drawing.Point(20, 255);
            cboTenCa.Name = "cboTenCa";
            cboTenCa.Size = new System.Drawing.Size(290, 25);
            cboTenCa.TabIndex = 7;
            cboTenCa.SelectedIndexChanged += cboTenCa_SelectedIndexChanged;
            // 
            // lblTenCa
            // 
            lblTenCa.AutoSize = true;
            lblTenCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTenCa.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTenCa.Location = new System.Drawing.Point(20, 235);
            lblTenCa.Name = "lblTenCa";
            lblTenCa.Size = new System.Drawing.Size(46, 15);
            lblTenCa.TabIndex = 6;
            lblTenCa.Text = "Ca trực:";
            // 
            // cboThuThu
            // 
            cboThuThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboThuThu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboThuThu.FormattingEnabled = true;
            cboThuThu.Location = new System.Drawing.Point(20, 200);
            cboThuThu.Name = "cboThuThu";
            cboThuThu.Size = new System.Drawing.Size(290, 25);
            cboThuThu.TabIndex = 5;
            // 
            // lblThuThu
            // 
            lblThuThu.AutoSize = true;
            lblThuThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblThuThu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblThuThu.Location = new System.Drawing.Point(20, 180);
            lblThuThu.Name = "lblThuThu";
            lblThuThu.Size = new System.Drawing.Size(99, 15);
            lblThuThu.TabIndex = 4;
            lblThuThu.Text = "Nhân sự thủ thư:";
            // 
            // cboChiNhanh
            // 
            cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboChiNhanh.FormattingEnabled = true;
            cboChiNhanh.Location = new System.Drawing.Point(20, 145);
            cboChiNhanh.Name = "cboChiNhanh";
            cboChiNhanh.Size = new System.Drawing.Size(290, 25);
            cboChiNhanh.TabIndex = 3;
            // 
            // lblChiNhanh
            // 
            lblChiNhanh.AutoSize = true;
            lblChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblChiNhanh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblChiNhanh.Location = new System.Drawing.Point(20, 125);
            lblChiNhanh.Name = "lblChiNhanh";
            lblChiNhanh.Size = new System.Drawing.Size(126, 15);
            lblChiNhanh.TabIndex = 2;
            lblChiNhanh.Text = "Chi nhánh phân công:";
            // 
            // dtpNgayTruc
            // 
            dtpNgayTruc.CustomFormat = "dd/MM/yyyy";
            dtpNgayTruc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpNgayTruc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpNgayTruc.Location = new System.Drawing.Point(20, 90);
            dtpNgayTruc.Name = "dtpNgayTruc";
            dtpNgayTruc.Size = new System.Drawing.Size(290, 24);
            dtpNgayTruc.TabIndex = 1;
            // 
            // lblNgayTruc
            // 
            lblNgayTruc.AutoSize = true;
            lblNgayTruc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblNgayTruc.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblNgayTruc.Location = new System.Drawing.Point(20, 70);
            lblNgayTruc.Name = "lblNgayTruc";
            lblNgayTruc.Size = new System.Drawing.Size(62, 15);
            lblNgayTruc.TabIndex = 0;
            lblNgayTruc.Text = "Ngày trực:";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvCaTruc);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(330, 65);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new System.Windows.Forms.Padding(15, 0, 20, 20);
            pnlMain.Size = new System.Drawing.Size(670, 555);
            pnlMain.TabIndex = 2;
            // 
            // dgvCaTruc
            // 
            dgvCaTruc.AllowUserToAddRows = false;
            dgvCaTruc.AllowUserToDeleteRows = false;
            dgvCaTruc.AllowUserToResizeRows = false;
            dgvCaTruc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaTruc.BackgroundColor = System.Drawing.Color.White;
            dgvCaTruc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCaTruc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCaTruc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCaTruc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCaTruc.ColumnHeadersHeight = 38;
            dgvCaTruc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCaTruc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaSo, colNgayTruc, colChiNhanh, colTenCa, colGioTruc, colMaThuThu, colHoTen, colQuay, colTienDauCa, colTrangThai });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCaTruc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCaTruc.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCaTruc.EnableHeadersVisualStyles = false;
            dgvCaTruc.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvCaTruc.Location = new System.Drawing.Point(15, 55);
            dgvCaTruc.MultiSelect = false;
            dgvCaTruc.Name = "dgvCaTruc";
            dgvCaTruc.ReadOnly = true;
            dgvCaTruc.RowHeadersVisible = false;
            dgvCaTruc.RowTemplate.Height = 36;
            dgvCaTruc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCaTruc.Size = new System.Drawing.Size(635, 480);
            dgvCaTruc.TabIndex = 1;
            dgvCaTruc.CellFormatting += dgvCaTruc_CellFormatting;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "Ma_So";
            colMaSo.FillWeight = 35F;
            colMaSo.HeaderText = "#";
            colMaSo.Name = "colMaSo";
            colMaSo.ReadOnly = true;
            // 
            // colNgayTruc
            // 
            colNgayTruc.DataPropertyName = "Ngay_Truc";
            colNgayTruc.FillWeight = 65F;
            colNgayTruc.HeaderText = "Ngày";
            colNgayTruc.Name = "colNgayTruc";
            colNgayTruc.ReadOnly = true;
            // 
            // colChiNhanh
            // 
            colChiNhanh.DataPropertyName = "Ten_Chi_Nhanh";
            colChiNhanh.FillWeight = 90F;
            colChiNhanh.HeaderText = "Chi Nhánh";
            colChiNhanh.Name = "colChiNhanh";
            colChiNhanh.ReadOnly = true;
            // 
            // colTenCa
            // 
            colTenCa.DataPropertyName = "Ten_Ca";
            colTenCa.FillWeight = 55F;
            colTenCa.HeaderText = "Ca";
            colTenCa.Name = "colTenCa";
            colTenCa.ReadOnly = true;
            // 
            // colGioTruc
            // 
            colGioTruc.FillWeight = 80F;
            colGioTruc.HeaderText = "Khung Giờ";
            colGioTruc.Name = "colGioTruc";
            colGioTruc.ReadOnly = true;
            // 
            // colMaThuThu
            // 
            colMaThuThu.DataPropertyName = "Ma_Thu_Thu";
            colMaThuThu.FillWeight = 50F;
            colMaThuThu.HeaderText = "Mã NV";
            colMaThuThu.Name = "colMaThuThu";
            colMaThuThu.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "Ho_Ten";
            colHoTen.FillWeight = 90F;
            colHoTen.HeaderText = "Thủ Thư";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colQuay
            // 
            colQuay.DataPropertyName = "Quay_Phu_Trach";
            colQuay.FillWeight = 85F;
            colQuay.HeaderText = "Quầy";
            colQuay.Name = "colQuay";
            colQuay.ReadOnly = true;
            // 
            // colTienDauCa
            // 
            colTienDauCa.DataPropertyName = "Tien_Dau_Ca";
            colTienDauCa.FillWeight = 70F;
            colTienDauCa.HeaderText = "Tiền Đầu Ca";
            colTienDauCa.Name = "colTienDauCa";
            colTienDauCa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "Trang_Thai";
            colTrangThai.FillWeight = 70F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(btnLamMoi);
            pnlFilter.Controls.Add(btnLoc);
            pnlFilter.Controls.Add(dtpDenNgay);
            pnlFilter.Controls.Add(lblDenNgay);
            pnlFilter.Controls.Add(dtpTuNgay);
            pnlFilter.Controls.Add(lblTuNgay);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(15, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new System.Drawing.Size(635, 55);
            pnlFilter.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new System.Drawing.Point(440, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(75, 28);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "🔄 Tải lại";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLoc.ForeColor = System.Drawing.Color.White;
            btnLoc.Location = new System.Drawing.Point(365, 12);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new System.Drawing.Size(68, 28);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "🔍 Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(245, 15);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(110, 23);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDenNgay.Location = new System.Drawing.Point(185, 18);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new System.Drawing.Size(60, 15);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(65, 15);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(110, 23);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTuNgay.Location = new System.Drawing.Point(10, 18);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new System.Drawing.Size(53, 15);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // FormPhanCaTruc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1000, 620);
            Controls.Add(pnlMain);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormPhanCaTruc";
            Text = "Phân Ca Làm Việc";
            Load += FormPhanCaTruc_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTienDauCa).EndInit();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCaTruc).EndInit();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblNgayTruc;
        private System.Windows.Forms.DateTimePicker dtpNgayTruc;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label lblThuThu;
        private System.Windows.Forms.ComboBox cboThuThu;
        private System.Windows.Forms.Label lblTenCa;
        private System.Windows.Forms.ComboBox cboTenCa;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblTienDauCa;
        private System.Windows.Forms.NumericUpDown nudTienDauCa;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuuCa;
        private System.Windows.Forms.Button btnXoaCa;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvCaTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDauCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}