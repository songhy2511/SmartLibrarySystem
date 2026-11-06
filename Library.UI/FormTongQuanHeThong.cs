using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormTongQuanHeThong : Form
    {
        private readonly ThongKeBLL _thongKeBLL = new ThongKeBLL();
        private readonly ChiNhanhBLL _chiNhanhBLL = new ChiNhanhBLL();

        public FormTongQuanHeThong()
        {
            InitializeComponent();
        }

        private void FormTongQuanHeThong_Load(object sender, EventArgs e)
        {
            // Khóa màu tiêu đề bảng không bị đổi màu khi nhấp/chọn cột
            KhoaMauTieuDeBang(dgvKhoSach);
            KhoaMauTieuDeBang(dgvLuuThongTuan);
            KhoaMauTieuDeBang(dgvDoiSoat);

            TaiDuLieuThongKeTuanVaKPI();
            NapDanhSachChiNhanhKho();
            TaiDuLieuKhoSach();
        }

        private void KhoaMauTieuDeBang(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Cố định màu khi được chọn trùng với màu gốc
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Tắt hiệu ứng viền chọn trên tiêu đề cột
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void TaiDuLieuThongKeTuanVaKPI()
        {
            try
            {
                // 1. Tải báo cáo mượn/trả trong tuần của các chi nhánh
                var listLuuThong = _thongKeBLL.LayBaoCaoLuuThongTuan();
                dgvLuuThongTuan.AutoGenerateColumns = false;
                dgvLuuThongTuan.DataSource = null;
                dgvLuuThongTuan.DataSource = listLuuThong;

                // Cập nhật số liệu lượt sách đang mượn
                int tongDangLuuThong = listLuuThong.Sum(x => x.So_Sach_Dang_Muon_Hien_Tai);
                lblLuuThongVal.Text = tongDangLuuThong.ToString();

                // 2. Tải số liệu Độc giả và Tiền phạt thực tế từ CSDL (thay cho giá trị hardcode)
                var (tongDocGia, tongTienPhat) = _thongKeBLL.LayKPIDocGiaVaTienPhat();
                lblDocGiaVal.Text = tongDocGia.ToString();
                lblTienPhatVal.Text = $"{tongTienPhat:N0} đ";

                // 3. Tải danh sách đối soát ca trực
                var listDoiSoat = _thongKeBLL.LayDanhSachDoiSoatCaTruc(0, DateTime.Today.AddDays(-7), DateTime.Today);
                dgvDoiSoat.AutoGenerateColumns = false;
                dgvDoiSoat.DataSource = null;
                dgvDoiSoat.DataSource = listDoiSoat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp báo cáo tuần: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapDanhSachChiNhanhKho()
        {
            try
            {
                var listCN = _chiNhanhBLL.LayDanhSachChiNhanh();
                // Chèn thêm mục tất cả chi nhánh
                listCN.Insert(0, new ChiNhanhDTO { Ma_So = 0, Ten_Chi_Nhanh = "-- Toàn bộ chi nhánh --" });

                cboChiNhanhKho.DataSource = listCN;
                cboChiNhanhKho.DisplayMember = "Ten_Chi_Nhanh";
                cboChiNhanhKho.ValueMember = "Ma_So";
                cboChiNhanhKho.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục chi nhánh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDuLieuKhoSach()
        {
            try
            {
                int chiNhanhMaSo = 0;
                if (cboChiNhanhKho.SelectedValue != null && int.TryParse(cboChiNhanhKho.SelectedValue.ToString(), out int id))
                {
                    chiNhanhMaSo = id;
                }

                string tuKhoa = txtTimKiemSach.Text.Trim();
                var listKho = _thongKeBLL.LayChiTietKhoSachChiNhanh(chiNhanhMaSo, tuKhoa);

                dgvKhoSach.AutoGenerateColumns = false;
                dgvKhoSach.DataSource = null;
                dgvKhoSach.DataSource = listKho;

                // Cập nhật các thẻ tóm tắt kho
                lblTongDauSachCNVal.Text = listKho.Count.ToString();
                lblTongBanSaoCNVal.Text = listKho.Sum(x => x.Tong_Ban_Sao).ToString();
                lblDangMuonCNVal.Text = listKho.Sum(x => x.Dang_Muon).ToString();
                lblSanCoCNVal.Text = listKho.Sum(x => x.San_Co).ToString();

                // Cập nhật card "SÁCH SẴN SÀNG KHO" ở Tab 1
                lblSachSanSangVal.Text = listKho.Sum(x => x.San_Co).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải kho sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboChiNhanhKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiNhanhKho.SelectedIndex >= 0)
            {
                TaiDuLieuKhoSach();
            }
        }

        private void txtTimKiemSach_TextChanged(object sender, EventArgs e)
        {
            TaiDuLieuKhoSach();
        }

        private void btnTaiLaiKho_Click(object sender, EventArgs e)
        {
            txtTimKiemSach.Clear();
            TaiDuLieuKhoSach();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                TaiDuLieuThongKeTuanVaKPI();
            }
            else
            {
                TaiDuLieuKhoSach();
            }
        }

    }
}