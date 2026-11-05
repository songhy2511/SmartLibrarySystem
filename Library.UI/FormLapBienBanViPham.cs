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
using Library.BLL;


namespace Library.UI
{
    public partial class FormLapBienBanViPham : Form
    {
        private readonly PhieuMuonBLL _phieuMuonBLL = new PhieuMuonBLL();

        public FormLapBienBanViPham()
        {
            InitializeComponent();
        }

        private void btnLuuBienBan_Click(object sender, EventArgs e)
        {
            try
            {
                PhatTienDTO bb = new PhatTienDTO
                {
                    MaBienBan = txtMaBienBan.Text.Trim(),
                    MaDocGia = "DG0001",
                    LoaiViPham = cboLoaiViPham.SelectedItem?.ToString() ?? "Mất sách",
                    MoTa = txtMoTa.Text.Trim(),
                    SoTienPhat = Convert.ToDecimal(txtSoTienPhat.Text.Trim()),
                    NgayLap = dtpNgayLap.Value,
                    NgayHenNop = dtpNgayHenNop.Value,
                    TrangThai = "Chờ nộp",
                    CanBoLap = txtCanBoLap.Text.Trim()
                };

                if (_phieuMuonBLL.LapBienBanViPham(bb))
                {
                    MessageBox.Show("Lập biên bản vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu biên bản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}