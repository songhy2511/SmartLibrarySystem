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
using System.Windows.Forms;

namespace Library.UI
{
    public partial class FormBanLuuThong : Form
    {
        private readonly PhieuMuonBLL _phieuMuonBLL = new PhieuMuonBLL();

        public FormBanLuuThong()
        {
            InitializeComponent();
        }

        private void FormBanLuuThong_Load(object sender, EventArgs e)
        {
            LoadDanhSachDangMuon("DG0001"); // Độc giả mẫu khớp với giao diện[cite: 2]
        }

        private void LoadDanhSachDangMuon(string maDocGia)
        {
            try
            {
                DataTable dt = _phieuMuonBLL.LayDanhSachDangMuon(maDocGia);
                dgvSachDangMuon.DataSource = dt;
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
                string maDocGia = "DG0001";
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
                // Dùng toán tử ?.ToString() và toán tử null-forgiving (!) hoặc gán giá trị an toàn
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
                    LoadDanhSachDangMuon("DG0001");
                }
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvSachDangMuon.SelectedRows.Count > 0)
            {
                try
                {
                    string maPhieu = dgvSachDangMuon.SelectedRows[0].Cells["MaPhieu"].Value?.ToString() ?? string.Empty;

                    // Lấy số lần gia hạn an toàn (tránh lỗi null nếu cell trống)
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
                        LoadDanhSachDangMuon("DG0001");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}