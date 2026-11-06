using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormTongQuanHeThong : Form
    {
        private readonly ThongKeBLL _thongKeBLL = new ThongKeBLL();
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();
        private bool _isInitialized = false;

        public FormTongQuanHeThong()
        {
            InitializeComponent();
        }

        private void FormTongQuanHeThong_Load(object sender, EventArgs e)
        {
            TaiDuLieuTongQuan();
            NapDanhSachChiNhanh();
            TaiDuLieuKhoChiNhanh();
            _isInitialized = true;
        }

        #region Tab 1: Tổng Quan Chỉ Số Hệ Thống
        private void TaiDuLieuTongQuan()
        {
            try
            {
                // 1. Nạp 4 chỉ số KPI toàn hệ thống
                lblKPIDocGiaVal.Text = _thongKeBLL.LayTongSoDocGia().ToString("N0");
                lblKPIDauSachVal.Text = _thongKeBLL.LayTongSoDauSach().ToString("N0");
                lblKPIDangMuonVal.Text = _thongKeBLL.LayTongSachDangMuon().ToString("N0");

                decimal tienPhatChuaThu = _thongKeBLL.LayTongTienPhatChuaThu();
                lblKPITienPhatVal.Text = $"{tienPhatChuaThu:N0} đ";

                // 2. Nạp danh sách lưu thông tuần
                DataTable dtLuuThong = _thongKeBLL.LayLuuThongTuan();
                dgvLuuThongTuan.AutoGenerateColumns = false;
                dgvLuuThongTuan.DataSource = dtLuuThong;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu tổng quan: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoiTongQuan_Click(object sender, EventArgs e)
        {
            TaiDuLieuTongQuan();
        }

        private void dgvLuuThongTuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click trên cell lưu thông (nếu có bổ sung cột thao tác)
        }
        #endregion

        #region Tab 2: Kho Sách Chi Nhánh & Điều Phối
        private void NapDanhSachChiNhanh()
        {
            try
            {
                var listCN = _chiNhanhBLL.LayDanhSachChiNhanh();
                listCN.Insert(0, new ChiNhanhDTO { Ma_So = 0, Ten_Chi_Nhanh = "-- Toàn bộ hệ thống thư viện --" });

                cboChiNhanhKho.DataSource = listCN;
                cboChiNhanhKho.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanhKho.ValueMember = "Ma_So";
                cboChiNhanhKho.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục chi nhánh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDuLieuKhoChiNhanh()
        {
            try
            {
                int chiNhanhMaSo = 0;
                if (cboChiNhanhKho.SelectedValue != null && int.TryParse(cboChiNhanhKho.SelectedValue.ToString(), out int id))
                {
                    chiNhanhMaSo = id;
                }

                string tuKhoa = txtTimKiemKho.Text.Trim();
                var listKho = _thongKeBLL.LayChiTietKhoSachChiNhanh(chiNhanhMaSo, tuKhoa);

                dgvKhoSachChiNhanh.AutoGenerateColumns = false;
                dgvKhoSachChiNhanh.DataSource = null;
                dgvKhoSachChiNhanh.DataSource = listKho;

                // Cập nhật 5 thẻ KPI của chi nhánh
                lblTongDauSachCNVal.Text = listKho.Count.ToString("N0");
                lblTongBanSaoCNVal.Text = listKho.Sum(x => x.Tong_Ban_Sao).ToString("N0");
                lblDangMuonCNVal.Text = listKho.Sum(x => x.Dang_Muon).ToString("N0");
                lblSanCoCNVal.Text = listKho.Sum(x => x.San_Co).ToString("N0");
                lblBaoTriCNVal.Text = listKho.Sum(x => x.Bao_Tri).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải kho sách chi nhánh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboChiNhanhKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                TaiDuLieuKhoChiNhanh();
            }
        }

        private void txtTimKiemKho_TextChanged(object sender, EventArgs e)
        {
            TaiDuLieuKhoChiNhanh();
        }

        private void btnTaiLaiKho_Click(object sender, EventArgs e)
        {
            txtTimKiemKho.Clear();
            TaiDuLieuKhoChiNhanh();
        }

        private void btnDieuPhoiSach_Click(object sender, EventArgs e)
        {
            if (dgvKhoSachChiNhanh.CurrentRow?.DataBoundItem is not KhoSachChiNhanhDTO selected)
            {
                MessageBox.Show("Vui lòng chọn 1 đầu sách từ danh sách chi nhánh để tiến hành điều phối!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int chiNhanhHienTaiId = 0;
            if (cboChiNhanhKho.SelectedValue != null)
            {
                int.TryParse(cboChiNhanhKho.SelectedValue.ToString(), out chiNhanhHienTaiId);
            }

            if (chiNhanhHienTaiId == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi nhánh xuất cụ thể từ danh sách lọc phía trên (không chọn 'Toàn bộ hệ thống') để xác định nguồn điều chuyển!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChiNhanhKho.Focus();
                return;
            }

            if (selected.San_Co <= 0)
            {
                MessageBox.Show($"Đầu sách '{selected.Tieu_De}' tại chi nhánh này hiện không còn bản sao nào sẵn sàng trên kệ để luân chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenChiNhanhHienTai = cboChiNhanhKho.Text;

            // Mở popup điều phối sách đã được thiết kế
            using var popup = new FormDieuPhoiSach(selected.Ma_Sach, selected.Tieu_De, chiNhanhHienTaiId, tenChiNhanhHienTai);
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                TaiDuLieuKhoChiNhanh();
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                TaiDuLieuTongQuan();
            }
            else
            {
                TaiDuLieuKhoChiNhanh();
            }
        }
        #endregion
    }
}