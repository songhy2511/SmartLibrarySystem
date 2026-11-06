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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            tabControlMain = new TabControl();
            tabThongKe = new TabPage();
            pnlDoiSoatSection = new Panel();
            dgvDoiSoat = new DataGridView();
            lblDoiSoatHeader = new Label();
            pnlLuuThongSection = new Panel();
            dgvLuuThongTuan = new DataGridView();
            colLTChiNhanh = new DataGridViewTextBoxColumn();
            colLTMuonTuan = new DataGridViewTextBoxColumn();
            colLTTraTuan = new DataGridViewTextBoxColumn();
            colLTDangMuon = new DataGridViewTextBoxColumn();
            lblLuuThongHeader = new Label();
            pnlKPI = new Panel();
            cardTienPhat = new Panel();
            lblTienPhatVal = new Label();
            lblTienPhatTitle = new Label();
            cardLuuThong = new Panel();
            lblLuuThongVal = new Label();
            lblLuuThongTitle = new Label();
            cardSachSanSang = new Panel();
            lblSachSanSangVal = new Label();
            lblSachSanSangTitle = new Label();
            cardDocGia = new Panel();
            lblDocGiaVal = new Label();
            lblDocGiaTitle = new Label();
            tabKhoSach = new TabPage();
            dgvKhoSach = new DataGridView();
            colKS_MaSach = new DataGridViewTextBoxColumn();
            colKS_TieuDe = new DataGridViewTextBoxColumn();
            colKS_TheLoai = new DataGridViewTextBoxColumn();
            colKS_TacGia = new DataGridViewTextBoxColumn();
            colKS_TongBanSao = new DataGridViewTextBoxColumn();
            colKS_DangMuon = new DataGridViewTextBoxColumn();
            colKS_SanCo = new DataGridViewTextBoxColumn();
            colKS_BaoTri = new DataGridViewTextBoxColumn();
            pnlKhoKPI = new Panel();
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
            pnlKhoHeader = new Panel();
            btnTaiLaiKho = new Button();
            txtTimKiemSach = new TextBox();
            lblTimKiem = new Label();
            cboChiNhanhKho = new ComboBox();
            lblChonChiNhanh = new Label();
            pnlHeader.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabThongKe.SuspendLayout();
            pnlDoiSoatSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoiSoat).BeginInit();
            pnlLuuThongSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLuuThongTuan).BeginInit();
            pnlKPI.SuspendLayout();
            cardTienPhat.SuspendLayout();
            cardLuuThong.SuspendLayout();
            cardSachSanSang.SuspendLayout();
            cardDocGia.SuspendLayout();
            tabKhoSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).BeginInit();
            pnlKhoKPI.SuspendLayout();
            pnlSanCoCN.SuspendLayout();
            pnlDangMuonCN.SuspendLayout();
            pnlTongBanSaoCN.SuspendLayout();
            pnlTongDauSachCN.SuspendLayout();
            pnlKhoHeader.SuspendLayout();
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
            pnlHeader.Size = new Size(1150, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(25, 36);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(537, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Giám sát lưu thông mượn/trả trong tuần, quản lý kho sách từng chi nhánh và bảng đối soát tiền mặt";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(23, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TỔNG QUAN HỆ THỐNG - THỐNG KÊ & KHO SÁCH";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabThongKe);
            tabControlMain.Controls.Add(tabKhoSach);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tabControlMain.Location = new Point(0, 65);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1150, 635);
            tabControlMain.TabIndex = 1;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabThongKe
            // 
            tabThongKe.BackColor = Color.FromArgb(248, 250, 252);
            tabThongKe.Controls.Add(pnlDoiSoatSection);
            tabThongKe.Controls.Add(pnlLuuThongSection);
            tabThongKe.Controls.Add(pnlKPI);
            tabThongKe.Location = new Point(4, 26);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.Padding = new Padding(15);
            tabThongKe.Size = new Size(1142, 605);
            tabThongKe.TabIndex = 0;
            tabThongKe.Text = " 📊 Thống Kê Tuần & Đối Soát Quỹ ";
            // 
            // pnlDoiSoatSection
            // 
            pnlDoiSoatSection.BackColor = Color.White;
            pnlDoiSoatSection.Controls.Add(dgvDoiSoat);
            pnlDoiSoatSection.Controls.Add(lblDoiSoatHeader);
            pnlDoiSoatSection.Dock = DockStyle.Fill;
            pnlDoiSoatSection.Location = new Point(15, 270);
            pnlDoiSoatSection.Name = "pnlDoiSoatSection";
            pnlDoiSoatSection.Padding = new Padding(15, 10, 15, 10);
            pnlDoiSoatSection.Size = new Size(1112, 320);
            pnlDoiSoatSection.TabIndex = 2;
            // 
            // dgvDoiSoat
            // 
            dgvDoiSoat.AllowUserToAddRows = false;
            dgvDoiSoat.AllowUserToDeleteRows = false;
            dgvDoiSoat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoiSoat.BackgroundColor = Color.White;
            dgvDoiSoat.BorderStyle = BorderStyle.None;
            dgvDoiSoat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(6);
            dgvDoiSoat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoiSoat.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDoiSoat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDoiSoat.Dock = DockStyle.Fill;
            dgvDoiSoat.EnableHeadersVisualStyles = false;
            dgvDoiSoat.GridColor = Color.FromArgb(241, 245, 249);
            dgvDoiSoat.Location = new Point(15, 10);
            dgvDoiSoat.Name = "dgvDoiSoat";
            dgvDoiSoat.ReadOnly = true;
            dgvDoiSoat.RowHeadersVisible = false;
            dgvDoiSoat.RowTemplate.Height = 34;
            dgvDoiSoat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoiSoat.Size = new Size(1082, 300);
            dgvDoiSoat.TabIndex = 1;
            // 
            // lblDoiSoatHeader
            // 
            lblDoiSoatHeader.AutoSize = true;
            lblDoiSoatHeader.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDoiSoatHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblDoiSoatHeader.Location = new Point(12, 10);
            lblDoiSoatHeader.Name = "lblDoiSoatHeader";
            lblDoiSoatHeader.Size = new Size(306, 19);
            lblDoiSoatHeader.TabIndex = 0;
            lblDoiSoatHeader.Text = "💵 ĐỐI SOÁT QUỸ TIỀN MẶT THEO CA TRỰC";
            // 
            // pnlLuuThongSection
            // 
            pnlLuuThongSection.BackColor = Color.White;
            pnlLuuThongSection.Controls.Add(dgvLuuThongTuan);
            pnlLuuThongSection.Controls.Add(lblLuuThongHeader);
            pnlLuuThongSection.Dock = DockStyle.Top;
            pnlLuuThongSection.Location = new Point(15, 90);
            pnlLuuThongSection.Name = "pnlLuuThongSection";
            pnlLuuThongSection.Padding = new Padding(15, 10, 15, 10);
            pnlLuuThongSection.Size = new Size(1112, 180);
            pnlLuuThongSection.TabIndex = 1;
            // 
            // dgvLuuThongTuan
            // 
            dgvLuuThongTuan.AllowUserToAddRows = false;
            dgvLuuThongTuan.AllowUserToDeleteRows = false;
            dgvLuuThongTuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLuuThongTuan.BackgroundColor = Color.White;
            dgvLuuThongTuan.BorderStyle = BorderStyle.None;
            dgvLuuThongTuan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLuuThongTuan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLuuThongTuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLuuThongTuan.ColumnHeadersHeight = 34;
            dgvLuuThongTuan.Columns.AddRange(new DataGridViewColumn[] { colLTChiNhanh, colLTMuonTuan, colLTTraTuan, colLTDangMuon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLuuThongTuan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLuuThongTuan.Dock = DockStyle.Fill;
            dgvLuuThongTuan.EnableHeadersVisualStyles = false;
            dgvLuuThongTuan.GridColor = Color.FromArgb(241, 245, 249);
            dgvLuuThongTuan.Location = new Point(15, 10);
            dgvLuuThongTuan.Name = "dgvLuuThongTuan";
            dgvLuuThongTuan.ReadOnly = true;
            dgvLuuThongTuan.RowHeadersVisible = false;
            dgvLuuThongTuan.RowTemplate.Height = 34;
            dgvLuuThongTuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuuThongTuan.Size = new Size(1082, 160);
            dgvLuuThongTuan.TabIndex = 1;
            // 
            // colLTChiNhanh
            // 
            colLTChiNhanh.DataPropertyName = "Ten_Chi_Nhanh";
            colLTChiNhanh.FillWeight = 140F;
            colLTChiNhanh.HeaderText = "Chi Nhánh Thư Viện";
            colLTChiNhanh.Name = "colLTChiNhanh";
            colLTChiNhanh.ReadOnly = true;
            // 
            // colLTMuonTuan
            // 
            colLTMuonTuan.DataPropertyName = "So_Luot_Muon_Trong_Tuan";
            colLTMuonTuan.FillWeight = 90F;
            colLTMuonTuan.HeaderText = "Lượt Mượn Trong Tuần";
            colLTMuonTuan.Name = "colLTMuonTuan";
            colLTMuonTuan.ReadOnly = true;
            // 
            // colLTTraTuan
            // 
            colLTTraTuan.DataPropertyName = "So_Luot_Tra_Trong_Tuan";
            colLTTraTuan.FillWeight = 90F;
            colLTTraTuan.HeaderText = "Lượt Trả Trong Tuần";
            colLTTraTuan.Name = "colLTTraTuan";
            colLTTraTuan.ReadOnly = true;
            // 
            // colLTDangMuon
            // 
            colLTDangMuon.DataPropertyName = "So_Sach_Dang_Muon_Hien_Tai";
            colLTDangMuon.HeaderText = "Số Cuốn Đang Mượn Chưa Trả";
            colLTDangMuon.Name = "colLTDangMuon";
            colLTDangMuon.ReadOnly = true;
            // 
            // lblLuuThongHeader
            // 
            lblLuuThongHeader.AutoSize = true;
            lblLuuThongHeader.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLuuThongHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblLuuThongHeader.Location = new Point(12, 8);
            lblLuuThongHeader.Name = "lblLuuThongHeader";
            lblLuuThongHeader.Size = new Size(479, 19);
            lblLuuThongHeader.TabIndex = 0;
            lblLuuThongHeader.Text = "📖 BÁO CÁO LƯỢT MƯỢN & TRẢ SÁCH TRONG TUẦN MỖI CHI NHÁNH";
            // 
            // pnlKPI
            // 
            pnlKPI.Controls.Add(cardTienPhat);
            pnlKPI.Controls.Add(cardLuuThong);
            pnlKPI.Controls.Add(cardSachSanSang);
            pnlKPI.Controls.Add(cardDocGia);
            pnlKPI.Dock = DockStyle.Top;
            pnlKPI.Location = new Point(15, 15);
            pnlKPI.Name = "pnlKPI";
            pnlKPI.Size = new Size(1112, 75);
            pnlKPI.TabIndex = 0;
            // 
            // cardTienPhat
            // 
            cardTienPhat.BackColor = Color.FromArgb(245, 243, 255);
            cardTienPhat.Controls.Add(lblTienPhatVal);
            cardTienPhat.Controls.Add(lblTienPhatTitle);
            cardTienPhat.Dock = DockStyle.Left;
            cardTienPhat.Location = new Point(825, 0);
            cardTienPhat.Name = "cardTienPhat";
            cardTienPhat.Padding = new Padding(12);
            cardTienPhat.Size = new Size(275, 75);
            cardTienPhat.TabIndex = 3;
            // 
            // lblTienPhatVal
            // 
            lblTienPhatVal.AutoSize = true;
            lblTienPhatVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTienPhatVal.ForeColor = Color.FromArgb(124, 58, 237);
            lblTienPhatVal.Location = new Point(12, 33);
            lblTienPhatVal.Name = "lblTienPhatVal";
            lblTienPhatVal.Size = new Size(40, 25);
            lblTienPhatVal.TabIndex = 1;
            lblTienPhatVal.Text = "0 đ";
            // 
            // lblTienPhatTitle
            // 
            lblTienPhatTitle.AutoSize = true;
            lblTienPhatTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTienPhatTitle.ForeColor = Color.FromArgb(109, 40, 217);
            lblTienPhatTitle.Location = new Point(12, 12);
            lblTienPhatTitle.Name = "lblTienPhatTitle";
            lblTienPhatTitle.Size = new Size(166, 13);
            lblTienPhatTitle.TabIndex = 0;
            lblTienPhatTitle.Text = "TIỀN PHẠT ĐÃ THU HỆ THỐNG";
            // 
            // cardLuuThong
            // 
            cardLuuThong.BackColor = Color.FromArgb(254, 243, 199);
            cardLuuThong.Controls.Add(lblLuuThongVal);
            cardLuuThong.Controls.Add(lblLuuThongTitle);
            cardLuuThong.Dock = DockStyle.Left;
            cardLuuThong.Location = new Point(550, 0);
            cardLuuThong.Name = "cardLuuThong";
            cardLuuThong.Padding = new Padding(12);
            cardLuuThong.Size = new Size(275, 75);
            cardLuuThong.TabIndex = 2;
            // 
            // lblLuuThongVal
            // 
            lblLuuThongVal.AutoSize = true;
            lblLuuThongVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLuuThongVal.ForeColor = Color.FromArgb(217, 119, 6);
            lblLuuThongVal.Location = new Point(12, 30);
            lblLuuThongVal.Name = "lblLuuThongVal";
            lblLuuThongVal.Size = new Size(26, 30);
            lblLuuThongVal.TabIndex = 1;
            lblLuuThongVal.Text = "0";
            // 
            // lblLuuThongTitle
            // 
            lblLuuThongTitle.AutoSize = true;
            lblLuuThongTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLuuThongTitle.ForeColor = Color.FromArgb(180, 83, 9);
            lblLuuThongTitle.Location = new Point(12, 12);
            lblLuuThongTitle.Name = "lblLuuThongTitle";
            lblLuuThongTitle.Size = new Size(141, 13);
            lblLuuThongTitle.TabIndex = 0;
            lblLuuThongTitle.Text = "LƯỢT ĐANG LƯU THÔNG";
            // 
            // cardSachSanSang
            // 
            cardSachSanSang.BackColor = Color.FromArgb(240, 253, 244);
            cardSachSanSang.Controls.Add(lblSachSanSangVal);
            cardSachSanSang.Controls.Add(lblSachSanSangTitle);
            cardSachSanSang.Dock = DockStyle.Left;
            cardSachSanSang.Location = new Point(275, 0);
            cardSachSanSang.Name = "cardSachSanSang";
            cardSachSanSang.Padding = new Padding(12);
            cardSachSanSang.Size = new Size(275, 75);
            cardSachSanSang.TabIndex = 1;
            // 
            // lblSachSanSangVal
            // 
            lblSachSanSangVal.AutoSize = true;
            lblSachSanSangVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSachSanSangVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblSachSanSangVal.Location = new Point(12, 30);
            lblSachSanSangVal.Name = "lblSachSanSangVal";
            lblSachSanSangVal.Size = new Size(26, 30);
            lblSachSanSangVal.TabIndex = 1;
            lblSachSanSangVal.Text = "0";
            // 
            // lblSachSanSangTitle
            // 
            lblSachSanSangTitle.AutoSize = true;
            lblSachSanSangTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSachSanSangTitle.ForeColor = Color.FromArgb(21, 128, 61);
            lblSachSanSangTitle.Location = new Point(12, 12);
            lblSachSanSangTitle.Name = "lblSachSanSangTitle";
            lblSachSanSangTitle.Size = new Size(122, 13);
            lblSachSanSangTitle.TabIndex = 0;
            lblSachSanSangTitle.Text = "SÁCH SẴN SÀNG KHO";
            // 
            // cardDocGia
            // 
            cardDocGia.BackColor = Color.FromArgb(240, 249, 255);
            cardDocGia.Controls.Add(lblDocGiaVal);
            cardDocGia.Controls.Add(lblDocGiaTitle);
            cardDocGia.Dock = DockStyle.Left;
            cardDocGia.Location = new Point(0, 0);
            cardDocGia.Name = "cardDocGia";
            cardDocGia.Padding = new Padding(12);
            cardDocGia.Size = new Size(275, 75);
            cardDocGia.TabIndex = 0;
            // 
            // lblDocGiaVal
            // 
            lblDocGiaVal.AutoSize = true;
            lblDocGiaVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDocGiaVal.ForeColor = Color.FromArgb(2, 132, 199);
            lblDocGiaVal.Location = new Point(12, 30);
            lblDocGiaVal.Name = "lblDocGiaVal";
            lblDocGiaVal.Size = new Size(26, 30);
            lblDocGiaVal.TabIndex = 1;
            lblDocGiaVal.Text = "3";
            // 
            // lblDocGiaTitle
            // 
            lblDocGiaTitle.AutoSize = true;
            lblDocGiaTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDocGiaTitle.ForeColor = Color.FromArgb(3, 105, 161);
            lblDocGiaTitle.Location = new Point(12, 12);
            lblDocGiaTitle.Name = "lblDocGiaTitle";
            lblDocGiaTitle.Size = new Size(105, 13);
            lblDocGiaTitle.TabIndex = 0;
            lblDocGiaTitle.Text = "ĐỘC GIẢ HIỆU LỰC";
            // 
            // tabKhoSach
            // 
            tabKhoSach.BackColor = Color.FromArgb(248, 250, 252);
            tabKhoSach.Controls.Add(dgvKhoSach);
            tabKhoSach.Controls.Add(pnlKhoKPI);
            tabKhoSach.Controls.Add(pnlKhoHeader);
            tabKhoSach.Location = new Point(4, 26);
            tabKhoSach.Name = "tabKhoSach";
            tabKhoSach.Padding = new Padding(15);
            tabKhoSach.Size = new Size(1142, 605);
            tabKhoSach.TabIndex = 1;
            tabKhoSach.Text = " 📚 Quản Lý Kho Sách Chi Nhánh ";
            // 
            // dgvKhoSach
            // 
            dgvKhoSach.AllowUserToAddRows = false;
            dgvKhoSach.AllowUserToDeleteRows = false;
            dgvKhoSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoSach.BackgroundColor = Color.White;
            dgvKhoSach.BorderStyle = BorderStyle.None;
            dgvKhoSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhoSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhoSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhoSach.ColumnHeadersHeight = 36;
            dgvKhoSach.Columns.AddRange(new DataGridViewColumn[] { colKS_MaSach, colKS_TieuDe, colKS_TheLoai, colKS_TacGia, colKS_TongBanSao, colKS_DangMuon, colKS_SanCo, colKS_BaoTri });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle4.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKhoSach.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKhoSach.Dock = DockStyle.Fill;
            dgvKhoSach.EnableHeadersVisualStyles = false;
            dgvKhoSach.GridColor = Color.FromArgb(241, 245, 249);
            dgvKhoSach.Location = new Point(15, 145);
            dgvKhoSach.Name = "dgvKhoSach";
            dgvKhoSach.ReadOnly = true;
            dgvKhoSach.RowHeadersVisible = false;
            dgvKhoSach.RowTemplate.Height = 34;
            dgvKhoSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhoSach.Size = new Size(1112, 445);
            dgvKhoSach.TabIndex = 2;
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
            colKS_SanCo.HeaderText = "Có Sẵn";
            colKS_SanCo.Name = "colKS_SanCo";
            colKS_SanCo.ReadOnly = true;
            // 
            // colKS_BaoTri
            // 
            colKS_BaoTri.DataPropertyName = "Bao_Tri";
            colKS_BaoTri.FillWeight = 50F;
            colKS_BaoTri.HeaderText = "Bảo Trì";
            colKS_BaoTri.Name = "colKS_BaoTri";
            colKS_BaoTri.ReadOnly = true;
            // 
            // pnlKhoKPI
            // 
            pnlKhoKPI.Controls.Add(pnlSanCoCN);
            pnlKhoKPI.Controls.Add(pnlDangMuonCN);
            pnlKhoKPI.Controls.Add(pnlTongBanSaoCN);
            pnlKhoKPI.Controls.Add(pnlTongDauSachCN);
            pnlKhoKPI.Dock = DockStyle.Top;
            pnlKhoKPI.Location = new Point(15, 70);
            pnlKhoKPI.Name = "pnlKhoKPI";
            pnlKhoKPI.Padding = new Padding(0, 10, 0, 10);
            pnlKhoKPI.Size = new Size(1112, 75);
            pnlKhoKPI.TabIndex = 1;
            // 
            // pnlSanCoCN
            // 
            pnlSanCoCN.BackColor = Color.White;
            pnlSanCoCN.Controls.Add(lblSanCoCNVal);
            pnlSanCoCN.Controls.Add(lblSanCoCNTitle);
            pnlSanCoCN.Dock = DockStyle.Left;
            pnlSanCoCN.Location = new Point(630, 10);
            pnlSanCoCN.Name = "pnlSanCoCN";
            pnlSanCoCN.Padding = new Padding(10);
            pnlSanCoCN.Size = new Size(210, 55);
            pnlSanCoCN.TabIndex = 3;
            // 
            // lblSanCoCNVal
            // 
            lblSanCoCNVal.AutoSize = true;
            lblSanCoCNVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSanCoCNVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblSanCoCNVal.Location = new Point(10, 24);
            lblSanCoCNVal.Name = "lblSanCoCNVal";
            lblSanCoCNVal.Size = new Size(23, 25);
            lblSanCoCNVal.TabIndex = 1;
            lblSanCoCNVal.Text = "0";
            // 
            // lblSanCoCNTitle
            // 
            lblSanCoCNTitle.AutoSize = true;
            lblSanCoCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSanCoCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSanCoCNTitle.Location = new Point(10, 8);
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
            pnlDangMuonCN.Location = new Point(420, 10);
            pnlDangMuonCN.Name = "pnlDangMuonCN";
            pnlDangMuonCN.Padding = new Padding(10);
            pnlDangMuonCN.Size = new Size(210, 55);
            pnlDangMuonCN.TabIndex = 2;
            // 
            // lblDangMuonCNVal
            // 
            lblDangMuonCNVal.AutoSize = true;
            lblDangMuonCNVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDangMuonCNVal.ForeColor = Color.FromArgb(217, 119, 6);
            lblDangMuonCNVal.Location = new Point(10, 24);
            lblDangMuonCNVal.Name = "lblDangMuonCNVal";
            lblDangMuonCNVal.Size = new Size(23, 25);
            lblDangMuonCNVal.TabIndex = 1;
            lblDangMuonCNVal.Text = "0";
            // 
            // lblDangMuonCNTitle
            // 
            lblDangMuonCNTitle.AutoSize = true;
            lblDangMuonCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDangMuonCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblDangMuonCNTitle.Location = new Point(10, 8);
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
            pnlTongBanSaoCN.Location = new Point(210, 10);
            pnlTongBanSaoCN.Name = "pnlTongBanSaoCN";
            pnlTongBanSaoCN.Padding = new Padding(10);
            pnlTongBanSaoCN.Size = new Size(210, 55);
            pnlTongBanSaoCN.TabIndex = 1;
            // 
            // lblTongBanSaoCNVal
            // 
            lblTongBanSaoCNVal.AutoSize = true;
            lblTongBanSaoCNVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongBanSaoCNVal.ForeColor = Color.FromArgb(2, 132, 199);
            lblTongBanSaoCNVal.Location = new Point(10, 24);
            lblTongBanSaoCNVal.Name = "lblTongBanSaoCNVal";
            lblTongBanSaoCNVal.Size = new Size(23, 25);
            lblTongBanSaoCNVal.TabIndex = 1;
            lblTongBanSaoCNVal.Text = "0";
            // 
            // lblTongBanSaoCNTitle
            // 
            lblTongBanSaoCNTitle.AutoSize = true;
            lblTongBanSaoCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTongBanSaoCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTongBanSaoCNTitle.Location = new Point(10, 8);
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
            pnlTongDauSachCN.Location = new Point(0, 10);
            pnlTongDauSachCN.Name = "pnlTongDauSachCN";
            pnlTongDauSachCN.Padding = new Padding(10);
            pnlTongDauSachCN.Size = new Size(210, 55);
            pnlTongDauSachCN.TabIndex = 0;
            // 
            // lblTongDauSachCNVal
            // 
            lblTongDauSachCNVal.AutoSize = true;
            lblTongDauSachCNVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongDauSachCNVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblTongDauSachCNVal.Location = new Point(10, 24);
            lblTongDauSachCNVal.Name = "lblTongDauSachCNVal";
            lblTongDauSachCNVal.Size = new Size(23, 25);
            lblTongDauSachCNVal.TabIndex = 1;
            lblTongDauSachCNVal.Text = "0";
            // 
            // lblTongDauSachCNTitle
            // 
            lblTongDauSachCNTitle.AutoSize = true;
            lblTongDauSachCNTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTongDauSachCNTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTongDauSachCNTitle.Location = new Point(10, 8);
            lblTongDauSachCNTitle.Name = "lblTongDauSachCNTitle";
            lblTongDauSachCNTitle.Size = new Size(97, 13);
            lblTongDauSachCNTitle.TabIndex = 0;
            lblTongDauSachCNTitle.Text = "TỔNG ĐẦU SÁCH";
            // 
            // pnlKhoHeader
            // 
            pnlKhoHeader.BackColor = Color.White;
            pnlKhoHeader.Controls.Add(btnTaiLaiKho);
            pnlKhoHeader.Controls.Add(txtTimKiemSach);
            pnlKhoHeader.Controls.Add(lblTimKiem);
            pnlKhoHeader.Controls.Add(cboChiNhanhKho);
            pnlKhoHeader.Controls.Add(lblChonChiNhanh);
            pnlKhoHeader.Dock = DockStyle.Top;
            pnlKhoHeader.Location = new Point(15, 15);
            pnlKhoHeader.Name = "pnlKhoHeader";
            pnlKhoHeader.Padding = new Padding(15, 10, 15, 10);
            pnlKhoHeader.Size = new Size(1112, 55);
            pnlKhoHeader.TabIndex = 0;
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
            // txtTimKiemSach
            // 
            txtTimKiemSach.Font = new Font("Segoe UI", 9.5F);
            txtTimKiemSach.Location = new Point(482, 14);
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.PlaceholderText = "Tên sách, tác giả, mã sách...";
            txtTimKiemSach.Size = new Size(250, 24);
            txtTimKiemSach.TabIndex = 3;
            txtTimKiemSach.TextChanged += txtTimKiemSach_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(51, 65, 85);
            lblTimKiem.Location = new Point(410, 18);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(65, 17);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm Sách:";
            // 
            // cboChiNhanhKho
            // 
            cboChiNhanhKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChiNhanhKho.Font = new Font("Segoe UI", 9.5F);
            cboChiNhanhKho.FormattingEnabled = true;
            cboChiNhanhKho.Location = new Point(128, 14);
            cboChiNhanhKho.Name = "cboChiNhanhKho";
            cboChiNhanhKho.Size = new Size(250, 25);
            cboChiNhanhKho.TabIndex = 1;
            cboChiNhanhKho.SelectedIndexChanged += cboChiNhanhKho_SelectedIndexChanged;
            // 
            // lblChonChiNhanh
            // 
            lblChonChiNhanh.AutoSize = true;
            lblChonChiNhanh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblChonChiNhanh.ForeColor = Color.FromArgb(51, 65, 85);
            lblChonChiNhanh.Location = new Point(15, 18);
            lblChonChiNhanh.Name = "lblChonChiNhanh";
            lblChonChiNhanh.Size = new Size(111, 17);
            lblChonChiNhanh.TabIndex = 0;
            lblChonChiNhanh.Text = "Chọn Chi Nhánh:";
            // 
            // FormTongQuanHeThong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1150, 700);
            Controls.Add(tabControlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTongQuanHeThong";
            Text = "Tổng Quan Hệ Thống";
            Load += FormTongQuanHeThong_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabThongKe.ResumeLayout(false);
            pnlDoiSoatSection.ResumeLayout(false);
            pnlDoiSoatSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoiSoat).EndInit();
            pnlLuuThongSection.ResumeLayout(false);
            pnlLuuThongSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLuuThongTuan).EndInit();
            pnlKPI.ResumeLayout(false);
            cardTienPhat.ResumeLayout(false);
            cardTienPhat.PerformLayout();
            cardLuuThong.ResumeLayout(false);
            cardLuuThong.PerformLayout();
            cardSachSanSang.ResumeLayout(false);
            cardSachSanSang.PerformLayout();
            cardDocGia.ResumeLayout(false);
            cardDocGia.PerformLayout();
            tabKhoSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoSach).EndInit();
            pnlKhoKPI.ResumeLayout(false);
            pnlSanCoCN.ResumeLayout(false);
            pnlSanCoCN.PerformLayout();
            pnlDangMuonCN.ResumeLayout(false);
            pnlDangMuonCN.PerformLayout();
            pnlTongBanSaoCN.ResumeLayout(false);
            pnlTongBanSaoCN.PerformLayout();
            pnlTongDauSachCN.ResumeLayout(false);
            pnlTongDauSachCN.PerformLayout();
            pnlKhoHeader.ResumeLayout(false);
            pnlKhoHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel pnlKPI;
        private System.Windows.Forms.Panel cardDocGia;
        private System.Windows.Forms.Label lblDocGiaTitle;
        private System.Windows.Forms.Label lblDocGiaVal;
        private System.Windows.Forms.Panel cardSachSanSang;
        private System.Windows.Forms.Label lblSachSanSangTitle;
        private System.Windows.Forms.Label lblSachSanSangVal;
        private System.Windows.Forms.Panel cardLuuThong;
        private System.Windows.Forms.Label lblLuuThongTitle;
        private System.Windows.Forms.Label lblLuuThongVal;
        private System.Windows.Forms.Panel cardTienPhat;
        private System.Windows.Forms.Label lblTienPhatTitle;
        private System.Windows.Forms.Label lblTienPhatVal;
        private System.Windows.Forms.Panel pnlLuuThongSection;
        private System.Windows.Forms.Label lblLuuThongHeader;
        private System.Windows.Forms.DataGridView dgvLuuThongTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTMuonTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTTraTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLTDangMuon;
        private System.Windows.Forms.Panel pnlDoiSoatSection;
        private System.Windows.Forms.Label lblDoiSoatHeader;
        private System.Windows.Forms.DataGridView dgvDoiSoat;
        private System.Windows.Forms.TabPage tabKhoSach;
        private System.Windows.Forms.Panel pnlKhoHeader;
        private System.Windows.Forms.Label lblChonChiNhanh;
        private System.Windows.Forms.ComboBox cboChiNhanhKho;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSach;
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
        private System.Windows.Forms.DataGridView dgvKhoSach;
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