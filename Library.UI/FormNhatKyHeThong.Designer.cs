namespace Library.UI
{
    partial class FormNhatKyHeThong
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
            pnlFilter = new System.Windows.Forms.Panel();
            btnMoThuMucLog = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            btnLoc = new System.Windows.Forms.Button();
            txtTuKhoa = new System.Windows.Forms.TextBox();
            lblTuKhoa = new System.Windows.Forms.Label();
            cboHanhDong = new System.Windows.Forms.ComboBox();
            lblHanhDong = new System.Windows.Forms.Label();
            cboMucDo = new System.Windows.Forms.ComboBox();
            lblMucDo = new System.Windows.Forms.Label();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            lblDenNgay = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblTuNgay = new System.Windows.Forms.Label();
            pnlGridContainer = new System.Windows.Forms.Panel();
            dgvNhatKy = new System.Windows.Forms.DataGridView();
            colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMucDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDiaChiIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(1100, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(25, 36);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(465, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Theo dõi lịch sử đăng nhập, các tác vụ quản trị và biến động cấu hình dữ liệu toàn hệ thống";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(288, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHẬT KÝ HỆ THỐNG (AUDIT LOG)";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = System.Drawing.Color.White;
            pnlFilter.Controls.Add(btnMoThuMucLog);
            pnlFilter.Controls.Add(btnLamMoi);
            pnlFilter.Controls.Add(btnLoc);
            pnlFilter.Controls.Add(txtTuKhoa);
            pnlFilter.Controls.Add(lblTuKhoa);
            pnlFilter.Controls.Add(cboHanhDong);
            pnlFilter.Controls.Add(lblHanhDong);
            pnlFilter.Controls.Add(cboMucDo);
            pnlFilter.Controls.Add(lblMucDo);
            pnlFilter.Controls.Add(dtpDenNgay);
            pnlFilter.Controls.Add(lblDenNgay);
            pnlFilter.Controls.Add(dtpTuNgay);
            pnlFilter.Controls.Add(lblTuNgay);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Location = new System.Drawing.Point(0, 65);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            pnlFilter.Size = new System.Drawing.Size(1100, 56);
            pnlFilter.TabIndex = 1;
            // 
            // btnMoThuMucLog
            // 
            btnMoThuMucLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMoThuMucLog.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnMoThuMucLog.FlatAppearance.BorderSize = 0;
            btnMoThuMucLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMoThuMucLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnMoThuMucLog.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnMoThuMucLog.Location = new System.Drawing.Point(985, 13);
            btnMoThuMucLog.Name = "btnMoThuMucLog";
            btnMoThuMucLog.Size = new System.Drawing.Size(100, 30);
            btnMoThuMucLog.TabIndex = 12;
            btnMoThuMucLog.Text = "📂 File Log";
            btnMoThuMucLog.UseVisualStyleBackColor = false;
            btnMoThuMucLog.Click += btnMoThuMucLog_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new System.Drawing.Point(905, 13);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(74, 30);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "🔄 Tải lại";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLoc.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLoc.ForeColor = System.Drawing.Color.White;
            btnLoc.Location = new System.Drawing.Point(825, 13);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new System.Drawing.Size(74, 30);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "🔍 Tìm";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTuKhoa.Location = new System.Drawing.Point(680, 16);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Tài khoản hoặc chi tiết...";
            txtTuKhoa.Size = new System.Drawing.Size(135, 24);
            txtTuKhoa.TabIndex = 9;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTuKhoa.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTuKhoa.Location = new System.Drawing.Point(628, 21);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new System.Drawing.Size(51, 15);
            lblTuKhoa.TabIndex = 8;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // cboHanhDong
            // 
            cboHanhDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboHanhDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboHanhDong.FormattingEnabled = true;
            cboHanhDong.Location = new System.Drawing.Point(500, 17);
            cboHanhDong.Name = "cboHanhDong";
            cboHanhDong.Size = new System.Drawing.Size(120, 23);
            cboHanhDong.TabIndex = 7;
            // 
            // lblHanhDong
            // 
            lblHanhDong.AutoSize = true;
            lblHanhDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblHanhDong.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblHanhDong.Location = new System.Drawing.Point(432, 21);
            lblHanhDong.Name = "lblHanhDong";
            lblHanhDong.Size = new System.Drawing.Size(68, 15);
            lblHanhDong.TabIndex = 6;
            lblHanhDong.Text = "Hành động:";
            // 
            // cboMucDo
            // 
            cboMucDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMucDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboMucDo.FormattingEnabled = true;
            cboMucDo.Location = new System.Drawing.Point(330, 17);
            cboMucDo.Name = "cboMucDo";
            cboMucDo.Size = new System.Drawing.Size(95, 23);
            cboMucDo.TabIndex = 5;
            // 
            // lblMucDo
            // 
            lblMucDo.AutoSize = true;
            lblMucDo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblMucDo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMucDo.Location = new System.Drawing.Point(280, 21);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new System.Drawing.Size(51, 15);
            lblMucDo.TabIndex = 4;
            lblMucDo.Text = "Mức độ:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(180, 16);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(95, 24);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDenNgay.Location = new System.Drawing.Point(148, 21);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new System.Drawing.Size(31, 15);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(45, 16);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(95, 24);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTuNgay.Location = new System.Drawing.Point(18, 21);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new System.Drawing.Size(24, 15);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvNhatKy);
            pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridContainer.Location = new System.Drawing.Point(0, 121);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new System.Windows.Forms.Padding(20);
            pnlGridContainer.Size = new System.Drawing.Size(1100, 499);
            pnlGridContainer.TabIndex = 2;
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AllowUserToResizeRows = false;
            dgvNhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.BackgroundColor = System.Drawing.Color.White;
            dgvNhatKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvNhatKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhatKy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhatKy.ColumnHeadersHeight = 38;
            dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaSo, colThoiGian, colTenDangNhap, colVaiTro, colMucDo, colHanhDong, colChiTiet, colDiaChiIP });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvNhatKy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNhatKy.EnableHeadersVisualStyles = false;
            dgvNhatKy.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvNhatKy.Location = new System.Drawing.Point(20, 20);
            dgvNhatKy.MultiSelect = false;
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.ReadOnly = true;
            dgvNhatKy.RowHeadersVisible = false;
            dgvNhatKy.RowTemplate.Height = 36;
            dgvNhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvNhatKy.Size = new System.Drawing.Size(1060, 459);
            dgvNhatKy.TabIndex = 0;
            dgvNhatKy.CellFormatting += dgvNhatKy_CellFormatting;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "Ma_So";
            colMaSo.FillWeight = 30F;
            colMaSo.HeaderText = "#";
            colMaSo.Name = "colMaSo";
            colMaSo.ReadOnly = true;
            // 
            // colThoiGian
            // 
            colThoiGian.DataPropertyName = "Thoi_Gian";
            colThoiGian.FillWeight = 85F;
            colThoiGian.HeaderText = "Thời Gian";
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "Ten_Dang_Nhap";
            colTenDangNhap.FillWeight = 65F;
            colTenDangNhap.HeaderText = "Tài Khoản";
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "Vai_Tro";
            colVaiTro.FillWeight = 50F;
            colVaiTro.HeaderText = "Vai Trò";
            colVaiTro.Name = "colVaiTro";
            colVaiTro.ReadOnly = true;
            // 
            // colMucDo
            // 
            colMucDo.DataPropertyName = "Muc_Do";
            colMucDo.FillWeight = 60F;
            colMucDo.HeaderText = "Mức Độ";
            colMucDo.Name = "colMucDo";
            colMucDo.ReadOnly = true;
            // 
            // colHanhDong
            // 
            colHanhDong.DataPropertyName = "Hanh_Dong";
            colHanhDong.FillWeight = 80F;
            colHanhDong.HeaderText = "Hành Động";
            colHanhDong.Name = "colHanhDong";
            colHanhDong.ReadOnly = true;
            // 
            // colChiTiet
            // 
            colChiTiet.DataPropertyName = "Chi_Tiet";
            colChiTiet.FillWeight = 190F;
            colChiTiet.HeaderText = "Nội Dung Thao Tác";
            colChiTiet.Name = "colChiTiet";
            colChiTiet.ReadOnly = true;
            // 
            // colDiaChiIP
            // 
            colDiaChiIP.DataPropertyName = "Dia_Chi_IP";
            colDiaChiIP.FillWeight = 60F;
            colDiaChiIP.HeaderText = "Địa Chỉ IP";
            colDiaChiIP.Name = "colDiaChiIP";
            colDiaChiIP.ReadOnly = true;
            // 
            // FormNhatKyHeThong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(1100, 620);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormNhatKyHeThong";
            Text = "Nhật Ký Hệ Thống";
            Load += FormNhatKyHeThong_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.ComboBox cboMucDo;
        private System.Windows.Forms.Label lblHanhDong;
        private System.Windows.Forms.ComboBox cboHanhDong;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnMoThuMucLog;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanhDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiIP;
    }
}