using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using ClosedXML.Excel;
using Library.DAL;
using Library.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Library.BLL
{
    public class BaoCaoBLL
    {
        private static readonly CultureInfo VietNam = CultureInfo.GetCultureInfo("vi-VN");
        private readonly BaoCaoDAL _dal = new BaoCaoDAL();

        static BaoCaoBLL()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            QuestPDF.Settings.ThrowOnMissingTextGlyphs = false;

            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "segoeui.ttf");
            if (File.Exists(fontPath))
                using (var font = File.OpenRead(fontPath))
                    QuestPDF.Drawing.FontManager.RegisterFontFromStream(font);
        }

        public BaoCaoKPIDTO GetKPISummary(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            DataTable dt = _dal.GetKPISummary(tuNgay, denNgay, chiNhanhMaSo);
            var kpi = new BaoCaoKPIDTO();
            if (dt.Rows.Count == 0) return kpi;

            DataRow r = dt.Rows[0];
            kpi.TongDocGia = DocSoNguyen(r, "TongDocGia");
            kpi.SachSanCo = DocSoNguyen(r, "SachSanCo");
            kpi.LuotDangMuon = DocSoNguyen(r, "LuotDangMuon");
            kpi.TongTienPhatDaThu = DocTien(r, "TongTienPhatDaThu");
            kpi.TongTienPhatChuaThu = DocTien(r, "TongTienPhatChuaThu");
            kpi.LuotMuonTrongKy = DocSoNguyen(r, "LuotMuonTrongKy");
            kpi.TongCaDaKetThuc = DocSoNguyen(r, "TongCaDaKetThuc");
            kpi.SoCaLechTien = DocSoNguyen(r, "SoCaLechTien");
            kpi.PhieuKhongGanCa = DocSoNguyen(r, "PhieuKhongGanCa");
            kpi.ThuKhongGanCa = DocSoNguyen(r, "ThuKhongGanCa");
            return kpi;
        }

        public DataTable GetDoanhThuTheoCa(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return _dal.GetDoanhThuTheoCa(tuNgay, denNgay, chiNhanhMaSo);
        }

        public DataTable GetTopHotBooks(int limit, DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            if (limit <= 0) limit = 10;
            if (limit > 100) limit = 100;
            KiemTraKhoangNgay(tuNgay, denNgay);
            return _dal.GetTopHotBooksByFilter(limit, tuNgay, denNgay, chiNhanhMaSo);
        }

        public DataTable GetQuayVongChiNhanh(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            KiemTraKhoangNgay(tuNgay, denNgay);
            return _dal.GetQuayVongChiNhanh(tuNgay, denNgay, chiNhanhMaSo);
        }

        public void ExportToCsv(DataTable dt, string filePath, int? currentUserId)
        {
            if (dt == null || dt.Rows.Count == 0)
                throw new InvalidOperationException("Không có dữ liệu để xuất báo cáo.");

            var sb = new StringBuilder();
            const string separator = ";";

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append(EscapeCsvCell(TenCot(dt.Columns[i].ColumnName), separator));
                if (i < dt.Columns.Count - 1) sb.Append(separator);
            }
            sb.AppendLine();

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append(EscapeCsvCell(DinhDangO(row[i], dt.Columns[i].ColumnName), separator));
                    if (i < dt.Columns.Count - 1) sb.Append(separator);
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));
            GhiNhatKy("Xuất Báo Cáo CSV", filePath, currentUserId);
        }

        public void ExportToExcel(DataTable dt, string filePath, string tieuDe, string phuDe, int? currentUserId)
        {
            if (dt == null || dt.Rows.Count == 0)
                throw new InvalidOperationException("Không có dữ liệu để xuất báo cáo.");

            using var workbook = new XLWorkbook();
            var sheet = workbook.Worksheets.Add("BaoCao");
            sheet.Cell(1, 1).Value = tieuDe;
            sheet.Cell(1, 1).Style.Font.Bold = true;
            sheet.Cell(1, 1).Style.Font.FontSize = 16;
            sheet.Range(1, 1, 1, dt.Columns.Count).Merge();

            sheet.Cell(2, 1).Value = phuDe;
            sheet.Range(2, 1, 2, dt.Columns.Count).Merge();

            for (int col = 0; col < dt.Columns.Count; col++)
            {
                var cell = sheet.Cell(4, col + 1);
                cell.Value = TenCot(dt.Columns[col].ColumnName);
                cell.Style.Font.Bold = true;
                cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#1E293B");
                cell.Style.Font.FontColor = XLColor.White;
            }

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    var cell = sheet.Cell(row + 5, col + 1);
                    string ten = dt.Columns[col].ColumnName;
                    object value = dt.Rows[row][col];
                    GanGiaTriExcel(cell, value, ten);
                }
            }
            sheet.Columns().AdjustToContents();
            sheet.SheetView.FreezeRows(4);
            workbook.SaveAs(filePath);
            GhiNhatKy("Xuất Báo Cáo Excel", filePath, currentUserId);
        }

        public void ExportToPdf(DataTable dt, string filePath, string tieuDe, string phuDe, int? currentUserId)
        {
            if (dt == null || dt.Rows.Count == 0)
                throw new InvalidOperationException("Không có dữ liệu để xuất báo cáo.");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(24);
                    page.DefaultTextStyle(style => style.FontSize(9).FontFamily("Segoe UI"));

                    page.Header().Column(col =>
                    {
                        col.Item().Text(tieuDe).FontSize(16).Bold().FontColor(Colors.Blue.Darken3);
                        col.Item().PaddingTop(4).Text(phuDe).FontSize(9).FontColor(Colors.Grey.Darken2);
                        col.Item().PaddingTop(8).LineHorizontal(1).LineColor(Colors.Grey.Lighten1);
                    });

                    page.Content().PaddingTop(10).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                                columns.RelativeColumn(DoRongCot(dt.Columns[i].ColumnName));
                        });

                        table.Header(header =>
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                header.Cell().Background(Colors.BlueGrey.Darken3).Padding(4)
                                    .Text(TenCot(column.ColumnName)).FontSize(8).Bold().FontColor(Colors.White);
                            }
                        });

                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                table.Cell().BorderBottom(0.4f).BorderColor(Colors.Grey.Lighten2).Padding(3)
                                    .Text(DinhDangO(row[column], column.ColumnName)).FontSize(8);
                            }
                        }
                    });

                    page.Footer().AlignRight().Text(text =>
                    {
                        text.Span("Trang ").FontSize(8);
                        text.CurrentPageNumber().FontSize(8);
                        text.Span(" / ").FontSize(8);
                        text.TotalPages().FontSize(8);
                    });
                });
            }).GeneratePdf(filePath);

            GhiNhatKy("Xuất Báo Cáo PDF", filePath, currentUserId);
        }

        public static string TenCot(string maCot)
        {
            return maCot switch
            {
                "NgayTruc" => "Ngày trực",
                "TenCa" => "Ca trực",
                "ThuThu" => "Thủ thư",
                "ChiNhanh" => "Chi nhánh",
                "TrangThai" => "Trạng thái",
                "TienDauCa" => "Tiền đầu ca",
                "SoPhieuPhat" => "Số phiếu phạt",
                "TienPhatLap" => "Phạt lập trong ca",
                "TienDaThu" => "Tiền đã thu",
                "TienConNo" => "Còn nợ hiện tại",
                "TienChuaThu" => "Tiền chưa thu",
                "TienLyThuyet" => "Tiền lý thuyết",
                "TienKetCa" => "Tiền kết ca",
                "ChenhLech" => "Chênh lệch quỹ",
                "Hang" => "Hạng",
                "MaSach" => "Mã sách",
                "TieuDe" => "Tên đầu sách",
                "TacGia" => "Tác giả",
                "TheLoai" => "Thể loại",
                "SoLuotMuon" => "Số lượt mượn",
                "SoBanSao" => "Bản sao lưu hành",
                "SanSang" => "Sẵn sàng",
                "DangMuon" => "Đang cho mượn",
                "LuotMuon" => "Lượt mượn trong kỳ",
                "TyLeQuayVong" => "Tỷ lệ (lượt/bản)",
                _ => maCot
            };
        }

        private static void GanGiaTriExcel(IXLCell cell, object value, string tenCot)
        {
            if (value == null || value == DBNull.Value)
            {
                cell.Value = "";
                return;
            }

            if (LaCotNgay(tenCot) && value is DateTime ngay)
            {
                cell.Value = ngay;
                cell.Style.DateFormat.Format = "dd/MM/yyyy";
                return;
            }

            if (LaCotTien(tenCot) && value is IConvertible)
            {
                cell.Value = Convert.ToDecimal(value);
                cell.Style.NumberFormat.Format = "#,##0";
                return;
            }

            if (LaCotTyLe(tenCot))
            {
                cell.Value = Convert.ToDecimal(value);
                cell.Style.NumberFormat.Format = "#,##0.00";
                return;
            }

            if (value is int soNguyen)
            {
                cell.Value = soNguyen;
                return;
            }

            if (value is long soDai)
            {
                cell.Value = soDai;
                return;
            }

            cell.Value = Convert.ToString(value, VietNam) ?? "";
        }

        private static string DinhDangO(object value, string tenCot)
        {
            if (value == null || value == DBNull.Value) return "";
            if (LaCotNgay(tenCot) && value is DateTime ngay) return ngay.ToString("dd/MM/yyyy");
            if (LaCotTien(tenCot)) return Convert.ToDecimal(value).ToString("N0", VietNam);
            if (LaCotTyLe(tenCot)) return Convert.ToDecimal(value).ToString("N2", VietNam);
            if (value is DateTime dt) return dt.ToString("dd/MM/yyyy");
            return Convert.ToString(value, VietNam) ?? "";
        }

        private static bool LaCotNgay(string tenCot) => tenCot.Contains("Ngay", StringComparison.OrdinalIgnoreCase);
        private static bool LaCotTyLe(string tenCot) => tenCot.Contains("TyLe", StringComparison.OrdinalIgnoreCase);

        private static bool LaCotTien(string tenCot)
        {
            return tenCot.Contains("Tien", StringComparison.OrdinalIgnoreCase)
                || tenCot.Contains("ChenhLech", StringComparison.OrdinalIgnoreCase);
        }

        private static float DoRongCot(string tenCot)
        {
            if (tenCot is "TieuDe" or "ThuThu" or "ChiNhanh" or "TacGia") return 2.2f;
            if (tenCot is "Hang" or "SoPhieuPhat" or "SanSang" or "DangMuon") return 0.8f;
            return 1.2f;
        }

        private static int DocSoNguyen(DataRow row, string cot)
        {
            return row[cot] == DBNull.Value ? 0 : Convert.ToInt32(row[cot]);
        }

        private static decimal DocTien(DataRow row, string cot)
        {
            return row[cot] == DBNull.Value ? 0 : Convert.ToDecimal(row[cot]);
        }

        private static void KiemTraKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay.Date > denNgay.Date)
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
        }

        private static string EscapeCsvCell(string cell, string separator)
        {
            if (string.IsNullOrEmpty(cell)) return "";
            if (cell.Contains(separator) || cell.Contains('"') || cell.Contains('\n') || cell.Contains('\r'))
                return $"\"{cell.Replace("\"", "\"\"")}\"";
            return cell;
        }

        private static void GhiNhatKy(string hanhDong, string filePath, int? currentUserId)
        {
            try
            {
                SystemLogger.Log(LogLevel.INFO, hanhDong, $"Đã xuất thành công file: {filePath}", currentUserId);
            }
            catch
            {
                // Nhật ký không được chặn việc xuất file đã ghi xong.
            }
        }
    }
}
