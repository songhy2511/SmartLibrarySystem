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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            pnlFilter = new Panel();
            btnMoThuMucLog = new Button();
            btnLamMoi = new Button();
            btnLoc = new Button();
            txtTuKhoa = new TextBox();
            lblTuKhoa = new Label();
            cboHanhDong = new ComboBox();
            lblHanhDong = new Label();
            cboMucDo = new ComboBox();
            lblMucDo = new Label();
            dtpDenNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            pnlGridContainer = new Panel();
            dgvNhatKy = new DataGridView();
            colMaSo = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            colMucDo = new DataGridViewTextBoxColumn();
            colHanhDong = new DataGridViewTextBoxColumn();
            colChiTiet = new DataGridViewTextBoxColumn();
            colDiaChiIP = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(29, 16, 29, 16);
            pnlHeader.Size = new Size(1257, 87);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(29, 48);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(613, 20);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Theo dõi lịch sử đăng nhập, các tác vụ quản trị và biến động cấu hình dữ liệu toàn hệ thống";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(26, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHẬT KÝ HỆ THỐNG (AUDIT LOG)";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
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
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 87);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(17, 13, 17, 13);
            pnlFilter.Size = new Size(1257, 75);
            pnlFilter.TabIndex = 1;
            // 
            // btnMoThuMucLog
            // 
            btnMoThuMucLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMoThuMucLog.BackColor = Color.FromArgb(241, 245, 249);
            btnMoThuMucLog.FlatAppearance.BorderSize = 0;
            btnMoThuMucLog.FlatStyle = FlatStyle.Flat;
            btnMoThuMucLog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMoThuMucLog.ForeColor = Color.FromArgb(30, 41, 59);
            btnMoThuMucLog.Location = new Point(1126, 17);
            btnMoThuMucLog.Margin = new Padding(3, 4, 3, 4);
            btnMoThuMucLog.Name = "btnMoThuMucLog";
            btnMoThuMucLog.Size = new Size(114, 40);
            btnMoThuMucLog.TabIndex = 12;
            btnMoThuMucLog.Text = "📂 File Log";
            btnMoThuMucLog.UseVisualStyleBackColor = false;
            btnMoThuMucLog.Click += btnMoThuMucLog_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new Point(1034, 17);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(85, 40);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "🔄 Tải lại";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoc.BackColor = Color.FromArgb(2, 132, 199);
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(943, 17);
            btnLoc.Margin = new Padding(3, 4, 3, 4);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(85, 40);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "🔍 Tìm";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Segoe UI", 9.5F);
            txtTuKhoa.Location = new Point(777, 21);
            txtTuKhoa.Margin = new Padding(3, 4, 3, 4);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Tài khoản hoặc chi tiết...";
            txtTuKhoa.Size = new Size(154, 29);
            txtTuKhoa.TabIndex = 9;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTuKhoa.ForeColor = Color.FromArgb(51, 65, 85);
            lblTuKhoa.Location = new Point(718, 28);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(68, 20);
            lblTuKhoa.TabIndex = 8;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // cboHanhDong
            // 
            cboHanhDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHanhDong.Font = new Font("Segoe UI", 9F);
            cboHanhDong.FormattingEnabled = true;
            cboHanhDong.Location = new Point(571, 23);
            cboHanhDong.Margin = new Padding(3, 4, 3, 4);
            cboHanhDong.Name = "cboHanhDong";
            cboHanhDong.Size = new Size(137, 28);
            cboHanhDong.TabIndex = 7;
            // 
            // lblHanhDong
            // 
            lblHanhDong.AutoSize = true;
            lblHanhDong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHanhDong.ForeColor = Color.FromArgb(51, 65, 85);
            lblHanhDong.Location = new Point(494, 28);
            lblHanhDong.Name = "lblHanhDong";
            lblHanhDong.Size = new Size(90, 20);
            lblHanhDong.TabIndex = 6;
            lblHanhDong.Text = "Hành động:";
            // 
            // cboMucDo
            // 
            cboMucDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDo.Font = new Font("Segoe UI", 9F);
            cboMucDo.FormattingEnabled = true;
            cboMucDo.Location = new Point(377, 23);
            cboMucDo.Margin = new Padding(3, 4, 3, 4);
            cboMucDo.Name = "cboMucDo";
            cboMucDo.Size = new Size(108, 28);
            cboMucDo.TabIndex = 5;
            // 
            // lblMucDo
            // 
            lblMucDo.AutoSize = true;
            lblMucDo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMucDo.ForeColor = Color.FromArgb(51, 65, 85);
            lblMucDo.Location = new Point(320, 28);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new Size(65, 20);
            lblMucDo.TabIndex = 4;
            lblMucDo.Text = "Mức độ:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 9.5F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(206, 21);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(108, 29);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDenNgay.ForeColor = Color.FromArgb(51, 65, 85);
            lblDenNgay.Location = new Point(169, 28);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(41, 20);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 9.5F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(51, 21);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(108, 29);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTuNgay.ForeColor = Color.FromArgb(51, 65, 85);
            lblTuNgay.Location = new Point(21, 28);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(30, 20);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvNhatKy);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 162);
            pnlGridContainer.Margin = new Padding(3, 4, 3, 4);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(23, 27, 23, 27);
            pnlGridContainer.Size = new Size(1257, 665);
            pnlGridContainer.TabIndex = 2;
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AllowUserToResizeRows = false;
            dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.BackgroundColor = Color.White;
            dgvNhatKy.BorderStyle = BorderStyle.None;
            dgvNhatKy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhatKy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhatKy.ColumnHeadersHeight = 38;
            dgvNhatKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhatKy.Columns.AddRange(new DataGridViewColumn[] { colMaSo, colThoiGian, colTenDangNhap, colVaiTro, colMucDo, colHanhDong, colChiTiet, colDiaChiIP });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhatKy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhatKy.Dock = DockStyle.Fill;
            dgvNhatKy.EnableHeadersVisualStyles = false;
            dgvNhatKy.GridColor = Color.FromArgb(241, 245, 249);
            dgvNhatKy.Location = new Point(23, 27);
            dgvNhatKy.Margin = new Padding(3, 4, 3, 4);
            dgvNhatKy.MultiSelect = false;
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.ReadOnly = true;
            dgvNhatKy.RowHeadersVisible = false;
            dgvNhatKy.RowHeadersWidth = 51;
            dgvNhatKy.RowTemplate.Height = 36;
            dgvNhatKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhatKy.Size = new Size(1211, 611);
            dgvNhatKy.TabIndex = 0;
            dgvNhatKy.CellFormatting += dgvNhatKy_CellFormatting;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "Ma_So";
            colMaSo.FillWeight = 30F;
            colMaSo.HeaderText = "#";
            colMaSo.MinimumWidth = 6;
            colMaSo.Name = "colMaSo";
            colMaSo.ReadOnly = true;
            // 
            // colThoiGian
            // 
            colThoiGian.DataPropertyName = "Thoi_Gian";
            colThoiGian.FillWeight = 85F;
            colThoiGian.HeaderText = "Thời Gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "Ten_Dang_Nhap";
            colTenDangNhap.FillWeight = 65F;
            colTenDangNhap.HeaderText = "Tài Khoản";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "Vai_Tro";
            colVaiTro.FillWeight = 50F;
            colVaiTro.HeaderText = "Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            colVaiTro.ReadOnly = true;
            // 
            // colMucDo
            // 
            colMucDo.DataPropertyName = "Muc_Do";
            colMucDo.FillWeight = 60F;
            colMucDo.HeaderText = "Mức Độ";
            colMucDo.MinimumWidth = 6;
            colMucDo.Name = "colMucDo";
            colMucDo.ReadOnly = true;
            // 
            // colHanhDong
            // 
            colHanhDong.DataPropertyName = "Hanh_Dong";
            colHanhDong.FillWeight = 80F;
            colHanhDong.HeaderText = "Hành Động";
            colHanhDong.MinimumWidth = 6;
            colHanhDong.Name = "colHanhDong";
            colHanhDong.ReadOnly = true;
            // 
            // colChiTiet
            // 
            colChiTiet.DataPropertyName = "Chi_Tiet";
            colChiTiet.FillWeight = 190F;
            colChiTiet.HeaderText = "Nội Dung Thao Tác";
            colChiTiet.MinimumWidth = 6;
            colChiTiet.Name = "colChiTiet";
            colChiTiet.ReadOnly = true;
            // 
            // colDiaChiIP
            // 
            colDiaChiIP.DataPropertyName = "Dia_Chi_IP";
            colDiaChiIP.FillWeight = 60F;
            colDiaChiIP.HeaderText = "Địa Chỉ IP";
            colDiaChiIP.MinimumWidth = 6;
            colDiaChiIP.Name = "colDiaChiIP";
            colDiaChiIP.ReadOnly = true;
            // 
            // FormNhatKyHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1257, 827);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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