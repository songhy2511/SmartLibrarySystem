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

            int soNgay = _phieuMuonBLL.LaySoNgayMuonToiDa();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(soNgay);

            _isInitialized = true;

            if (cboDocGia.SelectedValue != null)
            {
                LoadDanhSachDangMuon(cboDocGia.SelectedValue.ToString() ?? "");
            }

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
            dgvSachDangMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachDangMuon.RowTemplate.Height = 35;

            dgvSachDangMuon.ColumnHeadersHeight = 40;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 78, 74);
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            dgvSachDangMuon.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvSachDangMuon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvSachDangMuon.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                string query = "SELECT Ma_So AS MaDocGia, Ma_Doc_Gia AS MaThe, Ho_Ten AS TenDocGia FROM dbo.Doc_Gia";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaThe + ' - ' + TenDocGia");

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "MaDocGia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách độc giả: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized && cboDocGia.SelectedValue != null)
            {
                string selectedMaDocGia = cboDocGia.SelectedValue.ToString() ?? "";
                if (!string.IsNullOrEmpty(selectedMaDocGia))
                {
                    LoadDanhSachDangMuon(selectedMaDocGia);
                }
            }
        }

        private void LoadDanhSachDangMuon(string maDocGia)
        {
            try
            {
                DataTable dt = _phieuMuonBLL.LayDanhSachDangMuon(maDocGia);
                dgvSachDangMuon.DataSource = dt;

                if (dgvSachDangMuon.Columns["MaPhieu"] != null) { dgvSachDangMuon.Columns["MaPhieu"].HeaderText = "Mã Phiếu"; dgvSachDangMuon.Columns["MaPhieu"].Width = 95; }
                if (dgvSachDangMuon.Columns["TenDocGia"] != null) { dgvSachDangMuon.Columns["TenDocGia"].HeaderText = "Tên Độc Giả"; dgvSachDangMuon.Columns["TenDocGia"].Width = 150; }
                if (dgvSachDangMuon.Columns["TenSach"] != null) { dgvSachDangMuon.Columns["TenSach"].HeaderText = "Tên Sách"; }
                if (dgvSachDangMuon.Columns["MaVach"] != null) { dgvSachDangMuon.Columns["MaVach"].HeaderText = "Mã Vạch"; dgvSachDangMuon.Columns["MaVach"].Width = 110; }
                if (dgvSachDangMuon.Columns["NgayMuon"] != null)
                {
                    dgvSachDangMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dgvSachDangMuon.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSachDangMuon.Columns["NgayMuon"].Width = 100;
                }
                if (dgvSachDangMuon.Columns["NgayHenHan"] != null)
                {
                    dgvSachDangMuon.Columns["NgayHenHan"].HeaderText = "Ngày Hẹn Trả";
                    dgvSachDangMuon.Columns["NgayHenHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSachDangMuon.Columns["NgayHenHan"].Width = 105;
                }
                if (dgvSachDangMuon.Columns["SoLanGiaHan"] != null)
                {
                    dgvSachDangMuon.Columns["SoLanGiaHan"].HeaderText = "Gia Hạn";
                    dgvSachDangMuon.Columns["SoLanGiaHan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSachDangMuon.Columns["SoLanGiaHan"].Width = 75;
                }
                if (dgvSachDangMuon.Columns["TrangThai"] != null) { dgvSachDangMuon.Columns["TrangThai"].HeaderText = "Trạng Thái"; dgvSachDangMuon.Columns["TrangThai"].Width = 110; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp sách đang mượn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDocGia.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn độc giả trước khi cấp mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maSach = txtMaSach.Text.Trim();
                if (string.IsNullOrEmpty(maSach))
                {
                    MessageBox.Show("Vui lòng nhập mã sách hoặc quét mã vạch cần cho mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSach.Focus();
                    return;
                }

                string maDocGia = cboDocGia.SelectedValue.ToString() ?? "1";
                DateTime ngayMuon = dtpNgayMuon.Value;

                string maPhieu = _phieuMuonBLL.LapPhieuMuon(maDocGia, maSach, ngayMuon);
                if (!string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show($"Lập phiếu mượn thành công!\nMã phiếu mượn: {maPhieu}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSach.Clear();
                    LoadDanhSachDangMuon(maDocGia);
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
                string maPhieu = row.Cells["MaPhieu"].Value?.ToString() ?? string.Empty;

                int soLanGiaHan = 0;
                if (row.Cells["SoLanGiaHan"]?.Value != null)
                {
                    int.TryParse(row.Cells["SoLanGiaHan"].Value.ToString(), out soLanGiaHan);
                }

                DateTime ngayHenHan = Convert.ToDateTime(row.Cells["NgayHenHan"].Value ?? DateTime.Now);

                if (_phieuMuonBLL.GiaHanPhieu(maPhieu, soLanGiaHan, ngayHenHan))
                {
                    MessageBox.Show("Gia hạn thời hạn trả sách thành công thêm 7 ngày!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string currentDocGia = cboDocGia.SelectedValue?.ToString() ?? "1";
                    LoadDanhSachDangMuon(currentDocGia);
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
                string maPhieu = row.Cells["MaPhieu"].Value?.ToString() ?? string.Empty;
                // Note: Ensure your DataGridView has a column for MaDocGia, or retrieve it from cboDocGia
                string maDocGia = cboDocGia.SelectedValue?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maDocGia))
                {
                    MessageBox.Show("Dữ liệu phiếu mượn hoặc độc giả không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayHenHan = Convert.ToDateTime(row.Cells["NgayHenHan"].Value ?? DateTime.Now);
                DateTime ngayTra = DateTime.Now;

                // Get Librarian ID (Handle nulls gracefully if SessionContext is null)
                int thuThuId = 1; // Default fallback
                if (SessionContext.CurrentLibrarian != null)
                {
                    thuThuId = SessionContext.CurrentLibrarian.Ma_So;
                }

                if (_phieuMuonBLL.TraSach(maPhieu, maDocGia, ngayTra, ngayHenHan, thuThuId, out decimal tienPhat))
                {
                    if (tienPhat > 0)
                    {
                        int soNgayTre = (ngayTra.Date - ngayHenHan.Date).Days;
                        decimal donGia = _phieuMuonBLL.LayDonGiaPhatTreHan();

                        string msg = $"Trả sách thành công!\n" +
                                     $"Phát hiện trễ hạn: {soNgayTre} ngày.\n" +
                                     $"Đơn giá phạt quy chế: {donGia:N0} VNĐ/ngày.\n" +
                                     $"Tổng tiền phạt: {tienPhat:N0} VNĐ.\n" +
                                     $"-> Hệ thống đã tự động lập Phiếu phạt vi phạm cho độc giả!";
                        MessageBox.Show(msg, "Thông báo vi phạm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Trả sách thành công! Độc giả trả đúng hạn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadDanhSachDangMuon(maDocGia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi trả sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();

            // Fix: Use dynamic config instead of hardcoded '14'
            int soNgay = _phieuMuonBLL.LaySoNgayMuonToiDa();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(soNgay);

            if (cboDocGia.SelectedValue != null)
            {
                LoadDanhSachDangMuon(cboDocGia.SelectedValue.ToString() ?? "");
            }
        }
    }
}