using System;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;

namespace Library.UI
{
    /// <summary>
    /// Đếm tiền cuối ca trước khi thủ thư đăng xuất.
    /// Quỹ lý thuyết = tiền đầu ca + tiền phạt đã thu. Chênh lệch = tiền đếm được − quỹ lý thuyết.
    /// </summary>
    public partial class FormChotCaTruc : Form
    {
        private readonly int _caTrucId;
        private readonly decimal _tienLyThuyet;

        public FormChotCaTruc(int caTrucId, string tenCa, decimal tienDauCa, decimal tienThuPhat)
        {
            InitializeComponent();

            _caTrucId = caTrucId;
            _tienLyThuyet = tienDauCa + tienThuPhat; // Số tiền quỹ phải có nếu không thừa, không thiếu

            lblTenCa.Text = $"Ca đang trực: {tenCa}";
            lblTienDauCaVal.Text = $"{tienDauCa:N0} đ";
            lblThuPhatVal.Text = $"+ {tienThuPhat:N0} đ";
            lblLyThuyetVal.Text = $"{_tienLyThuyet:N0} đ";

            // Khởi tạo mặc định số tiền thực tế bằng lý thuyết để thủ thư đỡ phải gõ nếu không lệch
            nudThucTeVal.Value = _tienLyThuyet;
            TinhChenhLech();
        }

        private void nudThucTeVal_ValueChanged(object sender, EventArgs e)
        {
            TinhChenhLech();
        }

        /// <summary>Cập nhật nhãn: khớp quỹ (xanh), thiếu (đỏ), dư (xanh dương).</summary>
        private void TinhChenhLech()
        {
            decimal thucTe = nudThucTeVal.Value;
            decimal chenhLech = thucTe - _tienLyThuyet;

            if (chenhLech == 0)
            {
                lblChenhLechVal.Text = "Khớp quỹ (0 đ)";
                lblChenhLechVal.ForeColor = Color.FromArgb(22, 163, 74); // Xanh lá
            }
            else if (chenhLech < 0)
            {
                lblChenhLechVal.Text = $"Thiếu hụt: {chenhLech:N0} đ";
                lblChenhLechVal.ForeColor = Color.FromArgb(225, 29, 72); // Đỏ
            }
            else
            {
                lblChenhLechVal.Text = $"Dư ra: +{chenhLech:N0} đ";
                lblChenhLechVal.ForeColor = Color.FromArgb(2, 132, 199); // Xanh dương
            }
        }

        /// <summary>Ghi tiền thực tế xuống ca rồi đóng form với DialogResult.OK để dashboard tiếp tục đăng xuất.</summary>
        private void btnChotCa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Xác nhận bàn giao và kết thúc ca trực? Hành động này không thể hoàn tác.",
                "Chốt ca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var bll = new CaTrucBLL();
            decimal tienThucTe = nudThucTeVal.Value;
            var (isSuccess, message) = bll.ChotCaTruc(_caTrucId, tienThucTe);

            if (isSuccess)
            {
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Chốt ca trực",
                    $"Thủ thư đã chốt ca. Lý thuyết: {_tienLyThuyet:N0}đ | Bàn giao thực tế: {tienThucTe:N0}đ.",
                    SessionContext.CurrentUser?.Ma_So
                );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}