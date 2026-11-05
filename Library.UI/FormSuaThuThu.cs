using System;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormSuaThuThu : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private readonly ThuThuDTO _thuThu;

        public FormSuaThuThu(ThuThuDTO thuThu)
        {
            InitializeComponent();
            _thuThu = thuThu;
            DoDuLieuLenForm();
        }

        private void DoDuLieuLenForm()
        {
            txtMaThuThu.Text = $"{_thuThu.Ma_Thu_Thu} (Tài khoản: {_thuThu.Ten_Dang_Nhap})";
            txtHoTen.Text = _thuThu.Ho_Ten;
            txtSoDienThoai.Text = _thuThu.So_Dien_Thoai ?? string.Empty;
            txtEmail.Text = _thuThu.Email ?? string.Empty;

            if (cboQuayPhuTrach.Items.Contains(_thuThu.Quay_Phu_Trach))
            {
                cboQuayPhuTrach.SelectedItem = _thuThu.Quay_Phu_Trach;
            }
            else
            {
                cboQuayPhuTrach.SelectedIndex = 0;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _thuThu.Ho_Ten = txtHoTen.Text.Trim();
            _thuThu.So_Dien_Thoai = txtSoDienThoai.Text.Trim();
            _thuThu.Email = txtEmail.Text.Trim();
            _thuThu.Quay_Phu_Trach = cboQuayPhuTrach.SelectedItem?.ToString() ?? "Quầy Mượn - Trả số 1";

            var (isSuccess, message) = _nguoiDungBLL.CapNhatThongTinThuThu(_thuThu);
            if (isSuccess)
            {
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}