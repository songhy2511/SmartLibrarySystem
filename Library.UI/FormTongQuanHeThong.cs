using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    /// <summary>Trang chủ Admin: bốn thẻ KPI và lưới mượn-trả trong tuần hiện tại, tính từ thứ Hai.</summary>
    public partial class FormTongQuanHeThong : Form
    {
        private readonly ThongKeBLL _thongKeBLL = new ThongKeBLL();
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();
        private bool _isInitialized = false;

        public FormTongQuanHeThong()
        {
            InitializeComponent();
        }

        private async void FormTongQuanHeThong_Load(object sender, EventArgs e)
        {
            await TaiDuLieuTongQuanAsync();
            NapDanhSachChiNhanh();
            await TaiDuLieuKhoChiNhanhAsync();

            dgvLuuThongTuan.EnableDoubleBuffered(true);
            dgvKhoSachChiNhanh.EnableDoubleBuffered(true);

            _isInitialized = true;
        }

        #region Tab 1: Tổng Quan Chỉ Số Hệ Thống
        private async Task TaiDuLieuTongQuanAsync()
        {
            try
            {
                lblKPIDocGiaVal.Text = _thongKeBLL.LayTongSoDocGia().ToString("N0");
                lblKPIDauSachVal.Text = _thongKeBLL.LayTongSoDauSach().ToString("N0");
                lblKPIDangMuonVal.Text = _thongKeBLL.LayTongSachDangMuon().ToString("N0");
                lblKPITienPhatVal.Text = $"{_thongKeBLL.LayTongTienPhatChuaThu():N0} đ";

                DataTable dtLuuThong = await _thongKeBLL.LayLuuThongTuanAsync();
                dgvLuuThongTuan.AutoGenerateColumns = false;
                dgvLuuThongTuan.DataSource = dtLuuThong;
            }
            catch { }
        }

        private async void btnLamMoiTongQuan_Click(object sender, EventArgs e)
        {
            await TaiDuLieuTongQuanAsync();
        }

        private void dgvLuuThongTuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private async Task TaiDuLieuKhoChiNhanhAsync()
        {
            try
            {
                int chiNhanhMaSo = cboChiNhanhKho.SelectedValue != null ? Convert.ToInt32(cboChiNhanhKho.SelectedValue) : 0;
                string tuKhoa = txtTimKiemKho.Text.Trim();

                var listKho = await _thongKeBLL.LayChiTietKhoSachChiNhanhAsync(chiNhanhMaSo, tuKhoa);

                dgvKhoSachChiNhanh.AutoGenerateColumns = false;
                dgvKhoSachChiNhanh.DataSource = listKho;

                // 👉 Đã khôi phục code tính toán KPI
                lblTongDauSachCNVal.Text = listKho.Count.ToString("N0");
                lblTongBanSaoCNVal.Text = listKho.Sum(x => x.Tong_Ban_Sao).ToString("N0");
                lblDangMuonCNVal.Text = listKho.Sum(x => x.Dang_Muon).ToString("N0");
                lblSanCoCNVal.Text = listKho.Sum(x => x.San_Co).ToString("N0");
                lblBaoTriCNVal.Text = listKho.Sum(x => x.Bao_Tri).ToString("N0");
            }
            catch { }
        }

        private async void cboChiNhanhKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized)
            {
                await TaiDuLieuKhoChiNhanhAsync();
            }
        }

        private async void txtTimKiemKho_TextChanged(object sender, EventArgs e)
        {
            // 👉 Đã bổ sung chặn lỗi khi Form khởi tạo
            if (_isInitialized)
            {
                await TaiDuLieuKhoChiNhanhAsync();
            }
        }

        private async void btnTaiLaiKho_Click(object sender, EventArgs e)
        {
            txtTimKiemKho.Clear();
            await TaiDuLieuKhoChiNhanhAsync();
        }

        private async void btnDieuPhoiSach_Click(object sender, EventArgs e)
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

            using var popup = new FormDieuPhoiSach(selected.Ma_Sach, selected.Tieu_De, chiNhanhHienTaiId, tenChiNhanhHienTai);
            if (popup.ShowDialog(this) == DialogResult.OK)
            {
                await TaiDuLieuKhoChiNhanhAsync();
            }
        }

        private async void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                await TaiDuLieuTongQuanAsync();
            }
            else
            {
                await TaiDuLieuKhoChiNhanhAsync();
            }
        }
        #endregion
    }
}