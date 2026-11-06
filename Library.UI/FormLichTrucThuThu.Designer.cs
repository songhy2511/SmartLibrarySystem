using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormLichTrucThuThu
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
            pnlToday = new Panel();
            lblTodayContent = new Label();
            lblTodayTitle = new Label();
            pnlFilter = new Panel();
            btnLamMoi = new Button();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            lblKhoangThoiGian = new Label();
            btnSau = new Button();
            btnHienTai = new Button();
            btnTruoc = new Button();
            cboCheDoXem = new ComboBox();
            lblCheDo = new Label();
            pnlMain = new Panel();
            dgvLichTruc = new DataGridView();
            colNgayTruc = new DataGridViewTextBoxColumn();
            colChiNhanh = new DataGridViewTextBoxColumn();
            colTenCa = new DataGridViewTextBoxColumn();
            colKhungGio = new DataGridViewTextBoxColumn();
            colQuay = new DataGridViewTextBoxColumn();
            colTienDauCa = new DataGridViewTextBoxColumn();
            colTienKetCa = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlToday.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichTruc).BeginInit();
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
            pnlHeader.Size = new Size(1000, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(25, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(520, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Theo dõi phân công ca làm việc cá nhân, chi nhánh trực và định mức tiền bàn giao đối soát đầu ca";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LỊCH TRỰC CỦA THỦ THƯ";
            // 
            // pnlToday
            // 
            pnlToday.BackColor = Color.FromArgb(240, 253, 250);
            pnlToday.Controls.Add(lblTodayContent);
            pnlToday.Controls.Add(lblTodayTitle);
            pnlToday.Dock = DockStyle.Top;
            pnlToday.Location = new Point(0, 65);
            pnlToday.Name = "pnlToday";
            pnlToday.Padding = new Padding(25, 10, 25, 10);
            pnlToday.Size = new Size(1000, 65);
            pnlToday.TabIndex = 1;
            // 
            // lblTodayContent
            // 
            lblTodayContent.AutoSize = true;
            lblTodayContent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTodayContent.ForeColor = Color.FromArgb(15, 118, 110);
            lblTodayContent.Location = new Point(25, 34);
            lblTodayContent.Name = "lblTodayContent";
            lblTodayContent.Size = new Size(169, 17);
            lblTodayContent.TabIndex = 1;
            lblTodayContent.Text = "Đang kiểm tra ca trực hôm nay...";
            // 
            // lblTodayTitle
            // 
            lblTodayTitle.AutoSize = true;
            lblTodayTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTodayTitle.ForeColor = Color.FromArgb(13, 148, 136);
            lblTodayTitle.Location = new Point(25, 12);
            lblTodayTitle.Name = "lblTodayTitle";
            lblTodayTitle.Size = new Size(140, 15);
            lblTodayTitle.TabIndex = 0;
            lblTodayTitle.Text = "📌 CA TRỰC HÔM NAY:";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(248, 250, 252);
            pnlFilter.Controls.Add(btnLamMoi);
            pnlFilter.Controls.Add(btnLoc);
            pnlFilter.Controls.Add(dtpDenNgay);
            pnlFilter.Controls.Add(lblDenNgay);
            pnlFilter.Controls.Add(dtpTuNgay);
            pnlFilter.Controls.Add(lblTuNgay);
            pnlFilter.Controls.Add(lblKhoangThoiGian);
            pnlFilter.Controls.Add(btnSau);
            pnlFilter.Controls.Add(btnHienTai);
            pnlFilter.Controls.Add(btnTruoc);
            pnlFilter.Controls.Add(cboCheDoXem);
            pnlFilter.Controls.Add(lblCheDo);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 130);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(25, 10, 25, 10);
            pnlFilter.Size = new Size(1000, 55);
            pnlFilter.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(51, 65, 85);
            btnLamMoi.Location = new Point(900, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 30);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "🔄 Tải lại";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(15, 118, 110);
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(810, 12);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(60, 30);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 9F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(700, 15);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(100, 23);
            dtpDenNgay.TabIndex = 9;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 9F);
            lblDenNgay.ForeColor = Color.FromArgb(71, 85, 105);
            lblDenNgay.Location = new Point(665, 19);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(31, 15);
            lblDenNgay.TabIndex = 8;
            lblDenNgay.Text = "đến:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 9F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(555, 15);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(100, 23);
            dtpTuNgay.TabIndex = 7;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 9F);
            lblTuNgay.ForeColor = Color.FromArgb(71, 85, 105);
            lblTuNgay.Location = new Point(525, 19);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(23, 15);
            lblTuNgay.TabIndex = 6;
            lblTuNgay.Text = "Từ:";
            // 
            // lblKhoangThoiGian
            // 
            lblKhoangThoiGian.AutoSize = true;
            lblKhoangThoiGian.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblKhoangThoiGian.ForeColor = Color.FromArgb(15, 118, 110);
            lblKhoangThoiGian.Location = new Point(340, 18);
            lblKhoangThoiGian.Name = "lblKhoangThoiGian";
            lblKhoangThoiGian.Size = new Size(130, 17);
            lblKhoangThoiGian.TabIndex = 5;
            lblKhoangThoiGian.Text = "Tuần: --/-- đến --/--";
            // 
            // btnSau
            // 
            btnSau.BackColor = Color.FromArgb(241, 245, 249);
            btnSau.FlatAppearance.BorderSize = 0;
            btnSau.FlatStyle = FlatStyle.Flat;
            btnSau.Font = new Font("Segoe UI", 9F);
            btnSau.Location = new Point(285, 12);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(40, 30);
            btnSau.TabIndex = 4;
            btnSau.Text = "▶";
            btnSau.UseVisualStyleBackColor = false;
            btnSau.Click += btnSau_Click;
            // 
            // btnHienTai
            // 
            btnHienTai.BackColor = Color.FromArgb(241, 245, 249);
            btnHienTai.FlatAppearance.BorderSize = 0;
            btnHienTai.FlatStyle = FlatStyle.Flat;
            btnHienTai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnHienTai.ForeColor = Color.FromArgb(15, 118, 110);
            btnHienTai.Location = new Point(220, 12);
            btnHienTai.Name = "btnHienTai";
            btnHienTai.Size = new Size(60, 30);
            btnHienTai.TabIndex = 3;
            btnHienTai.Text = "Hiện tại";
            btnHienTai.UseVisualStyleBackColor = false;
            btnHienTai.Click += btnHienTai_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.BackColor = Color.FromArgb(241, 245, 249);
            btnTruoc.FlatAppearance.BorderSize = 0;
            btnTruoc.FlatStyle = FlatStyle.Flat;
            btnTruoc.Font = new Font("Segoe UI", 9F);
            btnTruoc.Location = new Point(175, 12);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(40, 30);
            btnTruoc.TabIndex = 2;
            btnTruoc.Text = "◀";
            btnTruoc.UseVisualStyleBackColor = false;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // cboCheDoXem
            // 
            cboCheDoXem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCheDoXem.Font = new Font("Segoe UI", 9F);
            cboCheDoXem.FormattingEnabled = true;
            cboCheDoXem.Items.AddRange(new object[] { "Theo Tuần", "Theo Tháng", "Tùy chọn ngày" });
            cboCheDoXem.Location = new Point(65, 15);
            cboCheDoXem.Name = "cboCheDoXem";
            cboCheDoXem.Size = new Size(100, 23);
            cboCheDoXem.TabIndex = 1;
            cboCheDoXem.SelectedIndexChanged += cboCheDoXem_SelectedIndexChanged;
            // 
            // lblCheDo
            // 
            lblCheDo.AutoSize = true;
            lblCheDo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCheDo.ForeColor = Color.FromArgb(51, 65, 85);
            lblCheDo.Location = new Point(25, 19);
            lblCheDo.Name = "lblCheDo";
            lblCheDo.Size = new Size(34, 15);
            lblCheDo.TabIndex = 0;
            lblCheDo.Text = "Xem:";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvLichTruc);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 185);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(25, 10, 25, 25);
            pnlMain.Size = new Size(1000, 435);
            pnlMain.TabIndex = 3;
            // 
            // dgvLichTruc
            // 
            dgvLichTruc.AllowUserToAddRows = false;
            dgvLichTruc.AllowUserToDeleteRows = false;
            dgvLichTruc.AllowUserToResizeRows = false;
            dgvLichTruc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichTruc.BackgroundColor = Color.White;
            dgvLichTruc.BorderStyle = BorderStyle.None;
            dgvLichTruc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLichTruc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(19, 78, 74);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichTruc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichTruc.ColumnHeadersHeight = 38;
            dgvLichTruc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLichTruc.Columns.AddRange(new DataGridViewColumn[] { colNgayTruc, colChiNhanh, colTenCa, colKhungGio, colQuay, colTienDauCa, colTienKetCa, colTrangThai, colGhiChu });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLichTruc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLichTruc.Dock = DockStyle.Fill;
            dgvLichTruc.EnableHeadersVisualStyles = false;
            dgvLichTruc.GridColor = Color.FromArgb(241, 245, 249);
            dgvLichTruc.Location = new Point(25, 10);
            dgvLichTruc.MultiSelect = false;
            dgvLichTruc.Name = "dgvLichTruc";
            dgvLichTruc.ReadOnly = true;
            dgvLichTruc.RowHeadersVisible = false;
            dgvLichTruc.RowTemplate.Height = 36;
            dgvLichTruc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichTruc.Size = new Size(950, 400);
            dgvLichTruc.TabIndex = 0;
            dgvLichTruc.CellFormatting += dgvLichTruc_CellFormatting;
            // 
            // colNgayTruc
            // 
            colNgayTruc.DataPropertyName = "Ngay_Truc";
            colNgayTruc.FillWeight = 85F;
            colNgayTruc.HeaderText = "Thứ / Ngày";
            colNgayTruc.Name = "colNgayTruc";
            colNgayTruc.ReadOnly = true;
            // 
            // colChiNhanh
            // 
            colChiNhanh.DataPropertyName = "Ten_Chi_Nhanh";
            colChiNhanh.FillWeight = 95F;
            colChiNhanh.HeaderText = "Chi Nhánh";
            colChiNhanh.Name = "colChiNhanh";
            colChiNhanh.ReadOnly = true;
            // 
            // colTenCa
            // 
            colTenCa.DataPropertyName = "Ten_Ca";
            colTenCa.FillWeight = 55F;
            colTenCa.HeaderText = "Ca Trực";
            colTenCa.Name = "colTenCa";
            colTenCa.ReadOnly = true;
            // 
            // colKhungGio
            // 
            colKhungGio.FillWeight = 75F;
            colKhungGio.HeaderText = "Khung Giờ";
            colKhungGio.Name = "colKhungGio";
            colKhungGio.ReadOnly = true;
            // 
            // colQuay
            // 
            colQuay.DataPropertyName = "Quay_Phu_Trach";
            colQuay.FillWeight = 80F;
            colQuay.HeaderText = "Quầy Phục Vụ";
            colQuay.Name = "colQuay";
            colQuay.ReadOnly = true;
            // 
            // colTienDauCa
            // 
            colTienDauCa.DataPropertyName = "Tien_Dau_Ca";
            colTienDauCa.FillWeight = 70F;
            colTienDauCa.HeaderText = "Tiền Đầu Ca";
            colTienDauCa.Name = "colTienDauCa";
            colTienDauCa.ReadOnly = true;
            // 
            // colTienKetCa
            // 
            colTienKetCa.DataPropertyName = "Tien_Ket_Ca";
            colTienKetCa.FillWeight = 70F;
            colTienKetCa.HeaderText = "Tiền Kết Ca";
            colTienKetCa.Name = "colTienKetCa";
            colTienKetCa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "Trang_Thai";
            colTrangThai.FillWeight = 65F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "Ghi_Chu";
            colGhiChu.FillWeight = 90F;
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            // 
            // FormLichTrucThuThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1000, 620);
            Controls.Add(pnlMain);
            Controls.Add(pnlFilter);
            Controls.Add(pnlToday);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLichTrucThuThu";
            Text = "Lịch Trực Thủ Thư";
            Load += FormLichTrucThuThu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToday.ResumeLayout(false);
            pnlToday.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichTruc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubTitle;
        private Panel pnlToday;
        private Label lblTodayTitle;
        private Label lblTodayContent;
        private Panel pnlFilter;
        private Label lblCheDo;
        private ComboBox cboCheDoXem;
        private Button btnTruoc;
        private Button btnHienTai;
        private Button btnSau;
        private Label lblKhoangThoiGian;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnLoc;
        private Button btnLamMoi;
        private Panel pnlMain;
        private DataGridView dgvLichTruc;
        private DataGridViewTextBoxColumn colNgayTruc;
        private DataGridViewTextBoxColumn colChiNhanh;
        private DataGridViewTextBoxColumn colTenCa;
        private DataGridViewTextBoxColumn colKhungGio;
        private DataGridViewTextBoxColumn colQuay;
        private DataGridViewTextBoxColumn colTienDauCa;
        private DataGridViewTextBoxColumn colTienKetCa;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colGhiChu;
    }
}