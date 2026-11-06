using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DAL;

namespace Library.UI
{
    public partial class FormLapBienBanViPham : Form
    {
        private readonly PhieuPhatBLL _phieuPhatBLL = new PhieuPhatBLL();
        private readonly CauHinhHeThongBLL _cauHinhBLL = new CauHinhHeThongBLL();

        public FormLapBienBanViPham()
        {
            InitializeComponent();
        }

        private void FormLapBienBanViPham_Load(object sender, EventArgs e)
        {
            DinhDangDataGridView();
            LoadDanhSachDocGia();
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();

            // Đấu nối sự kiện thay đổi lựa chọn
            cboLoaiViPham.SelectedIndexChanged -= cboLoaiViPham_SelectedIndexChanged;
            cboLoaiViPham.SelectedIndexChanged += cboLoaiViPham_SelectedIndexChanged;

            cboDocGia.SelectedIndexChanged -= cboDocGia_SelectedIndexChanged;
            cboDocGia.SelectedIndexChanged += cboDocGia_SelectedIndexChanged;
        }

        private void cboDocGia_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CapNhatTienPhatTheoQuyChe();
        }

        private void cboLoaiViPham_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CapNhatTienPhatTheoQuyChe();
        }

        /// <summary>
        /// Tự động kiểm tra số ngày trễ hạn từ CSDL và nhân với đơn giá quy chế động
        /// </summary>
        private void CapNhatTienPhatTheoQuyChe()
        {
            if (cboLoaiViPham.SelectedItem == null) return;

            string loaiViPham = cboLoaiViPham.SelectedItem.ToString() ?? "";
            string maDocGia = cboDocGia.SelectedValue?.ToString() ?? "";

            if (loaiViPham == "Quá hạn mượn kéo dài" || loaiViPham == "Trễ hạn")
            {
                txtSoTienPhat.ReadOnly = true;

                // 1. Lấy đơn giá phạt mỗi ngày từ cấu hình hệ thống
                decimal donGiaMoiNgay = _cauHinhBLL.LayTienPhatMoiNgay();

                // 2. Tìm phiếu mượn quá hạn gần nhất của độc giả này
                string query = @"
                    SELECT TOP 1 
                        pm.Ma_Phieu_Muon, 
                        pm.Ngay_Hen_Tra, 
                        ISNULL(s.Tieu_De, N'Tài liệu thư viện') AS TenSach,
                        DATEDIFF(DAY, pm.Ngay_Hen_Tra, GETDATE()) AS SoNgayTre
                    FROM dbo.Phieu_Muon pm
                    INNER JOIN dbo.Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
                    LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ct ON pm.Ma_So = ct.Phieu_Muon_Ma_So
                    LEFT JOIN dbo.Ban_Sao_Sach bs ON ct.Ban_Sao_Sach_Ma_So = bs.Ma_So
                    LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
                    WHERE (dg.Ma_Doc_Gia = @MaDG OR dg.Ma_So = TRY_CAST(@MaDG AS INT))
                      AND pm.Trang_Thai = N'Đang mượn'
                      AND pm.Ngay_Hen_Tra < CAST(GETDATE() AS DATE)
                    ORDER BY pm.Ngay_Hen_Tra ASC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, new[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@MaDG", maDocGia)
                });

                if (dt.Rows.Count > 0)
                {
                    int soNgayTre = Convert.ToInt32(dt.Rows[0]["SoNgayTre"]);
                    string tenSach = dt.Rows[0]["TenSach"].ToString() ?? "";
                    string maPhieu = dt.Rows[0]["Ma_Phieu_Muon"].ToString() ?? "";

                    decimal tongTienPhat = soNgayTre * donGiaMoiNgay;
                    txtSoTienPhat.Text = tongTienPhat.ToString("0");
                    txtMoTa.Text = $"Quá hạn {soNgayTre} ngày cuốn '{tenSach}' (Mã phiếu: {maPhieu}). Đơn giá phạt: {donGiaMoiNgay:N0} VNĐ/ngày.";
                }
                else
                {
                    // Nếu độc giả chưa có phiếu quá hạn thực tế trên hệ thống
                    txtSoTienPhat.Text = donGiaMoiNgay.ToString("0");
                    txtMoTa.Text = $"Phạt vi phạm quy định mượn trả (Định mức: {donGiaMoiNgay:N0} VNĐ/ngày).";
                }
            }
            else // "Làm mất sách" hoặc "Làm rách / hư hỏng sách"
            {
                txtSoTienPhat.ReadOnly = false;
                txtSoTienPhat.Text = "50000"; // Mức bồi thường gợi ý cơ bản
                txtMoTa.Text = $"Bồi thường tài liệu do {loaiViPham.ToLower()}.";
                txtSoTienPhat.Focus();
                txtSoTienPhat.SelectAll();
            }
        }

        private void DinhDangDataGridView()
        {
            dgvBienBanViPham.BackgroundColor = Color.White;
            dgvBienBanViPham.BorderStyle = BorderStyle.None;
            dgvBienBanViPham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBienBanViPham.GridColor = Color.FromArgb(226, 232, 240);
            dgvBienBanViPham.EnableHeadersVisualStyles = false;
            dgvBienBanViPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBienBanViPham.MultiSelect = false;
            dgvBienBanViPham.ReadOnly = true;
            dgvBienBanViPham.RowHeadersVisible = false;
            dgvBienBanViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBienBanViPham.RowTemplate.Height = 35;

            dgvBienBanViPham.ColumnHeadersHeight = 40;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 78, 74);
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            dgvBienBanViPham.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvBienBanViPham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvBienBanViPham.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                string query = "SELECT Ma_So AS DocGiaId, Ma_Doc_Gia AS MaDG, Ho_Ten AS TenDG FROM dbo.Doc_Gia";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaDG + ' - ' + TenDG");

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "MaDG";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiTaoGiaTriMacDinh()
        {
            txtMaBienBan.Text = "Tự động sinh (ID)";
            txtCanBoLap.Text = SessionContext.CurrentLibrarian?.Ho_Ten ?? "Lê Minh Tuấn";

            if (cboLoaiViPham.Items.Count > 0)
                cboLoaiViPham.SelectedIndex = 0;

            dtpNgayLap.Value = DateTime.Now;
            dtpNgayHenNop.Value = DateTime.Now.AddDays(7);
            CapNhatTienPhatTheoQuyChe();
        }

        private void LoadDanhSachViPham()
        {
            try
            {
                DataTable dt = _phieuPhatBLL.LayDanhSachBienBan();
                dgvBienBanViPham.DataSource = dt;

                if (dgvBienBanViPham.Columns["MaBienBan"] != null) { dgvBienBanViPham.Columns["MaBienBan"].HeaderText = "Mã BB"; dgvBienBanViPham.Columns["MaBienBan"].Width = 80; }
                if (dgvBienBanViPham.Columns["MaDocGia"] != null) { dgvBienBanViPham.Columns["MaDocGia"].HeaderText = "Mã ĐG"; dgvBienBanViPham.Columns["MaDocGia"].Width = 95; }
                if (dgvBienBanViPham.Columns["TenDocGia"] != null) { dgvBienBanViPham.Columns["TenDocGia"].HeaderText = "Tên Độc Giả"; dgvBienBanViPham.Columns["TenDocGia"].Width = 160; }
                if (dgvBienBanViPham.Columns["LyDoViPham"] != null) { dgvBienBanViPham.Columns["LyDoViPham"].HeaderText = "Lý Do Vi Phạm"; }
                if (dgvBienBanViPham.Columns["SoTienPhat"] != null)
                {
                    dgvBienBanViPham.Columns["SoTienPhat"].HeaderText = "Tiền Phạt (VNĐ)";
                    dgvBienBanViPham.Columns["SoTienPhat"].DefaultCellStyle.Format = "#,##0";
                    dgvBienBanViPham.Columns["SoTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBienBanViPham.Columns["SoTienPhat"].Width = 120;
                }
                if (dgvBienBanViPham.Columns["NgayLap"] != null)
                {
                    dgvBienBanViPham.Columns["NgayLap"].HeaderText = "Ngày Lập";
                    dgvBienBanViPham.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvBienBanViPham.Columns["NgayLap"].Width = 135;
                }
                if (dgvBienBanViPham.Columns["TrangThai"] != null) { dgvBienBanViPham.Columns["TrangThai"].HeaderText = "Trạng Thái"; dgvBienBanViPham.Columns["TrangThai"].Width = 100; }
                if (dgvBienBanViPham.Columns["CanBoLap"] != null) { dgvBienBanViPham.Columns["CanBoLap"].HeaderText = "Cán Bộ Lập"; dgvBienBanViPham.Columns["CanBoLap"].Width = 140; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách biên bản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuBienBan_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả vi phạm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTienPhat.Text.Trim(), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phạt phải là số nguyên dương hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienPhat.Focus();
                return;
            }

            string maDocGia = cboDocGia.SelectedValue.ToString() ?? "";
            string loaiViPham = cboLoaiViPham.SelectedItem?.ToString() ?? "Vi phạm khác";
            string chiTiet = txtMoTa.Text.Trim();
            string lyDoTongHop = string.IsNullOrWhiteSpace(chiTiet) ? loaiViPham : $"{chiTiet}";

            int thuThuId = SessionContext.CurrentLibrarian?.Ma_So ?? 1;

            var (isSuccess, message) = _phieuPhatBLL.LapBienBan(maDocGia, soTien, lyDoTongHop, thuThuId, 1);

            if (isSuccess)
            {
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMoTa.Clear();
                LoadDanhSachViPham();
                KhoiTaoGiaTriMacDinh();
            }
            else
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
        }
    }
}