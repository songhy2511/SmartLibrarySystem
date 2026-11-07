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
    public partial class FormQuanLyDocGia : Form
    {
        private readonly DocGiaBLL _bll = new DocGiaBLL();
        private Button btnCapNhatDocGia = new Button();

        public FormQuanLyDocGia()
        {
            InitializeComponent();
            ApplyTheme();
            LoadData();
        }

        private void ApplyTheme()
        {
            this.BackColor = UITheme.ContentBg;
            if (dgvDocGia != null)
            {
                dgvDocGia.CellFormatting += DgvDocGia_CellFormatting;
                dgvDocGia.EnableDoubleBuffered(true);

                dgvDocGia.CellClick += dgvDocGia_CellClick;
            }
            // Đặt nút Cập Nhật nằm cạnh nút Xóa Độc Giả
            if (btnXoaDocGia != null)
            {
                btnCapNhatDocGia.Text = "Cập Nhật Độc Giả";
                btnCapNhatDocGia.Font = btnThemDocGia != null ? btnThemDocGia.Font : new Font("Segoe UI", 9F);
                btnCapNhatDocGia.BackColor = Color.FromArgb(16, 149, 117); // Xanh Emerald nổi bật
                btnCapNhatDocGia.ForeColor = Color.White;
                btnCapNhatDocGia.FlatStyle = FlatStyle.Flat;
                btnCapNhatDocGia.FlatAppearance.BorderSize = 0;
                btnCapNhatDocGia.Size = btnXoaDocGia.Size;
                btnCapNhatDocGia.Location = new Point(btnXoaDocGia.Right + 12, btnXoaDocGia.Top);
                btnCapNhatDocGia.Cursor = Cursors.Hand;
                btnCapNhatDocGia.Click += btnCapNhatDocGia_Click;

                this.Controls.Add(btnCapNhatDocGia);
                btnCapNhatDocGia.BringToFront();
            }
        }

        private void btnCapNhatDocGia_Click(object? sender, EventArgs e)
        {
            if (dgvDocGia?.CurrentRow?.DataBoundItem is not DataRowView drv)
            {
                MessageBox.Show("Vui lòng chọn một độc giả từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maDG = drv["Ma_Doc_Gia"]?.ToString() ?? string.Empty;
            var dg = new DocGiaDTO
            {
                Ma_Doc_Gia = maDG,
                Ho_Ten = txtHoTen?.Text.Trim() ?? string.Empty,
                So_Dien_Thoai = txtSDT?.Text.Trim(),
                Email = txtEmail?.Text.Trim()
            };

            int? currentUserId = SessionContext.CurrentUser?.Ma_So;

            if (_bll.CapNhatDocGia(dg, currentUserId, out string err))
            {
                MessageBox.Show($"Cập nhật thông tin độc giả {maDG} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(err, "Cảnh báo cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoaDocGia_Click(object? sender, EventArgs e)
        {
            if (dgvDocGia?.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                string maDG = drv["Ma_Doc_Gia"].ToString() ?? string.Empty;
                string hoTen = drv["Ho_Ten"].ToString() ?? string.Empty;

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa độc giả {maDG} - {hoTen} khỏi hệ thống?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int? currentUserId = SessionContext.CurrentUser?.Ma_So;
                    if (_bll.XoaDocGia(maDG, currentUserId, out string err))
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(err, "Lỗi xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 độc giả trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDocGia_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocGia == null || e.RowIndex < 0 || e.RowIndex >= dgvDocGia.Rows.Count) return;
            if (dgvDocGia.Rows[e.RowIndex].DataBoundItem is not DataRowView drv) return;

            if (txtHoTen != null) txtHoTen.Text = drv["Ho_Ten"]?.ToString() ?? string.Empty;
            if (txtSDT != null) txtSDT.Text = drv["So_Dien_Thoai"] != DBNull.Value ? drv["So_Dien_Thoai"].ToString() : string.Empty;
            if (txtEmail != null) txtEmail.Text = drv["Email"] != DBNull.Value ? drv["Email"].ToString() : string.Empty;
        }
        private void LoadData()
        {
            if (dgvDocGia != null)
            {
                dgvDocGia.DataSource = _bll.TimKiemDocGia(txtTimKiem?.Text.Trim() ?? string.Empty);
            }
        }

        private void DgvDocGia_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDocGia != null && e.RowIndex >= 0 && e.RowIndex < dgvDocGia.Rows.Count)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                if (row.DataBoundItem is DataRowView drv)
                {
                    int viPham = drv["So_Lan_Vi_Pham"] != DBNull.Value ? Convert.ToInt32(drv["So_Lan_Vi_Pham"]) : 0;
                    string trangThai = drv["Trang_Thai"]?.ToString() ?? "";

                    if (viPham >= 3 || trangThai == "Khóa tạm thời" || trangThai == "Hết hạn")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                        row.DefaultCellStyle.ForeColor = UITheme.Danger;
                    }
                }
            }
        }

        private void btnThemDocGia_Click(object? sender, EventArgs e)
        {
            var dg = new DocGiaDTO
            {
                Ho_Ten = txtHoTen?.Text.Trim() ?? string.Empty,
                So_Dien_Thoai = txtSDT?.Text.Trim(),
                Email = txtEmail?.Text.Trim()
            };

            int? currentUserId = SessionContext.CurrentUser?.Ma_So;

            if (_bll.ThemDocGia(dg, currentUserId, out string err))
            {
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoaMoKhoa_Click(object? sender, EventArgs e)
        {
            if (dgvDocGia?.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                string maDG = drv["Ma_Doc_Gia"].ToString() ?? string.Empty;
                string currentStatus = drv["Trang_Thai"]?.ToString() ?? "Hoạt động";
                bool isKhoa = currentStatus != "Khóa tạm thời";

                string actionName = isKhoa ? "khóa" : "mở khóa";
                if (MessageBox.Show($"Bạn có chắc muốn {actionName} thẻ độc giả {maDG}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int? currentUserId = SessionContext.CurrentUser?.Ma_So;
                    if (_bll.ThayDoiTrangThaiKhoa(maDG, isKhoa, currentUserId))
                    {
                        MessageBox.Show($"Đã {actionName} thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void btnGiaHan_Click(object? sender, EventArgs e)
        {
            if (dgvDocGia?.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                string maDG = drv["Ma_Doc_Gia"].ToString() ?? string.Empty;
                int? currentUserId = SessionContext.CurrentUser?.Ma_So;

                if (_bll.GiaHanTheDocGia(maDG, 1, currentUserId))
                {
                    MessageBox.Show($"Gia hạn thẻ {maDG} thêm 1 năm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            LoadData();
        }
    }
}