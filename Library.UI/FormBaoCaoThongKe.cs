using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    public partial class FormBaoCaoThongKe : Form
    {
        private readonly BaoCaoBLL _bll = new BaoCaoBLL();

        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            // Thiết lập mốc thời gian mặc định 30 ngày gần nhất
            if (dtpTuNgay != null) dtpTuNgay.Value = DateTime.Today.AddDays(-30);
            if (dtpDenNgay != null) dtpDenNgay.Value = DateTime.Today;

            TaiDuLieuBaoCao();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            TaiDuLieuBaoCao();
        }

        private void TaiDuLieuBaoCao()
        {
            try
            {
                if (dtpTuNgay.Value > dtpDenNgay.Value)
                {
                    MessageBox.Show("Mốc 'Từ ngày' không được lớn hơn 'Đến ngày'!", "Lỗi Lọc Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor = Cursors.WaitCursor;

                DateTime tu = dtpTuNgay.Value;
                DateTime den = dtpDenNgay.Value;

                // 1. Nạp dữ liệu doanh thu theo ca vào DataGridView (dgvBaoCao)
                DataTable dt = _bll.GetDoanhThuTheoCa(tu, den, null);
                if (dgvBaoCao != null)
                {
                    dgvBaoCao.DataSource = null;
                    dgvBaoCao.DataSource = dt;
                    DinhDangCotGridView();
                }

                // 2. Nạp chỉ số KPI vào các thẻ card trên giao diện
                BaoCaoKPIDTO kpi = _bll.GetKPISummary(tu, den, null);

                if (lblValTongDoanhThu != null)
                    lblValTongDoanhThu.Text = string.Format("{0:N0} đ", kpi.TongTienPhatDaThu);

                if (lblValTongSoGiaoDich != null)
                    lblValTongSoGiaoDich.Text = dt != null ? dt.Rows.Count.ToString("N0") : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp dữ liệu báo cáo: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void DinhDangCotGridView()
        {
            if (dgvBaoCao == null || dgvBaoCao.Columns.Count == 0) return;

            // 1. Ép style mặc định của Header căn giữa toàn bộ
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                string colName = col.Name.ToLower();

                // 2. Đổi tên tiêu đề cột có dấu cách
                if (colName.Contains("ngaytruc") || colName.Contains("ngay"))
                    col.HeaderText = "Ngày Trực";
                else if (colName.Contains("tenca"))
                    col.HeaderText = "Tên Ca";
                else if (colName.Contains("thuthu"))
                    col.HeaderText = "Thủ Thư";
                else if (colName.Contains("chinhanh"))
                    col.HeaderText = "Chi Nhánh";
                else if (colName.Contains("sophieuphat"))
                    col.HeaderText = "Số Phiếu Phạt";
                else if (colName.Contains("tiendathu"))
                    col.HeaderText = "Tiền Đã Thu";
                else if (colName.Contains("tienchuathu"))
                    col.HeaderText = "Tiền Chưa Thu";

                // 3. Định dạng phân cách hàng nghìn cho số tiền
                if (colName.Contains("doanhthu") || colName.Contains("tiendathu") || colName.Contains("tienchuathu"))
                {
                    col.DefaultCellStyle.Format = "N0";
                }

                // 4. Ép căn giữa cho từng cột và Header
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 5. Bỏ không gian chứa mũi tên Sort Glyph để chữ Header không bị xô sang trái
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // --- XỬ LÝ XUẤT FILE CSV ---
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            ThucHienXuatCsv();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ThucHienXuatCsv();
        }

        private void btnXuatPdf_Click(object sender, EventArgs e)
        {
            ThucHienXuatCsv();
        }

        private void ThucHienXuatCsv()
        {
            try
            {
                if (dgvBaoCao == null || dgvBaoCao.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV file (*.csv)|*.csv";
                    sfd.FileName = "BaoCaoDoanhThu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = dgvBaoCao.DataSource as DataTable;
                        if (dt != null)
                        {
                            int? userId = SessionContext.CurrentUser?.Ma_So;
                            _bll.ExportToCsv(dt, sfd.FileName, userId);
                            MessageBox.Show("Xuất file báo cáo thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- XỬ LÝ TÍNH NĂNG IN BÁO CÁO (PRINT PREVIEW) ---
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao == null || dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in báo cáo!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            using (PrintPreviewDialog previewDlg = new PrintPreviewDialog())
            {
                previewDlg.Document = printDoc;
                previewDlg.Width = 900;
                previewDlg.Height = 700;
                previewDlg.Text = "Xem Trước Bản In Báo Cáo Doanh Thu";
                previewDlg.ShowDialog();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Đặt khổ giấy nằm ngang (Landscape)
            e.PageSettings.Landscape = true;

            Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSub = new Font("Segoe UI", 10, FontStyle.Italic);
            Font fontHeader = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Font fontRow = new Font("Segoe UI", 9F, FontStyle.Regular);

            Brush brush = Brushes.Black;
            Pen penGrid = new Pen(Color.FromArgb(160, 160, 160), 1);

            float startX = 30; // Lề trái
            float startY = 40; // Lề trên
            float printableWidth = e.PageBounds.Width - 60; // Tự động lấy toàn bộ chiều rộng trang in ngang (trừ lề trái/phải)
            float offsetY = 0;

            // 1. Tiêu đề báo cáo
            e.Graphics.DrawString("BÁO CÁO THỐNG KÊ DOANH THU THƯ VIỆN", fontTitle, brush, startX, startY + offsetY);
            offsetY += 32;

            string timeStr = $"Khoảng thời gian: {dtpTuNgay.Value:dd/MM/yyyy} - {dtpDenNgay.Value:dd/MM/yyyy}   |   Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}";
            e.Graphics.DrawString(timeStr, fontSub, brush, startX, startY + offsetY);
            offsetY += 28;

            e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + printableWidth, startY + offsetY);
            offsetY += 15;

            // 2. Tính toán độ rộng động cho từng cột dựa vào độ dài dữ liệu thực tế
            int visibleColsCount = 0;
            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                if (col.Visible) visibleColsCount++;
            }

            if (visibleColsCount == 0) return;

            // Mảng trọng số độ rộng cho từng cột (Cột Chi Nhánh và Thủ Thư sẽ được cấp hệ số rộng hơn các cột khác)
            float[] colWidths = new float[visibleColsCount];
            float totalWeight = 0;

            int idx = 0;
            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                if (col.Visible)
                {
                    string name = col.HeaderText.ToLower();
                    if (name.Contains("chi nhánh") || name.Contains("thủ thư"))
                    {
                        colWidths[idx] = 2.2f; // Cột dài cho tên chi nhánh, thủ thư
                    }
                    else if (name.Contains("ngày") || name.Contains("ca"))
                    {
                        colWidths[idx] = 1.2f; // Cột ngày tháng, ca trực
                    }
                    else
                    {
                        colWidths[idx] = 1.0f; // Các cột số lượng, tiền tệ
                    }
                    totalWeight += colWidths[idx];
                    idx++;
                }
            }

            // Quy đổi trọng số thành kích thước Pixel thực tế vừa khít trang in
            for (int i = 0; i < visibleColsCount; i++)
            {
                colWidths[i] = (colWidths[i] / totalWeight) * printableWidth;
            }

            // 3. Vẽ Tiêu đề cột (Header)
            float currentY = startY + offsetY;
            float headerHeight = 32;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(235, 240, 245)), startX, currentY, printableWidth, headerHeight);

            float currentX = startX;
            int colIndex = 0;

            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                if (col.Visible)
                {
                    float currentWidth = colWidths[colIndex];
                    string headerText = col.HeaderText;

                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center,
                        Trimming = StringTrimming.EllipsisCharacter
                    };

                    RectangleF cellRect = new RectangleF(currentX, currentY, currentWidth, headerHeight);
                    e.Graphics.DrawString(headerText, fontHeader, brush, cellRect, sf);
                    e.Graphics.DrawRectangle(penGrid, currentX, currentY, currentWidth, headerHeight);

                    currentX += currentWidth;
                    colIndex++;
                }
            }
            currentY += headerHeight;

            // 4. Vẽ các dòng dữ liệu (Rows)
            float rowHeight = 28;
            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                if (row.IsNewRow) continue;
                currentX = startX;
                colIndex = 0;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        float currentWidth = colWidths[colIndex];
                        string val = cell.Value?.ToString() ?? "";

                        // Xóa giờ thừa ngày tháng
                        if (val.Contains("12:00:00"))
                        {
                            val = val.Replace(" 12:00:00 SA", "").Replace(" 12:00:00 CH", "").Replace(" 00:00:00", "");
                        }

                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center,
                            Trimming = StringTrimming.Word // Tự động co giãn ngắt từ thông minh, tránh bị cụt chữ
                        };

                        RectangleF cellRect = new RectangleF(currentX, currentY, currentWidth, rowHeight);
                        e.Graphics.DrawString(val, fontRow, brush, cellRect, sf);
                        e.Graphics.DrawRectangle(penGrid, currentX, currentY, currentWidth, rowHeight);

                        currentX += currentWidth;
                        colIndex++;
                    }
                }
                currentY += rowHeight;

                if (currentY > e.MarginBounds.Height + 280)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }

        private void FormBaoCaoThongKe_Load_1(object sender, EventArgs e)
        {

        }
    }
}