using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Library.BLL;
using Library.DTO;

namespace Library.UI
{
    /// <summary>
    /// Báo cáo dùng chung cho Admin và Thủ thư: doanh thu theo ca, top sách, tỷ lệ quay vòng.
    /// Xuất CSV (dấu chấm phẩy), Excel, PDF ngang, hoặc xem trước bản in.
    /// </summary>
    public partial class FormBaoCaoThongKe : Form
    {
        private readonly BaoCaoBLL _bll = new BaoCaoBLL();
        private int _dongIn;
        private readonly Font _fontLechQuy = new Font("Segoe UI", 9F, FontStyle.Bold);

        public FormBaoCaoThongKe()
        {
            InitializeComponent();
            dgvDoanhThuCa.CellFormatting += DgvDoanhThuCa_CellFormatting;
            FormClosed += (_, _) => _fontLechQuy.Dispose();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-29);
            dtpDenNgay.Value = DateTime.Today;
            NapChiNhanh();
            TaiDuLieuBaoCao();
        }

        private void btnXem_Click(object sender, EventArgs e) => TaiDuLieuBaoCao();
        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e) => TaiDuLieuBaoCao();
        private void tabControlBaoCao_SelectedIndexChanged(object sender, EventArgs e) => TaiDuLieuBaoCao();
        private void btn7Ngay_Click(object sender, EventArgs e) => ChonKy(DateTime.Today.AddDays(-6), DateTime.Today);
        private void btn30Ngay_Click(object sender, EventArgs e) => ChonKy(DateTime.Today.AddDays(-29), DateTime.Today);

        private void ChonKy(DateTime tu, DateTime den)
        {
            dtpTuNgay.Value = tu;
            dtpDenNgay.Value = den;
            TaiDuLieuBaoCao();
        }

        private void TaiDuLieuBaoCao()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DateTime tu = dtpTuNgay.Value.Date;
                DateTime den = dtpDenNgay.Value.Date;
                int? chiNhanh = ChiNhanhDangChon();

                int loaiBaoCao = 0;
                if (tabControlBaoCao.SelectedTab == tabTopSach) loaiBaoCao = 1;
                else if (tabControlBaoCao.SelectedTab == tabQuayVong) loaiBaoCao = 2;

                int topLimit = (int)nudTopSach.Value;

                // Gọi BLL lấy dữ liệu, BLL sẽ tự kiểm tra logic ngày tháng và tham số
                DataTable dt = _bll.LayDuLieuBaoCao(loaiBaoCao, tu, den, chiNhanh, topLimit);

                if (loaiBaoCao == 1) GanNguon(dgvTopSach, dt);
                else if (loaiBaoCao == 2) GanNguon(dgvQuayVong, dt);
                else GanNguon(dgvDoanhThuCa, dt);

                BaoCaoKPIDTO kpi = _bll.GetKPISummary(tu, den, chiNhanh);

                lblValTongDoanhThu.Text = kpi.TongTienPhatDaThu.ToString("N0") + " đ";
                lblValTienConNo.Text = kpi.TongTienPhatChuaThu.ToString("N0") + " đ";
                lblValLuotMuon.Text = kpi.LuotMuonTrongKy.ToString("N0");
                lblValCaLech.Text = kpi.SoCaLechTien.ToString("N0");

                lblValCaLech.ForeColor = kpi.SoCaLechTien > 0
                    ? Color.FromArgb(190, 18, 60)
                    : Color.FromArgb(15, 23, 42);

                if (kpi.PhieuKhongGanCa > 0 || kpi.ThuKhongGanCa > 0)
                {
                    lblCanhBao.Text = $"Có {kpi.PhieuKhongGanCa} phiếu phạt và {kpi.ThuKhongGanCa} lần thu không gắn được vào ca trực. Kiểm tra lịch phân ca của thủ thư trong kỳ.";
                    lblCanhBao.ForeColor = Color.FromArgb(180, 83, 9);
                }
                else if (dt.Rows.Count == 0)
                {
                    lblCanhBao.Text = "Không có phát sinh trong kỳ và phạm vi đang chọn.";
                    lblCanhBao.ForeColor = Color.FromArgb(100, 116, 139);
                }
                else
                {
                    lblCanhBao.Text = "Tiền đã thu gắn vào ca của thủ thư thu tiền. Tiền lý thuyết = tiền đầu ca + tiền đã thu. Chênh lệch quỹ = tiền kết ca − tiền lý thuyết.";
                    lblCanhBao.ForeColor = Color.FromArgb(71, 85, 105);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi lọc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể trích xuất số liệu báo cáo cho khoảng thời gian đã chọn. Vui lòng thử lại!",
                                "Lỗi trích xuất số liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            XuatFile("CSV (*.csv)|*.csv", "csv", (dt, path) =>
                _bll.ExportToCsv(dt, path, SessionContext.CurrentUser?.Ma_So));
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            XuatFile("Excel (*.xlsx)|*.xlsx", "xlsx", (dt, path) =>
                _bll.ExportToExcel(dt, path, TieuDeBaoCao(), PhuDeBaoCao(), SessionContext.CurrentUser?.Ma_So));
        }

        private void btnXuatPdf_Click(object sender, EventArgs e)
        {
            XuatFile("PDF (*.pdf)|*.pdf", "pdf", (dt, path) =>
                _bll.ExportToPdf(dt, path, TieuDeBaoCao(), PhuDeBaoCao(), SessionContext.CurrentUser?.Ma_So));
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            DataGridView activeDgv = GetCurrentActiveDataGridView();
            if (activeDgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dongIn = 0;
            using var printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = true;
            printDoc.DocumentName = TieuDeBaoCao();
            printDoc.PrintPage += PrintDoc_PrintPage;

            using var previewDlg = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 1000,
                Height = 720,
                Text = "Xem trước bản in - " + TieuDeBaoCao()
            };
            previewDlg.ShowDialog(this);
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView activeDgv = GetCurrentActiveDataGridView();
            using Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            using Font fontSub = new Font("Segoe UI", 10, FontStyle.Italic);
            using Font fontHeader = new Font("Segoe UI", 9, FontStyle.Bold);
            using Font fontRow = new Font("Segoe UI", 9, FontStyle.Regular);
            using Pen penGrid = new Pen(Color.FromArgb(160, 160, 160), 1);
            using Brush headerBrush = new SolidBrush(Color.FromArgb(235, 240, 245));

            var cot = activeDgv.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).ToList();
            if (cot.Count == 0 || e.Graphics == null)
            {
                e.HasMorePages = false;
                return;
            }

            float startX = e.MarginBounds.Left;
            float startY = e.MarginBounds.Top;
            float printableWidth = e.MarginBounds.Width;
            float currentY = startY;

            e.Graphics.DrawString(TieuDeBaoCao().ToUpper(), fontTitle, Brushes.Black, startX, currentY);
            currentY += 30;
            e.Graphics.DrawString(PhuDeBaoCao() + $"    |    Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fontSub, Brushes.Black, startX, currentY);
            currentY += 24;
            e.Graphics.DrawLine(Pens.Black, startX, currentY, startX + printableWidth, currentY);
            currentY += 12;

            float totalWeight = cot.Sum(c => TrongSoCot(c.HeaderText));
            float[] colWidths = cot.Select(c => printableWidth * TrongSoCot(c.HeaderText) / totalWeight).ToArray();
            const float headerHeight = 30;
            const float rowHeight = 26;

            VeDong(e.Graphics, cot.Select(c => c.HeaderText).ToArray(), colWidths, startX, currentY, headerHeight, fontHeader, headerBrush, penGrid, true);
            currentY += headerHeight;

            while (_dongIn < activeDgv.Rows.Count)
            {
                DataGridViewRow row = activeDgv.Rows[_dongIn];
                if (row.IsNewRow)
                {
                    _dongIn++;
                    continue;
                }

                if (currentY + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                string[] values = cot.Select(c => row.Cells[c.Index].FormattedValue?.ToString() ?? "").ToArray();
                VeDong(e.Graphics, values, colWidths, startX, currentY, rowHeight, fontRow, Brushes.White, penGrid, false);
                currentY += rowHeight;
                _dongIn++;
            }

            _dongIn = 0;
            e.HasMorePages = false;
        }

        private void NapChiNhanh()
        {
            cboChiNhanh.Items.Clear();
            cboChiNhanh.Items.Add(new MucChiNhanh(null, "Tất cả chi nhánh"));
            try
            {
                foreach (ChiNhanhDTO cn in new ChiNhanhBLL().LayDanhSachChiNhanh().Where(x => x.Dang_Hoat_Dong))
                    cboChiNhanh.Items.Add(new MucChiNhanh(cn.Ma_So, cn.Ten_Chi_Nhanh));
            }
            catch
            {
            }

            cboChiNhanh.SelectedIndex = 0;
        }

        private int? ChiNhanhDangChon() => (cboChiNhanh.SelectedItem as MucChiNhanh)?.MaSo;

        private void GanNguon(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = null;
            dgv.DataSource = dt;
            DinhDangCotGridView(dgv);
        }

        private static void DinhDangCotGridView(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderText = BaoCaoBLL.TenCot(col.Name);
                col.SortMode = DataGridViewColumnSortMode.Automatic;

                bool laTien = col.Name.Contains("Tien", StringComparison.OrdinalIgnoreCase)
                    || col.Name.Contains("ChenhLech", StringComparison.OrdinalIgnoreCase);
                bool laTyLe = col.Name.Contains("TyLe", StringComparison.OrdinalIgnoreCase);
                bool laNgay = col.Name.Contains("Ngay", StringComparison.OrdinalIgnoreCase);
                bool laChu = col.Name is "TenCa" or "ThuThu" or "ChiNhanh" or "TieuDe" or "TacGia" or "TheLoai" or "TrangThai";

                if (laTien) col.DefaultCellStyle.Format = "N0";
                else if (laTyLe) col.DefaultCellStyle.Format = "N2";
                else if (laNgay) col.DefaultCellStyle.Format = "dd/MM/yyyy";

                col.DefaultCellStyle.Alignment = laChu
                    ? DataGridViewContentAlignment.MiddleLeft
                    : DataGridViewContentAlignment.MiddleCenter;
                if (laTien) col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void DgvDoanhThuCa_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string ten = dgvDoanhThuCa.Columns[e.ColumnIndex].Name;
            if (ten == "ChenhLech" && e.Value != null && e.Value != DBNull.Value && Convert.ToDecimal(e.Value) != 0)
            {
                e.CellStyle!.ForeColor = Color.FromArgb(190, 18, 60);
                e.CellStyle.Font = _fontLechQuy;
            }
        }

        private DataGridView GetCurrentActiveDataGridView()
        {
            if (tabControlBaoCao.SelectedTab == tabTopSach) return dgvTopSach;
            if (tabControlBaoCao.SelectedTab == tabQuayVong) return dgvQuayVong;
            return dgvDoanhThuCa;
        }

        private void XuatFile(string filter, string extension, Action<DataTable, string> xuat)
        {
            try
            {
                DataGridView activeDgv = GetCurrentActiveDataGridView();
                if (activeDgv.DataSource is not DataTable dt || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Filter = filter,
                    FileName = $"BaoCao_{TenTap()}_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}"
                };
                if (sfd.ShowDialog(this) != DialogResult.OK) return;

                xuat(dt, sfd.FileName);
                MessageBox.Show("Xuất file báo cáo thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lưu file báo cáo. Vui lòng kiểm tra xem bạn có đang mở file trùng tên này trong Excel/PDF không và thử đóng lại trước khi xuất!",
                                "Không thể ghi tệp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string TieuDeBaoCao()
        {
            if (tabControlBaoCao.SelectedTab == tabTopSach) return "Báo cáo top sách được mượn nhiều";
            if (tabControlBaoCao.SelectedTab == tabQuayVong) return "Báo cáo tỷ lệ quay vòng theo chi nhánh";
            return "Báo cáo doanh thu và đối soát ca trực";
        }

        private string PhuDeBaoCao()
        {
            return $"Kỳ {dtpTuNgay.Value:dd/MM/yyyy} - {dtpDenNgay.Value:dd/MM/yyyy}   |   {cboChiNhanh.Text}";
        }

        private string TenTap()
        {
            if (tabControlBaoCao.SelectedTab == tabTopSach) return "TopSach";
            if (tabControlBaoCao.SelectedTab == tabQuayVong) return "QuayVong";
            return "DoanhThuCa";
        }

        private static float TrongSoCot(string header)
        {
            string name = header.ToLowerInvariant();
            if (name.Contains("chi nhánh") || name.Contains("thủ thư") || name.Contains("đầu sách") || name.Contains("tác giả") || name.Contains("thể loại"))
                return 2.5f;
            if (name.Contains("trạng thái") || name.Contains("lý thuyết") || name.Contains("chênh lệch") || name.Contains("ngày trực"))
                return 1.8f;
            return 1.2f;
        }

        private static void VeDong(Graphics graphics, string[] values, float[] widths, float x, float y, float height, Font font, Brush background, Pen border, bool laTieuDe)
        {
            float currentX = x;
            for (int i = 0; i < values.Length; i++)
            {
                var rect = new RectangleF(currentX + 2, y + 2, widths[i] - 4, height - 4);
                if (laTieuDe) graphics.FillRectangle(background, new RectangleF(currentX, y, widths[i], height));

                Font drawFont = font;
                if (laTieuDe)
                {
                    SizeF textSize = graphics.MeasureString(values[i], font);
                    if (textSize.Width > rect.Width)
                    {
                        drawFont = new Font(font.FontFamily, Math.Max(7.5f, font.Size - 1.5f), FontStyle.Bold);
                    }
                }

                var format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.None,
                    FormatFlags = StringFormatFlags.LineLimit
                };

                graphics.DrawString(values[i], drawFont, Brushes.Black, rect, format);
                graphics.DrawRectangle(border, currentX, y, widths[i], height);
                currentX += widths[i];
            }
        }

        private sealed class MucChiNhanh
        {
            public MucChiNhanh(int? maSo, string ten)
            {
                MaSo = maSo;
                Ten = ten;
            }

            public int? MaSo { get; }
            public string Ten { get; }
            public override string ToString() => Ten;
        }
    }
}