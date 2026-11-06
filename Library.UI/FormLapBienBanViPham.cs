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
        private readonly CauHinhHeThongBLL _cauHinhBLL = new CauHinhHeThongBLL();
        private bool _isInitialized = false;

        public FormLapBienBanViPham()
        {
            InitializeComponent();
        }

        private void FormLapBienBanViPham_Load(object sender, EventArgs e)
        {
            DinhDangDataGridView();
            LoadDanhSachDocGia();
            KhoiTaoLoaiViPham();
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();

            _isInitialized = true;
            NapSachTheoDocGia();
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
            dgvBienBanViPham.RowTemplate.Height = 35;

            dgvBienBanViPham.ColumnHeadersHeight = 38;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 78, 74);
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            dgvBienBanViPham.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvBienBanViPham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvBienBanViPham.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBienBanViPham.EnableDoubleBuffered(true);
        }

        private void KhoiTaoLoaiViPham()
        {
            cboLoaiViPham.Items.Clear();
            cboLoaiViPham.Items.Add("Quá hạn mượn kéo dài");
            cboLoaiViPham.Items.Add("Làm rách / hư hỏng nhẹ (Đền 30% giá bìa)");
            cboLoaiViPham.Items.Add("Làm hư hỏng nặng (Đền 60% giá bìa)");
            cboLoaiViPham.Items.Add("Làm mất tài liệu (Đền 100% giá bìa)");
            cboLoaiViPham.Items.Add("Vi phạm quy chế khác (Tự nhập)");
            cboLoaiViPham.SelectedIndex = 0;
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                string query = "SELECT Ma_So AS DocGiaMaSo, Ma_Doc_Gia AS MaDG, Ho_Ten AS TenDG FROM dbo.Doc_Gia WHERE Trang_Thai = N'Hoạt động' ORDER BY Ho_Ten ASC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaDG + ' - ' + TenDG");

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "DocGiaMaSo";

                if (dt.Rows.Count > 0)
                {
                    cboDocGia.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapSachTheoDocGia()
        {
            if (cboDocGia.SelectedValue == null) return;
            int.TryParse(cboDocGia.SelectedValue.ToString(), out int docGiaMaSo);

            try
            {
                // Truy vấn bao quát cả trạng thái 'Đang mượn' lẫn 'Quá hạn'
                string query = @"
                    SELECT 
                        0 AS BanSaoMaSo,
                        0 AS PhieuMuonMaSo,
                        N'-- Không gắn sách cụ thể --' AS HienThi,
                        CAST(0 AS DECIMAL(18,0)) AS Gia_Bia,
                        0 AS SoNgayTre,
                        N'' AS TenSach
                    UNION ALL
                    SELECT 
                        bs.Ma_So AS BanSaoMaSo,
                        pm.Ma_So AS PhieuMuonMaSo,
                        s.Tieu_De + N' [' + bs.Ma_Vach + N'] (Giá: ' + FORMAT(ISNULL(s.Gia_Bia, 80000), '#,##0') + N' đ)' AS HienThi,
                        ISNULL(s.Gia_Bia, 80000) AS Gia_Bia,
                        CASE WHEN pm.Ngay_Hen_Tra < CAST(GETDATE() AS DATE) 
                             THEN DATEDIFF(DAY, pm.Ngay_Hen_Tra, CAST(GETDATE() AS DATE)) 
                             ELSE 0 END AS SoNgayTre,
                        s.Tieu_De AS TenSach
                    FROM dbo.Phieu_Muon pm
                    INNER JOIN dbo.Chi_Tiet_Phieu_Muon ct ON pm.Ma_So = ct.Phieu_Muon_Ma_So
                    INNER JOIN dbo.Ban_Sao_Sach bs ON ct.Ban_Sao_Sach_Ma_So = bs.Ma_So
                    INNER JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
                    WHERE pm.Doc_Gia_Ma_So = @DocGiaMaSo 
                      AND pm.Trang_Thai IN (N'Đang mượn', N'Quá hạn')";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, new[] { new Microsoft.Data.SqlClient.SqlParameter("@DocGiaMaSo", docGiaMaSo) });

                // Nếu độc giả không có sách mượn, nạp danh mục trong kho
                if (dt.Rows.Count <= 1)
                {
                    string queryAll = @"
                        SELECT 
                            0 AS BanSaoMaSo,
                            0 AS PhieuMuonMaSo,
                            N'-- Chọn tài liệu từ kho thư viện --' AS HienThi,
                            CAST(0 AS DECIMAL(18,0)) AS Gia_Bia,
                            0 AS SoNgayTre,
                            N'' AS TenSach
                        UNION ALL
                        SELECT 
                            bs.Ma_So AS BanSaoMaSo,
                            0 AS PhieuMuonMaSo,
                            s.Tieu_De + N' [' + bs.Ma_Vach + N'] (Giá bìa: ' + FORMAT(ISNULL(s.Gia_Bia, 80000), '#,##0') + N' đ)' AS HienThi,
                            ISNULL(s.Gia_Bia, 80000) AS Gia_Bia,
                            0 AS SoNgayTre,
                            s.Tieu_De AS TenSach
                        FROM dbo.Ban_Sao_Sach bs
                        INNER JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
                        WHERE bs.Trang_Thai = N'Sẵn sàng'";
                    dt = DatabaseHelper.ExecuteQuery(queryAll);
                }

                cboSachViPham.DataSource = dt;
                cboSachViPham.DisplayMember = "HienThi";
                cboSachViPham.ValueMember = "BanSaoMaSo";

                if (dt.Rows.Count > 1)
                    cboSachViPham.SelectedIndex = 1;
                else
                    cboSachViPham.SelectedIndex = 0;

                CapNhatTienPhatTheoQuyChe();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi nạp sách: " + ex.Message);
            }
        }

        private void cboDocGia_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isInitialized)
            {
                NapSachTheoDocGia();
            }
        }

        private void cboSachViPham_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isInitialized)
            {
                CapNhatTienPhatTheoQuyChe();
            }
        }

        private void cboLoaiViPham_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isInitialized)
            {
                CapNhatTienPhatTheoQuyChe();
            }
        }

        private void nudSoNgayTre_ValueChanged(object? sender, EventArgs e)
        {
            if (_isInitialized && cboLoaiViPham.SelectedItem?.ToString()?.StartsWith("Quá hạn") == true)
            {
                CapNhatTienPhatTheoQuyChe();
            }
        }

        /// <summary>
        /// Tính toán tiền phạt minh bạch theo số ngày trễ (cho phép nhập tay/tự động) hoặc theo % giá bìa
        /// </summary>
        private void CapNhatTienPhatTheoQuyChe()
        {
            if (cboLoaiViPham.SelectedIndex < 0) return;

            string loaiViPham = cboLoaiViPham.SelectedItem?.ToString() ?? "";
            DataRowView? drvSach = cboSachViPham.SelectedItem as DataRowView;

            decimal giaBia = 80000m;
            int soNgayTreCSDL = 0;
            string tenSach = "Tài liệu thư viện";

            if (drvSach != null)
            {
                if (drvSach["Gia_Bia"] != DBNull.Value)
                    giaBia = Convert.ToDecimal(drvSach["Gia_Bia"]);
                if (drvSach["SoNgayTre"] != DBNull.Value)
                    soNgayTreCSDL = Convert.ToInt32(drvSach["SoNgayTre"]);
                tenSach = drvSach["TenSach"].ToString() ?? "Tài liệu thư viện";
            }

            if (loaiViPham.StartsWith("Quá hạn"))
            {
                nudSoNgayTre.Enabled = true;
                txtSoTienPhat.ReadOnly = true;

                // Nếu sách được chọn có số ngày trễ thực tế từ CSDL và sender không phải sự kiện gõ ngày
                if (soNgayTreCSDL > 0 && nudSoNgayTre.Value == 1)
                {
                    nudSoNgayTre.Value = soNgayTreCSDL;
                }

                int soNgayApDung = Convert.ToInt32(nudSoNgayTre.Value);
                decimal donGiaNgay = _cauHinhBLL.LayTienPhatMoiNgay();
                decimal tongTien = soNgayApDung * donGiaNgay;

                txtSoTienPhat.Text = tongTien.ToString("0");
                txtMoTa.Text = $"Quá hạn {soNgayApDung} ngày cuốn '{tenSach}'. Tiền phạt = {soNgayApDung} ngày × {donGiaNgay:N0} đ/ngày = {tongTien:N0} VNĐ.";
            }
            else
            {
                nudSoNgayTre.Enabled = false;

                if (loaiViPham.Contains("30%")) // Rách / ướt nhẹ
                {
                    txtSoTienPhat.ReadOnly = true;
                    decimal tyLe = _cauHinhBLL.LayTyLePhatRach();
                    decimal tienPhat = Math.Round(giaBia * (tyLe / 100m), 0);

                    txtSoTienPhat.Text = tienPhat.ToString("0");
                    txtMoTa.Text = $"Bồi thường rách/hỏng nhẹ cuốn '{tenSach}'. Đền bù {tyLe}% giá bìa ({giaBia:N0} đ) = {tienPhat:N0} VNĐ.";
                }
                else if (loaiViPham.Contains("60%")) // Hư hỏng nặng
                {
                    txtSoTienPhat.ReadOnly = true;
                    decimal tyLe = _cauHinhBLL.LayTyLePhatHong();
                    decimal tienPhat = Math.Round(giaBia * (tyLe / 100m), 0);

                    txtSoTienPhat.Text = tienPhat.ToString("0");
                    txtMoTa.Text = $"Bồi thường hư hỏng nặng cuốn '{tenSach}'. Đền bù {tyLe}% giá bìa ({giaBia:N0} đ) = {tienPhat:N0} VNĐ.";
                }
                else if (loaiViPham.Contains("100%")) // Mất sách
                {
                    txtSoTienPhat.ReadOnly = true;
                    decimal tyLe = _cauHinhBLL.LayTyLePhatMat();
                    decimal tienPhat = Math.Round(giaBia * (tyLe / 100m), 0);

                    txtSoTienPhat.Text = tienPhat.ToString("0");
                    txtMoTa.Text = $"Bồi thường làm mất tài liệu cuốn '{tenSach}'. Đền bù {tyLe}% giá bìa ({giaBia:N0} đ) = {tienPhat:N0} VNĐ.";
                }
                else // Vi phạm khác
                {
                    txtSoTienPhat.ReadOnly = false;
                    txtSoTienPhat.Text = "50000";
                    txtMoTa.Text = "Vi phạm nội quy thư viện / làm mất thẻ bạn đọc.";
                    txtSoTienPhat.Focus();
                    txtSoTienPhat.SelectAll();
                }
            }
        }

        private void KhoiTaoGiaTriMacDinh()
        {
            txtMaBienBan.Text = "Tự động sinh (ID)";
            txtCanBoLap.Text = SessionContext.CurrentLibrarian?.Ho_Ten ?? "Lê Minh Tuấn";
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayHenNop.Value = DateTime.Now.AddDays(7);
            nudSoNgayTre.Value = 1;
        }

        private void LoadDanhSachViPham()
        {
            try
            {
                string query = @"
                    SELECT 
                        pp.Ma_So AS MaBienBan,
                        dg.Ma_Doc_Gia AS MaDocGia,
                        dg.Ho_Ten AS TenDocGia,
                        ISNULL(s.Tieu_De, N'--') AS TenSach,
                        pp.Ly_Do AS LyDoViPham,
                        pp.So_Tien_Phat AS SoTienPhat,
                        pp.Ngay_Lap AS NgayLap,
                        pp.Trang_Thai AS TrangThai,
                        pp.Da_Thanh_Toan AS DaThanhToan,
                        ISNULL(tt.Ho_Ten, N'Thủ thư') AS CanBoLap
                    FROM dbo.Phieu_Phat pp
                    INNER JOIN dbo.Doc_Gia dg ON pp.Doc_Gia_Ma_So = dg.Ma_So
                    LEFT JOIN dbo.Phieu_Muon pm ON pp.Phieu_Muon_Ma_So = pm.Ma_So
                    LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ct ON pm.Ma_So = ct.Phieu_Muon_Ma_So
                    LEFT JOIN dbo.Ban_Sao_Sach bs ON ct.Ban_Sao_Sach_Ma_So = bs.Ma_So
                    LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
                    LEFT JOIN dbo.Thu_Thu tt ON pp.Thu_Thu_Ma_So = tt.Ma_So
                    ORDER BY pp.Ngay_Lap DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvBienBanViPham.AutoGenerateColumns = false;
                dgvBienBanViPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách biên bản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBienBanViPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBienBanViPham.Rows.Count) return;
            string colName = dgvBienBanViPham.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colSoTienPhat" && e.Value != null && e.Value != DBNull.Value)
            {
                e.Value = $"{Convert.ToDecimal(e.Value):N0} đ";
                e.FormattingApplied = true;
            }
            else if (colName == "colNgayLap" && e.Value != null && e.Value != DBNull.Value)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
            }
            else if (colName == "colTrangThai" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (status == "Đã thu")
                {
                    e.Value = "🟢 Đã thu";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                        e.CellStyle.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
                    }
                }
                else
                {
                    e.Value = "🔴 Chưa thu";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72);
                        e.CellStyle.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
                    }
                }
                e.FormattingApplied = true;
            }
        }
        private int KiemTraVaLayMaThuThu()
        {
            if (SessionContext.CurrentLibrarian == null)
            {
                MessageBox.Show("Phiên làm việc của bạn đã hết hạn. Vui lòng đăng nhập lại hệ thống!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return SessionContext.CurrentLibrarian.Ma_So;
        }

        private void btnLuuBienBan_Click(object sender, EventArgs e)
        {
            // Ràng buộc 1: Bắt lỗi fallback cứng khi mất Session (Hủy nguy cơ gán nhầm cho Thủ thư 1)
            if (SessionContext.CurrentLibrarian == null)
            {
                MessageBox.Show("Phiên làm việc đã hết hạn hoặc xảy ra lỗi. Vui lòng đăng nhập lại!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            int docGiaMaSo = Convert.ToInt32(cboDocGia.SelectedValue);
            string loaiViPham = cboLoaiViPham.SelectedItem?.ToString() ?? "Vi phạm";
            string chiTiet = txtMoTa.Text.Trim();
            string lyDo = string.IsNullOrWhiteSpace(chiTiet) ? loaiViPham : chiTiet;

            int thuThuId = KiemTraVaLayMaThuThu();
            if (thuThuId == 0) return;
            int chiNhanhId = 1;

            int phieuMuonMaSo = 0;
            int banSaoMaSo = 0;
            if (cboSachViPham.SelectedItem is DataRowView drv)
            {
                if (drv["PhieuMuonMaSo"] != DBNull.Value)
                    phieuMuonMaSo = Convert.ToInt32(drv["PhieuMuonMaSo"]);
                if (drv["BanSaoMaSo"] != DBNull.Value)
                    banSaoMaSo = Convert.ToInt32(drv["BanSaoMaSo"]);
            }

            var phieuPhatBLL = new PhieuPhatBLL();
            var (isSuccess, message) = phieuPhatBLL.LapBienBanToanDien(
                phieuMuonMaSo > 0 ? phieuMuonMaSo : null,
                docGiaMaSo, thuThuId, chiNhanhId, soTien, lyDo, loaiViPham, banSaoMaSo);

            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.WARNING,
                    "Lập biên bản vi phạm",
                    $"Lập biên bản xử phạt: {lyDo} (Số tiền: {soTien:N0}đ) cho độc giả ID {docGiaMaSo}.",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMoTa.Clear();
                nudSoNgayTre.Value = 1;
                LoadDanhSachViPham();
                NapSachTheoDocGia();
            }
            else
            {
                MessageBox.Show(message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThuTienPhat_Click(object sender, EventArgs e)
        {
            // Sử dụng hàm helper để kiểm tra phiên đăng nhập thống nhất
            int thuThuId = KiemTraVaLayMaThuThu();
            if (thuThuId == 0) return; // Ngăn chặn việc ghi nhận nhầm hoặc lỗi NullReferenceException

            if (dgvBienBanViPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một biên bản vi phạm từ danh sách cần thu tiền!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvBienBanViPham.SelectedRows[0];
            int maBienBan = Convert.ToInt32(row.Cells["colMaBienBan"].Value);
            string trangThai = row.Cells["colTrangThai"].Value?.ToString() ?? "";
            string tenDocGia = row.Cells["colTenDocGia"].Value?.ToString() ?? "Độc giả";
            decimal soTien = Convert.ToDecimal(row.Cells["colSoTienPhat"].Value);

            if (trangThai == "🟢 Đã thu" || trangThai == "Đã thu")
            {
                MessageBox.Show("Biên bản này đã được thu tiền và lưu vào ngân quỹ trước đó rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận thu đủ {soTien:N0} VNĐ tiền phạt từ độc giả '{tenDocGia}'?\n\n(Hệ thống sẽ cập nhật ngân quỹ ca trực và xuất hóa đơn thu tiền mặt)",
                "Xác nhận thu nộp phạt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            // Thực hiện giao dịch thu tiền phạt với thuThuId đã qua kiểm tra
            var phieuPhatBLL = new PhieuPhatBLL();
            var (isSuccess, message) = phieuPhatBLL.ThuTienPhatGiaoDich(maBienBan, thuThuId, soTien);

            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Thu tiền phạt",
                    $"Thủ thư đã thu thành công {soTien:N0}đ tiền phạt biên bản #{maBienBan} của độc giả '{tenDocGia}'.",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(message, "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachViPham();
            }
            else
            {
                MessageBox.Show(message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();
            NapSachTheoDocGia();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
            NapSachTheoDocGia();
        }
    }
}