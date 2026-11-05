using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    public partial class FormQuyCheThamSo : Form
    {
        private readonly CauHinhHeThongBLL _bll = new CauHinhHeThongBLL();

        public FormQuyCheThamSo()
        {
            InitializeComponent();
        }

        private void FormQuyCheThamSo_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            try
            {
                // Nạp giá trị hiện tại vào các control
                nudSoSachMuon.Value = _bll.LaySoSachMuonToiDa();
                nudSoNgayMuon.Value = _bll.LaySoNgayMuonToiDa();
                nudTienPhat.Value = _bll.LayTienPhatMoiNgay();
                nudThoiHanThe.Value = _bll.LayThoiHanTheThang();

                // Nạp dữ liệu đồng bộ vào bảng
                var list = _bll.LayDanhSachCauHinh();
                dgvThamSo.AutoGenerateColumns = false;
                dgvThamSo.DataSource = null;
                dgvThamSo.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải tham số hệ thống: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuQuyChe_Click(object sender, EventArgs e)
        {
            int soSach = Convert.ToInt32(nudSoSachMuon.Value);
            int soNgay = Convert.ToInt32(nudSoNgayMuon.Value);
            decimal tienPhat = nudTienPhat.Value;
            int thoiHanThe = Convert.ToInt32(nudThoiHanThe.Value);

            var confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn thay đổi các tham số quy chế này?\nCác quy định mới sẽ áp dụng trực tiếp cho tất cả lượt mượn trả tiếp theo.",
                "Xác nhận thay đổi quy chế",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                var (isSuccess, message) = _bll.LuuQuyChe(soSach, soNgay, tienPhat, thoiHanThe);
                if (isSuccess)
                {
                    // 👉 GHI LOG CẬP NHẬT QUY CHẾ (Mức WARNING vì ảnh hưởng toàn hệ thống)
                    SystemLogger.Log(
                        LogLevel.WARNING,
                        "Cập nhật quy chế",
                        $"Điều chỉnh tham số: Tối đa {soSach} cuốn, Hạn {soNgay} ngày, Phạt {tienPhat:N0}đ/ngày, Hiệu lực thẻ {thoiHanThe} tháng.",
                        SessionContext.CurrentUser?.Ma_So
                    );

                    MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                }
                else
                {
                    // 👉 GHI LOG KHI THIẾT LẬP THẤT BẠI
                    SystemLogger.Log(
                        LogLevel.WARNING,
                        "Cập nhật quy chế thất bại",
                        $"Lưu quy chế không hợp lệ: {message}",
                        SessionContext.CurrentUser?.Ma_So
                    );

                    MessageBox.Show(message, "Cảnh báo thiết lập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // 👉 GHI LOG NẾU PHÁT SINH LỖI CSDL
                SystemLogger.Log(
                    LogLevel.ERROR,
                    "Lỗi quy chế",
                    $"Ngoại lệ khi lưu quy chế hệ thống: {ex.Message}",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show($"Lỗi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}