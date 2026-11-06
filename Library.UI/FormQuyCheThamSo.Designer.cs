namespace Library.UI
{
    partial class FormQuyCheThamSo
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
            pnlMain = new System.Windows.Forms.Panel();
            pnlCard = new System.Windows.Forms.Panel();
            btnKhoiPhuc = new System.Windows.Forms.Button();
            btnLuuQuyChe = new System.Windows.Forms.Button();
            nudTyLeMat = new System.Windows.Forms.NumericUpDown();
            lblTyLeMat = new System.Windows.Forms.Label();
            nudTyLeHong = new System.Windows.Forms.NumericUpDown();
            lblTyLeHong = new System.Windows.Forms.Label();
            nudTyLeRach = new System.Windows.Forms.NumericUpDown();
            lblTyLeRach = new System.Windows.Forms.Label();
            lblDenBuSection = new System.Windows.Forms.Label();
            nudThoiHanThe = new System.Windows.Forms.NumericUpDown();
            lblThoiHanThe = new System.Windows.Forms.Label();
            nudTienPhat = new System.Windows.Forms.NumericUpDown();
            lblTienPhat = new System.Windows.Forms.Label();
            nudSoNgayMuon = new System.Windows.Forms.NumericUpDown();
            lblSoNgayMuon = new System.Windows.Forms.Label();
            nudSoSachMuon = new System.Windows.Forms.NumericUpDown();
            lblSoSachMuon = new System.Windows.Forms.Label();
            lblFormSection = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvThamSo = new System.Windows.Forms.DataGridView();
            colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenThamSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblGridTitle = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTyLeMat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTyLeHong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTyLeRach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThoiHanThe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTienPhat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoSachMuon).BeginInit();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThamSo).BeginInit();
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
            lblSubTitle.Size = new System.Drawing.Size(535, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Cấu hình hạn mức lưu thông mượn trả, biểu phí phạt vi phạm và tỷ lệ đền bù hư hao tài sản";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(326, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUY CHẾ & CẤU HÌNH THAM SỐ ĐỘNG";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlCard);
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 65);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new System.Windows.Forms.Padding(20);
            pnlMain.Size = new System.Drawing.Size(1000, 555);
            pnlMain.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(btnKhoiPhuc);
            pnlCard.Controls.Add(btnLuuQuyChe);
            pnlCard.Controls.Add(nudTyLeMat);
            pnlCard.Controls.Add(lblTyLeMat);
            pnlCard.Controls.Add(nudTyLeHong);
            pnlCard.Controls.Add(lblTyLeHong);
            pnlCard.Controls.Add(nudTyLeRach);
            pnlCard.Controls.Add(lblTyLeRach);
            pnlCard.Controls.Add(lblDenBuSection);
            pnlCard.Controls.Add(nudThoiHanThe);
            pnlCard.Controls.Add(lblThoiHanThe);
            pnlCard.Controls.Add(nudTienPhat);
            pnlCard.Controls.Add(lblTienPhat);
            pnlCard.Controls.Add(nudSoNgayMuon);
            pnlCard.Controls.Add(lblSoNgayMuon);
            pnlCard.Controls.Add(nudSoSachMuon);
            pnlCard.Controls.Add(lblSoSachMuon);
            pnlCard.Controls.Add(lblFormSection);
            pnlCard.Dock = System.Windows.Forms.DockStyle.Left;
            pnlCard.Location = new System.Drawing.Point(20, 20);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new System.Windows.Forms.Padding(18);
            pnlCard.Size = new System.Drawing.Size(430, 515);
            pnlCard.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnKhoiPhuc.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnKhoiPhuc.Location = new System.Drawing.Point(20, 465);
            btnKhoiPhuc.Name = "btnKhoiPhuc";
            btnKhoiPhuc.Size = new System.Drawing.Size(390, 32);
            btnKhoiPhuc.TabIndex = 17;
            btnKhoiPhuc.Text = "🔄 Nạp Lại Giá Trị Gốc";
            btnKhoiPhuc.UseVisualStyleBackColor = false;
            btnKhoiPhuc.Click += btnKhoiPhuc_Click;
            // 
            // btnLuuQuyChe
            // 
            btnLuuQuyChe.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnLuuQuyChe.FlatAppearance.BorderSize = 0;
            btnLuuQuyChe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLuuQuyChe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            btnLuuQuyChe.ForeColor = System.Drawing.Color.White;
            btnLuuQuyChe.Location = new System.Drawing.Point(20, 420);
            btnLuuQuyChe.Name = "btnLuuQuyChe";
            btnLuuQuyChe.Size = new System.Drawing.Size(390, 38);
            btnLuuQuyChe.TabIndex = 16;
            btnLuuQuyChe.Text = "💾 LƯU TOÀN DIỆN QUY CHẾ";
            btnLuuQuyChe.UseVisualStyleBackColor = false;
            btnLuuQuyChe.Click += btnLuuQuyChe_Click;
            // 
            // nudTyLeMat
            // 
            nudTyLeMat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudTyLeMat.Location = new System.Drawing.Point(286, 375);
            nudTyLeMat.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudTyLeMat.Name = "nudTyLeMat";
            nudTyLeMat.Size = new System.Drawing.Size(124, 24);
            nudTyLeMat.TabIndex = 15;
            nudTyLeMat.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblTyLeMat
            // 
            lblTyLeMat.AutoSize = true;
            lblTyLeMat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTyLeMat.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTyLeMat.Location = new System.Drawing.Point(286, 355);
            lblTyLeMat.Name = "lblTyLeMat";
            lblTyLeMat.Size = new System.Drawing.Size(81, 15);
            lblTyLeMat.TabIndex = 14;
            lblTyLeMat.Text = "Mất sách (%):";
            // 
            // nudTyLeHong
            // 
            nudTyLeHong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudTyLeHong.Location = new System.Drawing.Point(153, 375);
            nudTyLeHong.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudTyLeHong.Name = "nudTyLeHong";
            nudTyLeHong.Size = new System.Drawing.Size(124, 24);
            nudTyLeHong.TabIndex = 13;
            nudTyLeHong.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblTyLeHong
            // 
            lblTyLeHong.AutoSize = true;
            lblTyLeHong.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTyLeHong.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTyLeHong.Location = new System.Drawing.Point(153, 355);
            lblTyLeHong.Name = "lblTyLeHong";
            lblTyLeHong.Size = new System.Drawing.Size(89, 15);
            lblTyLeHong.TabIndex = 12;
            lblTyLeHong.Text = "Hỏng nặng (%):";
            // 
            // nudTyLeRach
            // 
            nudTyLeRach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudTyLeRach.Location = new System.Drawing.Point(20, 375);
            nudTyLeRach.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudTyLeRach.Name = "nudTyLeRach";
            nudTyLeRach.Size = new System.Drawing.Size(124, 24);
            nudTyLeRach.TabIndex = 11;
            nudTyLeRach.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblTyLeRach
            // 
            lblTyLeRach.AutoSize = true;
            lblTyLeRach.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTyLeRach.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTyLeRach.Location = new System.Drawing.Point(20, 355);
            lblTyLeRach.Name = "lblTyLeRach";
            lblTyLeRach.Size = new System.Drawing.Size(84, 15);
            lblTyLeRach.TabIndex = 10;
            lblTyLeRach.Text = "Rách / Ướt (%):";
            // 
            // lblDenBuSection
            // 
            lblDenBuSection.AutoSize = true;
            lblDenBuSection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDenBuSection.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);
            lblDenBuSection.Location = new System.Drawing.Point(20, 332);
            lblDenBuSection.Name = "lblDenBuSection";
            lblDenBuSection.Size = new System.Drawing.Size(306, 15);
            lblDenBuSection.TabIndex = 9;
            lblDenBuSection.Text = "5. TỶ LỆ ĐỀN BÙ TÀI LIỆU HƯ HỎNG / MẤT (% GIÁ BÌA):";
            // 
            // nudThoiHanThe
            // 
            nudThoiHanThe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudThoiHanThe.Location = new System.Drawing.Point(20, 288);
            nudThoiHanThe.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudThoiHanThe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThoiHanThe.Name = "nudThoiHanThe";
            nudThoiHanThe.Size = new System.Drawing.Size(390, 24);
            nudThoiHanThe.TabIndex = 8;
            nudThoiHanThe.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // lblThoiHanThe
            // 
            lblThoiHanThe.AutoSize = true;
            lblThoiHanThe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblThoiHanThe.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblThoiHanThe.Location = new System.Drawing.Point(20, 268);
            lblThoiHanThe.Name = "lblThoiHanThe";
            lblThoiHanThe.Size = new System.Drawing.Size(183, 15);
            lblThoiHanThe.TabIndex = 7;
            lblThoiHanThe.Text = "4. Thời hạn thẻ độc giả (tháng):";
            // 
            // nudTienPhat
            // 
            nudTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudTienPhat.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTienPhat.Location = new System.Drawing.Point(20, 225);
            nudTienPhat.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudTienPhat.Name = "nudTienPhat";
            nudTienPhat.Size = new System.Drawing.Size(390, 24);
            nudTienPhat.TabIndex = 6;
            nudTienPhat.ThousandsSeparator = true;
            nudTienPhat.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // lblTienPhat
            // 
            lblTienPhat.AutoSize = true;
            lblTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTienPhat.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTienPhat.Location = new System.Drawing.Point(20, 205);
            lblTienPhat.Name = "lblTienPhat";
            lblTienPhat.Size = new System.Drawing.Size(209, 15);
            lblTienPhat.TabIndex = 5;
            lblTienPhat.Text = "3. Tiền phạt trễ hạn (VNĐ/ngày/cuốn):";
            // 
            // nudSoNgayMuon
            // 
            nudSoNgayMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudSoNgayMuon.Location = new System.Drawing.Point(20, 162);
            nudSoNgayMuon.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudSoNgayMuon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoNgayMuon.Name = "nudSoNgayMuon";
            nudSoNgayMuon.Size = new System.Drawing.Size(390, 24);
            nudSoNgayMuon.TabIndex = 4;
            nudSoNgayMuon.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // lblSoNgayMuon
            // 
            lblSoNgayMuon.AutoSize = true;
            lblSoNgayMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSoNgayMuon.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSoNgayMuon.Location = new System.Drawing.Point(20, 142);
            lblSoNgayMuon.Name = "lblSoNgayMuon";
            lblSoNgayMuon.Size = new System.Drawing.Size(180, 15);
            lblSoNgayMuon.TabIndex = 3;
            lblSoNgayMuon.Text = "2. Số ngày mượn tối đa (ngày):";
            // 
            // nudSoSachMuon
            // 
            nudSoSachMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            nudSoSachMuon.Location = new System.Drawing.Point(20, 100);
            nudSoSachMuon.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSoSachMuon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoSachMuon.Name = "nudSoSachMuon";
            nudSoSachMuon.Size = new System.Drawing.Size(390, 24);
            nudSoSachMuon.TabIndex = 2;
            nudSoSachMuon.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblSoSachMuon
            // 
            lblSoSachMuon.AutoSize = true;
            lblSoSachMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSoSachMuon.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSoSachMuon.Location = new System.Drawing.Point(20, 80);
            lblSoSachMuon.Name = "lblSoSachMuon";
            lblSoSachMuon.Size = new System.Drawing.Size(185, 15);
            lblSoSachMuon.TabIndex = 1;
            lblSoSachMuon.Text = "1. Số sách mượn tối đa (cuốn):";
            // 
            // lblFormSection
            // 
            lblFormSection.AutoSize = true;
            lblFormSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblFormSection.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblFormSection.Location = new System.Drawing.Point(18, 15);
            lblFormSection.Name = "lblFormSection";
            lblFormSection.Size = new System.Drawing.Size(268, 20);
            lblFormSection.TabIndex = 0;
            lblFormSection.Text = "THIẾT LẬP THAM SỐ TOÀN HỆ THỐNG";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.BackColor = System.Drawing.Color.White;
            pnlGrid.Controls.Add(dgvThamSo);
            pnlGrid.Controls.Add(lblGridTitle);
            pnlGrid.Location = new System.Drawing.Point(465, 20);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(18);
            pnlGrid.Size = new System.Drawing.Size(515, 515);
            pnlGrid.TabIndex = 1;
            // 
            // dgvThamSo
            // 
            dgvThamSo.AllowUserToAddRows = false;
            dgvThamSo.AllowUserToDeleteRows = false;
            dgvThamSo.AllowUserToResizeRows = false;
            dgvThamSo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvThamSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvThamSo.BackgroundColor = System.Drawing.Color.White;
            dgvThamSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvThamSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThamSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvThamSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThamSo.ColumnHeadersHeight = 36;
            dgvThamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvThamSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaSo, colTenThamSo, colGiaTri, colMoTa });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvThamSo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThamSo.EnableHeadersVisualStyles = false;
            dgvThamSo.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvThamSo.Location = new System.Drawing.Point(18, 48);
            dgvThamSo.MultiSelect = false;
            dgvThamSo.Name = "dgvThamSo";
            dgvThamSo.ReadOnly = true;
            dgvThamSo.RowHeadersVisible = false;
            dgvThamSo.RowTemplate.Height = 35;
            dgvThamSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvThamSo.Size = new System.Drawing.Size(479, 449);
            dgvThamSo.TabIndex = 1;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "Ma_So";
            colMaSo.FillWeight = 28F;
            colMaSo.HeaderText = "#";
            colMaSo.Name = "colMaSo";
            colMaSo.ReadOnly = true;
            // 
            // colTenThamSo
            // 
            colTenThamSo.DataPropertyName = "Ten_Tham_So";
            colTenThamSo.FillWeight = 95F;
            colTenThamSo.HeaderText = "Mã Tham Số";
            colTenThamSo.Name = "colTenThamSo";
            colTenThamSo.ReadOnly = true;
            // 
            // colGiaTri
            // 
            colGiaTri.DataPropertyName = "Gia_Tri";
            colGiaTri.FillWeight = 50F;
            colGiaTri.HeaderText = "Giá Trị";
            colGiaTri.Name = "colGiaTri";
            colGiaTri.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "Mo_Ta";
            colMoTa.FillWeight = 140F;
            colMoTa.HeaderText = "Ý Nghĩa Quy Chế";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblGridTitle.Location = new System.Drawing.Point(15, 15);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new System.Drawing.Size(269, 20);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "BẢNG ĐỒNG BỘ CƠ SỞ DỮ LIỆU";
            // 
            // FormQuyCheThamSo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1000, 620);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormQuyCheThamSo";
            Text = "Quy Chế Tham Số";
            Load += FormQuyCheThamSo_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTyLeMat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTyLeHong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTyLeRach).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThoiHanThe).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTienPhat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoSachMuon).EndInit();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThamSo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblFormSection;
        private System.Windows.Forms.Label lblSoSachMuon;
        private System.Windows.Forms.NumericUpDown nudSoSachMuon;
        private System.Windows.Forms.Label lblSoNgayMuon;
        private System.Windows.Forms.NumericUpDown nudSoNgayMuon;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.NumericUpDown nudTienPhat;
        private System.Windows.Forms.Label lblThoiHanThe;
        private System.Windows.Forms.NumericUpDown nudThoiHanThe;
        private System.Windows.Forms.Label lblDenBuSection;
        private System.Windows.Forms.Label lblTyLeRach;
        private System.Windows.Forms.NumericUpDown nudTyLeRach;
        private System.Windows.Forms.Label lblTyLeHong;
        private System.Windows.Forms.NumericUpDown nudTyLeHong;
        private System.Windows.Forms.Label lblTyLeMat;
        private System.Windows.Forms.NumericUpDown nudTyLeMat;
        private System.Windows.Forms.Button btnLuuQuyChe;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
    }
}