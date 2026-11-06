using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Library.BLL;
using Library.DAL;

namespace Library.UI
{
    public partial class FormLapBienBanViPham : Form
    {
        private readonly PhieuPhatBLL _phieuPhatBLL = new PhieuPhatBLL();

        public FormLapBienBanViPham()
        {
            InitializeComponent();
        }

        private void FormLapBienBanViPham_Load(object sender, EventArgs e)
        {
            DinhDangDataGridView();
            LoadDanhSachDocGia();
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();
            cboLoaiViPham.Items.Add("Trễ hạn");
            cboLoaiViPham.Items.Add("Quá hạn mượn kéo dài");
            cboLoaiViPham.Items.Add("Làm mất sách");
            cboLoaiViPham.Items.Add("Làm rách / hư hỏng sách");
        }
        private void cboLoaiViPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiViPham.SelectedItem == null) return;

            string? loaiViPham = cboLoaiViPham.SelectedItem.ToString();

            if (loaiViPham == "Trễ hạn" || loaiViPham == "Quá hạn mượn kéo dài")
            {
                // Khóa textbox để lấy số tiền tính tự động từ BLL
                txtSoTienPhat.ReadOnly = true;
            }
            else if (loaiViPham == "Làm mất sách" || loaiViPham == "Làm rách / hư hỏng sách")
            {
                // Mở khóa để thủ thư nhập giá trị bồi thường theo biên bản
                txtSoTienPhat.ReadOnly = false;
                txtSoTienPhat.Clear();
                txtSoTienPhat.Focus();
            }
        }
        private void DinhDangDataGridView()
        {
            dgvBienBanViPham.BackgroundColor = Color.White;
            dgvBienBanViPham.BorderStyle = BorderStyle.None;
            dgvBienBanViPham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBienBanViPham.GridColor = Color.FromArgb(226, 232, 240);
            dgvBienBanViPham.EnableHeadersVisualStyles = false;
            dgvBienBanViPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBienBanViPham.MultiSelect = false;
            dgvBienBanViPham.ReadOnly = true;
            dgvBienBanViPham.RowHeadersVisible = false;
            dgvBienBanViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBienBanViPham.RowTemplate.Height = 35;

            // Header bảng
            dgvBienBanViPham.ColumnHeadersHeight = 40;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 78, 74);
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBienBanViPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            // Dòng dữ liệu
            dgvBienBanViPham.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvBienBanViPham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 251, 241);
            dgvBienBanViPham.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadDanhSachDocGia()
        {
            try
            {
                string query = "SELECT Ma_So AS DocGiaId, Ma_Doc_Gia AS MaDG, Ho_Ten AS TenDG FROM dbo.Doc_Gia";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dt.Columns.Add("HienThi", typeof(string), "MaDG + ' - ' + TenDG");

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HienThi";
                cboDocGia.ValueMember = "MaDG";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiTaoGiaTriMacDinh()
        {
            txtMaBienBan.Text = "Tự động sinh (ID)";
            txtCanBoLap.Text = SessionContext.CurrentLibrarian?.Ho_Ten ?? "Lê Minh Tuấn";

            if (cboLoaiViPham.Items.Count > 0)
                cboLoaiViPham.SelectedIndex = 0;

            txtSoTienPhat.Text = "50000";
            txtMoTa.Clear();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayHenNop.Value = DateTime.Now.AddDays(7);
        }

        private void LoadDanhSachViPham()
        {
            try
            {
                DataTable dt = _phieuPhatBLL.LayDanhSachBienBan();
                dgvBienBanViPham.DataSource = dt;

                if (dgvBienBanViPham.Columns["MaBienBan"] != null) { dgvBienBanViPham.Columns["MaBienBan"].HeaderText = "Mã BB"; dgvBienBanViPham.Columns["MaBienBan"].Width = 80; }
                if (dgvBienBanViPham.Columns["MaDocGia"] != null) { dgvBienBanViPham.Columns["MaDocGia"].HeaderText = "Mã ĐG"; dgvBienBanViPham.Columns["MaDocGia"].Width = 95; }
                if (dgvBienBanViPham.Columns["TenDocGia"] != null) { dgvBienBanViPham.Columns["TenDocGia"].HeaderText = "Tên Độc Giả"; dgvBienBanViPham.Columns["TenDocGia"].Width = 160; }
                if (dgvBienBanViPham.Columns["LyDoViPham"] != null) { dgvBienBanViPham.Columns["LyDoViPham"].HeaderText = "Lý Do Vi Phạm"; }
                if (dgvBienBanViPham.Columns["SoTienPhat"] != null)
                {
                    dgvBienBanViPham.Columns["SoTienPhat"].HeaderText = "Tiền Phạt (VNĐ)";
                    dgvBienBanViPham.Columns["SoTienPhat"].DefaultCellStyle.Format = "#,##0";
                    dgvBienBanViPham.Columns["SoTienPhat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvBienBanViPham.Columns["SoTienPhat"].Width = 120;
                }
                if (dgvBienBanViPham.Columns["NgayLap"] != null)
                {
                    dgvBienBanViPham.Columns["NgayLap"].HeaderText = "Ngày Lập";
                    dgvBienBanViPham.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvBienBanViPham.Columns["NgayLap"].Width = 135;
                }
                if (dgvBienBanViPham.Columns["TrangThai"] != null) { dgvBienBanViPham.Columns["TrangThai"].HeaderText = "Trạng Thái"; dgvBienBanViPham.Columns["TrangThai"].Width = 100; }
                if (dgvBienBanViPham.Columns["CanBoLap"] != null) { dgvBienBanViPham.Columns["CanBoLap"].HeaderText = "Cán Bộ Lập"; dgvBienBanViPham.Columns["CanBoLap"].Width = 140; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách biên bản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuBienBan_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả vi phạm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTienPhat.Text.Trim(), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phạt phải là số nguyên dương hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienPhat.Focus();
                return;
            }

            string maDocGia = cboDocGia.SelectedValue.ToString() ?? "";
            string loaiViPham = cboLoaiViPham.SelectedItem?.ToString() ?? "Vi phạm khác";
            string chiTiet = txtMoTa.Text.Trim();
            string lyDoTongHop = string.IsNullOrWhiteSpace(chiTiet) ? loaiViPham : $"{loaiViPham} - {chiTiet}";

            int thuThuId = SessionContext.CurrentLibrarian?.Ma_So ?? 1;

            var (isSuccess, message) = _phieuPhatBLL.LapBienBan(maDocGia, soTien, lyDoTongHop, thuThuId, 1);

            if (isSuccess)
            {
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMoTa.Clear();
                txtSoTienPhat.Text = "50000";
                LoadDanhSachViPham();
            }
            else
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
            LoadDanhSachViPham();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaTriMacDinh();
        }
    }
}