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
            dgvThamSo.EnableDoubleBuffered(true);
        }

        private void TaiDuLieu()
        {
            try
            {
                // 1. Nạp 4 tham số cơ bản vào controls
                nudSoSachMuon.Value = _bll.LaySoSachMuonToiDa();
                nudSoNgayMuon.Value = _bll.LaySoNgayMuonToiDa();
                nudTienPhat.Value = _bll.LayTienPhatMoiNgay();
                nudThoiHanThe.Value = _bll.LayThoiHanTheThang();

                // 2. Nạp 3 tỷ lệ đền bù tài liệu (%)
                nudTyLeRach.Value = _bll.LayTyLePhatRach();
                nudTyLeHong.Value = _bll.LayTyLePhatHong();
                nudTyLeMat.Value = _bll.LayTyLePhatMat();

                // 3. Nạp danh sách đầy đủ 7 tham số vào bảng đồng bộ
                var list = _bll.LayDanhSachCauHinh();
                dgvThamSo.AutoGenerateColumns = false;
                dgvThamSo.DataSource = null;
                dgvThamSo.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể tải thông tin quy chế hệ thống. Vui lòng thử lại!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuQuyChe_Click(object sender, EventArgs e)
        {
            int soSach = Convert.ToInt32(nudSoSachMuon.Value);
            int soNgay = Convert.ToInt32(nudSoNgayMuon.Value);
            decimal tienPhat = nudTienPhat.Value;
            int thoiHanThe = Convert.ToInt32(nudThoiHanThe.Value);
            decimal tyLeRach = nudTyLeRach.Value;
            decimal tyLeHong = nudTyLeHong.Value;
            decimal tyLeMat = nudTyLeMat.Value;

            var confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn thay đổi toàn bộ các tham số quy chế và tỷ lệ đền bù này?\n" +
                "Các thiết lập mới sẽ được áp dụng trực tiếp cho tất cả các nghiệp vụ lưu thông và xử phạt vi phạm.",
                "Xác nhận thay đổi quy chế",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                var (isSuccess, message) = _bll.LuuQuyCheToanDien(
                    soSach,
                    soNgay,
                    tienPhat,
                    thoiHanThe,
                    tyLeRach,
                    tyLeHong,
                    tyLeMat
                );

                if (isSuccess)
                {
                    // 👉 Ghi log kiểm toán cập nhật quy chế toàn diện
                    SystemLogger.Log(
                        LogLevel.WARNING,
                        "Cập nhật quy chế",
                        $"Điều chỉnh tham số: Tối đa {soSach} cuốn, Hạn {soNgay} ngày, Phạt {tienPhat:N0}đ/ngày, " +
                        $"Hiệu lực thẻ {thoiHanThe} tháng, Đền bù Rách {tyLeRach}%, Hỏng {tyLeHong}%, Mất {tyLeMat}%.",
                        SessionContext.CurrentUser?.Ma_So
                    );

                    MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                }
                else
                {
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
                SystemLogger.Log(
                    LogLevel.ERROR,
                    "Lỗi quy chế",
                    $"Ngoại lệ khi lưu quy chế hệ thống: {ex.Message}",
                    SessionContext.CurrentUser?.Ma_So
                );

                MessageBox.Show($"Lưu quy chế thất bại. Vui lòng kiểm tra lại các giá trị nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}