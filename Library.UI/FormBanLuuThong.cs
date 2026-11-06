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

            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(_phieuMuonBLL.LaySoNgayMuonToiDa());

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

                    // Cho phép thủ thư gõ tên sách, mã sách hoặc gợi ý kèm số lượng
                    collection.Add($"{tieuDe} (Còn {khaDung})");
                    collection.Add(tieuDe);
                    collection.Add(maSach);
                    collection.Add($"{maSach} - {tieuDe}");
                }

                txtMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach.AutoCompleteCustomSource = collection;
                txtMaSach.PlaceholderText = "Nhập mã sách, mã vạch hoặc tên sách...";
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
                string query = "SELECT Ma_So AS MaDocGia, Ma_Doc_Gia AS MaThe, Ho_Ten AS TenDocGia FROM dbo.Doc_Gia WHERE Trang_Thai = N'Hoạt động'";
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

                if (dgvSachDangMuon.Columns["MaPhieu"] != null) { dgvSachDangMuon.Columns["MaPhieu"].HeaderText = "Mã Phiếu"; dgvSachDangMuon.Columns["MaPhieu"].Width = 110; }
                if (dgvSachDangMuon.Columns["TenDocGia"] != null) { dgvSachDangMuon.Columns["TenDocGia"].HeaderText = "Tên Độc Giả"; dgvSachDangMuon.Columns["TenDocGia"].Width = 140; }
                if (dgvSachDangMuon.Columns["TenSach"] != null) { dgvSachDangMuon.Columns["TenSach"].HeaderText = "Tên Sách"; }
                if (dgvSachDangMuon.Columns["MaVach"] != null) { dgvSachDangMuon.Columns["MaVach"].HeaderText = "Mã Vạch"; dgvSachDangMuon.Columns["MaVach"].Width = 110; }
                if (dgvSachDangMuon.Columns["NgayMuon"] != null)
                {
                    dgvSachDangMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dgvSachDangMuon.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSachDangMuon.Columns["NgayMuon"].Width = 95;
                }
                if (dgvSachDangMuon.Columns["NgayHenHan"] != null)
                {
                    dgvSachDangMuon.Columns["NgayHenHan"].HeaderText = "Ngày Hẹn Trả";
                    dgvSachDangMuon.Columns["NgayHenHan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSachDangMuon.Columns["NgayHenHan"].Width = 100;
                }
                if (dgvSachDangMuon.Columns["SoLanGiaHan"] != null)
                {
                    dgvSachDangMuon.Columns["SoLanGiaHan"].HeaderText = "Gia Hạn";
                    dgvSachDangMuon.Columns["SoLanGiaHan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSachDangMuon.Columns["SoLanGiaHan"].Width = 75;
                }
                if (dgvSachDangMuon.Columns["TrangThai"] != null) { dgvSachDangMuon.Columns["TrangThai"].HeaderText = "Trạng Thái"; dgvSachDangMuon.Columns["TrangThai"].Width = 100; }
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

                string inputSach = txtMaSach.Text.Trim();
                if (string.IsNullOrEmpty(inputSach))
                {
                    MessageBox.Show("Vui lòng nhập tên sách, mã sách hoặc quét mã vạch cần cho mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSach.Focus();
                    return;
                }

                string maDocGia = cboDocGia.SelectedValue.ToString() ?? "1";
                DateTime ngayMuon = dtpNgayMuon.Value;

                int thuThuMaSo = SessionContext.CurrentLibrarian?.Ma_So ?? 1;
                int chiNhanhMaSo = 1;

                string maPhieu = _phieuMuonBLL.LapPhieuMuon(maDocGia, inputSach, ngayMuon, thuThuMaSo, chiNhanhMaSo);
                if (!string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show($"Cấp mượn thành công!\nMã phiếu mượn: {maPhieu}", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaSach.Clear();
                    LoadDanhSachDangMuon(maDocGia);
                    CaiDatAutoCompleteTimKiemSach(); // Cập nhật lại số lượng trong danh sách gợi ý
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

                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Mã phiếu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayHenHan = Convert.ToDateTime(row.Cells["NgayHenHan"].Value ?? DateTime.Now);
                DateTime ngayTra = DateTime.Now;

                if (_phieuMuonBLL.TraSach(maPhieu, ngayTra, ngayHenHan, out decimal tienPhat))
                {
                    string thongBao = tienPhat > 0
                        ? $"Trả sách hoàn tất!\n⚠️ Sách trả trễ hạn, phát sinh tiền phạt: {tienPhat:N0} VNĐ"
                        : "Xác nhận trả sách đúng hạn thành công!";

                    MessageBox.Show(thongBao, "Thông báo hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string currentDocGia = cboDocGia.SelectedValue?.ToString() ?? "1";
                    LoadDanhSachDangMuon(currentDocGia);
                    CaiDatAutoCompleteTimKiemSach(); // Cập nhật lại số lượng khả dụng
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
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(_phieuMuonBLL.LaySoNgayMuonToiDa());

            if (cboDocGia.SelectedValue != null)
            {
                LoadDanhSachDangMuon(cboDocGia.SelectedValue.ToString() ?? "");
            }
            CaiDatAutoCompleteTimKiemSach();
        }
    }
}