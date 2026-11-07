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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            tabControlMain = new TabControl();
            tabKhoChiNhanh = new TabPage();
            dgvKhoChiNhanh = new DataGridView();
            colKS_MaSach = new DataGridViewTextBoxColumn();
            colKS_TieuDe = new DataGridViewTextBoxColumn();
            colKS_TheLoai = new DataGridViewTextBoxColumn();
            colKS_TacGia = new DataGridViewTextBoxColumn();
            colKS_TongBanSao = new DataGridViewTextBoxColumn();
            colKS_DangMuon = new DataGridViewTextBoxColumn();
            colKS_SanCo = new DataGridViewTextBoxColumn();
            colKS_BaoTri = new DataGridViewTextBoxColumn();
            pnlKhoBottom = new Panel();
            btnThanhLyCuon = new Button();
            lblHuongDanKho = new Label();
            pnlKhoKPI = new Panel();
            pnlBaoTriCN = new Panel();
            lblBaoTriCNVal = new Label();
            lblBaoTriCNTitle = new Label();
            pnlSanCoCN = new Panel();
            lblSanCoCNVal = new Label();
            lblSanCoCNTitle = new Label();
            pnlDangMuonCN = new Panel();
            lblDangMuonCNVal = new Label();
            lblDangMuonCNTitle = new Label();
            pnlTongBanSaoCN = new Panel();
            lblTongBanSaoCNVal = new Label();
            lblTongBanSaoCNTitle = new Label();
            pnlTongDauSachCN = new Panel();
            lblTongDauSachCNVal = new Label();
            lblTongDauSachCNTitle = new Label();
            pnlKhoFilter = new Panel();
            btnTaiLaiKho = new Button();
            txtTimKiemKho = new TextBox();
            lblTimKiemKho = new Label();
            cboChiNhanhKho = new ComboBox();
            lblChonChiNhanh = new Label();
            tabDanhMucSach = new TabPage();
            dgvSach = new DataGridView();
            pnlInput = new Panel();
            btnXoaSach = new Button();
            btnDeXuatThanhLy = new Button();
            btnCapNhatKho = new Button();
            btnThemSach = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            nudTongSoLuong = new NumericUpDown();
            lblTongSoLuong = new Label();
            txtViTri = new TextBox();
            lblViTri = new Label();
            txtTheLoai = new TextBox();
            lblTheLoai = new Label();
            txtTacGia = new TextBox();
            lblTacGia = new Label();
            txtTenSach = new TextBox();
            lblTenSach = new Label();
            pnlHeader.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabKhoChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoChiNhanh).BeginInit();
            pnlKhoBottom.SuspendLayout();
            pnlKhoKPI.SuspendLayout();
            pnlBaoTriCN.SuspendLayout();
            pnlSanCoCN.SuspendLayout();
            pnlDangMuonCN.SuspendLayout();
            pnlTongBanSaoCN.SuspendLayout();
            pnlTongDauSachCN.SuspendLayout();
            pnlKhoFilter.SuspendLayout();
            tabDanhMucSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTongSoLuong).BeginInit();
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
            pnlHeader.Padding = new Padding(25, 12, 25, 12);
            pnlHeader.Size = new Size(1060, 65);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(25, 36);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(558, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Giám sát số lượng sách thực tế tại chi nhánh trực, kiểm kê bản sao lưu hành và biên mục danh mục sách";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(23, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(443, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ KHO SÁCH & BẢN SAO THEO CHI NHÁNH";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabKhoChiNhanh);
            tabControlMain.Controls.Add(tabDanhMucSach);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            tabControlMain.Location = new Point(0, 65);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1060, 605);
            tabControlMain.TabIndex = 1;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabKhoChiNhanh
            // 
            tabKhoChiNhanh.BackColor = Color.FromArgb(248, 250, 252);
            tabKhoChiNhanh.Controls.Add(dgvKhoChiNhanh);
            tabKhoChiNhanh.Controls.Add(pnlKhoBottom);
            tabKhoChiNhanh.Controls.Add(pnlKhoKPI);
            tabKhoChiNhanh.Controls.Add(pnlKhoFilter);
            tabKhoChiNhanh.Location = new Point(4, 26);
            tabKhoChiNhanh.Name = "tabKhoChiNhanh";
            tabKhoChiNhanh.Padding = new Padding(15);
            tabKhoChiNhanh.Size = new Size(1052, 575);
            tabKhoChiNhanh.TabIndex = 0;
            tabKhoChiNhanh.Text = " 🏢 Kho Sách Theo Chi Nhánh ";
            // 
            // dgvKhoChiNhanh
            // 
            dgvKhoChiNhanh.AllowUserToAddRows = false;
            dgvKhoChiNhanh.AllowUserToDeleteRows = false;
            dgvKhoChiNhanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoChiNhanh.BackgroundColor = Color.White;
            dgvKhoChiNhanh.BorderStyle = BorderStyle.None;
            dgvKhoChiNhanh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhoChiNhanh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhoChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoChiNhanh.ColumnHeadersHeight = 36;
            dgvKhoChiNhanh.Columns.AddRange(new DataGridViewColumn[] { colKS_MaSach, colKS_TieuDe, colKS_TheLoai, colKS_TacGia, colKS_TongBanSao, colKS_DangMuon, colKS_SanCo, colKS_BaoTri });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhoChiNhanh.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhoChiNhanh.Dock = DockStyle.Fill;
            dgvKhoChiNhanh.EnableHeadersVisualStyles = false;
            dgvKhoChiNhanh.GridColor = Color.FromArgb(241, 245, 249);
            dgvKhoChiNhanh.Location = new Point(15, 137);
            dgvKhoChiNhanh.MultiSelect = false;
            dgvKhoChiNhanh.Name = "dgvKhoChiNhanh";
            dgvKhoChiNhanh.ReadOnly = true;
            dgvKhoChiNhanh.RowHeadersVisible = false;
            dgvKhoChiNhanh.RowTemplate.Height = 34;
            dgvKhoChiNhanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoChiNhanh.Size = new Size(1022, 375);
            dgvKhoChiNhanh.TabIndex = 2;
            // 
            // colKS_MaSach
            // 
            colKS_MaSach.DataPropertyName = "Ma_Sach";
            colKS_MaSach.FillWeight = 50F;
            colKS_MaSach.HeaderText = "Mã Sách";
            colKS_MaSach.Name = "colKS_MaSach";
            colKS_MaSach.ReadOnly = true;
            // 
            // colKS_TieuDe
            // 
            colKS_TieuDe.DataPropertyName = "Tieu_De";
            colKS_TieuDe.FillWeight = 160F;
            colKS_TieuDe.HeaderText = "Tên Đầu Sách";
            colKS_TieuDe.Name = "colKS_TieuDe";
            colKS_TieuDe.ReadOnly = true;
            // 
            // colKS_TheLoai
            // 
            colKS_TheLoai.DataPropertyName = "The_Loai";
            colKS_TheLoai.FillWeight = 85F;
            colKS_TheLoai.HeaderText = "Thể Loại";
            colKS_TheLoai.Name = "colKS_TheLoai";
            colKS_TheLoai.ReadOnly = true;
            // 
            // colKS_TacGia
            // 
            colKS_TacGia.DataPropertyName = "Tac_Gia";
            colKS_TacGia.FillWeight = 85F;
            colKS_TacGia.HeaderText = "Tác Giả";
            colKS_TacGia.Name = "colKS_TacGia";
            colKS_TacGia.ReadOnly = true;
            // 
            // colKS_TongBanSao
            // 
            colKS_TongBanSao.DataPropertyName = "Tong_Ban_Sao";
            colKS_TongBanSao.FillWeight = 65F;
            colKS_TongBanSao.HeaderText = "Tổng Tại CN";
            colKS_TongBanSao.Name = "colKS_TongBanSao";
            colKS_TongBanSao.ReadOnly = true;
            // 
            // colKS_DangMuon
            // 
            colKS_DangMuon.DataPropertyName = "Dang_Muon";
            colKS_DangMuon.FillWeight = 60F;
            colKS_DangMuon.HeaderText = "Đang Mượn";
            colKS_DangMuon.Name = "colKS_DangMuon";
            colKS_DangMuon.ReadOnly = true;
            // 
            // colKS_SanCo
            // 
            colKS_SanCo.DataPropertyName = "San_Co";
            colKS_SanCo.FillWeight = 60F;
            colKS_SanCo.HeaderText = "Có Sẵn Kệ";
            colKS_SanCo.Name = "colKS_SanCo";
            colKS_SanCo.ReadOnly = true;
            // 
            // colKS_BaoTri
            // 
            colKS_BaoTri.DataPropertyName = "Bao_Tri";
            colKS_BaoTri.FillWeight = 55F;
            colKS_BaoTri.HeaderText = "Bảo Trì / Hỏng";
            colKS_BaoTri.Name = "colKS_BaoTri";
            colKS_BaoTri.ReadOnly = true;
            // 
            // pnlKhoBottom
            // 
            pnlKhoBottom.BackColor = Color.White;
            pnlKhoBottom.Controls.Add(btnThanhLyCuon);
            pnlKhoBottom.Controls.Add(lblHuongDanKho);
            pnlKhoBottom.Dock = DockStyle.Bottom;
            pnlKhoBottom.Location = new Point(15, 512);
            pnlKhoBottom.Name = "pnlKhoBottom";
            pnlKhoBottom.Size = new Size(1022, 48);
            pnlKhoBottom.TabIndex = 3;
            // 
            // btnThanhLyCuon
            // 
            btnThanhLyCuon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThanhLyCuon.BackColor = Color.FromArgb(225, 29, 72);
            btnThanhLyCuon.FlatAppearance.BorderSize = 0;
            btnThanhLyCuon.FlatStyle = FlatStyle.Flat;
            btnThanhLyCuon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThanhLyCuon.ForeColor = Color.White;
            btnThanhLyCuon.Location = new Point(800, 8);
            btnThanhLyCuon.Name = "btnThanhLyCuon";
            btnThanhLyCuon.Size = new Size(210, 32);
            btnThanhLyCuon.TabIndex = 1;
            btnThanhLyCuon.Text = "🗑️ Thanh Lý 1 Cuốn Hư Hỏng";
            btnThanhLyCuon.UseVisualStyleBackColor = false;
            btnThanhLyCuon.Click += btnThanhLyCuon_Click;
            // 
            // lblHuongDanKho
            // 
            lblHuongDanKho.AutoSize = true;
            lblHuongDanKho.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblHuongDanKho.ForeColor = Color.FromArgb(100, 116, 139);
            lblHuongDanKho.Location = new Point(12, 16);
            lblHuongDanKho.Name = "lblHuongDanKho";
            lblHuongDanKho.Size = new Size(615, 15);
            lblHuongDanKho.TabIndex = 0;
            lblHuongDanKho.Text = "* Chọn 1 đầu sách trong bảng để theo dõi số lượng sẵn sàng trên kệ hoặc lập biên bản thanh lý bản sao rách/hỏng.";
            // 
            // pnlKhoKPI
            // 
            pnlKhoKPI.Controls.Add(pnlBaoTriCN);
            pnlKhoKPI.Controls.Add(pnlSanCoCN);
            pnlKhoKPI.Controls.Add(pnlDangMuonCN);
            pnlKhoKPI.Controls.Add(pnlTongBanSaoCN);
            pnlKhoKPI.Controls.Add(pnlTongDauSachCN);
            pnlKhoKPI.Dock = DockStyle.Top;
            pnlKhoKPI.Location = new Point(15, 67);
            pnlKhoKPI.Name = "pnlKhoKPI";
            pnlKhoKPI.Padding = new Padding(0, 8, 0, 8);
            pnlKhoKPI.Size = new Size(1022, 70);
            pnlKhoKPI.TabIndex = 1;
            // 
            // pnlBaoTriCN
            // 
            pnlBaoTriCN.BackColor = Color.White;
            pnlBaoTriCN.Controls.Add(lblBaoTriCNVal);
            pnlBaoTriCN.Controls.Add(lblBaoTriCNTitle);
            pnlBaoTriCN.Dock = DockStyle.Left;
            pnlBaoTriCN.Location = new Point(760, 8);
            pnlBaoTriCN.Name = "pnlBaoTriCN";
            pnlBaoTriCN.Padding = new Padding(10);
            pnlBaoTriCN.Size = new Size(190, 54);
            pnlBaoTriCN.TabIndex = 4;
            // 
            // lblBaoTriCNVal
            // 
            lblBaoTriCNVal.AutoSize = true;
            lblBaoTriCNVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBaoTriCNVal.ForeColor = Color.FromArgb(225, 29, 72);
            lblBaoTriCNVal.Location = new Point(10, 22);
            lblBaoTriCNVal.Name = "lblBaoTriCNVal";
            lblBaoTriCNVal.Size = new Size(22, 25);
            lblBaoTriCNVal.TabIndex = 1;
            lblBaoTriCNVal.Text = "0";
            // 
            // lblBaoTriCNTitle
            // 
            lblBaoTriCNTitle.AutoSize = true;
            lblBaoTriCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBaoTriCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblBaoTriCNTitle.Location = new Point(10, 6);
            lblBaoTriCNTitle.Name = "lblBaoTriCNTitle";
            lblBaoTriCNTitle.Size = new Size(93, 13);
            lblBaoTriCNTitle.TabIndex = 0;
            lblBaoTriCNTitle.Text = "BẢO TRÌ / HỎNG";
            // 
            // pnlSanCoCN
            // 
            pnlSanCoCN.BackColor = Color.White;
            pnlSanCoCN.Controls.Add(lblSanCoCNVal);
            pnlSanCoCN.Controls.Add(lblSanCoCNTitle);
            pnlSanCoCN.Dock = DockStyle.Left;
            pnlSanCoCN.Location = new Point(570, 8);
            pnlSanCoCN.Name = "pnlSanCoCN";
            pnlSanCoCN.Padding = new Padding(10);
            pnlSanCoCN.Size = new Size(190, 54);
            pnlSanCoCN.TabIndex = 3;
            // 
            // lblSanCoCNVal
            // 
            lblSanCoCNVal.AutoSize = true;
            lblSanCoCNVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSanCoCNVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblSanCoCNVal.Location = new Point(10, 22);
            lblSanCoCNVal.Name = "lblSanCoCNVal";
            lblSanCoCNVal.Size = new Size(22, 25);
            lblSanCoCNVal.TabIndex = 1;
            lblSanCoCNVal.Text = "0";
            // 
            // lblSanCoCNTitle
            // 
            lblSanCoCNTitle.AutoSize = true;
            lblSanCoCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSanCoCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSanCoCNTitle.Location = new Point(10, 6);
            lblSanCoCNTitle.Name = "lblSanCoCNTitle";
            lblSanCoCNTitle.Size = new Size(111, 13);
            lblSanCoCNTitle.TabIndex = 0;
            lblSanCoCNTitle.Text = "SẴN SÀNG TRÊN KỆ";
            // 
            // pnlDangMuonCN
            // 
            pnlDangMuonCN.BackColor = Color.White;
            pnlDangMuonCN.Controls.Add(lblDangMuonCNVal);
            pnlDangMuonCN.Controls.Add(lblDangMuonCNTitle);
            pnlDangMuonCN.Dock = DockStyle.Left;
            pnlDangMuonCN.Location = new Point(380, 8);
            pnlDangMuonCN.Name = "pnlDangMuonCN";
            pnlDangMuonCN.Padding = new Padding(10);
            pnlDangMuonCN.Size = new Size(190, 54);
            pnlDangMuonCN.TabIndex = 2;
            // 
            // lblDangMuonCNVal
            // 
            lblDangMuonCNVal.AutoSize = true;
            lblDangMuonCNVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDangMuonCNVal.ForeColor = Color.FromArgb(217, 119, 6);
            lblDangMuonCNVal.Location = new Point(10, 22);
            lblDangMuonCNVal.Name = "lblDangMuonCNVal";
            lblDangMuonCNVal.Size = new Size(22, 25);
            lblDangMuonCNVal.TabIndex = 1;
            lblDangMuonCNVal.Text = "0";
            // 
            // lblDangMuonCNTitle
            // 
            lblDangMuonCNTitle.AutoSize = true;
            lblDangMuonCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDangMuonCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblDangMuonCNTitle.Location = new Point(10, 6);
            lblDangMuonCNTitle.Name = "lblDangMuonCNTitle";
            lblDangMuonCNTitle.Size = new Size(107, 13);
            lblDangMuonCNTitle.TabIndex = 0;
            lblDangMuonCNTitle.Text = "ĐANG CHO MƯỢN";
            // 
            // pnlTongBanSaoCN
            // 
            pnlTongBanSaoCN.BackColor = Color.White;
            pnlTongBanSaoCN.Controls.Add(lblTongBanSaoCNVal);
            pnlTongBanSaoCN.Controls.Add(lblTongBanSaoCNTitle);
            pnlTongBanSaoCN.Dock = DockStyle.Left;
            pnlTongBanSaoCN.Location = new Point(190, 8);
            pnlTongBanSaoCN.Name = "pnlTongBanSaoCN";
            pnlTongBanSaoCN.Padding = new Padding(10);
            pnlTongBanSaoCN.Size = new Size(190, 54);
            pnlTongBanSaoCN.TabIndex = 1;
            // 
            // lblTongBanSaoCNVal
            // 
            lblTongBanSaoCNVal.AutoSize = true;
            lblTongBanSaoCNVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongBanSaoCNVal.ForeColor = Color.FromArgb(2, 132, 199);
            lblTongBanSaoCNVal.Location = new Point(10, 22);
            lblTongBanSaoCNVal.Name = "lblTongBanSaoCNVal";
            lblTongBanSaoCNVal.Size = new Size(22, 25);
            lblTongBanSaoCNVal.TabIndex = 1;
            lblTongBanSaoCNVal.Text = "0";
            // 
            // lblTongBanSaoCNTitle
            // 
            lblTongBanSaoCNTitle.AutoSize = true;
            lblTongBanSaoCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTongBanSaoCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTongBanSaoCNTitle.Location = new Point(10, 6);
            lblTongBanSaoCNTitle.Name = "lblTongBanSaoCNTitle";
            lblTongBanSaoCNTitle.Size = new Size(129, 13);
            lblTongBanSaoCNTitle.TabIndex = 0;
            lblTongBanSaoCNTitle.Text = "TỔNG BẢN SAO TẠI CN";
            // 
            // pnlTongDauSachCN
            // 
            pnlTongDauSachCN.BackColor = Color.White;
            pnlTongDauSachCN.Controls.Add(lblTongDauSachCNVal);
            pnlTongDauSachCN.Controls.Add(lblTongDauSachCNTitle);
            pnlTongDauSachCN.Dock = DockStyle.Left;
            pnlTongDauSachCN.Location = new Point(0, 8);
            pnlTongDauSachCN.Name = "pnlTongDauSachCN";
            pnlTongDauSachCN.Padding = new Padding(10);
            pnlTongDauSachCN.Size = new Size(190, 54);
            pnlTongDauSachCN.TabIndex = 0;
            // 
            // lblTongDauSachCNVal
            // 
            lblTongDauSachCNVal.AutoSize = true;
            lblTongDauSachCNVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongDauSachCNVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblTongDauSachCNVal.Location = new Point(10, 22);
            lblTongDauSachCNVal.Name = "lblTongDauSachCNVal";
            lblTongDauSachCNVal.Size = new Size(22, 25);
            lblTongDauSachCNVal.TabIndex = 1;
            lblTongDauSachCNVal.Text = "0";
            // 
            // lblTongDauSachCNTitle
            // 
            lblTongDauSachCNTitle.AutoSize = true;
            lblTongDauSachCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTongDauSachCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTongDauSachCNTitle.Location = new Point(10, 6);
            lblTongDauSachCNTitle.Name = "lblTongDauSachCNTitle";
            lblTongDauSachCNTitle.Size = new Size(97, 13);
            lblTongDauSachCNTitle.TabIndex = 0;
            lblTongDauSachCNTitle.Text = "TỔNG ĐẦU SÁCH";
            // 
            // pnlKhoFilter
            // 
            pnlKhoFilter.BackColor = Color.White;
            pnlKhoFilter.Controls.Add(btnTaiLaiKho);
            pnlKhoFilter.Controls.Add(txtTimKiemKho);
            pnlKhoFilter.Controls.Add(lblTimKiemKho);
            pnlKhoFilter.Controls.Add(cboChiNhanhKho);
            pnlKhoFilter.Controls.Add(lblChonChiNhanh);
            pnlKhoFilter.Dock = DockStyle.Top;
            pnlKhoFilter.Location = new Point(15, 15);
            pnlKhoFilter.Name = "pnlKhoFilter";
            pnlKhoFilter.Padding = new Padding(15, 10, 15, 10);
            pnlKhoFilter.Size = new Size(1022, 52);
            pnlKhoFilter.TabIndex = 0;
            // 
            // btnTaiLaiKho
            // 
            btnTaiLaiKho.BackColor = Color.FromArgb(241, 245, 249);
            btnTaiLaiKho.FlatAppearance.BorderSize = 0;
            btnTaiLaiKho.FlatStyle = FlatStyle.Flat;
            btnTaiLaiKho.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTaiLaiKho.ForeColor = Color.FromArgb(51, 65, 85);
            btnTaiLaiKho.Location = new Point(745, 12);
            btnTaiLaiKho.Name = "btnTaiLaiKho";
            btnTaiLaiKho.Size = new Size(85, 28);
            btnTaiLaiKho.TabIndex = 4;
            btnTaiLaiKho.Text = "🔄 Làm Mới";
            btnTaiLaiKho.UseVisualStyleBackColor = false;
            btnTaiLaiKho.Click += btnTaiLaiKho_Click;
            // 
            // txtTimKiemKho
            // 
            txtTimKiemKho.Font = new Font("Segoe UI", 9.5F);
            txtTimKiemKho.Location = new Point(480, 14);
            txtTimKiemKho.Name = "txtTimKiemKho";
            txtTimKiemKho.PlaceholderText = "Tên sách, tác giả, mã sách...";
            txtTimKiemKho.Size = new Size(250, 24);
            txtTimKiemKho.TabIndex = 3;
            txtTimKiemKho.TextChanged += txtTimKiemKho_TextChanged;
            // 
            // lblTimKiemKho
            // 
            lblTimKiemKho.AutoSize = true;
            lblTimKiemKho.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTimKiemKho.ForeColor = Color.FromArgb(51, 65, 85);
            lblTimKiemKho.Location = new Point(415, 18);
            lblTimKiemKho.Name = "lblTimKiemKho";
            lblTimKiemKho.Size = new Size(60, 15);
            lblTimKiemKho.TabIndex = 2;
            lblTimKiemKho.Text = "Tìm Sách:";
            // 
            // cboChiNhanhKho
            // 
            cboChiNhanhKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChiNhanhKho.Font = new Font("Segoe UI", 9.5F);
            cboChiNhanhKho.FormattingEnabled = true;
            cboChiNhanhKho.Location = new Point(145, 14);
            cboChiNhanhKho.Name = "cboChiNhanhKho";
            cboChiNhanhKho.Size = new Size(250, 25);
            cboChiNhanhKho.TabIndex = 1;
            cboChiNhanhKho.SelectedIndexChanged += cboChiNhanhKho_SelectedIndexChanged;
            // 
            // lblChonChiNhanh
            // 
            lblChonChiNhanh.AutoSize = true;
            lblChonChiNhanh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblChonChiNhanh.ForeColor = Color.FromArgb(51, 65, 85);
            lblChonChiNhanh.Location = new Point(15, 18);
            lblChonChiNhanh.Name = "lblChonChiNhanh";
            lblChonChiNhanh.Size = new Size(124, 15);
            lblChonChiNhanh.TabIndex = 0;
            lblChonChiNhanh.Text = "Chi Nhánh Đang Trực:";
            // 
            // tabDanhMucSach
            // 
            tabDanhMucSach.BackColor = Color.FromArgb(248, 250, 252);
            tabDanhMucSach.Controls.Add(dgvSach);
            tabDanhMucSach.Controls.Add(pnlInput);
            tabDanhMucSach.Location = new Point(4, 26);
            tabDanhMucSach.Name = "tabDanhMucSach";
            tabDanhMucSach.Padding = new Padding(15);
            tabDanhMucSach.Size = new Size(1052, 575);
            tabDanhMucSach.TabIndex = 1;
            tabDanhMucSach.Text = " 📖 Danh Mục Biểu Ghi & Nhập Mới ";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = Color.White;
            dgvSach.BorderStyle = BorderStyle.None;
            dgvSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSach.ColumnHeadersHeight = 36;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle4.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSach.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.EnableHeadersVisualStyles = false;
            dgvSach.GridColor = Color.FromArgb(241, 245, 249);
            dgvSach.Location = new Point(15, 175);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowTemplate.Height = 34;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1022, 385);
            dgvSach.TabIndex = 1;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(btnXoaSach);
            pnlInput.Controls.Add(btnDeXuatThanhLy);
            pnlInput.Controls.Add(btnCapNhatKho);
            pnlInput.Controls.Add(btnThemSach);
            pnlInput.Controls.Add(btnTimKiem);
            pnlInput.Controls.Add(txtTimKiem);
            pnlInput.Controls.Add(lblTimKiem);
            pnlInput.Controls.Add(nudTongSoLuong);
            pnlInput.Controls.Add(lblTongSoLuong);
            pnlInput.Controls.Add(txtViTri);
            pnlInput.Controls.Add(lblViTri);
            pnlInput.Controls.Add(txtTheLoai);
            pnlInput.Controls.Add(lblTheLoai);
            pnlInput.Controls.Add(txtTacGia);
            pnlInput.Controls.Add(lblTacGia);
            pnlInput.Controls.Add(txtTenSach);
            pnlInput.Controls.Add(lblTenSach);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(15, 15);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(1022, 160);
            pnlInput.TabIndex = 0;
            // 
            // btnXoaSach
            // 
            btnXoaSach.BackColor = Color.FromArgb(241, 245, 249);
            btnXoaSach.FlatAppearance.BorderSize = 0;
            btnXoaSach.FlatStyle = FlatStyle.Flat;
            btnXoaSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoaSach.ForeColor = Color.FromArgb(225, 29, 72);
            btnXoaSach.Location = new Point(540, 118);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(110, 32);
            btnXoaSach.TabIndex = 16;
            btnXoaSach.Text = "🗑️ Xóa Biểu Ghi";
            btnXoaSach.UseVisualStyleBackColor = false;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // btnDeXuatThanhLy
            // 
            btnDeXuatThanhLy.BackColor = Color.FromArgb(241, 245, 249);
            btnDeXuatThanhLy.FlatAppearance.BorderSize = 0;
            btnDeXuatThanhLy.FlatStyle = FlatStyle.Flat;
            btnDeXuatThanhLy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeXuatThanhLy.ForeColor = Color.FromArgb(51, 65, 85);
            btnDeXuatThanhLy.Location = new Point(380, 118);
            btnDeXuatThanhLy.Name = "btnDeXuatThanhLy";
            btnDeXuatThanhLy.Size = new Size(145, 32);
            btnDeXuatThanhLy.TabIndex = 15;
            btnDeXuatThanhLy.Text = "⚠️ Thanh Lý 1 Cuốn";
            btnDeXuatThanhLy.UseVisualStyleBackColor = false;
            btnDeXuatThanhLy.Click += btnDeXuatThanhLy_Click;
            // 
            // btnCapNhatKho
            // 
            btnCapNhatKho.BackColor = Color.FromArgb(241, 245, 249);
            btnCapNhatKho.FlatAppearance.BorderSize = 0;
            btnCapNhatKho.FlatStyle = FlatStyle.Flat;
            btnCapNhatKho.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCapNhatKho.ForeColor = Color.FromArgb(51, 65, 85);
            btnCapNhatKho.Location = new Point(235, 118);
            btnCapNhatKho.Name = "btnCapNhatKho";
            btnCapNhatKho.Size = new Size(130, 32);
            btnCapNhatKho.TabIndex = 14;
            btnCapNhatKho.Text = "✏️ Cập Nhật Kho";
            btnCapNhatKho.UseVisualStyleBackColor = false;
            btnCapNhatKho.Click += btnCapNhatKho_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.BackColor = Color.FromArgb(15, 118, 110);
            btnThemSach.FlatAppearance.BorderSize = 0;
            btnThemSach.FlatStyle = FlatStyle.Flat;
            btnThemSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThemSach.ForeColor = Color.White;
            btnThemSach.Location = new Point(85, 118);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(135, 32);
            btnThemSach.TabIndex = 13;
            btnThemSach.Text = "➕ Thêm Sách Mới";
            btnThemSach.UseVisualStyleBackColor = false;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(241, 245, 249);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTimKiem.Location = new Point(520, 82);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(85, 25);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "🔍 Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(85, 83);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tên sách, mã sách, tác giả...";
            txtTimKiem.Size = new Size(425, 23);
            txtTimKiem.TabIndex = 11;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTimKiem.Location = new Point(20, 86);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(60, 15);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // nudTongSoLuong
            // 
            nudTongSoLuong.Font = new Font("Segoe UI", 9F);
            nudTongSoLuong.Location = new Point(390, 48);
            nudTongSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTongSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTongSoLuong.Name = "nudTongSoLuong";
            nudTongSoLuong.Size = new Size(120, 23);
            nudTongSoLuong.TabIndex = 9;
            nudTongSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.AutoSize = true;
            lblTongSoLuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTongSoLuong.Location = new Point(325, 51);
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(58, 15);
            lblTongSoLuong.TabIndex = 8;
            lblTongSoLuong.Text = "Số lượng:";
            // 
            // txtViTri
            // 
            txtViTri.Font = new Font("Segoe UI", 9F);
            txtViTri.Location = new Point(85, 48);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(220, 23);
            txtViTri.TabIndex = 7;
            txtViTri.Text = "Kệ A1-01";
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblViTri.Location = new Point(20, 51);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(35, 15);
            lblViTri.TabIndex = 6;
            lblViTri.Text = "Vị trí:";
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI", 9F);
            txtTheLoai.Location = new Point(645, 14);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(180, 23);
            txtTheLoai.TabIndex = 5;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTheLoai.Location = new Point(585, 17);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(52, 15);
            lblTheLoai.TabIndex = 4;
            lblTheLoai.Text = "Thể loại:";
            // 
            // txtTacGia
            // 
            txtTacGia.Font = new Font("Segoe UI", 9F);
            txtTacGia.Location = new Point(390, 14);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(180, 23);
            txtTacGia.TabIndex = 3;
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTacGia.Location = new Point(325, 17);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(47, 15);
            lblTacGia.TabIndex = 2;
            lblTacGia.Text = "Tác giả:";
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI", 9F);
            txtTenSach.Location = new Point(85, 14);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(220, 23);
            txtTenSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTenSach.Location = new Point(20, 17);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(56, 15);
            lblTenSach.TabIndex = 0;
            lblTenSach.Text = "Tên sách:";
            // 
            // FormQuanLySach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1060, 670);
            Controls.Add(tabControlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQuanLySach";
            Text = "Quản Lý Kho Sách Chi Nhánh";
            Load += FormQuanLySach_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabKhoChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoChiNhanh).EndInit();
            pnlKhoBottom.ResumeLayout(false);
            pnlKhoBottom.PerformLayout();
            pnlKhoKPI.ResumeLayout(false);
            pnlBaoTriCN.ResumeLayout(false);
            pnlBaoTriCN.PerformLayout();
            pnlSanCoCN.ResumeLayout(false);
            pnlSanCoCN.PerformLayout();
            pnlDangMuonCN.ResumeLayout(false);
            pnlDangMuonCN.PerformLayout();
            pnlTongBanSaoCN.ResumeLayout(false);
            pnlTongBanSaoCN.PerformLayout();
            pnlTongDauSachCN.ResumeLayout(false);
            pnlTongDauSachCN.PerformLayout();
            pnlKhoFilter.ResumeLayout(false);
            pnlKhoFilter.PerformLayout();
            tabDanhMucSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTongSoLuong).EndInit();
            ResumeLayout(false);

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