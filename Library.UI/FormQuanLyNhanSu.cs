using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormQuanLyNhanSu : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private List<ThuThuDTO> _danhSachNhanSu = new List<ThuThuDTO>();

        public FormQuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                _danhSachNhanSu = _nguoiDungBLL.LayDanhSachNhanSu();
                HienThiDanhSach(_danhSachNhanSu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSach(List<ThuThuDTO> danhSach)
        {
            dgvNhanSu.AutoGenerateColumns = false;
            dgvNhanSu.DataSource = null;
            dgvNhanSu.DataSource = danhSach;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                HienThiDanhSach(_danhSachNhanSu);
                return;
            }

            var ketQua = _danhSachNhanSu.Where(x =>
                x.Ma_Thu_Thu.ToLower().Contains(keyword) ||
                x.Ho_Ten.ToLower().Contains(keyword) ||
                (x.Ten_Dang_Nhap != null && x.Ten_Dang_Nhap.ToLower().Contains(keyword)) ||
                (x.So_Dien_Thoai != null && x.So_Dien_Thoai.Contains(keyword))
            ).ToList();

            HienThiDanhSach(ketQua);
        }

        private ThuThuDTO? LayNhanSuDangChon()
        {
            if (dgvNhanSu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân sự từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return dgvNhanSu.CurrentRow.DataBoundItem as ThuThuDTO;
        }

        private void MoFormSuaThongTin()
        {
            var selected = LayNhanSuDangChon();
            if (selected == null) return;

            using var formSua = new FormSuaThuThu(selected);
            if (formSua.ShowDialog(this) == DialogResult.OK)
            {
                TaiDuLieu();
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            MoFormSuaThongTin();
        }

        private void dgvNhanSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MoFormSuaThongTin();
            }
        }

        private void btnKhoaMoKhoa_Click(object sender, EventArgs e)
        {
            var selected = LayNhanSuDangChon();
            if (selected == null) return;

            string thaoTac = selected.Dang_Hoat_Dong ? "KHÓA" : "MỞ KHÓA";
            var xacNhan = MessageBox.Show(
                $"Bạn có chắc chắn muốn {thaoTac} tài khoản của thủ thư '{selected.Ho_Ten}' (Tài khoản: {selected.Ten_Dang_Nhap})?",
                "Xác nhận thay đổi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan != DialogResult.Yes) return;

            int currentAdminId = SessionContext.CurrentUser?.Ma_So ?? 0;
            var (isSuccess, message) = _nguoiDungBLL.ChuyenTrangThaiTaiKhoan(selected.Nguoi_Dung_Ma_So, currentAdminId);

            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.SECURITY,
                    selected.Dang_Hoat_Dong ? "Mở khóa tài khoản" : "Khóa tài khoản",
                    $"Quản trị viên đã thay đổi trạng thái tài khoản '{selected.Ten_Dang_Nhap}' (Thủ thư: {selected.Ho_Ten}) thành: {(selected.Dang_Hoat_Dong ? "Hoạt động" : "Bị khóa")}.",
                    currentAdminId
                );

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            var selected = LayNhanSuDangChon();
            if (selected == null) return;

            var xacNhan = MessageBox.Show(
                $"Bạn có chắc chắn muốn cấp lại mật khẩu tạm thời cho tài khoản '{selected.Ten_Dang_Nhap}'?\n" +
                "Mật khẩu ngẫu nhiên mới sẽ được tạo và nhân viên phải sử dụng mật khẩu này để đăng nhập lại.",
                "Xác nhận Reset Mật khẩu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (xacNhan != DialogResult.Yes) return;

            var (isSuccess, message, matKhauTam) = _nguoiDungBLL.ResetMatKhauTamThoi(selected.Nguoi_Dung_Ma_So);
            if (isSuccess)
            {
                // 1. Sao chép mật khẩu tạm vào Clipboard để Admin tiện gửi cho nhân viên
                Clipboard.SetText(matKhauTam);

                // 2. GHI LOG KIỂM TOÁN AN TOÀN (Tuyệt đối KHÔNG ghi chuỗi mật khẩu vào log)
                SystemLogger.Log(
                    LogLevel.SECURITY,
                    "Reset mật khẩu",
                    $"Quản trị viên đã cấp lại mật khẩu tạm thời cho tài khoản '{selected.Ten_Dang_Nhap}' (ID: {selected.Nguoi_Dung_Ma_So}).",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show(
                    $"{message}\n\n" +
                    $"🔑 Mật khẩu tạm thời mới: {matKhauTam}\n\n" +
                    $"(Mật khẩu đã được sao chép tự động vào Clipboard. Hãy gửi thông tin này cho nhân viên và yêu cầu đổi mật khẩu ngay sau khi đăng nhập).",
                    "Cấp Mật Khẩu Tạm Thời",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            TaiDuLieu();
        }

        private void dgvNhanSu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanSu.Columns[e.ColumnIndex]?.Name == "colTrangThai" && e.Value != null)
            {
                bool dangHoatDong = (bool)e.Value;
                if (dangHoatDong)
                {
                    e.Value = "🟢 Đang hoạt động";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 149, 117);
                    }
                }
                else
                {
                    e.Value = "🔴 Đã bị khóa";
                    if (e.CellStyle != null)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72);
                    }
                }
                e.FormattingApplied = true;
            }
        }

        private void btnThemThuThu_Click(object sender, EventArgs e)
        {
            using var formThem = new FormThemThuThu();
            if (formThem.ShowDialog(this) == DialogResult.OK)
            {
                TaiDuLieu(); // Cập nhật lại DataGridView ngay khi thêm thành công
            }
        }

        private void dgvNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}