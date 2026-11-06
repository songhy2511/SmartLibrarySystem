using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Library.DAL
{
    public class BaoCaoDAL
    {
        // 1. Lấy chỉ số KPI tổng hợp theo kỳ
        public DataTable GetKPISummary(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM Doc_Gia WHERE Ngay_Cap_The <= @DenNgay) AS TongDocGia,
                    (SELECT ISNULL(SUM(So_Luong_Kha_Dung), 0) FROM Sach) AS SachSanCo,
                    (SELECT COUNT(*) FROM Phieu_Muon WHERE Trang_Thai = N'Đang mượn') AS LuotDangMuon,
                    (SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM Phieu_Phat WHERE Da_Thanh_Toan = 1 AND Ngay_Lap >= @TuNgay AND Ngay_Lap <= @DenNgay) AS TongTienPhatDaThu,
                    (SELECT COUNT(*) FROM Ca_Truc WHERE Trang_Thai = N'Đã hoàn thành' AND Ngay_Truc >= @TuNgay AND Ngay_Truc <= @DenNgay) AS TongCaDaKetThuc,
                    (SELECT COUNT(*) FROM Ca_Truc WHERE Tien_Ket_Ca IS NOT NULL AND Tien_Ket_Ca <> Tien_Mat_Dau_Ca AND Ngay_Truc >= @TuNgay AND Ngay_Truc <= @DenNgay) AS SoCaLechTien";

            SqlParameter[] parameters = {
                new SqlParameter("@TuNgay", SqlDbType.DateTime) { Value = tuNgay.Date },
                new SqlParameter("@DenNgay", SqlDbType.DateTime) { Value = denNgay.Date.AddDays(1).AddSeconds(-1) }
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // 2. Tab 1: Doanh thu theo ca trực
        public DataTable GetDoanhThuTheoCa(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string query = @"
                SELECT 
                    ct.Ngay_Truc AS NgayTruc,
                    ct.Ten_Ca AS TenCa,
                    tt.Ho_Ten AS ThuThu,
                    cn.Ten_Chi_Nhanh AS ChiNhanh,
                    COUNT(p.Ma_So) AS SoPhieuPhat,
                    SUM(CASE WHEN p.Da_Thanh_Toan = 1 THEN p.So_Tien_Phat ELSE 0 END) AS TienDaThu,
                    SUM(CASE WHEN p.Da_Thanh_Toan = 0 THEN p.So_Tien_Phat ELSE 0 END) AS TienChuaThu
                FROM Ca_Truc ct
                JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                LEFT JOIN Phieu_Phat p ON p.Thu_Thu_Ma_So = ct.Thu_Thu_Ma_So 
                    AND p.Chi_Nhanh_Ma_So = ct.Chi_Nhanh_Ma_So 
                    AND CAST(p.Ngay_Tao AS DATE) = ct.Ngay_Truc
                WHERE ct.Ngay_Truc >= @TuNgay AND ct.Ngay_Truc <= @DenNgay
                GROUP BY ct.Ngay_Truc, ct.Ten_Ca, tt.Ho_Ten, cn.Ten_Chi_Nhanh
                ORDER BY ct.Ngay_Truc DESC, ct.Ten_Ca";

            SqlParameter[] parameters = {
                new SqlParameter("@TuNgay", SqlDbType.Date) { Value = tuNgay.Date },
                new SqlParameter("@DenNgay", SqlDbType.Date) { Value = denNgay.Date }
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // 3. Tab 2: Top sách mượn nhiều
        public DataTable GetTopHotBooksByFilter(int limit, DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string query = @"
                SELECT TOP (@Limit) 
                    b.Ma_Sach AS MaSach, 
                    b.Tieu_De AS TieuDe, 
                    b.Tac_Gia AS TacGia, 
                    COUNT(ct.Ma_So) AS SoLuotMuon
                FROM Sach b
                JOIN Ban_Sao_Sach bs ON b.Ma_So = bs.Sach_Ma_So
                JOIN Chi_Tiet_Phieu_Muon ct ON bs.Ma_So = ct.Ban_Sao_Sach_Ma_So
                JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                WHERE pm.Ngay_Muon >= @TuNgay AND pm.Ngay_Muon <= @DenNgay
                GROUP BY b.Ma_Sach, b.Tieu_De, b.Tac_Gia
                ORDER BY SoLuotMuon DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@Limit", SqlDbType.Int) { Value = limit <= 0 ? 10 : limit },
                new SqlParameter("@TuNgay", SqlDbType.DateTime) { Value = tuNgay.Date },
                new SqlParameter("@DenNgay", SqlDbType.DateTime) { Value = denNgay.Date.AddDays(1).AddSeconds(-1) }
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // 4. Tab 3: Tỷ lệ quay vòng theo chi nhánh
        public DataTable GetQuayVongChiNhanh(DateTime tuNgay, DateTime denNgay)
        {
            string query = @"
                SELECT 
                    cn.Ten_Chi_Nhanh AS ChiNhanh,
                    (SELECT COUNT(*) FROM Ban_Sao_Sach bs WHERE bs.Chi_Nhanh_Ma_So = cn.Ma_So) AS SoBanSao,
                    ISNULL(LuotMuon.TongLuot, 0) AS LuotMuon,
                    CAST(ISNULL(LuotMuon.TongLuot, 0) * 1.0 / NULLIF((SELECT COUNT(*) FROM Ban_Sao_Sach bs WHERE bs.Chi_Nhanh_Ma_So = cn.Ma_So), 0) AS DECIMAL(10,2)) AS TyLeQuayVong
                FROM Chi_Nhanh cn
                LEFT JOIN (
                    SELECT pm.Chi_Nhanh_Ma_So, COUNT(ct.Ma_So) AS TongLuot
                    FROM Chi_Tiet_Phieu_Muon ct
                    JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                    WHERE pm.Ngay_Muon >= @TuNgay AND pm.Ngay_Muon <= @DenNgay
                    GROUP BY pm.Chi_Nhanh_Ma_So
                ) LuotMuon ON cn.Ma_So = LuotMuon.Chi_Nhanh_Ma_So";

            SqlParameter[] parameters = {
                new SqlParameter("@TuNgay", SqlDbType.DateTime) { Value = tuNgay.Date },
                new SqlParameter("@DenNgay", SqlDbType.DateTime) { Value = denNgay.Date.AddDays(1).AddSeconds(-1) }
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}