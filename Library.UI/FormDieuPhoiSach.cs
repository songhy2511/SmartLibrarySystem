using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    /// <summary>Chuyển một bản sao đang "Sẵn sàng" từ chi nhánh này sang chi nhánh khác. Không chuyển sang chính chi nhánh nguồn.</summary>
    public partial class FormDieuPhoiSach : Form
    {
        private readonly SachBLL _sachBLL = new SachBLL();
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();

        private readonly string _maSach;
        private readonly string _tieuDe;
        private readonly int _chiNhanhHienTaiId;
        private readonly string _tenChiNhanhHienTai;

        public FormDieuPhoiSach(string maSach, string tieuDe, int chiNhanhHienTaiId, string tenChiNhanhHienTai)
        {
            InitializeComponent();
            _maSach = maSach;
            _tieuDe = tieuDe;
            _chiNhanhHienTaiId = chiNhanhHienTaiId;
            _tenChiNhanhHienTai = tenChiNhanhHienTai;
        }

        private void FormDieuPhoiSach_Load(object sender, EventArgs e)
        {
            lblSach.Text = $"Đầu sách: [{_maSach}] {_tieuDe}";
            lblNguon.Text = $"Chi nhánh xuất: {_tenChiNhanhHienTai}";

            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                // 1. Nạp danh sách bản sao đang 'Sẵn sàng' tại chi nhánh nguồn
                DataTable dtBanSao = _sachBLL.LayBanSaoSanCoTaiChiNhanh(_maSach, _chiNhanhHienTaiId);
                dtBanSao.Columns.Add("HienThi", typeof(string), "MaVach + ' (Tình trạng: ' + TinhTrang + ')'");

                cboBanSao.DataSource = dtBanSao;
                cboBanSao.DisplayMember = "HienThi";
                cboBanSao.ValueMember = "BanSaoMaSo";

                if (dtBanSao.Rows.Count == 0)
                {
                    btnXacNhan.Enabled = false;
                    lblThongTinCuon.Text = "Chi nhánh này không còn bản sao nào sẵn sàng trên kệ.";
                    lblThongTinCuon.ForeColor = Color.FromArgb(220, 38, 38);
                }

                // 2. Nạp danh sách chi nhánh đích (loại trừ chính chi nhánh xuất hiện tại)
                var listCN = _chiNhanhBLL.LayDanhSachChiNhanh()
                                        .Where(x => x.Ma_So != _chiNhanhHienTaiId)
                                        .ToList();

                cboChiNhanhDich.DataSource = listCN;
                cboChiNhanhDich.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanhDich.ValueMember = "Ma_So";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp thông tin điều phối: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboBanSao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBanSao.SelectedItem is DataRowView drv)
            {
                string tinhTrang = drv["TinhTrang"].ToString() ?? "Bình thường";
                lblThongTinCuon.Text = $"Tình trạng vật lý: {tinhTrang} (Sẵn sàng điều phối)";
                lblThongTinCuon.ForeColor = Color.FromArgb(22, 101, 52);
            }
        }

        private int KiemTraVaLayMaAdmin()
        {
            if (SessionContext.CurrentUser == null)
            {
                MessageBox.Show("Phiên làm việc Quản trị viên đã hết hạn!", "Lỗi bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return SessionContext.CurrentUser.Ma_So;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboBanSao.SelectedValue == null)
            {
                MessageBox.Show("Không có bản sao hợp lệ nào được chọn để luân chuyển!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboChiNhanhDich.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh tiếp nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int banSaoMaSo = Convert.ToInt32(cboBanSao.SelectedValue);
            string maVach = (cboBanSao.SelectedItem as DataRowView)?["MaVach"]?.ToString() ?? string.Empty; 
            int chiNhanhDichId = Convert.ToInt32(cboChiNhanhDich.SelectedValue);
            string tenChiNhanhDich = cboChiNhanhDich.Text;
            string ghiChu = txtGhiChu.Text.Trim();

            var confirm = MessageBox.Show(
                $"Xác nhận chuyển cuốn sách [{maVach}] sang '{tenChiNhanhDich}'?",
                "Xác nhận điều phối sách",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            int adminId = KiemTraVaLayMaAdmin();
            if (adminId == 0) return;

            var (isSuccess, message) = _sachBLL.DieuPhoiSach(
                banSaoMaSo,
                maVach,
                _tieuDe,
                _chiNhanhHienTaiId,
                chiNhanhDichId,
                ghiChu,
                adminId 
            );

            if (isSuccess)
            {
                MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Lỗi điều phối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}