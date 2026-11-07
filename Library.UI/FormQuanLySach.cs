using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BLL;
using Library.DAL;
using Library.DTO;

namespace Library.UI
{
    /// <summary>
    /// Thủ thư quản lý kho chi nhánh: tìm đầu sách, sửa kệ và giá, đề xuất thanh lý một bản hỏng,
    /// mở form điều phối bản sao sang chi nhánh khác.
    /// </summary>
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

        private async void FormQuanLySach_Load(object sender, EventArgs e)
        {
            // Bật DoubleBuffered chống nháy màn hình (nếu bạn đã tạo Extension ở bước trước)
            // dgvSach.EnableDoubleBuffered(true);
            // dgvKhoChiNhanh.EnableDoubleBuffered(true);

            NapDanhSachChiNhanh();
            await TaiDuLieuKhoChiNhanhAsync();
            await LoadDataAsync();
            _isInitialized = true;
            dgvSach.CellClick += dgvSach_CellClick;
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
            if (SessionContext.CurrentLibrarian == null) return 1;
            return new CaTrucBLL().LayChiNhanhTrucHomNay(SessionContext.CurrentLibrarian.Ma_So);
        }

        private async Task TaiDuLieuKhoChiNhanhAsync()
        {
            try
            {
                int chiNhanhMaSo = 0;
                if (cboChiNhanhKho.SelectedValue != null && int.TryParse(cboChiNhanhKho.SelectedValue.ToString(), out int id))
                    chiNhanhMaSo = id;

                string tuKhoa = txtTimKiemKho.Text.Trim();

                // Gọi hàm bất đồng bộ, UI vẫn mượt trong lúc truy vấn CSDL
                var listKho = await _thongKeBLL.LayChiTietKhoSachChiNhanhAsync(chiNhanhMaSo, tuKhoa);

                dgvKhoChiNhanh.AutoGenerateColumns = false;
                dgvKhoChiNhanh.DataSource = listKho;

                lblTongDauSachCNVal.Text = listKho.Count.ToString();
                lblTongBanSaoCNVal.Text = listKho.Sum(x => x.Tong_Ban_Sao).ToString();
                lblDangMuonCNVal.Text = listKho.Sum(x => x.Dang_Muon).ToString();
                lblSanCoCNVal.Text = listKho.Sum(x => x.San_Co).ToString();
                lblBaoTriCNVal.Text = listKho.Sum(x => x.Bao_Tri).ToString();
            }
            catch { }
        }

        private async void cboChiNhanhKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitialized) await TaiDuLieuKhoChiNhanhAsync();
        }

        private async void txtTimKiemKho_TextChanged(object sender, EventArgs e)
        {
            if (_isInitialized) await TaiDuLieuKhoChiNhanhAsync();
        }

        private async void btnTaiLaiKho_Click(object sender, EventArgs e)
        {
            txtTimKiemKho.Clear();
            await TaiDuLieuKhoChiNhanhAsync();
        }

        private async void btnThanhLyCuon_Click(object sender, EventArgs e)
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
                await LoadDataAsync();
                await TaiDuLieuKhoChiNhanhAsync();
            }
            else
            {
                MessageBox.Show(err, "Không thể thanh lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Nghiệp vụ Danh mục Biểu ghi (Tab 2)
        private async Task LoadDataAsync()
        {
            try
            {
                if (dgvSach != null)
                {
                    dgvSach.DataSource = await _sachBLL.TimKiemSachAsync(txtTimKiem?.Text.Trim() ?? string.Empty);
                }
            }
            catch { }
        }

        private async void btnTimKiem_Click(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void btnThemSach_Click(object? sender, EventArgs e)
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
                await LoadDataAsync();
                await TaiDuLieuKhoChiNhanhAsync();
            }
            else
            {
                MessageBox.Show(err, "Cảnh báo kiểm kê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCapNhatKho_Click(object? sender, EventArgs e)
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
                    await LoadDataAsync();
                    await TaiDuLieuKhoChiNhanhAsync();
                }
                else
                {
                    MessageBox.Show(err, "Lỗi kiểm kê kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnXoaSach_Click(object? sender, EventArgs e)
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
                        await LoadDataAsync();
                        await TaiDuLieuKhoChiNhanhAsync();
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

        private async void btnDeXuatThanhLy_Click(object? sender, EventArgs e)
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
                await LoadDataAsync();
                await TaiDuLieuKhoChiNhanhAsync();
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
                if (txtTenSach != null) txtTenSach.Text = drv["Tieu_De"]?.ToString() ?? string.Empty;
                if (txtTacGia != null) txtTacGia.Text = drv["Tac_Gia"]?.ToString() ?? string.Empty;
                if (txtTheLoai != null) txtTheLoai.Text = drv["The_Loai"]?.ToString() ?? string.Empty;
                if (txtViTri != null) txtViTri.Text = drv["Vi_Tri_Ke"]?.ToString() ?? string.Empty;
                if (nudTongSoLuong != null && drv["Tong_So_Luong"] != DBNull.Value)
                    nudTongSoLuong.Value = Convert.ToDecimal(drv["Tong_So_Luong"]);
            }
        }

        private async void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                await TaiDuLieuKhoChiNhanhAsync();
            }
            else
            {
                await LoadDataAsync();
            }
        }
        #endregion
    }
}