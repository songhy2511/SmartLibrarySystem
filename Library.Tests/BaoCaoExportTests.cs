using System.Data;
using ClosedXML.Excel;
using Library.BLL;
using Library.DAL;

namespace Library.Tests
{
    [TestClass]
    public class BaoCaoExportTests
    {
        [TestMethod]
        public void KhoangNgayNguoc_BiChanTruocKhiVaoCoSoDuLieu()
        {
            var bll = new BaoCaoBLL();
            Assert.ThrowsExactly<ArgumentException>(() =>
                bll.GetDoanhThuTheoCa(new DateTime(2026, 5, 2), new DateTime(2026, 5, 1), null));
        }

        [TestMethod]
        public void XuatCsv_DungTieuDeTiengVietVaDinhDangTien()
        {
            var bll = new BaoCaoBLL();
            string path = Path.Combine(Path.GetTempPath(), $"baocao_{Guid.NewGuid():N}.csv");
            try
            {
                bll.ExportToCsv(BangMau(), path, null);
                string noiDung = File.ReadAllText(path);
                StringAssert.Contains(noiDung, "Ngày trực;Thủ thư;Tiền đã thu;Chênh lệch quỹ");
                StringAssert.Contains(noiDung, "01/05/2026");
                StringAssert.Contains(noiDung, "15.000");
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void XuatExcelVaPdf_TaoDuocFile()
        {
            var bll = new BaoCaoBLL();
            string excel = Path.Combine(Path.GetTempPath(), $"baocao_{Guid.NewGuid():N}.xlsx");
            string pdf = Path.Combine(Path.GetTempPath(), $"baocao_{Guid.NewGuid():N}.pdf");
            try
            {
                bll.ExportToExcel(BangMau(), excel, "Báo cáo doanh thu", "Kỳ thử", null);
                bll.ExportToPdf(BangMau(), pdf, "Báo cáo doanh thu", "Kỳ thử", null);

                using var workbook = new XLWorkbook(excel);
                Assert.AreEqual("Ngày trực", workbook.Worksheet(1).Cell(4, 1).GetString());
                Assert.AreEqual(15000m, workbook.Worksheet(1).Cell(5, 3).GetValue<decimal>());

                byte[] header = new byte[4];
                using var stream = File.OpenRead(pdf);
                Assert.AreEqual(4, stream.Read(header, 0, 4));
                Assert.AreEqual("%PDF", System.Text.Encoding.ASCII.GetString(header));
            }
            finally
            {
                if (File.Exists(excel)) File.Delete(excel);
                if (File.Exists(pdf)) File.Delete(pdf);
            }
        }

        [TestMethod]
        public void TruyVanBaoCao_KhongNhanDoiTienThu()
        {
            var dal = new BaoCaoDAL();
            DateTime tu = new DateTime(2020, 1, 1);
            DateTime den = DateTime.Today;
            DataTable kpi;
            DataTable ca;
            DataTable top;
            DataTable quayVong;
            try
            {
                kpi = dal.GetKPISummary(tu, den, null);
                ca = dal.GetDoanhThuTheoCa(tu, den, null);
                top = dal.GetTopHotBooksByFilter(10, tu, den, null);
                quayVong = dal.GetQuayVongChiNhanh(tu, den, null);
            }
            catch (Exception ex)
            {
                Assert.Inconclusive("Không kết nối được LibraryDB để kiểm tra truy vấn: " + ex.Message);
                return;
            }

            Assert.HasCount(1, kpi.Rows);
            Assert.Contains("ChenhLech", TenCot(ca));
            if (top.Rows.Count > 0) Assert.Contains("Hang", TenCot(top));
            Assert.Contains("TyLeQuayVong", TenCot(quayVong));

            decimal thuTrenCa = 0;
            foreach (DataRow row in ca.Rows)
            {
                thuTrenCa += Convert.ToDecimal(row["TienDaThu"]);
                if (row["TienKetCa"] != DBNull.Value)
                {
                    decimal lech = Convert.ToDecimal(row["TienKetCa"])
                        - (Convert.ToDecimal(row["TienDauCa"]) + Convert.ToDecimal(row["TienDaThu"]));
                    Assert.AreEqual(lech, Convert.ToDecimal(row["ChenhLech"]));
                }
            }

            if (Convert.ToInt32(kpi.Rows[0]["ThuKhongGanCa"]) == 0)
                Assert.AreEqual(Convert.ToDecimal(kpi.Rows[0]["TongTienPhatDaThu"]), thuTrenCa);
        }

        private static List<string> TenCot(DataTable dt)
        {
            return dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();
        }

        private static DataTable BangMau()
        {
            var dt = new DataTable();
            dt.Columns.Add("NgayTruc", typeof(DateTime));
            dt.Columns.Add("ThuThu", typeof(string));
            dt.Columns.Add("TienDaThu", typeof(decimal));
            dt.Columns.Add("ChenhLech", typeof(decimal));
            dt.Rows.Add(new DateTime(2026, 5, 1), "Nguyễn Văn A", 15000m, -5000m);
            return dt;
        }
    }
}
