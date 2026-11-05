using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class ThongKeDAL
    {
        public BaoCaoKPIDTO LayThongKeKPI()
        {
            var kpi = new BaoCaoKPIDTO();
            string query = @"
                SELECT 
                    (SELECT COUNT(1) FROM Doc_Gia WHERE Dang_Hoat_Dong = 1) AS TongDocGia,
                    (SELECT COUNT(1) FROM Ban_Sao_Sach WHERE Trang_Thai = N'Sẵn sàng') AS SachSanCo,
                    (SELECT COUNT(1) FROM Phieu_Muon WHERE Trang_Thai = N'Đang mượn') AS LuotDangMuon,
                    (SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM Phieu_Phat WHERE Da_Thanh_Toan = 1) AS TongTienPhatDaThu,
                    (SELECT COUNT(1) FROM Ca_Truc WHERE Trang_Thai = N'Đã kết ca') AS TongCaDaKetThuc;";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                kpi.TongDocGia = Convert.ToInt32(r["TongDocGia"]);
                kpi.SachSanCo = Convert.ToInt32(r["SachSanCo"]);
                kpi.LuotDangMuon = Convert.ToInt32(r["LuotDangMuon"]);
                kpi.TongTienPhatDaThu = Convert.ToDecimal(r["TongTienPhatDaThu"]);
                kpi.TongCaDaKetThuc = Convert.ToInt32(r["TongCaDaKetThuc"]);
            }
            return kpi;
        }

        public List<DoiSoatTienMatDTO> LayBangDoiSoatTienMat(int chiNhanhMaSo, DateTime tuNgay, DateTime denNgay)
        {
            var list = new List<DoiSoatTienMatDTO>();
            string query = @"
                SELECT 
                    ct.Ma_So,
                    ct.Ngay_Truc,
                    cn.Ten_Chi_Nhanh,
                    ct.Ten_Ca,
                    tt.Ma_Thu_Thu,
                    tt.Ho_Ten,
                    ct.Tien_Dau_Ca,
                    ISNULL((
                        SELECT SUM(pp.So_Tien_Phat)
                        FROM Phieu_Phat pp
                        WHERE pp.Thu_Thu_Ma_So = ct.Thu_Thu_Ma_So
                          AND pp.Chi_Nhanh_Ma_So = ct.Chi_Nhanh_Ma_So
                          AND CAST(pp.Ngay_Tao AS DATE) = CAST(ct.Ngay_Truc AS DATE)
                          AND pp.Da_Thanh_Toan = 1
                    ), 0) AS Tien_Thu_Trong_Ca,
                    ct.Tien_Ket_Ca,
                    ct.Trang_Thai,
                    ct.Ghi_Chu
                FROM Ca_Truc ct
                INNER JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                INNER JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                WHERE (@ChiNhanhMaSo = 0 OR ct.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                  AND CAST(ct.Ngay_Truc AS DATE) BETWEEN @TuNgay AND @DenNgay
                ORDER BY ct.Ngay_Truc DESC, ct.Ma_So DESC;";

            SqlParameter[] parameters = {
                new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DoiSoatTienMatDTO
                {
                    Ma_Ca = Convert.ToInt32(row["Ma_So"]),
                    Ngay_Truc = Convert.ToDateTime(row["Ngay_Truc"]),
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!,
                    Ten_Ca = row["Ten_Ca"].ToString()!,
                    Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                    Ho_Ten = row["Ho_Ten"].ToString()!,
                    Tien_Dau_Ca = Convert.ToDecimal(row["Tien_Dau_Ca"]),
                    Tien_Thu_Trong_Ca = Convert.ToDecimal(row["Tien_Thu_Trong_Ca"]),
                    Tien_Ket_Ca = row["Tien_Ket_Ca"] == DBNull.Value ? null : Convert.ToDecimal(row["Tien_Ket_Ca"]),
                    Trang_Thai = row["Trang_Thai"].ToString()!,
                    Ghi_Chu = row["Ghi_Chu"]?.ToString()
                });
            }
            return list;
        }
    }
}