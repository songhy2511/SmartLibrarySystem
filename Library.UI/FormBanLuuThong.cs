using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DAL;

namespace Library.UI
{
    public partial class FormBanLuuThong : Form
    {
        private readonly PhieuMuonBLL _phieuMuonBLL = new PhieuMuonBLL();
        private bool _isInitialized = false;

        public FormBanLuuThong()
        {
            InitializeComponent();
        }

        private void FormBanLuuThong_Load(object sender, EventArgs e)
        {
            DinhDangDataGridView();
            LoadDanhSachDocGia();
            CaiDatAutoCompleteTimKiemSach();

            int soNgay = _phieuMuonBLL.LaySoNgayMuonToiDa();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(soNgay);

            _isInitialized = true;
            TaiDanhSachDangMuon();
        }

        private void DinhDangDataGridView()
        {
            dgvSachDangMuon.BackgroundColor = Color.White;
            dgvSachDangMuon.BorderStyle = BorderStyle.None;
            dgvSachDangMuon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSachDangMuon.GridColor = Color.FromArgb(226, 232, 240);
            dgvSachDangMuon.EnableHeadersVisualStyles = false;
            dgvSachDangMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachDangMuon.MultiSelect = false;
            dgvSachDangMuon.ReadOnly = true;
            dgvSachDangMuon.RowHeadersVisible = false;
            dgvSachDangMuon.RowTemplate.Height = 35;

            dgvSachDangMuon.ColumnHeadersHeight = 38;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 78, 74);
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            dgvSachDangMuon.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvSachDangMuon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvSachDangMuon.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSachDangMuon.EnableDoubleBuffered(true);
        }

        private void CaiDatAutoCompleteTimKiemSach()
        {
            try
            {
                DataTable dt = _phieuMuonBLL.LayDanhSachGoiYSach();
                var collection = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    string maSach = row["Ma_Sach"].ToString() ?? "";
                    string tieuDe = row["Tieu_De"].ToString() ?? "";
                    int khaDung = row["So_Luong_Kha_Dung"] != DBNull.Value ? Convert.ToInt32(row["So_Luong_Kha_Dung"]) : 0;

                    collection.Add($"{tieuDe} (Còn {khaDung})");
                    collection.Add(tieuDe);
                    collection.Add(maSach);
                    collection.Add($"{maSach} - {tieuDe}");
                }

                txtMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach.AutoCompleteCustomSource = collection;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi AutoComplete: " + ex.Message);
            }
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                string query = "SELECT Ma_So AS MaDocGia, Ma_Doc_Gia AS MaThe, Ho_Ten AS TenDocGia FROM dbo.Doc_Gia WHERE Trang_Thai = N'Hoạt động' ORDER BY Ho_Ten ASC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaThe + ' - ' + TenDocGia");

                // Thêm mục 'Xem tất cả độc giả' lên đầu danh sách
                DataRow drAll = dt.NewRow();
                drAll["MaDocGia"] = 0;
                drAll["MaThe"] = "ALL";
                drAll["TenDocGia"] = "Tất cả";
                drAll["HienThi"] = "-- Xem tất cả độc giả đang mượn --";
                dt.Rows.InsertAt(drAll, 0);

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "MaDocGia";
                cboDocGia.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể tải danh mục bạn đọc. Vui lòng thử tải lại trang!", "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                TaiDanhSachDangMuon();
            }
        }

        private void chkChiQuaHan_CheckedChanged(object sender, EventArgs e)
        {
            TaiDanhSachDangMuon();
        }

        private void TaiDanhSachDangMuon()
        {
            try
            {
                int docGiaMaSo = 0;
                if (cboDocGia.SelectedValue != null)
                {
                    int.TryParse(cboDocGia.SelectedValue.ToString(), out docGiaMaSo);
                }

                bool chiQuaHan = chkChiQuaHan.Checked;
                DataTable dt = _phieuMuonBLL.LayDanhSachDangMuonNangCao(docGiaMaSo, chiQuaHan);
                dgvSachDangMuon.AutoGenerateColumns = false;
                dgvSachDangMuon.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể nạp danh sách sách đang mượn. Vui lòng thử lại!", "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSachDangMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvSachDangMuon.Rows.Count) return;
            if (dgvSachDangMuon.Rows[e.RowIndex].DataBoundItem is not DataRowView drv) return;

            string colName = dgvSachDangMuon.Columns[e.ColumnIndex]?.Name ?? string.Empty;

            if (colName == "colNgayMuon" || colName == "colNgayHenHan")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            else if (colName == "colTinhTrangHan")
            {
                DateTime ngayHenHan = Convert.ToDateTime(drv["NgayHenHan"]);
                int soNgayTre = drv["SoNgayTre"] != DBNull.Value ? Convert.ToInt32(drv["SoNgayTre"]) : 0;
                int soNgayConLai = drv["SoNgayConLai"] != DBNull.Value ? Convert.ToInt32(drv["SoNgayConLai"]) : 0;

                if (DateTime.Today > ngayHenHan.Date)
                {
                    e.Value = $"🔴 Quá hạn {soNgayTre} ngày";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                        e.CellStyle.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
                    }
                }
                else
                {
                    e.Value = soNgayConLai == 0 ? "🟡 Hạn chót hôm nay" : $"🟢 Còn {soNgayConLai} ngày";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = soNgayConLai == 0 ? Color.FromArgb(217, 119, 6) : Color.FromArgb(22, 101, 52);
                    }
                }
                e.FormattingApplied = true;
            }
        }

        private int KiemTraVaLayMaThuThu()
        {
            if (SessionContext.CurrentLibrarian == null)
            {
                MessageBox.Show("Phiên làm việc đã hết hạn hoặc mất kết nối tài khoản. Vui lòng đăng nhập lại để tiếp tục!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return SessionContext.CurrentLibrarian.Ma_So;
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDocGia.SelectedValue == null || Convert.ToInt32(cboDocGia.SelectedValue) == 0)
                {
                    MessageBox.Show("Vui lòng chọn một độc giả cụ thể từ danh sách để cấp mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboDocGia.Focus();
                    return;
                }

                string inputSach = txtMaSach.Text.Trim();
                if (string.IsNullOrEmpty(inputSach))
                {
                    MessageBox.Show("Vui lòng nhập tên sách, mã sách hoặc quét mã vạch cần cho mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSach.Focus();
                    return;
                }

                string maDocGia = cboDocGia.SelectedValue.ToString()!;
                DateTime ngayMuon = dtpNgayMuon.Value;
                int thuThuMaSo = KiemTraVaLayMaThuThu();
                if (thuThuMaSo == 0) return;

                int chiNhanhMaSo = new CaTrucBLL().LayChiNhanhTrucHomNay(thuThuMaSo);

                string maPhieu = _phieuMuonBLL.LapPhieuMuon(maDocGia, inputSach, ngayMuon, thuThuMaSo, chiNhanhMaSo);
                if (!string.IsNullOrEmpty(maPhieu))
                {
                    SystemLogger.Log(
                        LogLevel.INFO,
                        "Cấp mượn tài liệu",
                        $"Thủ thư đã lập phiếu mượn #{maPhieu} cho độc giả [{maDocGia}], tài liệu: '{inputSach}'.",
                        SessionContext.CurrentUser?.Ma_So
                    );
                    MessageBox.Show($"Cấp mượn thành công!\nMã phiếu mượn: {maPhieu}", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSach.Clear();
                    TaiDanhSachDangMuon();
                    CaiDatAutoCompleteTimKiemSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sách cần gia hạn trên danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var row = dgvSachDangMuon.SelectedRows[0];
                string maPhieu = row.Cells["colMaPhieu"].Value?.ToString() ?? string.Empty;

                int soLanGiaHan = 0;
                if (row.Cells["colSoLanGiaHan"]?.Value != null)
                {
                    int.TryParse(row.Cells["colSoLanGiaHan"].Value.ToString(), out soLanGiaHan);
                }

                DateTime ngayHenHan = Convert.ToDateTime(row.Cells["colNgayHenHan"].Value ?? DateTime.Now);

                if (_phieuMuonBLL.GiaHanPhieu(maPhieu, soLanGiaHan, ngayHenHan))
                {
                    SystemLogger.Log(
                        LogLevel.INFO,
                        "Gia hạn phiếu mượn",
                        $"Gia hạn thành công phiếu mượn #{maPhieu} thêm 7 ngày (Lần {soLanGiaHan + 1}).",
                        SessionContext.CurrentUser?.Ma_So
                    );
                    MessageBox.Show("Gia hạn thời hạn trả sách thành công thêm 7 ngày!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachDangMuon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách trong danh sách để xác nhận trả!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var row = dgvSachDangMuon.SelectedRows[0];
                string maPhieu = row.Cells["colMaPhieu"].Value?.ToString() ?? string.Empty;
                DateTime ngayHenHan = Convert.ToDateTime(row.Cells["colNgayHenHan"].Value ?? DateTime.Now);
                DateTime ngayTra = DateTime.Now;

                if (_phieuMuonBLL.TraSach(maPhieu, ngayTra, ngayHenHan, out decimal tienPhat))
                {
                    SystemLogger.Log(
                    LogLevel.INFO,
                    "Nhận trả tài liệu",
                    $"Xác nhận trả sách phiếu #{maPhieu}. " + (tienPhat > 0 ? $"Phát sinh phạt trễ hạn: {tienPhat:N0}đ." : "Trả đúng hạn."),
                    SessionContext.CurrentUser?.Ma_So
                );
                    string thongBao = tienPhat > 0
                        ? $"Trả sách hoàn tất!\n⚠️ Sách trả trễ hạn, phát sinh tiền phạt: {tienPhat:N0} VNĐ"
                        : "Xác nhận trả sách đúng hạn thành công!";

                    MessageBox.Show(thongBao, "Thông báo hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachDangMuon();
                    CaiDatAutoCompleteTimKiemSach();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể ghi nhận trả sách do lỗi dữ liệu. Vui lòng thử lại!", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiSDT_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng độc giả cần cập nhật số điện thoại!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dgvSachDangMuon.SelectedRows[0];

            // Lấy trực tiếp khóa chính Ma_So (DocGiaMaSo) từ DataRowView thay vì cắt chuỗi mã thẻ
            int docGiaMaSo = 0;
            if (row.DataBoundItem is DataRowView drv && drv["DocGiaMaSo"] != DBNull.Value)
            {
                docGiaMaSo = Convert.ToInt32(drv["DocGiaMaSo"]);
            }

            if (docGiaMaSo == 0)
            {
                MessageBox.Show("Không thể xác định mã độc giả hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenDocGia = row.Cells["colTenDocGia"].Value?.ToString() ?? "Độc giả";
            string sdtCu = row.Cells["colSoDienThoai"].Value?.ToString() ?? "";

            // Form prompt đơn giản
            Form prompt = new Form()
            {
                Width = 380,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Cập nhật liên hệ",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Label textLabel = new Label() { Left = 20, Top = 15, Width = 320, Text = $"Nhập SĐT liên hệ mới cho: {tenDocGia}" };
            TextBox textBox = new TextBox() { Left = 20, Top = 45, Width = 320, Text = sdtCu == "--" ? "" : sdtCu };
            Button confirmation = new Button() { Text = "Xác nhận", Left = 160, Width = 85, Top = 85, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Hủy", Left = 255, Width = 85, Top = 85, DialogResult = DialogResult.Cancel };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string sdtMoi = textBox.Text.Trim();
                if (string.IsNullOrEmpty(sdtMoi))
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_phieuMuonBLL.CapNhatSoDienThoaiDocGia(docGiaMaSo, sdtMoi))
                {
                    SystemLogger.Log(
                        LogLevel.INFO,
                        "Cập nhật hồ sơ bạn đọc",
                        $"Cập nhật số điện thoại liên hệ mới ({sdtMoi}) cho độc giả ID {docGiaMaSo}.",
                        SessionContext.CurrentUser?.Ma_So
                    );
                    MessageBox.Show("Cập nhật số điện thoại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachDangMuon();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            int soNgay = _phieuMuonBLL.LaySoNgayMuonToiDa();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(soNgay);
            chkChiQuaHan.Checked = false;
            cboDocGia.SelectedIndex = 0;
            TaiDanhSachDangMuon();
            CaiDatAutoCompleteTimKiemSach();
        }
    }
}