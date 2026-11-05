namespace Library.UI
{
    partial class FormTongQuanHeThong
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
            pnlCards = new System.Windows.Forms.TableLayoutPanel();
            card1 = new System.Windows.Forms.Panel();
            lblKpiDocGiaVal = new System.Windows.Forms.Label();
            lblKpiDocGiaTitle = new System.Windows.Forms.Label();
            card2 = new System.Windows.Forms.Panel();
            lblKpiSachVal = new System.Windows.Forms.Label();
            lblKpiSachTitle = new System.Windows.Forms.Label();
            card3 = new System.Windows.Forms.Panel();
            lblKpiMuonVal = new System.Windows.Forms.Label();
            lblKpiMuonTitle = new System.Windows.Forms.Label();
            card4 = new System.Windows.Forms.Panel();
            lblKpiTienVal = new System.Windows.Forms.Label();
            lblKpiTienTitle = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            btnLamMoi = new System.Windows.Forms.Button();
            btnLoc = new System.Windows.Forms.Button();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            lblDenNgay = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblTuNgay = new System.Windows.Forms.Label();
            cboChiNhanh = new System.Windows.Forms.ComboBox();
            lblChiNhanh = new System.Windows.Forms.Label();
            pnlGridContainer = new System.Windows.Forms.Panel();
            dgvDoiSoat = new System.Windows.Forms.DataGridView();
            colMaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNgayTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTienDauCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTienLyThuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTienKetCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlCards.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            card4.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoiSoat).BeginInit();
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
            pnlHeader.Padding = new System.Windows.Forms.Padding(25, 12, 25, 12);
            pnlHeader.Size = new System.Drawing.Size(1000, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(25, 36);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(390, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Giám sát KPI và bảng đối soát tiền mặt toàn hệ thống.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(206, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TỔNG QUAN HỆ THỐNG";
            // 
            // pnlCards
            // 
            pnlCards.ColumnCount = 4;
            pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlCards.Controls.Add(card1, 0, 0);
            pnlCards.Controls.Add(card2, 1, 0);
            pnlCards.Controls.Add(card3, 2, 0);
            pnlCards.Controls.Add(card4, 3, 0);
            pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            pnlCards.Location = new System.Drawing.Point(0, 65);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlCards.RowCount = 1;
            pnlCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pnlCards.Size = new System.Drawing.Size(1000, 100);
            pnlCards.TabIndex = 1;
            // 
            // card1
            // 
            card1.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            card1.Controls.Add(lblKpiDocGiaVal);
            card1.Controls.Add(lblKpiDocGiaTitle);
            card1.Dock = System.Windows.Forms.DockStyle.Fill;
            card1.Location = new System.Drawing.Point(23, 13);
            card1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            card1.Name = "card1";
            card1.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            card1.Size = new System.Drawing.Size(227, 74);
            card1.TabIndex = 0;
            // 
            // lblKpiDocGiaVal
            // 
            lblKpiDocGiaVal.AutoSize = true;
            lblKpiDocGiaVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblKpiDocGiaVal.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);
            lblKpiDocGiaVal.Location = new System.Drawing.Point(12, 32);
            lblKpiDocGiaVal.Name = "lblKpiDocGiaVal";
            lblKpiDocGiaVal.Size = new System.Drawing.Size(26, 30);
            lblKpiDocGiaVal.TabIndex = 1;
            lblKpiDocGiaVal.Text = "0";
            // 
            // lblKpiDocGiaTitle
            // 
            lblKpiDocGiaTitle.AutoSize = true;
            lblKpiDocGiaTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblKpiDocGiaTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiDocGiaTitle.Location = new System.Drawing.Point(14, 12);
            lblKpiDocGiaTitle.Name = "lblKpiDocGiaTitle";
            lblKpiDocGiaTitle.Size = new System.Drawing.Size(107, 15);
            lblKpiDocGiaTitle.TabIndex = 0;
            lblKpiDocGiaTitle.Text = "ĐỘC GIẢ HIỆU LỰC";
            // 
            // card2
            // 
            card2.BackColor = System.Drawing.Color.FromArgb(240, 253, 250);
            card2.Controls.Add(lblKpiSachVal);
            card2.Controls.Add(lblKpiSachTitle);
            card2.Dock = System.Windows.Forms.DockStyle.Fill;
            card2.Location = new System.Drawing.Point(263, 13);
            card2.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            card2.Name = "card2";
            card2.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            card2.Size = new System.Drawing.Size(227, 74);
            card2.TabIndex = 1;
            // 
            // lblKpiSachVal
            // 
            lblKpiSachVal.AutoSize = true;
            lblKpiSachVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblKpiSachVal.ForeColor = System.Drawing.Color.FromArgb(13, 148, 136);
            lblKpiSachVal.Location = new System.Drawing.Point(12, 32);
            lblKpiSachVal.Name = "lblKpiSachVal";
            lblKpiSachVal.Size = new System.Drawing.Size(26, 30);
            lblKpiSachVal.TabIndex = 1;
            lblKpiSachVal.Text = "0";
            // 
            // lblKpiSachTitle
            // 
            lblKpiSachTitle.AutoSize = true;
            lblKpiSachTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblKpiSachTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiSachTitle.Location = new System.Drawing.Point(14, 12);
            lblKpiSachTitle.Name = "lblKpiSachTitle";
            lblKpiSachTitle.Size = new System.Drawing.Size(117, 15);
            lblKpiSachTitle.TabIndex = 0;
            lblKpiSachTitle.Text = "SÁCH SẴN SÀNG KHO";
            // 
            // card3
            // 
            card3.BackColor = System.Drawing.Color.FromArgb(254, 243, 199);
            card3.Controls.Add(lblKpiMuonVal);
            card3.Controls.Add(lblKpiMuonTitle);
            card3.Dock = System.Windows.Forms.DockStyle.Fill;
            card3.Location = new System.Drawing.Point(503, 13);
            card3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            card3.Name = "card3";
            card3.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            card3.Size = new System.Drawing.Size(227, 74);
            card3.TabIndex = 2;
            // 
            // lblKpiMuonVal
            // 
            lblKpiMuonVal.AutoSize = true;
            lblKpiMuonVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblKpiMuonVal.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            lblKpiMuonVal.Location = new System.Drawing.Point(12, 32);
            lblKpiMuonVal.Name = "lblKpiMuonVal";
            lblKpiMuonVal.Size = new System.Drawing.Size(26, 30);
            lblKpiMuonVal.TabIndex = 1;
            lblKpiMuonVal.Text = "0";
            // 
            // lblKpiMuonTitle
            // 
            lblKpiMuonTitle.AutoSize = true;
            lblKpiMuonTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblKpiMuonTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiMuonTitle.Location = new System.Drawing.Point(14, 12);
            lblKpiMuonTitle.Name = "lblKpiMuonTitle";
            lblKpiMuonTitle.Size = new System.Drawing.Size(130, 15);
            lblKpiMuonTitle.TabIndex = 0;
            lblKpiMuonTitle.Text = "LƯỢT ĐANG LƯU THÔNG";
            // 
            // card4
            // 
            card4.BackColor = System.Drawing.Color.FromArgb(243, 232, 255);
            card4.Controls.Add(lblKpiTienVal);
            card4.Controls.Add(lblKpiTienTitle);
            card4.Dock = System.Windows.Forms.DockStyle.Fill;
            card4.Location = new System.Drawing.Point(743, 13);
            card4.Name = "card4";
            card4.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            card4.Size = new System.Drawing.Size(234, 74);
            card4.TabIndex = 3;
            // 
            // lblKpiTienVal
            // 
            lblKpiTienVal.AutoSize = true;
            lblKpiTienVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblKpiTienVal.ForeColor = System.Drawing.Color.FromArgb(124, 58, 237);
            lblKpiTienVal.Location = new System.Drawing.Point(12, 32);
            lblKpiTienVal.Name = "lblKpiTienVal";
            lblKpiTienVal.Size = new System.Drawing.Size(53, 30);
            lblKpiTienVal.TabIndex = 1;
            lblKpiTienVal.Text = "0 đ";
            // 
            // lblKpiTienTitle
            // 
            lblKpiTienTitle.AutoSize = true;
            lblKpiTienTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblKpiTienTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiTienTitle.Location = new System.Drawing.Point(14, 12);
            lblKpiTienTitle.Name = "lblKpiTienTitle";
            lblKpiTienTitle.Size = new System.Drawing.Size(127, 15);
            lblKpiTienTitle.TabIndex = 0;
            lblKpiTienTitle.Text = "TIỀN PHẠT ĐÃ THU HỆ THỐNG";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = System.Drawing.Color.White;
            pnlFilter.Controls.Add(btnLamMoi);
            pnlFilter.Controls.Add(btnLoc);
            pnlFilter.Controls.Add(dtpDenNgay);
            pnlFilter.Controls.Add(lblDenNgay);
            pnlFilter.Controls.Add(dtpTuNgay);
            pnlFilter.Controls.Add(lblTuNgay);
            pnlFilter.Controls.Add(cboChiNhanh);
            pnlFilter.Controls.Add(lblChiNhanh);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(0, 165);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            pnlFilter.Size = new System.Drawing.Size(1000, 50);
            pnlFilter.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new System.Drawing.Point(740, 10);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(85, 30);
            btnLamMoi.TabIndex = 7;
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
            btnLoc.Location = new System.Drawing.Point(645, 10);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new System.Drawing.Size(85, 30);
            btnLoc.TabIndex = 6;
            btnLoc.Text = "🔍 Đối Soát";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(510, 13);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(120, 24);
            dtpDenNgay.TabIndex = 5;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDenNgay.Location = new System.Drawing.Point(448, 17);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new System.Drawing.Size(60, 15);
            lblDenNgay.TabIndex = 4;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(320, 13);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(120, 24);
            dtpTuNgay.TabIndex = 3;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTuNgay.Location = new System.Drawing.Point(265, 17);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new System.Drawing.Size(53, 15);
            lblTuNgay.TabIndex = 2;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // cboChiNhanh
            // 
            cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboChiNhanh.FormattingEnabled = true;
            cboChiNhanh.Location = new System.Drawing.Point(90, 13);
            cboChiNhanh.Name = "cboChiNhanh";
            cboChiNhanh.Size = new System.Drawing.Size(165, 25);
            cboChiNhanh.TabIndex = 1;
            // 
            // lblChiNhanh
            // 
            lblChiNhanh.AutoSize = true;
            lblChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblChiNhanh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblChiNhanh.Location = new System.Drawing.Point(25, 17);
            lblChiNhanh.Name = "lblChiNhanh";
            lblChiNhanh.Size = new System.Drawing.Size(63, 15);
            lblChiNhanh.TabIndex = 0;
            lblChiNhanh.Text = "Chi nhánh:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvDoiSoat);
            pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridContainer.Location = new System.Drawing.Point(0, 215);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new System.Windows.Forms.Padding(20);
            pnlGridContainer.Size = new System.Drawing.Size(1000, 405);
            pnlGridContainer.TabIndex = 3;
            // 
            // dgvDoiSoat
            // 
            dgvDoiSoat.AllowUserToAddRows = false;
            dgvDoiSoat.AllowUserToDeleteRows = false;
            dgvDoiSoat.AllowUserToResizeRows = false;
            dgvDoiSoat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoiSoat.BackgroundColor = System.Drawing.Color.White;
            dgvDoiSoat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvDoiSoat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoiSoat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDoiSoat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoiSoat.ColumnHeadersHeight = 38;
            dgvDoiSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDoiSoat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaCa, colNgayTruc, colChiNhanh, colTenCa, colThuThu, colTienDauCa, colTienThu, colTienLyThuyet, colTienKetCa, colChenhLech, colTrangThai });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvDoiSoat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDoiSoat.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDoiSoat.EnableHeadersVisualStyles = false;
            dgvDoiSoat.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvDoiSoat.Location = new System.Drawing.Point(20, 20);
            dgvDoiSoat.MultiSelect = false;
            dgvDoiSoat.Name = "dgvDoiSoat";
            dgvDoiSoat.ReadOnly = true;
            dgvDoiSoat.RowHeadersVisible = false;
            dgvDoiSoat.RowTemplate.Height = 36;
            dgvDoiSoat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDoiSoat.Size = new System.Drawing.Size(960, 365);
            dgvDoiSoat.TabIndex = 0;
            dgvDoiSoat.CellFormatting += dgvDoiSoat_CellFormatting;
            // 
            // colMaCa
            // 
            colMaCa.DataPropertyName = "Ma_Ca";
            colMaCa.FillWeight = 40F;
            colMaCa.HeaderText = "#";
            colMaCa.Name = "colMaCa";
            colMaCa.ReadOnly = true;
            // 
            // colNgayTruc
            // 
            colNgayTruc.DataPropertyName = "Ngay_Truc";
            colNgayTruc.FillWeight = 70F;
            colNgayTruc.HeaderText = "Ngày";
            colNgayTruc.Name = "colNgayTruc";
            colNgayTruc.ReadOnly = true;
            // 
            // colChiNhanh
            // 
            colChiNhanh.DataPropertyName = "Ten_Chi_Nhanh";
            colChiNhanh.FillWeight = 95F;
            colChiNhanh.HeaderText = "Chi Nhánh";
            colChiNhanh.Name = "colChiNhanh";
            colChiNhanh.ReadOnly = true;
            // 
            // colTenCa
            // 
            colTenCa.DataPropertyName = "Ten_Ca";
            colTenCa.FillWeight = 60F;
            colTenCa.HeaderText = "Ca";
            colTenCa.Name = "colTenCa";
            colTenCa.ReadOnly = true;
            // 
            // colThuThu
            // 
            colThuThu.DataPropertyName = "Ho_Ten";
            colThuThu.FillWeight = 95F;
            colThuThu.HeaderText = "Thủ Thư";
            colThuThu.Name = "colThuThu";
            colThuThu.ReadOnly = true;
            // 
            // colTienDauCa
            // 
            colTienDauCa.DataPropertyName = "Tien_Dau_Ca";
            colTienDauCa.FillWeight = 75F;
            colTienDauCa.HeaderText = "Đầu Ca";
            colTienDauCa.Name = "colTienDauCa";
            colTienDauCa.ReadOnly = true;
            // 
            // colTienThu
            // 
            colTienThu.DataPropertyName = "Tien_Thu_Trong_Ca";
            colTienThu.FillWeight = 75F;
            colTienThu.HeaderText = "Thu Trong Ca";
            colTienThu.Name = "colTienThu";
            colTienThu.ReadOnly = true;
            // 
            // colTienLyThuyet
            // 
            colTienLyThuyet.DataPropertyName = "Tien_Ly_Thuyet";
            colTienLyThuyet.FillWeight = 80F;
            colTienLyThuyet.HeaderText = "Lý Thuyết";
            colTienLyThuyet.Name = "colTienLyThuyet";
            colTienLyThuyet.ReadOnly = true;
            // 
            // colTienKetCa
            // 
            colTienKetCa.DataPropertyName = "Tien_Ket_Ca";
            colTienKetCa.FillWeight = 80F;
            colTienKetCa.HeaderText = "Thực Nộp";
            colTienKetCa.Name = "colTienKetCa";
            colTienKetCa.ReadOnly = true;
            // 
            // colChenhLech
            // 
            colChenhLech.DataPropertyName = "Chenh_Lech";
            colChenhLech.FillWeight = 75F;
            colChenhLech.HeaderText = "Chênh Lệch";
            colChenhLech.Name = "colChenhLech";
            colChenhLech.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "Trang_Thai";
            colTrangThai.FillWeight = 70F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // FormTongQuanHeThong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1000, 620);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFilter);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormTongQuanHeThong";
            Text = "Tổng Quan Hệ Thống";
            Load += FormTongQuanHeThong_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCards.ResumeLayout(false);
            card1.ResumeLayout(false);
            card1.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            card4.ResumeLayout(false);
            card4.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoiSoat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TableLayoutPanel pnlCards;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblKpiDocGiaTitle;
        private System.Windows.Forms.Label lblKpiDocGiaVal;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblKpiSachTitle;
        private System.Windows.Forms.Label lblKpiSachVal;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblKpiMuonTitle;
        private System.Windows.Forms.Label lblKpiMuonVal;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Label lblKpiTienTitle;
        private System.Windows.Forms.Label lblKpiTienVal;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvDoiSoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDauCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienLyThuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienKetCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}