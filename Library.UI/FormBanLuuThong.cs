using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormBanLuuThong : Form
    {
        private readonly PhieuMuonBLL _phieuMuonBLL = new PhieuMuonBLL();

        public FormBanLuuThong()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            // Thiết lập AutoComplete cho ComboBox độc giả theo quy ước
            cboDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;

            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenHan.Value = DateTime.Now.AddDays(14); // Hạn mặc định 14 ngày

            LoadDanhSachPhieuMuon();
        }

        private void LoadDanhSachPhieuMuon()
        {
            // Nạp danh sách phiếu mượn vào DataGridView
            dgvPhieuMuon.DataSource = null;
            // dgvPhieuMuon.DataSource = _phieuMuonBLL.LayDanhSach();
        }

        private void btnKiemTraDieuKien_Click(object sender, EventArgs e)
        {
            string maDocGia = txtMaDocGia.Text.Trim();
            if (string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var check = _phieuMuonBLL.KiemTraDieuKienMuon(maDocGia);
            if (check.IsValid)
            {
                lblTrangThaiThe.Text = "Trạng thái: " + check.Message;
                lblTrangThaiThe.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblTrangThaiThe.Text = "Trạng thái: " + check.Message;
                lblTrangThaiThe.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnXacNhanMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) || string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Độc giả và Mã sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhieuMuonDTO pm = new PhieuMuonDTO
            {
                MaPhieuMuon = "BR" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                MaDocGia = txtMaDocGia.Text.Trim(),
                MaSach = txtMaSach.Text.Trim(),
                MaThuThu = "TT0001", // Lấy từ SessionContext đăng nhập
                NgayMuon = dtpNgayMuon.Value,
                NgayHetHan = dtpNgayHenHan.Value
            };

            bool ketQua = _phieuMuonBLL.LapPhieuMuon(pm, out string error);
            if (ketQua)
            {
                MessageBox.Show("Tạo phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhieuMuon();
            }
            else
            {
                MessageBox.Show($"Lỗi tạo phiếu mượn: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xử lý an toàn chống Null Reference
            string maPhieuMuon = dgvPhieuMuon.CurrentRow.Cells["MaPhieuMuon"]?.Value?.ToString() ?? string.Empty;
            var cellNgayHetHan = dgvPhieuMuon.CurrentRow.Cells["NgayHetHan"]?.Value;

            if (string.IsNullOrEmpty(maPhieuMuon) || cellNgayHetHan == null)
            {
                MessageBox.Show("Dữ liệu phiếu mượn được chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime ngayHetHan = Convert.ToDateTime(cellNgayHetHan);
            DateTime ngayTraActual = dtpNgayTra.Value;

            decimal tienPhat = _phieuMuonBLL.TraSach(maPhieuMuon, ngayTraActual, ngayHetHan);

            if (tienPhat > 0)
            {
                lblTongTienThu.Text = $"Tiền phạt trễ hạn: {tienPhat:N0} VNĐ";
                MessageBox.Show($"Trả sách thành công. Độc giả bị phạt trễ hạn: {tienPhat:N0} VNĐ", "Cảnh báo quá hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblTongTienThu.Text = "Tiền phạt: 0 VNĐ";
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadDanhSachPhieuMuon();
        }

        private void btnMoFormBiEnBan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow != null)
            {
                // Sử dụng ?? "" để đảm bảo luôn truyền chuỗi khác null vào constructor
                string maPhieuMuon = dgvPhieuMuon.CurrentRow.Cells["MaPhieuMuon"]?.Value?.ToString() ?? string.Empty;
                string maDocGia = dgvPhieuMuon.CurrentRow.Cells["MaDocGia"]?.Value?.ToString() ?? string.Empty;

                FormLapBienBanViPham formVP = new FormLapBienBanViPham(maPhieuMuon, maDocGia);
                formVP.ShowDialog();
            }
            else
            {
                FormLapBienBanViPham formVP = new FormLapBienBanViPham();
                formVP.ShowDialog();
            }
        }
    }
}
