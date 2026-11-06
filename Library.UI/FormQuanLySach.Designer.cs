namespace Library.UI
{
    partial class FormQuanLySach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabKhoChiNhanh = new System.Windows.Forms.TabPage();
            this.dgvKhoChiNhanh = new System.Windows.Forms.DataGridView();
            this.colKS_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_TongBanSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_DangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_SanCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKS_BaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlKhoBottom = new System.Windows.Forms.Panel();
            this.btnThanhLyCuon = new System.Windows.Forms.Button();
            this.lblHuongDanKho = new System.Windows.Forms.Label();
            this.pnlKhoKPI = new System.Windows.Forms.Panel();
            this.pnlBaoTriCN = new System.Windows.Forms.Panel();
            this.lblBaoTriCNVal = new System.Windows.Forms.Label();
            this.lblBaoTriCNTitle = new System.Windows.Forms.Label();
            this.pnlSanCoCN = new System.Windows.Forms.Panel();
            this.lblSanCoCNVal = new System.Windows.Forms.Label();
            this.lblSanCoCNTitle = new System.Windows.Forms.Label();
            this.pnlDangMuonCN = new System.Windows.Forms.Panel();
            this.lblDangMuonCNVal = new System.Windows.Forms.Label();
            this.lblDangMuonCNTitle = new System.Windows.Forms.Label();
            this.pnlTongBanSaoCN = new System.Windows.Forms.Panel();
            this.lblTongBanSaoCNVal = new System.Windows.Forms.Label();
            this.lblTongBanSaoCNTitle = new System.Windows.Forms.Label();
            this.pnlTongDauSachCN = new System.Windows.Forms.Panel();
            this.lblTongDauSachCNVal = new System.Windows.Forms.Label();
            this.lblTongDauSachCNTitle = new System.Windows.Forms.Label();
            this.pnlKhoFilter = new System.Windows.Forms.Panel();
            this.btnTaiLaiKho = new System.Windows.Forms.Button();
            this.txtTimKiemKho = new System.Windows.Forms.TextBox();
            this.lblTimKiemKho = new System.Windows.Forms.Label();
            this.cboChiNhanhKho = new System.Windows.Forms.ComboBox();
            this.lblChonChiNhanh = new System.Windows.Forms.Label();
            this.tabDanhMucSach = new System.Windows.Forms.TabPage();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnDeXuatThanhLy = new System.Windows.Forms.Button();
            this.btnCapNhatKho = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.nudTongSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabKhoChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoChiNhanh)).BeginInit();
            this.pnlKhoBottom.SuspendLayout();
            this.pnlKhoKPI.SuspendLayout();
            this.pnlBaoTriCN.SuspendLayout();
            this.pnlSanCoCN.SuspendLayout();
            this.pnlDangMuonCN.SuspendLayout();
            this.pnlTongBanSaoCN.SuspendLayout();
            this.pnlTongDauSachCN.SuspendLayout();
            this.pnlKhoFilter.SuspendLayout();
            this.tabDanhMucSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1060, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubTitle.Location = new System.Drawing.Point(25, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(580, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Giám sát số lượng sách thực tế tại chi nhánh trực, kiểm kê bản sao lưu hành và biên mục danh mục sách";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(23, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHO SÁCH & BẢN SAO THEO CHI NHÁNH";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabKhoChiNhanh);
            this.tabControlMain.Controls.Add(this.tabDanhMucSach);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabControlMain.Location = new System.Drawing.Point(0, 65);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1060, 605);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabKhoChiNhanh
            // 
            this.tabKhoChiNhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabKhoChiNhanh.Controls.Add(this.dgvKhoChiNhanh);
            this.tabKhoChiNhanh.Controls.Add(this.pnlKhoBottom);
            this.tabKhoChiNhanh.Controls.Add(this.pnlKhoKPI);
            this.tabKhoChiNhanh.Controls.Add(this.pnlKhoFilter);
            this.tabKhoChiNhanh.Location = new System.Drawing.Point(4, 26);
            this.tabKhoChiNhanh.Name = "tabKhoChiNhanh";
            this.tabKhoChiNhanh.Padding = new System.Windows.Forms.Padding(15);
            this.tabKhoChiNhanh.Size = new System.Drawing.Size(1052, 575);
            this.tabKhoChiNhanh.TabIndex = 0;
            this.tabKhoChiNhanh.Text = " 🏢 Kho Sách Theo Chi Nhánh ";
            // 
            // dgvKhoChiNhanh
            // 
            this.dgvKhoChiNhanh.AllowUserToAddRows = false;
            this.dgvKhoChiNhanh.AllowUserToDeleteRows = false;
            this.dgvKhoChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoChiNhanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhoChiNhanh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhoChiNhanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoChiNhanh.ColumnHeadersHeight = 36;
            this.dgvKhoChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKS_MaSach,
            this.colKS_TieuDe,
            this.colKS_TheLoai,
            this.colKS_TacGia,
            this.colKS_TongBanSao,
            this.colKS_DangMuon,
            this.colKS_SanCo,
            this.colKS_BaoTri});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoChiNhanh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhoChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoChiNhanh.EnableHeadersVisualStyles = false;
            this.dgvKhoChiNhanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvKhoChiNhanh.Location = new System.Drawing.Point(15, 137);
            this.dgvKhoChiNhanh.MultiSelect = false;
            this.dgvKhoChiNhanh.Name = "dgvKhoChiNhanh";
            this.dgvKhoChiNhanh.ReadOnly = true;
            this.dgvKhoChiNhanh.RowHeadersVisible = false;
            this.dgvKhoChiNhanh.RowTemplate.Height = 34;
            this.dgvKhoChiNhanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoChiNhanh.Size = new System.Drawing.Size(1022, 375);
            this.dgvKhoChiNhanh.TabIndex = 2;
            // 
            // colKS_MaSach
            // 
            this.colKS_MaSach.DataPropertyName = "Ma_Sach";
            this.colKS_MaSach.FillWeight = 50F;
            this.colKS_MaSach.HeaderText = "Mã Sách";
            this.colKS_MaSach.Name = "colKS_MaSach";
            this.colKS_MaSach.ReadOnly = true;
            // 
            // colKS_TieuDe
            // 
            this.colKS_TieuDe.DataPropertyName = "Tieu_De";
            this.colKS_TieuDe.FillWeight = 160F;
            this.colKS_TieuDe.HeaderText = "Tên Đầu Sách";
            this.colKS_TieuDe.Name = "colKS_TieuDe";
            this.colKS_TieuDe.ReadOnly = true;
            // 
            // colKS_TheLoai
            // 
            this.colKS_TheLoai.DataPropertyName = "The_Loai";
            this.colKS_TheLoai.FillWeight = 85F;
            this.colKS_TheLoai.HeaderText = "Thể Loại";
            this.colKS_TheLoai.Name = "colKS_TheLoai";
            this.colKS_TheLoai.ReadOnly = true;
            // 
            // colKS_TacGia
            // 
            this.colKS_TacGia.DataPropertyName = "Tac_Gia";
            this.colKS_TacGia.FillWeight = 85F;
            this.colKS_TacGia.HeaderText = "Tác Giả";
            this.colKS_TacGia.Name = "colKS_TacGia";
            this.colKS_TacGia.ReadOnly = true;
            // 
            // colKS_TongBanSao
            // 
            this.colKS_TongBanSao.DataPropertyName = "Tong_Ban_Sao";
            this.colKS_TongBanSao.FillWeight = 65F;
            this.colKS_TongBanSao.HeaderText = "Tổng Tại CN";
            this.colKS_TongBanSao.Name = "colKS_TongBanSao";
            this.colKS_TongBanSao.ReadOnly = true;
            // 
            // colKS_DangMuon
            // 
            this.colKS_DangMuon.DataPropertyName = "Dang_Muon";
            this.colKS_DangMuon.FillWeight = 60F;
            this.colKS_DangMuon.HeaderText = "Đang Mượn";
            this.colKS_DangMuon.Name = "colKS_DangMuon";
            this.colKS_DangMuon.ReadOnly = true;
            // 
            // colKS_SanCo
            // 
            this.colKS_SanCo.DataPropertyName = "San_Co";
            this.colKS_SanCo.FillWeight = 60F;
            this.colKS_SanCo.HeaderText = "Có Sẵn Kệ";
            this.colKS_SanCo.Name = "colKS_SanCo";
            this.colKS_SanCo.ReadOnly = true;
            // 
            // colKS_BaoTri
            // 
            this.colKS_BaoTri.DataPropertyName = "Bao_Tri";
            this.colKS_BaoTri.FillWeight = 55F;
            this.colKS_BaoTri.HeaderText = "Bảo Trì / Hỏng";
            this.colKS_BaoTri.Name = "colKS_BaoTri";
            this.colKS_BaoTri.ReadOnly = true;
            // 
            // pnlKhoBottom
            // 
            this.pnlKhoBottom.BackColor = System.Drawing.Color.White;
            this.pnlKhoBottom.Controls.Add(this.btnThanhLyCuon);
            this.pnlKhoBottom.Controls.Add(this.lblHuongDanKho);
            this.pnlKhoBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKhoBottom.Location = new System.Drawing.Point(15, 512);
            this.pnlKhoBottom.Name = "pnlKhoBottom";
            this.pnlKhoBottom.Size = new System.Drawing.Size(1022, 48);
            this.pnlKhoBottom.TabIndex = 3;
            // 
            // btnThanhLyCuon
            // 
            this.btnThanhLyCuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhLyCuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnThanhLyCuon.FlatAppearance.BorderSize = 0;
            this.btnThanhLyCuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhLyCuon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhLyCuon.ForeColor = System.Drawing.Color.White;
            this.btnThanhLyCuon.Location = new System.Drawing.Point(800, 8);
            this.btnThanhLyCuon.Name = "btnThanhLyCuon";
            this.btnThanhLyCuon.Size = new System.Drawing.Size(210, 32);
            this.btnThanhLyCuon.TabIndex = 1;
            this.btnThanhLyCuon.Text = "🗑️ Thanh Lý 1 Cuốn Hư Hỏng";
            this.btnThanhLyCuon.UseVisualStyleBackColor = false;
            this.btnThanhLyCuon.Click += new System.EventHandler(this.btnThanhLyCuon_Click);
            // 
            // lblHuongDanKho
            // 
            this.lblHuongDanKho.AutoSize = true;
            this.lblHuongDanKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHuongDanKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHuongDanKho.Location = new System.Drawing.Point(12, 16);
            this.lblHuongDanKho.Name = "lblHuongDanKho";
            this.lblHuongDanKho.Size = new System.Drawing.Size(564, 15);
            this.lblHuongDanKho.TabIndex = 0;
            this.lblHuongDanKho.Text = "* Chọn 1 đầu sách trong bảng để theo dõi số lượng sẵn sàng trên kệ hoặc lập biên bản thanh lý bản sao rác" +
    "h/hỏng.";
            // 
            // pnlKhoKPI
            // 
            this.pnlKhoKPI.Controls.Add(this.pnlBaoTriCN);
            this.pnlKhoKPI.Controls.Add(this.pnlSanCoCN);
            this.pnlKhoKPI.Controls.Add(this.pnlDangMuonCN);
            this.pnlKhoKPI.Controls.Add(this.pnlTongBanSaoCN);
            this.pnlKhoKPI.Controls.Add(this.pnlTongDauSachCN);
            this.pnlKhoKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhoKPI.Location = new System.Drawing.Point(15, 67);
            this.pnlKhoKPI.Name = "pnlKhoKPI";
            this.pnlKhoKPI.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.pnlKhoKPI.Size = new System.Drawing.Size(1022, 70);
            this.pnlKhoKPI.TabIndex = 1;
            // 
            // pnlBaoTriCN
            // 
            this.pnlBaoTriCN.BackColor = System.Drawing.Color.White;
            this.pnlBaoTriCN.Controls.Add(this.lblBaoTriCNVal);
            this.pnlBaoTriCN.Controls.Add(this.lblBaoTriCNTitle);
            this.pnlBaoTriCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBaoTriCN.Location = new System.Drawing.Point(760, 8);
            this.pnlBaoTriCN.Name = "pnlBaoTriCN";
            this.pnlBaoTriCN.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBaoTriCN.Size = new System.Drawing.Size(190, 54);
            this.pnlBaoTriCN.TabIndex = 4;
            // 
            // lblBaoTriCNVal
            // 
            this.lblBaoTriCNVal.AutoSize = true;
            this.lblBaoTriCNVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBaoTriCNVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.lblBaoTriCNVal.Location = new System.Drawing.Point(10, 22);
            this.lblBaoTriCNVal.Name = "lblBaoTriCNVal";
            this.lblBaoTriCNVal.Size = new System.Drawing.Size(22, 25);
            this.lblBaoTriCNVal.TabIndex = 1;
            this.lblBaoTriCNVal.Text = "0";
            // 
            // lblBaoTriCNTitle
            // 
            this.lblBaoTriCNTitle.AutoSize = true;
            this.lblBaoTriCNTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBaoTriCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBaoTriCNTitle.Location = new System.Drawing.Point(10, 6);
            this.lblBaoTriCNTitle.Name = "lblBaoTriCNTitle";
            this.lblBaoTriCNTitle.Size = new System.Drawing.Size(95, 13);
            this.lblBaoTriCNTitle.TabIndex = 0;
            this.lblBaoTriCNTitle.Text = "BẢO TRÌ / HỎNG";
            // 
            // pnlSanCoCN
            // 
            this.pnlSanCoCN.BackColor = System.Drawing.Color.White;
            this.pnlSanCoCN.Controls.Add(this.lblSanCoCNVal);
            this.pnlSanCoCN.Controls.Add(this.lblSanCoCNTitle);
            this.pnlSanCoCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSanCoCN.Location = new System.Drawing.Point(570, 8);
            this.pnlSanCoCN.Name = "pnlSanCoCN";
            this.pnlSanCoCN.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSanCoCN.Size = new System.Drawing.Size(190, 54);
            this.pnlSanCoCN.TabIndex = 3;
            // 
            // lblSanCoCNVal
            // 
            this.lblSanCoCNVal.AutoSize = true;
            this.lblSanCoCNVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSanCoCNVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblSanCoCNVal.Location = new System.Drawing.Point(10, 22);
            this.lblSanCoCNVal.Name = "lblSanCoCNVal";
            this.lblSanCoCNVal.Size = new System.Drawing.Size(22, 25);
            this.lblSanCoCNVal.TabIndex = 1;
            this.lblSanCoCNVal.Text = "0";
            // 
            // lblSanCoCNTitle
            // 
            this.lblSanCoCNTitle.AutoSize = true;
            this.lblSanCoCNTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSanCoCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSanCoCNTitle.Location = new System.Drawing.Point(10, 6);
            this.lblSanCoCNTitle.Name = "lblSanCoCNTitle";
            this.lblSanCoCNTitle.Size = new System.Drawing.Size(107, 13);
            this.lblSanCoCNTitle.TabIndex = 0;
            this.lblSanCoCNTitle.Text = "SẴN SÀNG TRÊN KỆ";
            // 
            // pnlDangMuonCN
            // 
            this.pnlDangMuonCN.BackColor = System.Drawing.Color.White;
            this.pnlDangMuonCN.Controls.Add(this.lblDangMuonCNVal);
            this.pnlDangMuonCN.Controls.Add(this.lblDangMuonCNTitle);
            this.pnlDangMuonCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDangMuonCN.Location = new System.Drawing.Point(380, 8);
            this.pnlDangMuonCN.Name = "pnlDangMuonCN";
            this.pnlDangMuonCN.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDangMuonCN.Size = new System.Drawing.Size(190, 54);
            this.pnlDangMuonCN.TabIndex = 2;
            // 
            // lblDangMuonCNVal
            // 
            this.lblDangMuonCNVal.AutoSize = true;
            this.lblDangMuonCNVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDangMuonCNVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblDangMuonCNVal.Location = new System.Drawing.Point(10, 22);
            this.lblDangMuonCNVal.Name = "lblDangMuonCNVal";
            this.lblDangMuonCNVal.Size = new System.Drawing.Size(22, 25);
            this.lblDangMuonCNVal.TabIndex = 1;
            this.lblDangMuonCNVal.Text = "0";
            // 
            // lblDangMuonCNTitle
            // 
            this.lblDangMuonCNTitle.AutoSize = true;
            this.lblDangMuonCNTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDangMuonCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDangMuonCNTitle.Location = new System.Drawing.Point(10, 6);
            this.lblDangMuonCNTitle.Name = "lblDangMuonCNTitle";
            this.lblDangMuonCNTitle.Size = new System.Drawing.Size(107, 13);
            this.lblDangMuonCNTitle.TabIndex = 0;
            this.lblDangMuonCNTitle.Text = "ĐANG CHO MƯỢN";
            // 
            // pnlTongBanSaoCN
            // 
            this.pnlTongBanSaoCN.BackColor = System.Drawing.Color.White;
            this.pnlTongBanSaoCN.Controls.Add(this.lblTongBanSaoCNVal);
            this.pnlTongBanSaoCN.Controls.Add(this.lblTongBanSaoCNTitle);
            this.pnlTongBanSaoCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTongBanSaoCN.Location = new System.Drawing.Point(190, 8);
            this.pnlTongBanSaoCN.Name = "pnlTongBanSaoCN";
            this.pnlTongBanSaoCN.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTongBanSaoCN.Size = new System.Drawing.Size(190, 54);
            this.pnlTongBanSaoCN.TabIndex = 1;
            // 
            // lblTongBanSaoCNVal
            // 
            this.lblTongBanSaoCNVal.AutoSize = true;
            this.lblTongBanSaoCNVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongBanSaoCNVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lblTongBanSaoCNVal.Location = new System.Drawing.Point(10, 22);
            this.lblTongBanSaoCNVal.Name = "lblTongBanSaoCNVal";
            this.lblTongBanSaoCNVal.Size = new System.Drawing.Size(22, 25);
            this.lblTongBanSaoCNVal.TabIndex = 1;
            this.lblTongBanSaoCNVal.Text = "0";
            // 
            // lblTongBanSaoCNTitle
            // 
            this.lblTongBanSaoCNTitle.AutoSize = true;
            this.lblTongBanSaoCNTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTongBanSaoCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTongBanSaoCNTitle.Location = new System.Drawing.Point(10, 6);
            this.lblTongBanSaoCNTitle.Name = "lblTongBanSaoCNTitle";
            this.lblTongBanSaoCNTitle.Size = new System.Drawing.Size(129, 13);
            this.lblTongBanSaoCNTitle.TabIndex = 0;
            this.lblTongBanSaoCNTitle.Text = "TỔNG BẢN SAO TẠI CN";
            // 
            // pnlTongDauSachCN
            // 
            this.pnlTongDauSachCN.BackColor = System.Drawing.Color.White;
            this.pnlTongDauSachCN.Controls.Add(this.lblTongDauSachCNVal);
            this.pnlTongDauSachCN.Controls.Add(this.lblTongDauSachCNTitle);
            this.pnlTongDauSachCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTongDauSachCN.Location = new System.Drawing.Point(0, 8);
            this.pnlTongDauSachCN.Name = "pnlTongDauSachCN";
            this.pnlTongDauSachCN.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTongDauSachCN.Size = new System.Drawing.Size(190, 54);
            this.pnlTongDauSachCN.TabIndex = 0;
            // 
            // lblTongDauSachCNVal
            // 
            this.lblTongDauSachCNVal.AutoSize = true;
            this.lblTongDauSachCNVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongDauSachCNVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTongDauSachCNVal.Location = new System.Drawing.Point(10, 22);
            this.lblTongDauSachCNVal.Name = "lblTongDauSachCNVal";
            this.lblTongDauSachCNVal.Size = new System.Drawing.Size(22, 25);
            this.lblTongDauSachCNVal.TabIndex = 1;
            this.lblTongDauSachCNVal.Text = "0";
            // 
            // lblTongDauSachCNTitle
            // 
            this.lblTongDauSachCNTitle.AutoSize = true;
            this.lblTongDauSachCNTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTongDauSachCNTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTongDauSachCNTitle.Location = new System.Drawing.Point(10, 6);
            this.lblTongDauSachCNTitle.Name = "lblTongDauSachCNTitle";
            this.lblTongDauSachCNTitle.Size = new System.Drawing.Size(97, 13);
            this.lblTongDauSachCNTitle.TabIndex = 0;
            this.lblTongDauSachCNTitle.Text = "TỔNG ĐẦU SÁCH";
            // 
            // pnlKhoFilter
            // 
            this.pnlKhoFilter.BackColor = System.Drawing.Color.White;
            this.pnlKhoFilter.Controls.Add(this.btnTaiLaiKho);
            this.pnlKhoFilter.Controls.Add(this.txtTimKiemKho);
            this.pnlKhoFilter.Controls.Add(this.lblTimKiemKho);
            this.pnlKhoFilter.Controls.Add(this.cboChiNhanhKho);
            this.pnlKhoFilter.Controls.Add(this.lblChonChiNhanh);
            this.pnlKhoFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhoFilter.Location = new System.Drawing.Point(15, 15);
            this.pnlKhoFilter.Name = "pnlKhoFilter";
            this.pnlKhoFilter.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlKhoFilter.Size = new System.Drawing.Size(1022, 52);
            this.pnlKhoFilter.TabIndex = 0;
            // 
            // btnTaiLaiKho
            // 
            this.btnTaiLaiKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnTaiLaiKho.FlatAppearance.BorderSize = 0;
            this.btnTaiLaiKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLaiKho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiLaiKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnTaiLaiKho.Location = new System.Drawing.Point(745, 12);
            this.btnTaiLaiKho.Name = "btnTaiLaiKho";
            this.btnTaiLaiKho.Size = new System.Drawing.Size(85, 28);
            this.btnTaiLaiKho.TabIndex = 4;
            this.btnTaiLaiKho.Text = "🔄 Làm Mới";
            this.btnTaiLaiKho.UseVisualStyleBackColor = false;
            this.btnTaiLaiKho.Click += new System.EventHandler(this.btnTaiLaiKho_Click);
            // 
            // txtTimKiemKho
            // 
            this.txtTimKiemKho.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiemKho.Location = new System.Drawing.Point(480, 14);
            this.txtTimKiemKho.Name = "txtTimKiemKho";
            this.txtTimKiemKho.PlaceholderText = "Tên sách, tác giả, mã sách...";
            this.txtTimKiemKho.Size = new System.Drawing.Size(250, 24);
            this.txtTimKiemKho.TabIndex = 3;
            this.txtTimKiemKho.TextChanged += new System.EventHandler(this.txtTimKiemKho_TextChanged);
            // 
            // lblTimKiemKho
            // 
            this.lblTimKiemKho.AutoSize = true;
            this.lblTimKiemKho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiemKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTimKiemKho.Location = new System.Drawing.Point(415, 18);
            this.lblTimKiemKho.Name = "lblTimKiemKho";
            this.lblTimKiemKho.Size = new System.Drawing.Size(58, 15);
            this.lblTimKiemKho.TabIndex = 2;
            this.lblTimKiemKho.Text = "Tìm Sách:";
            // 
            // cboChiNhanhKho
            // 
            this.cboChiNhanhKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanhKho.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboChiNhanhKho.FormattingEnabled = true;
            this.cboChiNhanhKho.Location = new System.Drawing.Point(145, 14);
            this.cboChiNhanhKho.Name = "cboChiNhanhKho";
            this.cboChiNhanhKho.Size = new System.Drawing.Size(250, 25);
            this.cboChiNhanhKho.TabIndex = 1;
            this.cboChiNhanhKho.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanhKho_SelectedIndexChanged);
            // 
            // lblChonChiNhanh
            // 
            this.lblChonChiNhanh.AutoSize = true;
            this.lblChonChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblChonChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblChonChiNhanh.Location = new System.Drawing.Point(15, 18);
            this.lblChonChiNhanh.Name = "lblChonChiNhanh";
            this.lblChonChiNhanh.Size = new System.Drawing.Size(124, 15);
            this.lblChonChiNhanh.TabIndex = 0;
            this.lblChonChiNhanh.Text = "Chi Nhánh Đang Trực:";
            // 
            // tabDanhMucSach
            // 
            this.tabDanhMucSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabDanhMucSach.Controls.Add(this.dgvSach);
            this.tabDanhMucSach.Controls.Add(this.pnlInput);
            this.tabDanhMucSach.Location = new System.Drawing.Point(4, 26);
            this.tabDanhMucSach.Name = "tabDanhMucSach";
            this.tabDanhMucSach.Padding = new System.Windows.Forms.Padding(15);
            this.tabDanhMucSach.Size = new System.Drawing.Size(1052, 575);
            this.tabDanhMucSach.TabIndex = 1;
            this.tabDanhMucSach.Text = " 📖 Danh Mục Biểu Ghi & Nhập Mới ";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.ColumnHeadersHeight = 36;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvSach.Location = new System.Drawing.Point(15, 175);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowTemplate.Height = 34;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1022, 385);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnXoaSach);
            this.pnlInput.Controls.Add(this.btnDeXuatThanhLy);
            this.pnlInput.Controls.Add(this.btnCapNhatKho);
            this.pnlInput.Controls.Add(this.btnThemSach);
            this.pnlInput.Controls.Add(this.btnTimKiem);
            this.pnlInput.Controls.Add(this.txtTimKiem);
            this.pnlInput.Controls.Add(this.lblTimKiem);
            this.pnlInput.Controls.Add(this.nudTongSoLuong);
            this.pnlInput.Controls.Add(this.lblTongSoLuong);
            this.pnlInput.Controls.Add(this.txtViTri);
            this.pnlInput.Controls.Add(this.lblViTri);
            this.pnlInput.Controls.Add(this.txtTheLoai);
            this.pnlInput.Controls.Add(this.lblTheLoai);
            this.pnlInput.Controls.Add(this.txtTacGia);
            this.pnlInput.Controls.Add(this.lblTacGia);
            this.pnlInput.Controls.Add(this.txtTenSach);
            this.pnlInput.Controls.Add(this.lblTenSach);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(15, 15);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(1022, 160);
            this.pnlInput.TabIndex = 0;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnXoaSach.FlatAppearance.BorderSize = 0;
            this.btnXoaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnXoaSach.Location = new System.Drawing.Point(540, 118);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(110, 32);
            this.btnXoaSach.TabIndex = 16;
            this.btnXoaSach.Text = "🗑️ Xóa Biểu Ghi";
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnDeXuatThanhLy
            // 
            this.btnDeXuatThanhLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnDeXuatThanhLy.FlatAppearance.BorderSize = 0;
            this.btnDeXuatThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeXuatThanhLy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeXuatThanhLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnDeXuatThanhLy.Location = new System.Drawing.Point(380, 118);
            this.btnDeXuatThanhLy.Name = "btnDeXuatThanhLy";
            this.btnDeXuatThanhLy.Size = new System.Drawing.Size(145, 32);
            this.btnDeXuatThanhLy.TabIndex = 15;
            this.btnDeXuatThanhLy.Text = "⚠️ Thanh Lý 1 Cuốn";
            this.btnDeXuatThanhLy.UseVisualStyleBackColor = false;
            this.btnDeXuatThanhLy.Click += new System.EventHandler(this.btnDeXuatThanhLy_Click);
            // 
            // btnCapNhatKho
            // 
            this.btnCapNhatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCapNhatKho.FlatAppearance.BorderSize = 0;
            this.btnCapNhatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatKho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCapNhatKho.Location = new System.Drawing.Point(235, 118);
            this.btnCapNhatKho.Name = "btnCapNhatKho";
            this.btnCapNhatKho.Size = new System.Drawing.Size(130, 32);
            this.btnCapNhatKho.TabIndex = 14;
            this.btnCapNhatKho.Text = "✏️ Cập Nhật Kho";
            this.btnCapNhatKho.UseVisualStyleBackColor = false;
            this.btnCapNhatKho.Click += new System.EventHandler(this.btnCapNhatKho_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnThemSach.FlatAppearance.BorderSize = 0;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Location = new System.Drawing.Point(85, 118);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(135, 32);
            this.btnThemSach.TabIndex = 13;
            this.btnThemSach.Text = "➕ Thêm Sách Mới";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(520, 82);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 25);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "🔍 Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(85, 83);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tên sách, mã sách, tác giả...";
            this.txtTimKiem.Size = new System.Drawing.Size(425, 23);
            this.txtTimKiem.TabIndex = 11;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.Location = new System.Drawing.Point(20, 86);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(58, 15);
            this.lblTimKiem.TabIndex = 10;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // nudTongSoLuong
            // 
            this.nudTongSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudTongSoLuong.Location = new System.Drawing.Point(390, 48);
            this.nudTongSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTongSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTongSoLuong.Name = "nudTongSoLuong";
            this.nudTongSoLuong.Size = new System.Drawing.Size(120, 23);
            this.nudTongSoLuong.TabIndex = 9;
            this.nudTongSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongSoLuong.Location = new System.Drawing.Point(325, 51);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblTongSoLuong.TabIndex = 8;
            this.lblTongSoLuong.Text = "Số lượng:";
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtViTri.Location = new System.Drawing.Point(85, 48);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(220, 23);
            this.txtViTri.TabIndex = 7;
            this.txtViTri.Text = "Kệ A1-01";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblViTri.Location = new System.Drawing.Point(20, 51);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(34, 15);
            this.lblViTri.TabIndex = 6;
            this.lblViTri.Text = "Vị trí:";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTheLoai.Location = new System.Drawing.Point(645, 14);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(180, 23);
            this.txtTheLoai.TabIndex = 5;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTheLoai.Location = new System.Drawing.Point(585, 17);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(52, 15);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTacGia.Location = new System.Drawing.Point(390, 14);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(180, 23);
            this.txtTacGia.TabIndex = 3;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTacGia.Location = new System.Drawing.Point(325, 17);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(46, 15);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSach.Location = new System.Drawing.Point(85, 14);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(220, 23);
            this.txtTenSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.Location = new System.Drawing.Point(20, 17);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(56, 15);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // FormQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1060, 670);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLySach";
            this.Text = "Quản Lý Kho Sách Chi Nhánh";
            this.Load += new System.EventHandler(this.FormQuanLySach_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabKhoChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoChiNhanh)).EndInit();
            this.pnlKhoBottom.ResumeLayout(false);
            this.pnlKhoBottom.PerformLayout();
            this.pnlKhoKPI.ResumeLayout(false);
            this.pnlBaoTriCN.ResumeLayout(false);
            this.pnlBaoTriCN.PerformLayout();
            this.pnlSanCoCN.ResumeLayout(false);
            this.pnlSanCoCN.PerformLayout();
            this.pnlDangMuonCN.ResumeLayout(false);
            this.pnlDangMuonCN.PerformLayout();
            this.pnlTongBanSaoCN.ResumeLayout(false);
            this.pnlTongBanSaoCN.PerformLayout();
            this.pnlTongDauSachCN.ResumeLayout(false);
            this.pnlTongDauSachCN.PerformLayout();
            this.pnlKhoFilter.ResumeLayout(false);
            this.pnlKhoFilter.PerformLayout();
            this.tabDanhMucSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabKhoChiNhanh;
        private System.Windows.Forms.TabPage tabDanhMucSach;
        private System.Windows.Forms.Panel pnlKhoFilter;
        private System.Windows.Forms.Label lblChonChiNhanh;
        private System.Windows.Forms.ComboBox cboChiNhanhKho;
        private System.Windows.Forms.Label lblTimKiemKho;
        private System.Windows.Forms.TextBox txtTimKiemKho;
        private System.Windows.Forms.Button btnTaiLaiKho;
        private System.Windows.Forms.Panel pnlKhoKPI;
        private System.Windows.Forms.Panel pnlTongDauSachCN;
        private System.Windows.Forms.Label lblTongDauSachCNTitle;
        private System.Windows.Forms.Label lblTongDauSachCNVal;
        private System.Windows.Forms.Panel pnlTongBanSaoCN;
        private System.Windows.Forms.Label lblTongBanSaoCNTitle;
        private System.Windows.Forms.Label lblTongBanSaoCNVal;
        private System.Windows.Forms.Panel pnlDangMuonCN;
        private System.Windows.Forms.Label lblDangMuonCNTitle;
        private System.Windows.Forms.Label lblDangMuonCNVal;
        private System.Windows.Forms.Panel pnlSanCoCN;
        private System.Windows.Forms.Label lblSanCoCNTitle;
        private System.Windows.Forms.Label lblSanCoCNVal;
        private System.Windows.Forms.Panel pnlBaoTriCN;
        private System.Windows.Forms.Label lblBaoTriCNTitle;
        private System.Windows.Forms.Label lblBaoTriCNVal;
        private System.Windows.Forms.DataGridView dgvKhoChiNhanh;
        private System.Windows.Forms.Panel pnlKhoBottom;
        private System.Windows.Forms.Button btnThanhLyCuon;
        private System.Windows.Forms.Label lblHuongDanKho;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.NumericUpDown nudTongSoLuong;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnCapNhatKho;
        private System.Windows.Forms.Button btnDeXuatThanhLy;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_TongBanSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_DangMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_SanCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKS_BaoTri;
    }
}