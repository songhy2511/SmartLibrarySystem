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
    public partial class FormQuanLySach : Form
    {
        private readonly SachBLL _sachBLL = new SachBLL();

        public FormQuanLySach()
        {
            InitializeComponent();
            this.BackColor = UITheme.ContentBg;
            LoadData();
        }

        private void LoadData()
        {
            if (dgvSach != null)
            {
                dgvSach.DataSource = _sachBLL.TimKiemSach(txtTimKiem?.Text.Trim() ?? string.Empty);
            }
        }

        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            LoadData();
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
                }
                else
                {
                    MessageBox.Show(err, "Lỗi kiểm kê kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}