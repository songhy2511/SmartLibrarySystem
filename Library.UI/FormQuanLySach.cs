using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DAL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormQuanLySach : Form
    {
        private readonly SachBLL _sachBLL = new SachBLL();
        private readonly ThongKeBLL _thongKeBLL = new ThongKeBLL();
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();
        private bool _isInitialized = false;

        public FormQuanLySach()
        {
            InitializeComponent();
        }

        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
            NapDanhSachChiNhanh();
            TaiDuLieuKhoChiNhanh();
            LoadData();
            _isInitialized = true;
        }

        private void NapDanhSachChiNhanh()
        {
            try
            {
                var listCN = _chiNhanhBLL.LayDanhSachChiNhanh();
                listCN.Insert(0, new ChiNhanhDTO { Ma_So = 0, Ten_Chi_Nhanh = "-- Toàn bộ hệ thống thư viện --" });

                cboChiNhanhKho.DataSource = listCN;
                cboChiNhanhKho.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanhKho.ValueMember = "Ma_So";

                // Tự động nhận diện chi nhánh mà thủ thư đang trực ca hôm nay
                int myBranchId = LayChiNhanhTrucHomNay();
                if (myBranchId > 0 && listCN.Any(x => x.Ma_So == myBranchId))
                {
                    cboChiNhanhKho.SelectedValue = myBranchId;
                }
                else
                {
                    // Mặc định chọn chi nhánh 1 nếu chưa phân ca
                    cboChiNhanhKho.SelectedValue = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục chi nhánh: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int LayChiNhanhTrucHomNay()
        {
            try
            {
                int thuThuMaSo = SessionContext.CurrentLibrarian?.Ma_So ?? 1;
                string query = "SELECT TOP 1 Chi_Nhanh_Ma_So FROM dbo.Ca_Truc WHERE Thu_Thu_Ma_So = @TTId AND CAST(Ngay_Truc AS DATE) = CAST(GETDATE() AS DATE)";
                object? res = DatabaseHelper.ExecuteScalar(query, new[] { new Microsoft.Data.SqlClient.SqlParameter("@TTId", thuThuMaSo) });
                if (res != null && res != DBNull.Value)
                {
                    return Convert.ToInt32(res);
                }
            }
            catch { }
            return 1;
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

                dgvKhoChiNhanh.AutoGenerateColumns = false;
                dgvKhoChiNhanh.DataSource = null;
                dgvKhoChiNhanh.DataSource = listKho;

                // Cập nhật 5 thẻ KPI kho chi nhánh
                lblTongDauSachCNVal.Text = listKho.Count.ToString();
                lblTongBanSaoCNVal.Text = listKho.Sum(x => x.Tong_Ban_Sao).ToString();
                lblDangMuonCNVal.Text = listKho.Sum(x => x.Dang_Muon).ToString();
                lblSanCoCNVal.Text = listKho.Sum(x => x.San_Co).ToString();
                lblBaoTriCNVal.Text = listKho.Sum(x => x.Bao_Tri).ToString();
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

        private void btnThanhLyCuon_Click(object sender, EventArgs e)
        {
            if (dgvKhoChiNhanh.CurrentRow?.DataBoundItem is not KhoSachChiNhanhDTO selected)
            {
                MessageBox.Show("Vui lòng chọn 1 đầu sách từ danh sách chi nhánh để thanh lý cuốn hỏng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selected.San_Co <= 0)
            {
                MessageBox.Show($"Đầu sách '{selected.Tieu_De}' hiện không còn cuốn nào khả dụng trên kệ để thanh lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận lập biên bản loại bỏ 1 cuốn sách bị rách nát / hư hỏng nặng thuộc đầu sách:\n\n'{selected.Tieu_De}' ({selected.Ma_Sach})?\n\n(Thao tác sẽ giảm 1 tổng số lượng và 1 số lượng sẵn sàng trên kệ)",
                "Xác nhận thanh lý bản sao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            int? currentUserId = SessionContext.CurrentUser?.Ma_So;
            if (_sachBLL.DeXuatThanhLyCuonSach(selected.Ma_Sach, selected.Tieu_De, selected.San_Co, currentUserId, out string err))
            {
                MessageBox.Show("Thanh lý cuốn sách thành công! Đã cập nhật tồn kho chi nhánh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieuKhoChiNhanh();
                LoadData();
            }
            else
            {
                MessageBox.Show(err, "Không thể thanh lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Nghiệp vụ Danh mục Biểu ghi (Tab 2)
        private void LoadData()
        {
            try
            {
                if (dgvSach != null)
                {
                    dgvSach.DataSource = _sachBLL.TimKiemSach(txtTimKiem?.Text.Trim() ?? string.Empty);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi load biểu ghi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemSach_Click(object? sender, EventArgs e)
        {
            var sach = new SachDTO
            {
                Tieu_De = txtTenSach?.Text.Trim() ?? string.Empty,
                Tac_Gia = txtTacGia?.Text.Trim() ?? string.Empty,
                The_Loai = txtTheLoai?.Text.Trim() ?? string.Empty,
                Vi_Tri_Ke = txtViTri?.Text.Trim() ?? "Kệ A1-01",
                Tong_So_Luong = nudTongSoLuong != null ? (int)nudTongSoLuong.Value : 1,
                So_Luong_Kha_Dung = nudTongSoLuong != null ? (int)nudTongSoLuong.Value : 1
            };

            int? currentUserId = SessionContext.CurrentUser?.Ma_So;
            if (_sachBLL.ThemSachMoi(sach, currentUserId, out string err))
            {
                MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TaiDuLieuKhoChiNhanh();
            }
            else
            {
                MessageBox.Show(err, "Cảnh báo kiểm kê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatKho_Click(object? sender, EventArgs e)
        {
            if (dgvSach?.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                var sach = new SachDTO
                {
                    Ma_Sach = drv["Ma_Sach"].ToString() ?? string.Empty,
                    Tieu_De = txtTenSach?.Text.Trim() ?? string.Empty,
                    Tac_Gia = txtTacGia?.Text.Trim() ?? string.Empty,
                    The_Loai = txtTheLoai?.Text.Trim() ?? string.Empty,
                    Vi_Tri_Ke = txtViTri?.Text.Trim() ?? "Kệ A1-01",
                    Nam_Xuat_Ban = drv["Nam_Xuat_Ban"] != DBNull.Value ? Convert.ToInt32(drv["Nam_Xuat_Ban"]) : 2024,
                    Tong_So_Luong = nudTongSoLuong != null ? (int)nudTongSoLuong.Value : 1,
                    So_Luong_Kha_Dung = drv["So_Luong_Kha_Dung"] != DBNull.Value ? Convert.ToInt32(drv["So_Luong_Kha_Dung"]) : 1
                };

                int? currentUserId = SessionContext.CurrentUser?.Ma_So;
                if (_sachBLL.CapNhatKhoSach(sach, currentUserId, out string err))
                {
                    MessageBox.Show("Cập nhật thông tin kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    TaiDuLieuKhoChiNhanh();
                }
                else
                {
                    MessageBox.Show(err, "Lỗi kiểm kê kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaSach_Click(object? sender, EventArgs e)
        {
            if (dgvSach?.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                string maSach = drv["Ma_Sach"].ToString() ?? string.Empty;
                string tieuDe = drv["Tieu_De"].ToString() ?? string.Empty;

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách '{tieuDe}' (Mã: {maSach}) khỏi kho?",
                    "Xác nhận xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int? currentUserId = SessionContext.CurrentUser?.Ma_So;
                    if (_sachBLL.XoaSach(maSach, currentUserId, out string err))
                    {
                        MessageBox.Show("Xóa đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        TaiDuLieuKhoChiNhanh();
                    }
                    else
                    {
                        MessageBox.Show(err, "Không thể xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 đầu sách trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeXuatThanhLy_Click(object? sender, EventArgs e)
        {
            if (dgvSach?.CurrentRow?.DataBoundItem is not DataRowView drv)
            {
                MessageBox.Show("Vui lòng chọn 1 đầu sách trong bảng để thanh lý cuốn hỏng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maSach = drv["Ma_Sach"].ToString() ?? string.Empty;
            string tieuDe = drv["Tieu_De"].ToString() ?? string.Empty;
            int khaDung = Convert.ToInt32(drv["So_Luong_Kha_Dung"]);

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn thanh lý 1 cuốn bị hư hỏng thuộc đầu sách:\n\n'{tieuDe}' ({maSach})?\n\n(Hệ thống sẽ giảm 1 tổng số lượng và 1 số lượng khả dụng)",
                "Xác nhận thanh lý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            int? currentUserId = SessionContext.CurrentUser?.Ma_So;

            if (_sachBLL.DeXuatThanhLyCuonSach(maSach, tieuDe, khaDung, currentUserId, out string err))
            {
                MessageBox.Show("Thanh lý thành công 1 cuốn sách! Số lượng tồn kho đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TaiDuLieuKhoChiNhanh();
            }
            else
            {
                MessageBox.Show(err, "Không thể thanh lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSach_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach != null && e.RowIndex >= 0 && dgvSach.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
            {
                if (txtTenSach != null) txtTenSach.Text = drv["Tieu_De"].ToString();
                if (txtTacGia != null) txtTacGia.Text = drv["Tac_Gia"].ToString();
                if (txtTheLoai != null) txtTheLoai.Text = drv["The_Loai"].ToString();
                if (txtViTri != null) txtViTri.Text = drv["Vi_Tri_Ke"].ToString();
                if (nudTongSoLuong != null) nudTongSoLuong.Value = Convert.ToDecimal(drv["Tong_So_Luong"]);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                TaiDuLieuKhoChiNhanh();
            }
            else
            {
                LoadData();
            }
        }
        #endregion
    }
}