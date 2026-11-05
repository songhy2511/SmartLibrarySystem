using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DTO;

namespace Library.UI
{
    public partial class FormLapBienBanViPham : Form
    {
        private string _maPhieuMuon = "";
        private string _maDocGia = "";

        public FormLapBienBanViPham()
        {
            InitializeComponent();
            KhoiTaoMacDinh();
        }

        public FormLapBienBanViPham(string? maPhieuMuon = null, string? maDocGia = null) : this()
        {
            _maPhieuMuon = maPhieuMuon ?? string.Empty;
            _maDocGia = maDocGia ?? string.Empty;
            txtMaPhieuMuon.Text = _maPhieuMuon;
            txtMaDocGia.Text = _maDocGia;
        }

        private void KhoiTaoMacDinh()
        {
            cboLyDoPhat.Items.Clear();
            cboLyDoPhat.Items.Add("Trễ hạn mượn");
            cboLyDoPhat.Items.Add("Làm hư hỏng sách");
            cboLyDoPhat.Items.Add("Làm mất sách");
            cboLyDoPhat.SelectedIndex = 0;

            dtpNgayLap.Value = DateTime.Now;
            txtMaBiEnBan.Text = "VP" + DateTime.Now.ToString("yyyyMMddHHmm");
        }

        private void cboLyDoPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sử dụng ?.ToString() và ?? "" để đảm bảo không bao giờ bị null reference
            string lyDo = cboLyDoPhat.SelectedItem?.ToString() ?? string.Empty;

            switch (lyDo)
            {
                case "Trễ hạn mượn":
                    txtSoTienPhat.Text = "5000";
                    break;
                case "Làm hư hỏng sách":
                    txtSoTienPhat.Text = "50000";
                    break;
                case "Làm mất sách":
                    txtSoTienPhat.Text = "200000";
                    break;
                default:
                    txtSoTienPhat.Text = "0";
                    break;
            }
        }

        private void btnXacNhanPhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) || string.IsNullOrWhiteSpace(txtSoTienPhat.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin biên bản vi phạm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTienPhat.Text, out decimal soTienPhat))
            {
                MessageBox.Show("Số tiền phạt không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy chuỗi an toàn chống null
            string lyDoPhatSelected = cboLyDoPhat.SelectedItem?.ToString() ?? "Khác";

            PhatTienDTO bienBan = new PhatTienDTO
            {
                MaBiEnBan = txtMaBiEnBan.Text.Trim(),
                MaPhieuMuon = txtMaPhieuMuon.Text.Trim(),
                MaDocGia = txtMaDocGia.Text.Trim(),
                LyDoPhat = lyDoPhatSelected, // Đã được xử lý null an toàn
                SoTienPhat = soTienPhat,
                NgayLap = dtpNgayLap.Value,
                DaThanhToan = chkDaThanhToan.Checked,
                GhiChu = txtGhiChu.Text.Trim()
            };

            // Gọi BLL / DAL lưu vào CSDL
            MessageBox.Show($"Lập biên bản vi phạm thành công!\nMã BB: {bienBan.MaBiEnBan}\nSố tiền: {bienBan.SoTienPhat:N0} VNĐ",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}