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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            lblSubTitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlInput = new System.Windows.Forms.Panel();
            btnThem = new System.Windows.Forms.Button();
            txtSoDienThoai = new System.Windows.Forms.TextBox();
            lblSoDienThoai = new System.Windows.Forms.Label();
            txtDiaChi = new System.Windows.Forms.TextBox();
            lblDiaChi = new System.Windows.Forms.Label();
            txtTenChiNhanh = new System.Windows.Forms.TextBox();
            lblTenChiNhanh = new System.Windows.Forms.Label();
            txtMaChiNhanh = new System.Windows.Forms.TextBox();
            lblMaChiNhanh = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvChiNhanh = new System.Windows.Forms.DataGridView();
            colMaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiNhanh).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(960, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(25, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(437, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Quản lý hệ thống mạng lưới thư viện và địa điểm phục vụ bạn đọc";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(262, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG CÁC CHI NHÁNH";
            // 
            // pnlInput
            // 
            pnlInput.BackColor = System.Drawing.Color.White;
            pnlInput.Controls.Add(btnThem);
            pnlInput.Controls.Add(txtSoDienThoai);
            pnlInput.Controls.Add(lblSoDienThoai);
            pnlInput.Controls.Add(txtDiaChi);
            pnlInput.Controls.Add(lblDiaChi);
            pnlInput.Controls.Add(txtTenChiNhanh);
            pnlInput.Controls.Add(lblTenChiNhanh);
            pnlInput.Controls.Add(txtMaChiNhanh);
            pnlInput.Controls.Add(lblMaChiNhanh);
            pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            pnlInput.Location = new System.Drawing.Point(0, 65);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new System.Windows.Forms.Padding(25);
            pnlInput.Size = new System.Drawing.Size(320, 535);
            pnlInput.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.Location = new System.Drawing.Point(25, 275);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(270, 40);
            btnThem.TabIndex = 8;
            btnThem.Text = "➕ THÊM CHI NHÁNH MỚI";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSoDienThoai.Location = new System.Drawing.Point(25, 225);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "0254.xxxxxxx";
            txtSoDienThoai.Size = new System.Drawing.Size(270, 24);
            txtSoDienThoai.TabIndex = 7;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSoDienThoai.Location = new System.Drawing.Point(25, 205);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new System.Drawing.Size(80, 15);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtDiaChi.Location = new System.Drawing.Point(25, 160);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Số nhà, tên đường, phường...";
            txtDiaChi.Size = new System.Drawing.Size(270, 24);
            txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDiaChi.Location = new System.Drawing.Point(25, 140);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(110, 15);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa điểm/Địa chỉ (*):";
            // 
            // txtTenChiNhanh
            // 
            txtTenChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTenChiNhanh.Location = new System.Drawing.Point(25, 95);
            txtTenChiNhanh.Name = "txtTenChiNhanh";
            txtTenChiNhanh.PlaceholderText = "Thư viện Cơ sở 2...";
            txtTenChiNhanh.Size = new System.Drawing.Size(270, 24);
            txtTenChiNhanh.TabIndex = 3;
            // 
            // lblTenChiNhanh
            // 
            lblTenChiNhanh.AutoSize = true;
            lblTenChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTenChiNhanh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTenChiNhanh.Location = new System.Drawing.Point(25, 75);
            lblTenChiNhanh.Name = "lblTenChiNhanh";
            lblTenChiNhanh.Size = new System.Drawing.Size(107, 15);
            lblTenChiNhanh.TabIndex = 2;
            lblTenChiNhanh.Text = "Tên chi nhánh (*):";
            // 
            // txtMaChiNhanh
            // 
            txtMaChiNhanh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            txtMaChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            txtMaChiNhanh.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);
            txtMaChiNhanh.Location = new System.Drawing.Point(25, 35);
            txtMaChiNhanh.Name = "txtMaChiNhanh";
            txtMaChiNhanh.ReadOnly = true;
            txtMaChiNhanh.Size = new System.Drawing.Size(270, 24);
            txtMaChiNhanh.TabIndex = 1;
            // 
            // lblMaChiNhanh
            // 
            lblMaChiNhanh.AutoSize = true;
            lblMaChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblMaChiNhanh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMaChiNhanh.Location = new System.Drawing.Point(25, 15);
            lblMaChiNhanh.Name = "lblMaChiNhanh";
            lblMaChiNhanh.Size = new System.Drawing.Size(125, 15);
            lblMaChiNhanh.TabIndex = 0;
            lblMaChiNhanh.Text = "Mã chi nhánh (Tự sinh):";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvChiNhanh);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(320, 65);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(20);
            pnlGrid.Size = new System.Drawing.Size(640, 535);
            pnlGrid.TabIndex = 2;
            // 
            // dgvChiNhanh
            // 
            dgvChiNhanh.AllowUserToAddRows = false;
            dgvChiNhanh.AllowUserToDeleteRows = false;
            dgvChiNhanh.AllowUserToResizeRows = false;
            dgvChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiNhanh.BackgroundColor = System.Drawing.Color.White;
            dgvChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvChiNhanh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiNhanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiNhanh.ColumnHeadersHeight = 38;
            dgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaChiNhanh, colTenChiNhanh, colDiaChi, colSoDienThoai, colTrangThai });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvChiNhanh.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvChiNhanh.EnableHeadersVisualStyles = false;
            dgvChiNhanh.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvChiNhanh.Location = new System.Drawing.Point(20, 20);
            dgvChiNhanh.MultiSelect = false;
            dgvChiNhanh.Name = "dgvChiNhanh";
            dgvChiNhanh.ReadOnly = true;
            dgvChiNhanh.RowHeadersVisible = false;
            dgvChiNhanh.RowTemplate.Height = 36;
            dgvChiNhanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvChiNhanh.Size = new System.Drawing.Size(600, 495);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            ClientSize = new System.Drawing.Size(960, 600);
            Controls.Add(pnlGrid);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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