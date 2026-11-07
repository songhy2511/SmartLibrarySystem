namespace Library.UI
{
    partial class FormQuanLyChiNhanh
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
            pnlInput = new Panel();
            btnThem = new Button();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtTenChiNhanh = new TextBox();
            lblTenChiNhanh = new Label();
            txtMaChiNhanh = new TextBox();
            lblMaChiNhanh = new Label();
            pnlGrid = new Panel();
            dgvChiNhanh = new DataGridView();
            colMaChiNhanh = new DataGridViewTextBoxColumn();
            colTenChiNhanh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiNhanh).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(25, 15, 25, 15);
            pnlHeader.Size = new Size(960, 65);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(25, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(358, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Quản lý hệ thống mạng lưới thư viện và địa điểm phục vụ bạn đọc";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG CÁC CHI NHÁNH";
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(btnThem);
            pnlInput.Controls.Add(txtSoDienThoai);
            pnlInput.Controls.Add(lblSoDienThoai);
            pnlInput.Controls.Add(txtDiaChi);
            pnlInput.Controls.Add(lblDiaChi);
            pnlInput.Controls.Add(txtTenChiNhanh);
            pnlInput.Controls.Add(lblTenChiNhanh);
            pnlInput.Controls.Add(txtMaChiNhanh);
            pnlInput.Controls.Add(lblMaChiNhanh);
            pnlInput.Dock = DockStyle.Left;
            pnlInput.Location = new Point(0, 65);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(25);
            pnlInput.Size = new Size(320, 535);
            pnlInput.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(2, 132, 199);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 275);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(270, 40);
            btnThem.TabIndex = 8;
            btnThem.Text = "➕ THÊM CHI NHÁNH MỚI";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 9.5F);
            txtSoDienThoai.Location = new Point(25, 225);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "0254.xxxxxxx";
            txtSoDienThoai.Size = new Size(270, 24);
            txtSoDienThoai.TabIndex = 7;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoDienThoai.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoDienThoai.Location = new Point(25, 205);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(80, 15);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 9.5F);
            txtDiaChi.Location = new Point(25, 160);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Số nhà, tên đường, phường...";
            txtDiaChi.Size = new Size(270, 24);
            txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDiaChi.ForeColor = Color.FromArgb(51, 65, 85);
            lblDiaChi.Location = new Point(25, 140);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(116, 15);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa điểm/Địa chỉ (*):";
            // 
            // txtTenChiNhanh
            // 
            txtTenChiNhanh.Font = new Font("Segoe UI", 9.5F);
            txtTenChiNhanh.Location = new Point(25, 95);
            txtTenChiNhanh.Name = "txtTenChiNhanh";
            txtTenChiNhanh.PlaceholderText = "Thư viện Cơ sở 2...";
            txtTenChiNhanh.Size = new Size(270, 24);
            txtTenChiNhanh.TabIndex = 3;
            // 
            // lblTenChiNhanh
            // 
            lblTenChiNhanh.AutoSize = true;
            lblTenChiNhanh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTenChiNhanh.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenChiNhanh.Location = new Point(25, 75);
            lblTenChiNhanh.Name = "lblTenChiNhanh";
            lblTenChiNhanh.Size = new Size(101, 15);
            lblTenChiNhanh.TabIndex = 2;
            lblTenChiNhanh.Text = "Tên chi nhánh (*):";
            // 
            // txtMaChiNhanh
            // 
            txtMaChiNhanh.BackColor = Color.FromArgb(241, 245, 249);
            txtMaChiNhanh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            txtMaChiNhanh.ForeColor = Color.FromArgb(2, 132, 199);
            txtMaChiNhanh.Location = new Point(25, 35);
            txtMaChiNhanh.Name = "txtMaChiNhanh";
            txtMaChiNhanh.ReadOnly = true;
            txtMaChiNhanh.Size = new Size(270, 24);
            txtMaChiNhanh.TabIndex = 1;
            // 
            // lblMaChiNhanh
            // 
            lblMaChiNhanh.AutoSize = true;
            lblMaChiNhanh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMaChiNhanh.ForeColor = Color.FromArgb(51, 65, 85);
            lblMaChiNhanh.Location = new Point(25, 15);
            lblMaChiNhanh.Name = "lblMaChiNhanh";
            lblMaChiNhanh.Size = new Size(133, 15);
            lblMaChiNhanh.TabIndex = 0;
            lblMaChiNhanh.Text = "Mã chi nhánh (Tự sinh):";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvChiNhanh);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(320, 65);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(20);
            pnlGrid.Size = new Size(640, 535);
            pnlGrid.TabIndex = 2;
            // 
            // dgvChiNhanh
            // 
            dgvChiNhanh.AllowUserToAddRows = false;
            dgvChiNhanh.AllowUserToDeleteRows = false;
            dgvChiNhanh.AllowUserToResizeRows = false;
            dgvChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiNhanh.BackgroundColor = Color.White;
            dgvChiNhanh.BorderStyle = BorderStyle.None;
            dgvChiNhanh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiNhanh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiNhanh.ColumnHeadersHeight = 38;
            dgvChiNhanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiNhanh.Columns.AddRange(new DataGridViewColumn[] { colMaChiNhanh, colTenChiNhanh, colDiaChi, colSoDienThoai, colTrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiNhanh.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiNhanh.Dock = DockStyle.Fill;
            dgvChiNhanh.EnableHeadersVisualStyles = false;
            dgvChiNhanh.GridColor = Color.FromArgb(241, 245, 249);
            dgvChiNhanh.Location = new Point(20, 20);
            dgvChiNhanh.MultiSelect = false;
            dgvChiNhanh.Name = "dgvChiNhanh";
            dgvChiNhanh.ReadOnly = true;
            dgvChiNhanh.RowHeadersVisible = false;
            dgvChiNhanh.RowTemplate.Height = 36;
            dgvChiNhanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiNhanh.Size = new Size(600, 495);
            dgvChiNhanh.TabIndex = 0;
            // 
            // colMaChiNhanh
            // 
            colMaChiNhanh.DataPropertyName = "Ma_Chi_Nhanh";
            colMaChiNhanh.FillWeight = 50F;
            colMaChiNhanh.HeaderText = "Mã";
            colMaChiNhanh.Name = "colMaChiNhanh";
            colMaChiNhanh.ReadOnly = true;
            // 
            // colTenChiNhanh
            // 
            colTenChiNhanh.DataPropertyName = "Ten_Chi_Nhanh";
            colTenChiNhanh.FillWeight = 110F;
            colTenChiNhanh.HeaderText = "Tên Chi Nhánh";
            colTenChiNhanh.Name = "colTenChiNhanh";
            colTenChiNhanh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "Dia_Chi";
            colDiaChi.FillWeight = 140F;
            colDiaChi.HeaderText = "Địa Điểm / Địa Chỉ";
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "So_Dien_Thoai";
            colSoDienThoai.FillWeight = 70F;
            colSoDienThoai.HeaderText = "Số ĐT";
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "Dang_Hoat_Dong";
            colTrangThai.FillWeight = 60F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // FormQuanLyChiNhanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(960, 600);
            Controls.Add(pnlGrid);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQuanLyChiNhanh";
            Text = "Quản Lý Chi Nhánh";
            Load += FormQuanLyChiNhanh_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiNhanh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblMaChiNhanh;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.Label lblTenChiNhanh;
        private System.Windows.Forms.TextBox txtTenChiNhanh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}