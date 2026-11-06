namespace Library.UI
{
    partial class FormBaoCaoThongKe
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
            pnlMain = new System.Windows.Forms.Panel();
            lblCanhBao = new System.Windows.Forms.Label();
            pnlCard4 = new System.Windows.Forms.Panel();
            pnlIndicator4 = new System.Windows.Forms.Panel();
            lblValCaLech = new System.Windows.Forms.Label();
            lblTitleCard4 = new System.Windows.Forms.Label();
            pnlCard3 = new System.Windows.Forms.Panel();
            pnlIndicator3 = new System.Windows.Forms.Panel();
            lblValLuotMuon = new System.Windows.Forms.Label();
            lblTitleCard3 = new System.Windows.Forms.Label();
            tabControlBaoCao = new System.Windows.Forms.TabControl();
            tabDoanhThuCa = new System.Windows.Forms.TabPage();
            dgvDoanhThuCa = new System.Windows.Forms.DataGridView();
            tabTopSach = new System.Windows.Forms.TabPage();
            dgvTopSach = new System.Windows.Forms.DataGridView();
            tabQuayVong = new System.Windows.Forms.TabPage();
            dgvQuayVong = new System.Windows.Forms.DataGridView();
            pnlFilterCard = new System.Windows.Forms.Panel();
            btn30Ngay = new System.Windows.Forms.Button();
            btn7Ngay = new System.Windows.Forms.Button();
            nudTopSach = new System.Windows.Forms.NumericUpDown();
            lblTopSach = new System.Windows.Forms.Label();
            cboChiNhanh = new System.Windows.Forms.ComboBox();
            lblChiNhanh = new System.Windows.Forms.Label();
            btnInBaoCao = new System.Windows.Forms.Button();
            btnXuatPdf = new System.Windows.Forms.Button();
            btnXuatExcel = new System.Windows.Forms.Button();
            btnXuatFile = new System.Windows.Forms.Button();
            btnXem = new System.Windows.Forms.Button();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            lblDen = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblTu = new System.Windows.Forms.Label();
            pnlCard2 = new System.Windows.Forms.Panel();
            pnlIndicator2 = new System.Windows.Forms.Panel();
            lblValTienConNo = new System.Windows.Forms.Label();
            lblTitleCard2 = new System.Windows.Forms.Label();
            pnlCard1 = new System.Windows.Forms.Panel();
            pnlIndicator1 = new System.Windows.Forms.Panel();
            lblValTongDoanhThu = new System.Windows.Forms.Label();
            lblTitleCard1 = new System.Windows.Forms.Label();
            pnlTopHeader = new System.Windows.Forms.Panel();
            lblSubTitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlMain.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlCard3.SuspendLayout();
            tabControlBaoCao.SuspendLayout();
            tabDoanhThuCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThuCa).BeginInit();
            tabTopSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopSach).BeginInit();
            tabQuayVong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuayVong).BeginInit();
            pnlFilterCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopSach).BeginInit();
            pnlCard2.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlTopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlMain.Controls.Add(lblCanhBao);
            pnlMain.Controls.Add(pnlCard4);
            pnlMain.Controls.Add(pnlCard3);
            pnlMain.Controls.Add(tabControlBaoCao);
            pnlMain.Controls.Add(pnlFilterCard);
            pnlMain.Controls.Add(pnlCard2);
            pnlMain.Controls.Add(pnlCard1);
            pnlMain.Controls.Add(pnlTopHeader);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new System.Windows.Forms.Padding(32, 37, 32, 37);
            pnlMain.Size = new System.Drawing.Size(1533, 1108);
            pnlMain.TabIndex = 0;
            // 
            // lblCanhBao
            // 
            lblCanhBao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCanhBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCanhBao.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblCanhBao.Location = new System.Drawing.Point(36, 430);
            lblCanhBao.Name = "lblCanhBao";
            lblCanhBao.Size = new System.Drawing.Size(1461, 23);
            lblCanhBao.TabIndex = 7;
            lblCanhBao.Text = "Tiền đã thu gắn vào ca của thủ thư thu tiền. Tiền lý thuyết = tiền đầu ca + tiền đã thu. Chênh lệch quỹ = tiền kết ca − tiền lý thuyết.";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = System.Drawing.Color.White;
            pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard4.Controls.Add(pnlIndicator4);
            pnlCard4.Controls.Add(lblValCaLech);
            pnlCard4.Controls.Add(lblTitleCard4);
            pnlCard4.Location = new System.Drawing.Point(1142, 169);
            pnlCard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new System.Drawing.Size(355, 130);
            pnlCard4.TabIndex = 6;
            // 
            // pnlIndicator4
            // 
            pnlIndicator4.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            pnlIndicator4.Dock = System.Windows.Forms.DockStyle.Left;
            pnlIndicator4.Location = new System.Drawing.Point(0, 0);
            pnlIndicator4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlIndicator4.Name = "pnlIndicator4";
            pnlIndicator4.Size = new System.Drawing.Size(7, 128);
            pnlIndicator4.TabIndex = 0;
            // 
            // lblValCaLech
            // 
            lblValCaLech.AutoSize = true;
            lblValCaLech.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            lblValCaLech.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblValCaLech.Location = new System.Drawing.Point(21, 58);
            lblValCaLech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValCaLech.Name = "lblValCaLech";
            lblValCaLech.Size = new System.Drawing.Size(34, 41);
            lblValCaLech.TabIndex = 1;
            lblValCaLech.Text = "0";
            // 
            // lblTitleCard4
            // 
            lblTitleCard4.AutoSize = true;
            lblTitleCard4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitleCard4.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitleCard4.Location = new System.Drawing.Point(24, 23);
            lblTitleCard4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitleCard4.Name = "lblTitleCard4";
            lblTitleCard4.Size = new System.Drawing.Size(95, 19);
            lblTitleCard4.TabIndex = 2;
            lblTitleCard4.Text = "CA LỆCH QUỸ";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = System.Drawing.Color.White;
            pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(pnlIndicator3);
            pnlCard3.Controls.Add(lblValLuotMuon);
            pnlCard3.Controls.Add(lblTitleCard3);
            pnlCard3.Location = new System.Drawing.Point(772, 169);
            pnlCard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new System.Drawing.Size(355, 130);
            pnlCard3.TabIndex = 5;
            // 
            // pnlIndicator3
            // 
            pnlIndicator3.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            pnlIndicator3.Dock = System.Windows.Forms.DockStyle.Left;
            pnlIndicator3.Location = new System.Drawing.Point(0, 0);
            pnlIndicator3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlIndicator3.Name = "pnlIndicator3";
            pnlIndicator3.Size = new System.Drawing.Size(7, 128);
            pnlIndicator3.TabIndex = 0;
            // 
            // lblValLuotMuon
            // 
            lblValLuotMuon.AutoSize = true;
            lblValLuotMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            lblValLuotMuon.ForeColor = System.Drawing.Color.FromArgb(3, 105, 161);
            lblValLuotMuon.Location = new System.Drawing.Point(21, 58);
            lblValLuotMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValLuotMuon.Name = "lblValLuotMuon";
            lblValLuotMuon.Size = new System.Drawing.Size(34, 41);
            lblValLuotMuon.TabIndex = 1;
            lblValLuotMuon.Text = "0";
            // 
            // lblTitleCard3
            // 
            lblTitleCard3.AutoSize = true;
            lblTitleCard3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitleCard3.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitleCard3.Location = new System.Drawing.Point(24, 23);
            lblTitleCard3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitleCard3.Name = "lblTitleCard3";
            lblTitleCard3.Size = new System.Drawing.Size(161, 19);
            lblTitleCard3.TabIndex = 2;
            lblTitleCard3.Text = "LƯỢT MƯỢN TRONG KỲ";
            // 
            // tabControlBaoCao
            // 
            tabControlBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControlBaoCao.Controls.Add(tabDoanhThuCa);
            tabControlBaoCao.Controls.Add(tabTopSach);
            tabControlBaoCao.Controls.Add(tabQuayVong);
            tabControlBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            tabControlBaoCao.Location = new System.Drawing.Point(32, 465);
            tabControlBaoCao.Name = "tabControlBaoCao";
            tabControlBaoCao.SelectedIndex = 0;
            tabControlBaoCao.Size = new System.Drawing.Size(1469, 596);
            tabControlBaoCao.TabIndex = 4;
            tabControlBaoCao.SelectedIndexChanged += tabControlBaoCao_SelectedIndexChanged;
            // 
            // tabDoanhThuCa
            // 
            tabDoanhThuCa.Controls.Add(dgvDoanhThuCa);
            tabDoanhThuCa.Location = new System.Drawing.Point(4, 32);
            tabDoanhThuCa.Name = "tabDoanhThuCa";
            tabDoanhThuCa.Padding = new System.Windows.Forms.Padding(10);
            tabDoanhThuCa.Size = new System.Drawing.Size(1461, 560);
            tabDoanhThuCa.TabIndex = 0;
            tabDoanhThuCa.Text = " 💵 Doanh Thu Theo Ca Trực ";
            tabDoanhThuCa.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThuCa
            // 
            dgvDoanhThuCa.AllowUserToAddRows = false;
            dgvDoanhThuCa.AllowUserToDeleteRows = false;
            dgvDoanhThuCa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThuCa.BackgroundColor = System.Drawing.Color.White;
            dgvDoanhThuCa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvDoanhThuCa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoanhThuCa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDoanhThuCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoanhThuCa.ColumnHeadersHeight = 44;
            dgvDoanhThuCa.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDoanhThuCa.EnableHeadersVisualStyles = false;
            dgvDoanhThuCa.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvDoanhThuCa.Location = new System.Drawing.Point(10, 10);
            dgvDoanhThuCa.Name = "dgvDoanhThuCa";
            dgvDoanhThuCa.ReadOnly = true;
            dgvDoanhThuCa.RowHeadersVisible = false;
            dgvDoanhThuCa.RowTemplate.Height = 40;
            dgvDoanhThuCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThuCa.Size = new System.Drawing.Size(1441, 540);
            dgvDoanhThuCa.TabIndex = 0;
            // 
            // tabTopSach
            // 
            tabTopSach.Controls.Add(dgvTopSach);
            tabTopSach.Location = new System.Drawing.Point(4, 32);
            tabTopSach.Name = "tabTopSach";
            tabTopSach.Padding = new System.Windows.Forms.Padding(10);
            tabTopSach.Size = new System.Drawing.Size(1461, 560);
            tabTopSach.TabIndex = 1;
            tabTopSach.Text = " 📚 Top Sách Mượn Nhiều ";
            tabTopSach.UseVisualStyleBackColor = true;
            // 
            // dgvTopSach
            // 
            dgvTopSach.AllowUserToAddRows = false;
            dgvTopSach.AllowUserToDeleteRows = false;
            dgvTopSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopSach.BackgroundColor = System.Drawing.Color.White;
            dgvTopSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTopSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTopSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvTopSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTopSach.ColumnHeadersHeight = 44;
            dgvTopSach.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTopSach.EnableHeadersVisualStyles = false;
            dgvTopSach.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvTopSach.Location = new System.Drawing.Point(10, 10);
            dgvTopSach.Name = "dgvTopSach";
            dgvTopSach.ReadOnly = true;
            dgvTopSach.RowHeadersVisible = false;
            dgvTopSach.RowTemplate.Height = 40;
            dgvTopSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTopSach.Size = new System.Drawing.Size(1441, 540);
            dgvTopSach.TabIndex = 0;
            // 
            // tabQuayVong
            // 
            tabQuayVong.Controls.Add(dgvQuayVong);
            tabQuayVong.Location = new System.Drawing.Point(4, 32);
            tabQuayVong.Name = "tabQuayVong";
            tabQuayVong.Padding = new System.Windows.Forms.Padding(10);
            tabQuayVong.Size = new System.Drawing.Size(1461, 560);
            tabQuayVong.TabIndex = 2;
            tabQuayVong.Text = " 🔄 Tỷ Lệ Quay Vòng Chi Nhánh ";
            tabQuayVong.UseVisualStyleBackColor = true;
            // 
            // dgvQuayVong
            // 
            dgvQuayVong.AllowUserToAddRows = false;
            dgvQuayVong.AllowUserToDeleteRows = false;
            dgvQuayVong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuayVong.BackgroundColor = System.Drawing.Color.White;
            dgvQuayVong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvQuayVong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvQuayVong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvQuayVong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuayVong.ColumnHeadersHeight = 44;
            dgvQuayVong.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvQuayVong.EnableHeadersVisualStyles = false;
            dgvQuayVong.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvQuayVong.Location = new System.Drawing.Point(10, 10);
            dgvQuayVong.Name = "dgvQuayVong";
            dgvQuayVong.ReadOnly = true;
            dgvQuayVong.RowHeadersVisible = false;
            dgvQuayVong.RowTemplate.Height = 40;
            dgvQuayVong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvQuayVong.Size = new System.Drawing.Size(1441, 540);
            dgvQuayVong.TabIndex = 0;
            // 
            // pnlFilterCard
            // 
            pnlFilterCard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFilterCard.BackColor = System.Drawing.Color.White;
            pnlFilterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlFilterCard.Controls.Add(btn30Ngay);
            pnlFilterCard.Controls.Add(btn7Ngay);
            pnlFilterCard.Controls.Add(nudTopSach);
            pnlFilterCard.Controls.Add(lblTopSach);
            pnlFilterCard.Controls.Add(cboChiNhanh);
            pnlFilterCard.Controls.Add(lblChiNhanh);
            pnlFilterCard.Controls.Add(btnInBaoCao);
            pnlFilterCard.Controls.Add(btnXuatPdf);
            pnlFilterCard.Controls.Add(btnXuatExcel);
            pnlFilterCard.Controls.Add(btnXuatFile);
            pnlFilterCard.Controls.Add(btnXem);
            pnlFilterCard.Controls.Add(dtpDenNgay);
            pnlFilterCard.Controls.Add(lblDen);
            pnlFilterCard.Controls.Add(dtpTuNgay);
            pnlFilterCard.Controls.Add(lblTu);
            pnlFilterCard.Location = new System.Drawing.Point(32, 315);
            pnlFilterCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Size = new System.Drawing.Size(1469, 105);
            pnlFilterCard.TabIndex = 3;
            // 
            // btn30Ngay
            // 
            btn30Ngay.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btn30Ngay.Cursor = System.Windows.Forms.Cursors.Hand;
            btn30Ngay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btn30Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn30Ngay.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            btn30Ngay.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btn30Ngay.Location = new System.Drawing.Point(107, 58);
            btn30Ngay.Name = "btn30Ngay";
            btn30Ngay.Size = new System.Drawing.Size(80, 32);
            btn30Ngay.TabIndex = 14;
            btn30Ngay.Text = "30 ngày";
            btn30Ngay.UseVisualStyleBackColor = false;
            btn30Ngay.Click += btn30Ngay_Click;
            // 
            // btn7Ngay
            // 
            btn7Ngay.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btn7Ngay.Cursor = System.Windows.Forms.Cursors.Hand;
            btn7Ngay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btn7Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn7Ngay.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            btn7Ngay.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btn7Ngay.Location = new System.Drawing.Point(18, 58);
            btn7Ngay.Name = "btn7Ngay";
            btn7Ngay.Size = new System.Drawing.Size(80, 32);
            btn7Ngay.TabIndex = 13;
            btn7Ngay.Text = "7 ngày";
            btn7Ngay.UseVisualStyleBackColor = false;
            btn7Ngay.Click += btn7Ngay_Click;
            // 
            // nudTopSach
            // 
            nudTopSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            nudTopSach.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudTopSach.Location = new System.Drawing.Point(630, 16);
            nudTopSach.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudTopSach.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTopSach.Name = "nudTopSach";
            nudTopSach.Size = new System.Drawing.Size(65, 27);
            nudTopSach.TabIndex = 12;
            nudTopSach.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblTopSach
            // 
            lblTopSach.AutoSize = true;
            lblTopSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTopSach.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTopSach.Location = new System.Drawing.Point(555, 19);
            lblTopSach.Name = "lblTopSach";
            lblTopSach.Size = new System.Drawing.Size(73, 20);
            lblTopSach.TabIndex = 11;
            lblTopSach.Text = "Top sách:";
            // 
            // cboChiNhanh
            // 
            cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboChiNhanh.FormattingEnabled = true;
            cboChiNhanh.Location = new System.Drawing.Point(348, 15);
            cboChiNhanh.Name = "cboChiNhanh";
            cboChiNhanh.Size = new System.Drawing.Size(185, 28);
            cboChiNhanh.TabIndex = 10;
            cboChiNhanh.SelectedIndexChanged += cboChiNhanh_SelectedIndexChanged;
            // 
            // lblChiNhanh
            // 
            lblChiNhanh.AutoSize = true;
            lblChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblChiNhanh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblChiNhanh.Location = new System.Drawing.Point(265, 19);
            lblChiNhanh.Name = "lblChiNhanh";
            lblChiNhanh.Size = new System.Drawing.Size(82, 20);
            lblChiNhanh.TabIndex = 9;
            lblChiNhanh.Text = "Chi nhánh:";
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            btnInBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInBaoCao.FlatAppearance.BorderSize = 0;
            btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnInBaoCao.ForeColor = System.Drawing.Color.White;
            btnInBaoCao.Location = new System.Drawing.Point(210, 55);
            btnInBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new System.Drawing.Size(125, 38);
            btnInBaoCao.TabIndex = 0;
            btnInBaoCao.Text = "🖨️ In báo cáo";
            btnInBaoCao.UseVisualStyleBackColor = false;
            btnInBaoCao.Click += btnInBaoCao_Click;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            btnXuatPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            btnXuatPdf.FlatAppearance.BorderSize = 0;
            btnXuatPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuatPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnXuatPdf.ForeColor = System.Drawing.Color.White;
            btnXuatPdf.Location = new System.Drawing.Point(620, 55);
            btnXuatPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new System.Drawing.Size(125, 38);
            btnXuatPdf.TabIndex = 1;
            btnXuatPdf.Text = "📄 Xuất PDF";
            btnXuatPdf.UseVisualStyleBackColor = false;
            btnXuatPdf.Click += btnXuatPdf_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnXuatExcel.ForeColor = System.Drawing.Color.White;
            btnXuatExcel.Location = new System.Drawing.Point(482, 55);
            btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new System.Drawing.Size(125, 38);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "📊 Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
            btnXuatFile.FlatAppearance.BorderSize = 0;
            btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXuatFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnXuatFile.ForeColor = System.Drawing.Color.White;
            btnXuatFile.Location = new System.Drawing.Point(346, 55);
            btnXuatFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new System.Drawing.Size(125, 38);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "📥 Xuất CSV";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // btnXem
            // 
            btnXem.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnXem.FlatAppearance.BorderSize = 0;
            btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnXem.ForeColor = System.Drawing.Color.White;
            btnXem.Location = new System.Drawing.Point(715, 12);
            btnXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnXem.Name = "btnXem";
            btnXem.Size = new System.Drawing.Size(95, 33);
            btnXem.TabIndex = 4;
            btnXem.Text = "🔍 Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(155, 15);
            dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(95, 27);
            dtpDenNgay.TabIndex = 5;
            // 
            // lblDen
            // 
            lblDen.AutoSize = true;
            lblDen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblDen.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDen.Location = new System.Drawing.Point(122, 19);
            lblDen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDen.Name = "lblDen";
            lblDen.Size = new System.Drawing.Size(39, 20);
            lblDen.TabIndex = 6;
            lblDen.Text = "đến:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(22, 15);
            dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(95, 27);
            dtpTuNgay.TabIndex = 7;
            // 
            // lblTu
            // 
            lblTu.AutoSize = true;
            lblTu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblTu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTu.Location = new System.Drawing.Point(-60, 19);
            lblTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTu.Name = "lblTu";
            lblTu.Size = new System.Drawing.Size(68, 20);
            lblTu.TabIndex = 8;
            lblTu.Text = "Từ ngày:";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = System.Drawing.Color.White;
            pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(pnlIndicator2);
            pnlCard2.Controls.Add(lblValTienConNo);
            pnlCard2.Controls.Add(lblTitleCard2);
            pnlCard2.Location = new System.Drawing.Point(402, 169);
            pnlCard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new System.Drawing.Size(355, 130);
            pnlCard2.TabIndex = 2;
            // 
            // pnlIndicator2
            // 
            pnlIndicator2.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            pnlIndicator2.Dock = System.Windows.Forms.DockStyle.Left;
            pnlIndicator2.Location = new System.Drawing.Point(0, 0);
            pnlIndicator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlIndicator2.Name = "pnlIndicator2";
            pnlIndicator2.Size = new System.Drawing.Size(7, 128);
            pnlIndicator2.TabIndex = 0;
            // 
            // lblValTienConNo
            // 
            lblValTienConNo.AutoSize = true;
            lblValTienConNo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            lblValTienConNo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblValTienConNo.Location = new System.Drawing.Point(21, 58);
            lblValTienConNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValTienConNo.Name = "lblValTienConNo";
            lblValTienConNo.Size = new System.Drawing.Size(65, 41);
            lblValTienConNo.TabIndex = 1;
            lblValTienConNo.Text = "0 đ";
            // 
            // lblTitleCard2
            // 
            lblTitleCard2.AutoSize = true;
            lblTitleCard2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitleCard2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitleCard2.Location = new System.Drawing.Point(24, 23);
            lblTitleCard2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitleCard2.Name = "lblTitleCard2";
            lblTitleCard2.Size = new System.Drawing.Size(144, 19);
            lblTitleCard2.TabIndex = 2;
            lblTitleCard2.Text = "TIỀN PHẠT CÒN NỢ";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = System.Drawing.Color.White;
            pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(pnlIndicator1);
            pnlCard1.Controls.Add(lblValTongDoanhThu);
            pnlCard1.Controls.Add(lblTitleCard1);
            pnlCard1.Location = new System.Drawing.Point(32, 169);
            pnlCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new System.Drawing.Size(355, 130);
            pnlCard1.TabIndex = 1;
            // 
            // pnlIndicator1
            // 
            pnlIndicator1.BackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            pnlIndicator1.Dock = System.Windows.Forms.DockStyle.Left;
            pnlIndicator1.Location = new System.Drawing.Point(0, 0);
            pnlIndicator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlIndicator1.Name = "pnlIndicator1";
            pnlIndicator1.Size = new System.Drawing.Size(7, 128);
            pnlIndicator1.TabIndex = 0;
            // 
            // lblValTongDoanhThu
            // 
            lblValTongDoanhThu.AutoSize = true;
            lblValTongDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            lblValTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblValTongDoanhThu.Location = new System.Drawing.Point(21, 58);
            lblValTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValTongDoanhThu.Name = "lblValTongDoanhThu";
            lblValTongDoanhThu.Size = new System.Drawing.Size(65, 41);
            lblValTongDoanhThu.TabIndex = 1;
            lblValTongDoanhThu.Text = "0 đ";
            // 
            // lblTitleCard1
            // 
            lblTitleCard1.AutoSize = true;
            lblTitleCard1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitleCard1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitleCard1.Location = new System.Drawing.Point(24, 23);
            lblTitleCard1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitleCard1.Name = "lblTitleCard1";
            lblTitleCard1.Size = new System.Drawing.Size(144, 19);
            lblTitleCard1.TabIndex = 2;
            lblTitleCard1.Text = "TIỀN PHẠT ĐÃ THU";
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = System.Drawing.Color.White;
            pnlTopHeader.Controls.Add(lblSubTitle);
            pnlTopHeader.Controls.Add(lblTitle);
            pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopHeader.Location = new System.Drawing.Point(32, 37);
            pnlTopHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new System.Drawing.Size(1469, 108);
            pnlTopHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new System.Drawing.Point(19, 62);
            lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new System.Drawing.Size(627, 21);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Doanh thu theo ca, sách mượn nhiều và tỷ lệ quay vòng — số liệu bám đúng kỳ và chi nhánh đã chọn.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(16, 15);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(298, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Báo cáo thống kê thư viện";
            // 
            // FormBaoCaoThongKe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1533, 1108);
            Controls.Add(pnlMain);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormBaoCaoThongKe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Báo Cáo & Thống Kê Tổng Hợp";
            Load += FormBaoCaoThongKe_Load;
            pnlMain.ResumeLayout(false);
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            tabControlBaoCao.ResumeLayout(false);
            tabDoanhThuCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThuCa).EndInit();
            tabTopSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopSach).EndInit();
            tabQuayVong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuayVong).EndInit();
            pnlFilterCard.ResumeLayout(false);
            pnlFilterCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopSach).EndInit();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlIndicator1;
        private System.Windows.Forms.Label lblTitleCard1;
        private System.Windows.Forms.Label lblValTongDoanhThu;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlIndicator2;
        private System.Windows.Forms.Label lblTitleCard2;
        private System.Windows.Forms.Label lblValTienConNo;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlIndicator3;
        private System.Windows.Forms.Label lblTitleCard3;
        private System.Windows.Forms.Label lblValLuotMuon;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Panel pnlIndicator4;
        private System.Windows.Forms.Label lblTitleCard4;
        private System.Windows.Forms.Label lblValCaLech;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label lblTopSach;
        private System.Windows.Forms.NumericUpDown nudTopSach;
        private System.Windows.Forms.Button btn7Ngay;
        private System.Windows.Forms.Button btn30Ngay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.TabControl tabControlBaoCao;
        private System.Windows.Forms.TabPage tabDoanhThuCa;
        private System.Windows.Forms.DataGridView dgvDoanhThuCa;
        private System.Windows.Forms.TabPage tabTopSach;
        private System.Windows.Forms.DataGridView dgvTopSach;
        private System.Windows.Forms.TabPage tabQuayVong;
        private System.Windows.Forms.DataGridView dgvQuayVong;
    }
}