using System;
using System.Data;
using System.IO;
using System.Text;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class BaoCaoBLL
    {
        private readonly BaoCaoDAL _dal = new BaoCaoDAL();

        public BaoCaoKPIDTO GetKPISummary(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            if (tuNgay > denNgay) throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc!");

            DataTable dt = _dal.GetKPISummary(tuNgay, denNgay, chiNhanhMaSo);
            var kpi = new BaoCaoKPIDTO();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                kpi.TongDocGia = r["TongDocGia"] != DBNull.Value ? Convert.ToInt32(r["TongDocGia"]) : 0;
                kpi.SachSanCo = r["SachSanCo"] != DBNull.Value ? Convert.ToInt32(r["SachSanCo"]) : 0;
                kpi.LuotDangMuon = r["LuotDangMuon"] != DBNull.Value ? Convert.ToInt32(r["LuotDangMuon"]) : 0;
                kpi.TongTienPhatDaThu = r["TongTienPhatDaThu"] != DBNull.Value ? Convert.ToDecimal(r["TongTienPhatDaThu"]) : 0;
                kpi.TongCaDaKetThuc = r["TongCaDaKetThuc"] != DBNull.Value ? Convert.ToInt32(r["TongCaDaKetThuc"]) : 0;
                kpi.SoCaLechTien = r["SoCaLechTien"] != DBNull.Value ? Convert.ToInt32(r["SoCaLechTien"]) : 0;
            }
            return kpi;
        }

        public DataTable GetDoanhThuTheoCa(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            if (tuNgay > denNgay) throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
            return _dal.GetDoanhThuTheoCa(tuNgay, denNgay, chiNhanhMaSo);
        }

        public DataTable GetTopHotBooks(int limit, DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            if (limit <= 0) limit = 10;
            if (tuNgay > denNgay) throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
            return _dal.GetTopHotBooksByFilter(limit, tuNgay, denNgay, chiNhanhMaSo);
        }

        public DataTable GetQuayVongChiNhanh(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay) throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
            return _dal.GetQuayVongChiNhanh(tuNgay, denNgay);
        }

        public void ExportToCsv(DataTable dt, string filePath, int? currentUserId)
        {
            if (dt == null || dt.Rows.Count == 0)
                throw new InvalidOperationException("Không có dữ liệu để xuất báo cáo.");

            StringBuilder sb = new StringBuilder();

            // Dùng dấu chấm phẩy (;) thay vì dấu phẩy (,) để Excel tự nhận diện phân cách cột chuẩn VN
            string separator = ";";

            // Header
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append(EscapeCsvCell(dt.Columns[i].ColumnName, separator));
                if (i < dt.Columns.Count - 1) sb.Append(separator);
            }
            sb.AppendLine();

            // Rows
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    object valObj = row[i];
                    string val = "";

                    if (valObj != null && valObj != DBNull.Value)
                    {
                        // Nếu là kiểu ngày tháng, cắt bỏ phần giờ mặc định 00:00:00
                        if (valObj is DateTime dtVal)
                        {
                            val = dtVal.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            val = valObj.ToString();
                        }
                    }

                    sb.Append(EscapeCsvCell(val, separator));
                    if (i < dt.Columns.Count - 1) sb.Append(separator);
                }
                sb.AppendLine();
            }

            // Ghi file kèm BOM UTF-8 để hiển thị tiếng Việt không bị lỗi font
            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));

            try
            {
                SystemLogger.Log(LogLevel.INFO, "Xuất Báo Cáo CSV", $"Đã xuất thành công file: {filePath}", currentUserId);
            }
            catch { }
        }

        private string EscapeCsvCell(string cell, string separator)
        {
            if (string.IsNullOrEmpty(cell)) return "";
            // Nếu ô chứa ký tự phân cách, dấu ngoặc kép hoặc xuống dòng thì bọc ngoặc kép
            if (cell.Contains(separator) || cell.Contains("\"") || cell.Contains("\n") || cell.Contains("\r"))
            {
                return $"\"{cell.Replace("\"", "\"\"")}\"";
            }
            return cell;
        }
    }
}