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
            nudThoiHanThe = new System.Windows.Forms.NumericUpDown();
            lblThoiHanTheDesc = new System.Windows.Forms.Label();
            lblThoiHanThe = new System.Windows.Forms.Label();
            nudTienPhat = new System.Windows.Forms.NumericUpDown();
            lblTienPhatDesc = new System.Windows.Forms.Label();
            lblTienPhat = new System.Windows.Forms.Label();
            nudSoNgayMuon = new System.Windows.Forms.NumericUpDown();
            lblSoNgayMuonDesc = new System.Windows.Forms.Label();
            lblSoNgayMuon = new System.Windows.Forms.Label();
            nudSoSachMuon = new System.Windows.Forms.NumericUpDown();
            lblSoSachMuonDesc = new System.Windows.Forms.Label();
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
            lblSubTitle.Size = new System.Drawing.Size(535, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Cấu hình hạn mức lưu thông mượn trả, biểu phí phạt vi phạm và hiệu lực thẻ độc giả toàn hệ thống";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 12);
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
            pnlMain.Padding = new System.Windows.Forms.Padding(25);
            pnlMain.Size = new System.Drawing.Size(1000, 555);
            pnlMain.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(btnKhoiPhuc);
            pnlCard.Controls.Add(btnLuuQuyChe);
            pnlCard.Controls.Add(nudThoiHanThe);
            pnlCard.Controls.Add(lblThoiHanTheDesc);
            pnlCard.Controls.Add(lblThoiHanThe);
            pnlCard.Controls.Add(nudTienPhat);
            pnlCard.Controls.Add(lblTienPhatDesc);
            pnlCard.Controls.Add(lblTienPhat);
            pnlCard.Controls.Add(nudSoNgayMuon);
            pnlCard.Controls.Add(lblSoNgayMuonDesc);
            pnlCard.Controls.Add(lblSoNgayMuon);
            pnlCard.Controls.Add(nudSoSachMuon);
            pnlCard.Controls.Add(lblSoSachMuonDesc);
            pnlCard.Controls.Add(lblSoSachMuon);
            pnlCard.Controls.Add(lblFormSection);
            pnlCard.Dock = System.Windows.Forms.DockStyle.Left;
            pnlCard.Location = new System.Drawing.Point(25, 25);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new System.Windows.Forms.Padding(20);
            pnlCard.Size = new System.Drawing.Size(420, 505);
            pnlCard.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnKhoiPhuc.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnKhoiPhuc.Location = new System.Drawing.Point(20, 445);
            btnKhoiPhuc.Name = "btnKhoiPhuc";
            btnKhoiPhuc.Size = new System.Drawing.Size(380, 36);
            btnKhoiPhuc.TabIndex = 14;
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
            btnLuuQuyChe.Location = new System.Drawing.Point(20, 395);
            btnLuuQuyChe.Name = "btnLuuQuyChe";
            btnLuuQuyChe.Size = new System.Drawing.Size(380, 42);
            btnLuuQuyChe.TabIndex = 13;
            btnLuuQuyChe.Text = "💾 LƯU THIẾT LẬP QUY CHẾ";
            btnLuuQuyChe.UseVisualStyleBackColor = false;
            btnLuuQuyChe.Click += btnLuuQuyChe_Click;
            // 
            // nudThoiHanThe
            // 
            nudThoiHanThe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            nudThoiHanThe.Location = new System.Drawing.Point(20, 345);
            nudThoiHanThe.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudThoiHanThe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThoiHanThe.Name = "nudThoiHanThe";
            nudThoiHanThe.Size = new System.Drawing.Size(380, 25);
            nudThoiHanThe.TabIndex = 12;
            nudThoiHanThe.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // lblThoiHanTheDesc
            // 
            lblThoiHanTheDesc.AutoSize = true;
            lblThoiHanTheDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblThoiHanTheDesc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblThoiHanTheDesc.Location = new System.Drawing.Point(20, 327);
            lblThoiHanTheDesc.Name = "lblThoiHanTheDesc";
            lblThoiHanTheDesc.Size = new System.Drawing.Size(262, 13);
            lblThoiHanTheDesc.TabIndex = 11;
            lblThoiHanTheDesc.Text = "Hiệu lực sử dụng tính từ ngày cấp thẻ cho độc giả";
            // 
            // lblThoiHanThe
            // 
            lblThoiHanThe.AutoSize = true;
            lblThoiHanThe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblThoiHanThe.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblThoiHanThe.Location = new System.Drawing.Point(20, 308);
            lblThoiHanThe.Name = "lblThoiHanThe";
            lblThoiHanThe.Size = new System.Drawing.Size(200, 17);
            lblThoiHanThe.TabIndex = 10;
            lblThoiHanThe.Text = "4. Thời hạn thẻ độc giả (tháng):";
            // 
            // nudTienPhat
            // 
            nudTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            nudTienPhat.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTienPhat.Location = new System.Drawing.Point(20, 260);
            nudTienPhat.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudTienPhat.Name = "nudTienPhat";
            nudTienPhat.Size = new System.Drawing.Size(380, 25);
            nudTienPhat.TabIndex = 9;
            nudTienPhat.ThousandsSeparator = true;
            nudTienPhat.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // lblTienPhatDesc
            // 
            lblTienPhatDesc.AutoSize = true;
            lblTienPhatDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblTienPhatDesc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblTienPhatDesc.Location = new System.Drawing.Point(20, 242);
            lblTienPhatDesc.Name = "lblTienPhatDesc";
            lblTienPhatDesc.Size = new System.Drawing.Size(248, 13);
            lblTienPhatDesc.TabIndex = 8;
            lblTienPhatDesc.Text = "Số tiền phạt lũy kế cho mỗi ngày quá hạn/cuốn";
            // 
            // lblTienPhat
            // 
            lblTienPhat.AutoSize = true;
            lblTienPhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTienPhat.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTienPhat.Location = new System.Drawing.Point(20, 223);
            lblTienPhat.Name = "lblTienPhat";
            lblTienPhat.Size = new System.Drawing.Size(229, 17);
            lblTienPhat.TabIndex = 7;
            lblTienPhat.Text = "3. Tiền phạt trễ hạn (VNĐ/ngày/cuốn):";
            // 
            // nudSoNgayMuon
            // 
            nudSoNgayMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            nudSoNgayMuon.Location = new System.Drawing.Point(20, 175);
            nudSoNgayMuon.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudSoNgayMuon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoNgayMuon.Name = "nudSoNgayMuon";
            nudSoNgayMuon.Size = new System.Drawing.Size(380, 25);
            nudSoNgayMuon.TabIndex = 6;
            nudSoNgayMuon.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // lblSoNgayMuonDesc
            // 
            lblSoNgayMuonDesc.AutoSize = true;
            lblSoNgayMuonDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblSoNgayMuonDesc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSoNgayMuonDesc.Location = new System.Drawing.Point(20, 157);
            lblSoNgayMuonDesc.Name = "lblSoNgayMuonDesc";
            lblSoNgayMuonDesc.Size = new System.Drawing.Size(268, 13);
            lblSoNgayMuonDesc.TabIndex = 5;
            lblSoNgayMuonDesc.Text = "Hạn trả sách mặc định khi tạo mới một phiếu mượn";
            // 
            // lblSoNgayMuon
            // 
            lblSoNgayMuon.AutoSize = true;
            lblSoNgayMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSoNgayMuon.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblSoNgayMuon.Location = new System.Drawing.Point(20, 138);
            lblSoNgayMuon.Name = "lblSoNgayMuon";
            lblSoNgayMuon.Size = new System.Drawing.Size(201, 17);
            lblSoNgayMuon.TabIndex = 4;
            lblSoNgayMuon.Text = "2. Số ngày mượn tối đa (ngày):";
            // 
            // nudSoSachMuon
            // 
            nudSoSachMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            nudSoSachMuon.Location = new System.Drawing.Point(20, 90);
            nudSoSachMuon.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSoSachMuon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoSachMuon.Name = "nudSoSachMuon";
            nudSoSachMuon.Size = new System.Drawing.Size(380, 25);
            nudSoSachMuon.TabIndex = 3;
            nudSoSachMuon.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblSoSachMuonDesc
            // 
            lblSoSachMuonDesc.AutoSize = true;
            lblSoSachMuonDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblSoSachMuonDesc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lblSoSachMuonDesc.Location = new System.Drawing.Point(20, 72);
            lblSoSachMuonDesc.Name = "lblSoSachMuonDesc";
            lblSoSachMuonDesc.Size = new System.Drawing.Size(277, 13);
            lblSoSachMuonDesc.TabIndex = 2;
            lblSoSachMuonDesc.Text = "Số sách tối đa 1 bạn đọc được mượn cùng một thời điểm";
            // 
            // lblSoSachMuon
            // 
            lblSoSachMuon.AutoSize = true;
            lblSoSachMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSoSachMuon.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblSoSachMuon.Location = new System.Drawing.Point(20, 53);
            lblSoSachMuon.Name = "lblSoSachMuon";
            lblSoSachMuon.Size = new System.Drawing.Size(206, 17);
            lblSoSachMuon.TabIndex = 1;
            lblSoSachMuon.Text = "1. Số sách mượn tối đa (cuốn):";
            // 
            // lblFormSection
            // 
            lblFormSection.AutoSize = true;
            lblFormSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblFormSection.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblFormSection.Location = new System.Drawing.Point(18, 16);
            lblFormSection.Name = "lblFormSection";
            lblFormSection.Size = new System.Drawing.Size(225, 20);
            lblFormSection.TabIndex = 0;
            lblFormSection.Text = "THIẾT LẬP THAM SỐ CƠ BẢN";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.BackColor = System.Drawing.Color.White;
            pnlGrid.Controls.Add(dgvThamSo);
            pnlGrid.Controls.Add(lblGridTitle);
            pnlGrid.Location = new System.Drawing.Point(465, 25);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(20);
            pnlGrid.Size = new System.Drawing.Size(510, 505);
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
            dgvThamSo.Location = new System.Drawing.Point(20, 50);
            dgvThamSo.MultiSelect = false;
            dgvThamSo.Name = "dgvThamSo";
            dgvThamSo.ReadOnly = true;
            dgvThamSo.RowHeadersVisible = false;
            dgvThamSo.RowTemplate.Height = 36;
            dgvThamSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvThamSo.Size = new System.Drawing.Size(470, 435);
            dgvThamSo.TabIndex = 1;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "Ma_So";
            colMaSo.FillWeight = 30F;
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
            colGiaTri.FillWeight = 55F;
            colGiaTri.HeaderText = "Giá Trị";
            colGiaTri.Name = "colGiaTri";
            colGiaTri.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "Mo_Ta";
            colMoTa.FillWeight = 130F;
            colMoTa.HeaderText = "Ý Nghĩa Quy Chế";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblGridTitle.Location = new System.Drawing.Point(16, 16);
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
        private System.Windows.Forms.Label lblSoSachMuonDesc;
        private System.Windows.Forms.NumericUpDown nudSoSachMuon;
        private System.Windows.Forms.Label lblSoNgayMuon;
        private System.Windows.Forms.Label lblSoNgayMuonDesc;
        private System.Windows.Forms.NumericUpDown nudSoNgayMuon;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.Label lblTienPhatDesc;
        private System.Windows.Forms.NumericUpDown nudTienPhat;
        private System.Windows.Forms.Label lblThoiHanThe;
        private System.Windows.Forms.Label lblThoiHanTheDesc;
        private System.Windows.Forms.NumericUpDown nudThoiHanThe;
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