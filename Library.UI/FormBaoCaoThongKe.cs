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
            if (dtpTuNgay != null) dtpTuNgay.Value = DateTime.Today.AddDays(-30);
            if (dtpDenNgay != null) dtpDenNgay.Value = DateTime.Today;

            TaiDuLieuBaoCao();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            TaiDuLieuBaoCao();
        }

        private void tabControlBaoCao_SelectedIndexChanged(object sender, EventArgs e)
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
                DataTable dt = null;

                // Xác định dữ liệu cần tải dựa theo Tab đang chọn
                if (tabControlBaoCao.SelectedTab == tabDoanhThuCa)
                {
                    dt = _bll.GetDoanhThuTheoCa(tu, den, null);
                    if (dgvDoanhThuCa != null)
                    {
                        dgvDoanhThuCa.DataSource = null;
                        dgvDoanhThuCa.DataSource = dt;
                        DinhDangCotGridView(dgvDoanhThuCa);
                    }
                }
                else if (tabControlBaoCao.SelectedTab == tabTopSach)
                {
                    dt = _bll.GetTopHotBooks(10, tu, den, null);
                    if (dgvTopSach != null)
                    {
                        dgvTopSach.DataSource = null;
                        dgvTopSach.DataSource = dt;
                        DinhDangCotGridView(dgvTopSach);
                    }
                }
                else if (tabControlBaoCao.SelectedTab == tabQuayVong)
                {
                    dt = _bll.GetQuayVongChiNhanh(tu, den);
                    if (dgvQuayVong != null)
                    {
                        dgvQuayVong.DataSource = null;
                        dgvQuayVong.DataSource = dt;
                        DinhDangCotGridView(dgvQuayVong);
                    }
                }

                // Cập nhật thông tin KPI chung ở các thẻ Card phía trên
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

        private static void DinhDangCotGridView(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                string colName = col.Name.ToLower();

                // Đổi tiêu đề tiếng Việt thân thiện
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
                else if (colName.Contains("masach"))
                    col.HeaderText = "Mã Sách";
                else if (colName.Contains("tieude"))
                    col.HeaderText = "Tên Đầu Sách";
                else if (colName.Contains("tacgia"))
                    col.HeaderText = "Tác Giả";
                else if (colName.Contains("soluotmuon"))
                    col.HeaderText = "Số Lượt Mượn";
                else if (colName.Contains("sobansao"))
                    col.HeaderText = "Tổng Bản Sao";
                else if (colName.Contains("luotmuon"))
                    col.HeaderText = "Tổng Lượt Mượn";
                else if (colName.Contains("tyletquaytong") || colName.Contains("tylequinvong"))
                    col.HeaderText = "Tỷ Lệ Quay Vòng";

                if (colName.Contains("doanhthu") || colName.Contains("tiendathu") || colName.Contains("tienchuathu"))
                {
                    col.DefaultCellStyle.Format = "N0";
                }

                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private DataGridView GetCurrentActiveDataGridView()
        {
            if (tabControlBaoCao.SelectedTab == tabDoanhThuCa) return dgvDoanhThuCa;
            if (tabControlBaoCao.SelectedTab == tabTopSach) return dgvTopSach;
            if (tabControlBaoCao.SelectedTab == tabQuayVong) return dgvQuayVong;
            return dgvDoanhThuCa;
        }

        private void btnXuatFile_Click(object sender, EventArgs e) => ThucHienXuatCsv();
        private void btnXuatExcel_Click(object sender, EventArgs e) => ThucHienXuatCsv();
        private void btnXuatPdf_Click(object sender, EventArgs e) => ThucHienXuatCsv();

        private void ThucHienXuatCsv()
        {
            try
            {
                DataGridView activeDgv = GetCurrentActiveDataGridView();
                if (activeDgv == null || activeDgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV file (*.csv)|*.csv";
                    sfd.FileName = "BaoCao_" + tabControlBaoCao.SelectedTab.Text.Trim() + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (activeDgv.DataSource is DataTable dt)
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

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            DataGridView activeDgv = GetCurrentActiveDataGridView();
            if (activeDgv == null || activeDgv.Rows.Count == 0)
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
                previewDlg.Text = "Xem Trước Bản In - " + tabControlBaoCao.SelectedTab.Text;
                previewDlg.ShowDialog();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = true;
            DataGridView activeDgv = GetCurrentActiveDataGridView();

            Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSub = new Font("Segoe UI", 10, FontStyle.Italic);
            Font fontHeader = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Font fontRow = new Font("Segoe UI", 9F, FontStyle.Regular);

            Brush brush = Brushes.Black;
            Pen penGrid = new Pen(Color.FromArgb(160, 160, 160), 1);

            float startX = 30;
            float startY = 40;
            float printableWidth = e.PageBounds.Width - 60;
            float offsetY = 0;

            e.Graphics.DrawString("BÁO CÁO THỐNG KÊ - " + tabControlBaoCao.SelectedTab.Text.ToUpper(), fontTitle, brush, startX, startY + offsetY);
            offsetY += 32;

            string timeStr = $"Khoảng thời gian: {dtpTuNgay.Value:dd/MM/yyyy} - {dtpDenNgay.Value:dd/MM/yyyy}   |   Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}";
            e.Graphics.DrawString(timeStr, fontSub, brush, startX, startY + offsetY);
            offsetY += 28;

            e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + printableWidth, startY + offsetY);
            offsetY += 15;

            int visibleColsCount = 0;
            foreach (DataGridViewColumn col in activeDgv.Columns)
            {
                if (col.Visible) visibleColsCount++;
            }

            if (visibleColsCount == 0) return;

            float[] colWidths = new float[visibleColsCount];
            float totalWeight = 0;
            int idx = 0;

            foreach (DataGridViewColumn col in activeDgv.Columns)
            {
                if (col.Visible)
                {
                    string name = col.HeaderText.ToLower();
                    if (name.Contains("chi nhánh") || name.Contains("thủ thư") || name.Contains("đầu sách") || name.Contains("tên"))
                    {
                        colWidths[idx] = 2.2f;
                    }
                    else
                    {
                        colWidths[idx] = 1.0f;
                    }
                    totalWeight += colWidths[idx];
                    idx++;
                }
            }

            for (int i = 0; i < visibleColsCount; i++)
            {
                colWidths[i] = (colWidths[i] / totalWeight) * printableWidth;
            }

            float currentY = startY + offsetY;
            float headerHeight = 32;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(235, 240, 245)), startX, currentY, printableWidth, headerHeight);

            float currentX = startX;
            int colIndex = 0;

            foreach (DataGridViewColumn col in activeDgv.Columns)
            {
                if (col.Visible)
                {
                    float currentWidth = colWidths[colIndex];
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    RectangleF cellRect = new RectangleF(currentX, currentY, currentWidth, headerHeight);
                    e.Graphics.DrawString(col.HeaderText, fontHeader, brush, cellRect, sf);
                    e.Graphics.DrawRectangle(penGrid, currentX, currentY, currentWidth, headerHeight);
                    currentX += currentWidth;
                    colIndex++;
                }
            }
            currentY += headerHeight;

            float rowHeight = 28;
            foreach (DataGridViewRow row in activeDgv.Rows)
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

                        StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
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
    }
}