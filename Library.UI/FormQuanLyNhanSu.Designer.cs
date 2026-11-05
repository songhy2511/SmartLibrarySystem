namespace Library.UI
{
    partial class FormQuanLyNhanSu
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
            pnlToolbar = new System.Windows.Forms.Panel();
            btnThemThuThu = new System.Windows.Forms.Button();
            btnSuaThongTin = new System.Windows.Forms.Button();
            btnKhoaMoKhoa = new System.Windows.Forms.Button();
            btnResetMatKhau = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            lblTimKiem = new System.Windows.Forms.Label();
            pnlGridContainer = new System.Windows.Forms.Panel();
            dgvNhanSu = new System.Windows.Forms.DataGridView();
            colMaThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanSu).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(860, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(25, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(434, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Quản lý danh sách nhân sự thủ thư, khóa/mở khóa và cấp lại mật khẩu hệ thống";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(268, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHÂN SỰ THỦ THƯ";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = System.Drawing.Color.White;
            pnlToolbar.Controls.Add(btnThemThuThu);
            pnlToolbar.Controls.Add(btnSuaThongTin);
            pnlToolbar.Controls.Add(btnKhoaMoKhoa);
            pnlToolbar.Controls.Add(btnResetMatKhau);
            pnlToolbar.Controls.Add(btnLamMoi);
            pnlToolbar.Controls.Add(txtTimKiem);
            pnlToolbar.Controls.Add(lblTimKiem);
            pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlToolbar.Location = new System.Drawing.Point(0, 65);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            pnlToolbar.Size = new System.Drawing.Size(860, 55);
            pnlToolbar.TabIndex = 1;
            // 
            // btnThemThuThu
            // 
            btnThemThuThu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnThemThuThu.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnThemThuThu.FlatAppearance.BorderSize = 0;
            btnThemThuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemThuThu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnThemThuThu.ForeColor = System.Drawing.Color.White;
            btnThemThuThu.Location = new System.Drawing.Point(240, 11);
            btnThemThuThu.Name = "btnThemThuThu";
            btnThemThuThu.Size = new System.Drawing.Size(100, 32);
            btnThemThuThu.TabIndex = 2;
            btnThemThuThu.Text = "➕ Thêm Mới";
            btnThemThuThu.UseVisualStyleBackColor = false;
            btnThemThuThu.Click += btnThemThuThu_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSuaThongTin.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);
            btnSuaThongTin.FlatAppearance.BorderSize = 0;
            btnSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnSuaThongTin.ForeColor = System.Drawing.Color.White;
            btnSuaThongTin.Location = new System.Drawing.Point(348, 11);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new System.Drawing.Size(115, 32);
            btnSuaThongTin.TabIndex = 3;
            btnSuaThongTin.Text = "✏️ Sửa Hồ Sơ";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnKhoaMoKhoa
            // 
            btnKhoaMoKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnKhoaMoKhoa.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnKhoaMoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoaMoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKhoaMoKhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnKhoaMoKhoa.ForeColor = System.Drawing.Color.White;
            btnKhoaMoKhoa.Location = new System.Drawing.Point(471, 11);
            btnKhoaMoKhoa.Name = "btnKhoaMoKhoa";
            btnKhoaMoKhoa.Size = new System.Drawing.Size(135, 32);
            btnKhoaMoKhoa.TabIndex = 4;
            btnKhoaMoKhoa.Text = "🔒 Khóa / Mở";
            btnKhoaMoKhoa.UseVisualStyleBackColor = false;
            btnKhoaMoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnResetMatKhau
            // 
            btnResetMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnResetMatKhau.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnResetMatKhau.FlatAppearance.BorderSize = 0;
            btnResetMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnResetMatKhau.ForeColor = System.Drawing.Color.White;
            btnResetMatKhau.Location = new System.Drawing.Point(614, 11);
            btnResetMatKhau.Name = "btnResetMatKhau";
            btnResetMatKhau.Size = new System.Drawing.Size(125, 32);
            btnResetMatKhau.TabIndex = 5;
            btnResetMatKhau.Text = "🔑 Reset Pass";
            btnResetMatKhau.UseVisualStyleBackColor = false;
            btnResetMatKhau.Click += btnResetMatKhau_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new System.Drawing.Point(747, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(88, 32);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTimKiem.Location = new System.Drawing.Point(90, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên, mã...";
            txtTimKiem.Size = new System.Drawing.Size(140, 25);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTimKiem.Location = new System.Drawing.Point(25, 18);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(63, 17);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvNhanSu);
            pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridContainer.Location = new System.Drawing.Point(0, 120);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new System.Windows.Forms.Padding(25, 15, 25, 20);
            pnlGridContainer.Size = new System.Drawing.Size(860, 440);
            pnlGridContainer.TabIndex = 2;
            // 
            // dgvNhanSu
            // 
            dgvNhanSu.AllowUserToAddRows = false;
            dgvNhanSu.AllowUserToDeleteRows = false;
            dgvNhanSu.AllowUserToResizeRows = false;
            dgvNhanSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanSu.BackgroundColor = System.Drawing.Color.White;
            dgvNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvNhanSu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanSu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvNhanSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanSu.ColumnHeadersHeight = 40;
            dgvNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaThuThu, colTenDangNhap, colHoTen, colQuay, colDienThoai, colEmail, colTrangThai });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvNhanSu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNhanSu.EnableHeadersVisualStyles = false;
            dgvNhanSu.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvNhanSu.Location = new System.Drawing.Point(25, 15);
            dgvNhanSu.MultiSelect = false;
            dgvNhanSu.Name = "dgvNhanSu";
            dgvNhanSu.ReadOnly = true;
            dgvNhanSu.RowHeadersVisible = false;
            dgvNhanSu.RowTemplate.Height = 38;
            dgvNhanSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvNhanSu.Size = new System.Drawing.Size(810, 405);
            dgvNhanSu.TabIndex = 0;
            dgvNhanSu.CellDoubleClick += dgvNhanSu_CellDoubleClick;
            dgvNhanSu.CellFormatting += dgvNhanSu_CellFormatting;
            // 
            // colMaThuThu
            // 
            colMaThuThu.DataPropertyName = "Ma_Thu_Thu";
            colMaThuThu.FillWeight = 65F;
            colMaThuThu.HeaderText = "Mã NV";
            colMaThuThu.Name = "colMaThuThu";
            colMaThuThu.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "Ten_Dang_Nhap";
            colTenDangNhap.FillWeight = 80F;
            colTenDangNhap.HeaderText = "Tài khoản";
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "Ho_Ten";
            colHoTen.FillWeight = 110F;
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colQuay
            // 
            colQuay.DataPropertyName = "Quay_Phu_Trach";
            colQuay.FillWeight = 110F;
            colQuay.HeaderText = "Quầy phụ trách";
            colQuay.Name = "colQuay";
            colQuay.ReadOnly = true;
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "So_Dien_Thoai";
            colDienThoai.FillWeight = 75F;
            colDienThoai.HeaderText = "Số ĐT";
            colDienThoai.Name = "colDienThoai";
            colDienThoai.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.FillWeight = 110F;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "Dang_Hoat_Dong";
            colTrangThai.FillWeight = 75F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // FormQuanLyNhanSu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(860, 560);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormQuanLyNhanSu";
            Text = "Quản Lý Nhân Sự";
            Load += FormQuanLyNhanSu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemThuThu;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnKhoaMoKhoa;
        private System.Windows.Forms.Button btnResetMatKhau;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}