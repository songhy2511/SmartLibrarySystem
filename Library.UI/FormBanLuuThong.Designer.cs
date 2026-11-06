using System.Drawing;
using System.Windows.Forms;

namespace Library.UI
{
    partial class FormBanLuuThong
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
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            grpMuonSach = new GroupBox();
            btnLamMoi = new Button();
            btnLapPhieuMuon = new Button();
            dtpNgayHenHan = new DateTimePicker();
            lblNgayHenHan = new Label();
            dtpNgayMuon = new DateTimePicker();
            lblNgayMuon = new Label();
            txtMaSach = new TextBox();
            lblMaSach = new Label();
            cboDocGia = new ComboBox();
            lblDocGia = new Label();
            grpDanhSach = new GroupBox();
            btnDoiSDT = new Button();
            chkChiQuaHan = new CheckBox();
            btnXacNhanTra = new Button();
            btnGiaHan = new Button();
            dgvSachDangMuon = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colTenDocGia = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colMaVach = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colNgayHenHan = new DataGridViewTextBoxColumn();
            colTinhTrangHan = new DataGridViewTextBoxColumn();
            colSoLanGiaHan = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            grpMuonSach.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(19, 78, 74);
            lblTieuDe.Location = new Point(25, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(207, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀN LƯU THÔNG";
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = true;
            lblPhuDe.Font = new Font("Segoe UI", 9.5F);
            lblPhuDe.ForeColor = Color.FromArgb(100, 116, 139);
            lblPhuDe.Location = new Point(27, 44);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(540, 17);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Quản lý mượn/trả sách, giám sát tiến độ hoàn trả toàn thư viện và cảnh báo trễ hạn tự động";
            // 
            // grpMuonSach
            // 
            grpMuonSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpMuonSach.Controls.Add(btnLamMoi);
            grpMuonSach.Controls.Add(btnLapPhieuMuon);
            grpMuonSach.Controls.Add(dtpNgayHenHan);
            grpMuonSach.Controls.Add(lblNgayHenHan);
            grpMuonSach.Controls.Add(dtpNgayMuon);
            grpMuonSach.Controls.Add(lblNgayMuon);
            grpMuonSach.Controls.Add(txtMaSach);
            grpMuonSach.Controls.Add(lblMaSach);
            grpMuonSach.Controls.Add(cboDocGia);
            grpMuonSach.Controls.Add(lblDocGia);
            grpMuonSach.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpMuonSach.ForeColor = Color.FromArgb(30, 41, 59);
            grpMuonSach.Location = new Point(25, 70);
            grpMuonSach.Name = "grpMuonSach";
            grpMuonSach.Size = new Size(1010, 135);
            grpMuonSach.TabIndex = 2;
            grpMuonSach.TabStop = false;
            grpMuonSach.Text = " Thiết lập phiếu mượn mới & Bộ lọc độc giả ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(241, 245, 249);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(30, 41, 59);
            btnLamMoi.Location = new Point(210, 85);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 38);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "🔄 LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.BackColor = Color.FromArgb(15, 118, 110);
            btnLapPhieuMuon.Cursor = Cursors.Hand;
            btnLapPhieuMuon.FlatAppearance.BorderSize = 0;
            btnLapPhieuMuon.FlatStyle = FlatStyle.Flat;
            btnLapPhieuMuon.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnLapPhieuMuon.ForeColor = Color.White;
            btnLapPhieuMuon.Location = new Point(20, 85);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(180, 38);
            btnLapPhieuMuon.TabIndex = 8;
            btnLapPhieuMuon.Text = "📖 CHO MƯỢN SÁCH";
            btnLapPhieuMuon.UseVisualStyleBackColor = false;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // dtpNgayHenHan
            // 
            dtpNgayHenHan.CustomFormat = "dd/MM/yyyy";
            dtpNgayHenHan.Font = new Font("Segoe UI", 9F);
            dtpNgayHenHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHenHan.Location = new Point(740, 45);
            dtpNgayHenHan.Name = "dtpNgayHenHan";
            dtpNgayHenHan.Size = new Size(140, 23);
            dtpNgayHenHan.TabIndex = 7;
            // 
            // lblNgayHenHan
            // 
            lblNgayHenHan.AutoSize = true;
            lblNgayHenHan.Font = new Font("Segoe UI", 9F);
            lblNgayHenHan.Location = new Point(740, 25);
            lblNgayHenHan.Name = "lblNgayHenHan";
            lblNgayHenHan.Size = new Size(81, 15);
            lblNgayHenHan.TabIndex = 6;
            lblNgayHenHan.Text = "Ngày hẹn trả:";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Font = new Font("Segoe UI", 9F);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(580, 45);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(140, 23);
            dtpNgayMuon.TabIndex = 5;
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Font = new Font("Segoe UI", 9F);
            lblNgayMuon.Location = new Point(580, 25);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(73, 15);
            lblNgayMuon.TabIndex = 4;
            lblNgayMuon.Text = "Ngày mượn:";
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI", 9F);
            txtMaSach.Location = new Point(310, 45);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.PlaceholderText = "Nhập mã sách, mã vạch hoặc tên...";
            txtMaSach.Size = new Size(250, 23);
            txtMaSach.TabIndex = 3;
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Font = new Font("Segoe UI", 9F);
            lblMaSach.Location = new Point(310, 25);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(125, 15);
            lblMaSach.TabIndex = 2;
            lblMaSach.Text = "Mã sách / Mã vạch (*):";
            // 
            // cboDocGia
            // 
            cboDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocGia.Font = new Font("Segoe UI", 9F);
            cboDocGia.FormattingEnabled = true;
            cboDocGia.Location = new Point(20, 45);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(270, 23);
            cboDocGia.TabIndex = 1;
            cboDocGia.SelectedIndexChanged += cboDocGia_SelectedIndexChanged;
            // 
            // lblDocGia
            // 
            lblDocGia.AutoSize = true;
            lblDocGia.Font = new Font("Segoe UI", 9F);
            lblDocGia.Location = new Point(20, 25);
            lblDocGia.Name = "lblDocGia";
            lblDocGia.Size = new Size(78, 15);
            lblDocGia.TabIndex = 0;
            lblDocGia.Text = "Độc giả (*):";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(btnDoiSDT);
            grpDanhSach.Controls.Add(chkChiQuaHan);
            grpDanhSach.Controls.Add(btnXacNhanTra);
            grpDanhSach.Controls.Add(btnGiaHan);
            grpDanhSach.Controls.Add(dgvSachDangMuon);
            grpDanhSach.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.FromArgb(19, 78, 74);
            grpDanhSach.Location = new Point(25, 215);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1010, 440);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = " Danh mục tài liệu đang mượn lưu thông ";
            // 
            // btnDoiSDT
            // 
            btnDoiSDT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDoiSDT.BackColor = Color.FromArgb(241, 245, 249);
            btnDoiSDT.Cursor = Cursors.Hand;
            btnDoiSDT.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDoiSDT.FlatStyle = FlatStyle.Flat;
            btnDoiSDT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDoiSDT.ForeColor = Color.FromArgb(51, 65, 85);
            btnDoiSDT.Location = new Point(15, 390);
            btnDoiSDT.Name = "btnDoiSDT";
            btnDoiSDT.Size = new Size(165, 40);
            btnDoiSDT.TabIndex = 4;
            btnDoiSDT.Text = "📞 CẬP NHẬT SĐT ĐG";
            btnDoiSDT.UseVisualStyleBackColor = false;
            btnDoiSDT.Click += btnDoiSDT_Click;
            // 
            // chkChiQuaHan
            // 
            chkChiQuaHan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkChiQuaHan.AutoSize = true;
            chkChiQuaHan.Cursor = Cursors.Hand;
            chkChiQuaHan.Font = new Font("Segoe UI Bold", 9.5F);
            chkChiQuaHan.ForeColor = Color.FromArgb(185, 28, 28);
            chkChiQuaHan.Location = new Point(780, -2);
            chkChiQuaHan.Name = "chkChiQuaHan";
            chkChiQuaHan.Size = new Size(215, 21);
            chkChiQuaHan.TabIndex = 3;
            chkChiQuaHan.Text = "🔴 Chỉ hiển thị sách quá hạn";
            chkChiQuaHan.UseVisualStyleBackColor = true;
            chkChiQuaHan.CheckedChanged += chkChiQuaHan_CheckedChanged;
            // 
            // btnXacNhanTra
            // 
            btnXacNhanTra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXacNhanTra.BackColor = Color.FromArgb(22, 101, 52);
            btnXacNhanTra.Cursor = Cursors.Hand;
            btnXacNhanTra.FlatAppearance.BorderSize = 0;
            btnXacNhanTra.FlatStyle = FlatStyle.Flat;
            btnXacNhanTra.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnXacNhanTra.ForeColor = Color.White;
            btnXacNhanTra.Location = new Point(815, 390);
            btnXacNhanTra.Name = "btnXacNhanTra";
            btnXacNhanTra.Size = new Size(180, 40);
            btnXacNhanTra.TabIndex = 2;
            btnXacNhanTra.Text = "✅ XÁC NHẬN TRẢ SÁCH";
            btnXacNhanTra.UseVisualStyleBackColor = false;
            btnXacNhanTra.Click += btnXacNhanTra_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGiaHan.BackColor = Color.FromArgb(234, 88, 12);
            btnGiaHan.Cursor = Cursors.Hand;
            btnGiaHan.FlatAppearance.BorderSize = 0;
            btnGiaHan.FlatStyle = FlatStyle.Flat;
            btnGiaHan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(630, 390);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(175, 40);
            btnGiaHan.TabIndex = 1;
            btnGiaHan.Text = "⏳ GIA HẠN (+7 NGÀY)";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // dgvSachDangMuon
            // 
            dgvSachDangMuon.AllowUserToAddRows = false;
            dgvSachDangMuon.AllowUserToDeleteRows = false;
            dgvSachDangMuon.AllowUserToResizeRows = false;
            dgvSachDangMuon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSachDangMuon.BackgroundColor = Color.White;
            dgvSachDangMuon.BorderStyle = BorderStyle.None;
            dgvSachDangMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachDangMuon.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colMaDocGia, colTenDocGia, colSoDienThoai, colTenSach, colMaVach, colNgayMuon, colNgayHenHan, colTinhTrangHan, colSoLanGiaHan, colTrangThai });
            dgvSachDangMuon.Location = new Point(15, 25);
            dgvSachDangMuon.Name = "dgvSachDangMuon";
            dgvSachDangMuon.ReadOnly = true;
            dgvSachDangMuon.RowHeadersVisible = false;
            dgvSachDangMuon.Size = new Size(980, 355);
            dgvSachDangMuon.TabIndex = 0;
            dgvSachDangMuon.CellFormatting += dgvSachDangMuon_CellFormatting;
            // 
            // colMaPhieu
            // 
            colMaPhieu.DataPropertyName = "MaPhieu";
            colMaPhieu.FillWeight = 80F;
            colMaPhieu.HeaderText = "Mã Phiếu";
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            colMaPhieu.Width = 85;
            // 
            // colMaDocGia
            // 
            colMaDocGia.DataPropertyName = "MaDocGia";
            colMaDocGia.FillWeight = 75F;
            colMaDocGia.HeaderText = "Mã ĐG";
            colMaDocGia.Name = "colMaDocGia";
            colMaDocGia.ReadOnly = true;
            colMaDocGia.Width = 80;
            // 
            // colTenDocGia
            // 
            colTenDocGia.DataPropertyName = "TenDocGia";
            colTenDocGia.FillWeight = 110F;
            colTenDocGia.HeaderText = "Tên Độc Giả";
            colTenDocGia.Name = "colTenDocGia";
            colTenDocGia.ReadOnly = true;
            colTenDocGia.Width = 135;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.FillWeight = 85F;
            colSoDienThoai.HeaderText = "SĐT Độc Giả";
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            colSoDienThoai.Width = 100;
            // 
            // colTenSach
            // 
            colTenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.FillWeight = 160F;
            colTenSach.HeaderText = "Tên Đầu Sách";
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            // 
            // colMaVach
            // 
            colMaVach.DataPropertyName = "MaVach";
            colMaVach.FillWeight = 90F;
            colMaVach.HeaderText = "Mã Vạch";
            colMaVach.Name = "colMaVach";
            colMaVach.ReadOnly = true;
            colMaVach.Width = 105;
            // 
            // colNgayMuon
            // 
            colNgayMuon.DataPropertyName = "NgayMuon";
            colNgayMuon.FillWeight = 80F;
            colNgayMuon.HeaderText = "Ngày Mượn";
            colNgayMuon.Name = "colNgayMuon";
            colNgayMuon.ReadOnly = true;
            colNgayMuon.Width = 95;
            // 
            // colNgayHenHan
            // 
            colNgayHenHan.DataPropertyName = "NgayHenHan";
            colNgayHenHan.FillWeight = 80F;
            colNgayHenHan.HeaderText = "Hạn Trả";
            colNgayHenHan.Name = "colNgayHenHan";
            colNgayHenHan.ReadOnly = true;
            colNgayHenHan.Width = 95;
            // 
            // colTinhTrangHan
            // 
            colTinhTrangHan.FillWeight = 115F;
            colTinhTrangHan.HeaderText = "Tình Trạng Hạn";
            colTinhTrangHan.Name = "colTinhTrangHan";
            colTinhTrangHan.ReadOnly = true;
            colTinhTrangHan.Width = 135;
            // 
            // colSoLanGiaHan
            // 
            colSoLanGiaHan.DataPropertyName = "SoLanGiaHan";
            colSoLanGiaHan.FillWeight = 55F;
            colSoLanGiaHan.HeaderText = "Gia Hạn";
            colSoLanGiaHan.Name = "colSoLanGiaHan";
            colSoLanGiaHan.ReadOnly = true;
            colSoLanGiaHan.Width = 65;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 75F;
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 85;
            // 
            // FormBanLuuThong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1060, 670);
            Controls.Add(grpDanhSach);
            Controls.Add(grpMuonSach);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBanLuuThong";
            Text = "Bàn Lưu Thông";
            Load += FormBanLuuThong_Load;
            grpMuonSach.ResumeLayout(false);
            grpMuonSach.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            grpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachDangMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private GroupBox grpMuonSach;
        private Label lblDocGia;
        private ComboBox cboDocGia;
        private Label lblMaSach;
        private TextBox txtMaSach;
        private Label lblNgayMuon;
        private DateTimePicker dtpNgayMuon;
        private Label lblNgayHenHan;
        private DateTimePicker dtpNgayHenHan;
        private Button btnLapPhieuMuon;
        private Button btnLamMoi;
        private GroupBox grpDanhSach;
        private DataGridView dgvSachDangMuon;
        private Button btnGiaHan;
        private Button btnXacNhanTra;
        private CheckBox chkChiQuaHan;
        private Button btnDoiSDT;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colTenDocGia;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colMaVach;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colNgayHenHan;
        private DataGridViewTextBoxColumn colTinhTrangHan;
        private DataGridViewTextBoxColumn colSoLanGiaHan;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}