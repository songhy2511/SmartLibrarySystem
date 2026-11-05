using Library.BLL;
using Library.DAL;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormBanLuuThong : Form
    {
        private readonly PhieuMuonBLL _phieuMuonBLL = new PhieuMuonBLL();
        private bool _isInitialized = false; // Cờ kiểm soát tránh gọi sự kiện quá sớm khi form chưa load xong

        public FormBanLuuThong()
        {
            InitializeComponent();
        }

        private void FormBanLuuThong_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình giao diện DataGridView chuẩn
            SetupDataGridView();

            // 2. Load danh sách độc giả vào ComboBox trước
            LoadDanhSachDocGia();

            // 3. Đánh dấu đã load xong để kích hoạt sự kiện SelectedIndexChanged của ComboBox
            _isInitialized = true;

            // 4. Load dữ liệu bảng ứng với độc giả đầu tiên đang chọn trên ComboBox
            if (cboDocGia.SelectedValue != null)
            {
                LoadDanhSachDangMuon(cboDocGia.SelectedValue.ToString() ?? "");
            }
        }

        private void SetupDataGridView()
        {
            dgvSachDangMuon.AutoGenerateColumns = true;
            dgvSachDangMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachDangMuon.MultiSelect = false;
            dgvSachDangMuon.ReadOnly = true;
            dgvSachDangMuon.BackgroundColor = Color.White;

            // Tắt chế độ Fill tự động toàn phần để cho phép set cứng chiều rộng từng cột rõ ràng, không bị bóp méo chữ
            dgvSachDangMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvSachDangMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvSachDangMuon.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            // Đặt chiều cao hàng và tiêu đề thoáng đãng
            dgvSachDangMuon.RowTemplate.Height = 28;
            dgvSachDangMuon.ColumnHeadersHeight = 35;
        }

        // Sự kiện liên kết quan trọng: Khi chọn độc giả khác trên ComboBox, bảng dữ liệu tự động thay đổi theo
        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized && cboDocGia.SelectedValue != null)
            {
                // Kiểm tra nếu SelectedValue là DataRowView thì lấy trực tiếp cột MaDocGia
                string selectedMaDocGia = string.Empty;

                if (cboDocGia.SelectedItem is DataRowView drv)
                {
                    selectedMaDocGia = drv["MaDocGia"].ToString() ?? "";
                }
                else
                {
                    selectedMaDocGia = cboDocGia.SelectedValue.ToString() ?? "";
                }

                if (!string.IsNullOrEmpty(selectedMaDocGia))
                {
                    LoadDanhSachDangMuon(selectedMaDocGia);
                }
            }
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                // Đảm bảo truy vấn lấy đúng cột khóa chính Ma_So làm ValueMember
                string query = "SELECT Ma_So AS MaDocGia, Ho_Ten AS TenDocGia FROM Doc_Gia";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaDocGia + ' - ' + TenDocGia");

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "MaDocGia"; // Giá trị này phải khớp chính xác với Ma_So trong CSDL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách độc giả: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachDangMuon(string maDocGia)
        {
            try
            {
                DataTable dt = _phieuMuonBLL.LayDanhSachDangMuon(maDocGia);
                dgvSachDangMuon.DataSource = dt;

                // Tùy chỉnh độ rộng từng cột cố định để không bị ép chữ xuống dòng
                if (dgvSachDangMuon.Columns["MaPhieu"] != null) { dgvSachDangMuon.Columns["MaPhieu"].HeaderText = "Mã Phiếu"; dgvSachDangMuon.Columns["MaPhieu"].Width = 95; }
                if (dgvSachDangMuon.Columns["TenDocGia"] != null) { dgvSachDangMuon.Columns["TenDocGia"].HeaderText = "Tên Độc Giả"; dgvSachDangMuon.Columns["TenDocGia"].Width = 150; }
                if (dgvSachDangMuon.Columns["TenSach"] != null) { dgvSachDangMuon.Columns["TenSach"].HeaderText = "Tên Sách"; dgvSachDangMuon.Columns["TenSach"].Width = 160; }
                if (dgvSachDangMuon.Columns["MaVach"] != null) { dgvSachDangMuon.Columns["MaVach"].HeaderText = "Mã Vạch"; dgvSachDangMuon.Columns["MaVach"].Width = 120; }
                if (dgvSachDangMuon.Columns["NgayMuon"] != null) { dgvSachDangMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn"; dgvSachDangMuon.Columns["NgayMuon"].Width = 105; }
                if (dgvSachDangMuon.Columns["NgayHenHan"] != null) { dgvSachDangMuon.Columns["NgayHenHan"].HeaderText = "Ngày Hẹn Trả"; dgvSachDangMuon.Columns["NgayHenHan"].Width = 105; }
                if (dgvSachDangMuon.Columns["TrangThai"] != null) { dgvSachDangMuon.Columns["TrangThai"].HeaderText = "Trạng Thái"; dgvSachDangMuon.Columns["TrangThai"].Width = 110; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                string maDocGia = cboDocGia.SelectedValue?.ToString() ?? "DG0001";
                string maSach = "B0001";
                DateTime ngayMuon = dtpNgayMuon.Value;

                string maPhieu = _phieuMuonBLL.LapPhieuMuon(maDocGia, maSach, ngayMuon);
                if (!string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show($"Lập phiếu mượn thành công! Mã phiếu: {maPhieu}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDangMuon(maDocGia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count > 0)
            {
                string maPhieu = dgvSachDangMuon.SelectedRows[0].Cells["MaPhieu"].Value?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Mã phiếu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayHenHan = Convert.ToDateTime(dgvSachDangMuon.SelectedRows[0].Cells["NgayHenHan"].Value ?? DateTime.Now);
                DateTime ngayTra = DateTime.Now;

                if (_phieuMuonBLL.TraSach(maPhieu, ngayTra, ngayHenHan, out decimal tienPhat))
                {
                    MessageBox.Show($"Trả sách thành công! Tiền phạt trễ hạn: {tienPhat:N0} VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string currentDocGia = cboDocGia.SelectedValue?.ToString() ?? "DG0001";
                    LoadDanhSachDangMuon(currentDocGia);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng phiếu mượn trong danh sách để trả sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count > 0)
            {
                try
                {
                    string maPhieu = dgvSachDangMuon.SelectedRows[0].Cells["MaPhieu"].Value?.ToString() ?? string.Empty;

                    int soLanGiaHan = 0;
                    var cellSoLan = dgvSachDangMuon.SelectedRows[0].Cells["SoLanGiaHan"].Value;
                    if (cellSoLan != null && int.TryParse(cellSoLan.ToString(), out int parsedLan))
                    {
                        soLanGiaHan = parsedLan;
                    }

                    DateTime ngayHenHan = Convert.ToDateTime(dgvSachDangMuon.SelectedRows[0].Cells["NgayHenHan"].Value ?? DateTime.Now);

                    if (_phieuMuonBLL.GiaHanPhieu(maPhieu, soLanGiaHan, ngayHenHan))
                    {
                        MessageBox.Show("Gia hạn thời gian mượn thành công thêm 7 ngày!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string currentDocGia = cboDocGia.SelectedValue?.ToString() ?? "DG0001";
                        LoadDanhSachDangMuon(currentDocGia);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần gia hạn trên bảng!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtTimKiemSach_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemSach.Text == "Nhập mã sách hoặc tên sách...")
            {
                txtTimKiemSach.Text = "";
                txtTimKiemSach.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiemSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemSach.Text))
            {
                txtTimKiemSach.Text = "Nhập mã sách hoặc tên sách...";
                txtTimKiemSach.ForeColor = Color.Gray;
            }
        }
    }
}