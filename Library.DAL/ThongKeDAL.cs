using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public partial class ThongKeDAL
    {
        // 1. Thống kê số lượt mượn và trả sách trong tuần của mỗi chi nhánh
        public List<ThongKeLuuThongChiNhanhDTO> LayThongKeMuonTraTuanCacChiNhanh(DateTime tuNgay, DateTime denNgay)
        {
            var list = new List<ThongKeLuuThongChiNhanhDTO>();
            string query = @"
                SELECT 
                    cn.Ma_So AS Chi_Nhanh_Ma_So,
                    cn.Ma_Chi_Nhanh,
                    cn.Ten_Chi_Nhanh,
                    ISNULL(m.So_Luot_Muon, 0) AS So_Luot_Muon_Trong_Tuan,
                    ISNULL(t.So_Luot_Tra, 0) AS So_Luot_Tra_Trong_Tuan,
                    ISNULL(dm.Dang_Muon, 0) AS So_Sach_Dang_Muon_Hien_Tai
                FROM Chi_Nhanh cn
                LEFT JOIN (
                    SELECT pm.Chi_Nhanh_Ma_So, COUNT(ct.Ma_So) AS So_Luot_Muon
                    FROM Chi_Tiet_Phieu_Muon ct
                    JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                    WHERE pm.Ngay_Muon >= @TuNgay AND pm.Ngay_Muon < DATEADD(DAY, 1, @DenNgay)
                    GROUP BY pm.Chi_Nhanh_Ma_So
                ) m ON cn.Ma_So = m.Chi_Nhanh_Ma_So
                LEFT JOIN (
                    SELECT pm.Chi_Nhanh_Ma_So, COUNT(*) AS So_Luot_Tra
                    FROM Chi_Tiet_Phieu_Muon ct
                    JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                    WHERE ct.Ngay_Tra_Thuc_Te >= @TuNgay AND ct.Ngay_Tra_Thuc_Te < DATEADD(DAY, 1, @DenNgay)
                    GROUP BY pm.Chi_Nhanh_Ma_So
                ) t ON cn.Ma_So = t.Chi_Nhanh_Ma_So
                LEFT JOIN (
                    SELECT pm.Chi_Nhanh_Ma_So, COUNT(*) AS Dang_Muon
                    FROM Chi_Tiet_Phieu_Muon ct
                    JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                    WHERE ct.Ngay_Tra_Thuc_Te IS NULL
                      AND pm.Trang_Thai IN (N'Đang mượn', N'Quá hạn')
                    GROUP BY pm.Chi_Nhanh_Ma_So
                ) dm ON cn.Ma_So = dm.Chi_Nhanh_Ma_So
                WHERE cn.Dang_Hoat_Dong = 1
                ORDER BY cn.Ma_So ASC";

            SqlParameter[] parameters = {
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ThongKeLuuThongChiNhanhDTO
                {
                    Chi_Nhanh_Ma_So = Convert.ToInt32(row["Chi_Nhanh_Ma_So"]),
                    Ma_Chi_Nhanh = row["Ma_Chi_Nhanh"].ToString()!,
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!,
                    So_Luot_Muon_Trong_Tuan = Convert.ToInt32(row["So_Luot_Muon_Trong_Tuan"]),
                    So_Luot_Tra_Trong_Tuan = Convert.ToInt32(row["So_Luot_Tra_Trong_Tuan"]),
                    So_Sach_Dang_Muon_Hien_Tai = Convert.ToInt32(row["So_Sach_Dang_Muon_Hien_Tai"])
                });
            }
            return list;
        }

        public async Task<List<KhoSachChiNhanhDTO>> LayKhoSachTheoChiNhanhAsync(int chiNhanhMaSo, string tuKhoa)
        {
            var list = new List<KhoSachChiNhanhDTO>();
            string query = @"
        SELECT 
            s.Ma_So AS Sach_Ma_So, s.Ma_Sach, s.Tieu_De, ISNULL(s.The_Loai, N'Chưa phân loại') AS The_Loai, s.Tac_Gia,
            COUNT(bss.Ma_So) AS Tong_Ban_Sao,
            SUM(CASE WHEN bss.Trang_Thai = N'Đang cho mượn' THEN 1 ELSE 0 END) AS Dang_Muon,
            SUM(CASE WHEN bss.Trang_Thai = N'Sẵn sàng' THEN 1 ELSE 0 END) AS San_Co,
            SUM(CASE WHEN bss.Trang_Thai IN (N'Hư hỏng', N'Mất/Thanh lý') THEN 1 ELSE 0 END) AS Bao_Tri
        FROM dbo.Sach s
        LEFT JOIN dbo.Ban_Sao_Sach bss ON s.Ma_So = bss.Sach_Ma_So AND (@ChiNhanhMaSo = 0 OR bss.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
        WHERE (@TuKhoa = '' OR s.Tieu_De LIKE '%' + @TuKhoa + '%' OR s.Ma_Sach LIKE '%' + @TuKhoa + '%' OR s.Tac_Gia LIKE '%' + @TuKhoa + '%')
          AND (@ChiNhanhMaSo = 0 OR bss.Ma_So IS NOT NULL)
        GROUP BY s.Ma_So, s.Ma_Sach, s.Tieu_De, s.The_Loai, s.Tac_Gia
        ORDER BY s.Ma_Sach ASC";

            SqlParameter[] parameters = {
        new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
        new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? "" : tuKhoa.Trim())
    };

            DataTable dt = await DatabaseHelper.ExecuteQueryAsync(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new KhoSachChiNhanhDTO
                {
                    Sach_Ma_So = Convert.ToInt32(row["Sach_Ma_So"]),
                    Ma_Sach = row["Ma_Sach"].ToString()!,
                    Tieu_De = row["Tieu_De"].ToString()!,
                    The_Loai = row["The_Loai"].ToString()!,
                    Tac_Gia = row["Tac_Gia"].ToString()!,
                    Tong_Ban_Sao = Convert.ToInt32(row["Tong_Ban_Sao"]),
                    Dang_Muon = Convert.ToInt32(row["Dang_Muon"]),
                    San_Co = Convert.ToInt32(row["San_Co"]),
                    Bao_Tri = Convert.ToInt32(row["Bao_Tri"])
                });
            }
            return list;
        }

        public async Task<DataTable> LayLuuThongTuanAsync()
        {
            string query = @"
        DECLARE @HomNay DATE = CAST(GETDATE() AS DATE);
        DECLARE @DauTuan DATE = DATEADD(DAY, -((DATEPART(WEEKDAY, @HomNay) + @@DATEFIRST + 5) % 7), @HomNay);
        DECLARE @CuoiTuan DATE = DATEADD(DAY, 7, @DauTuan);

        SELECT
            pm.Ma_Phieu_Muon, dg.Ho_Ten AS Ho_Ten_Doc_Gia, ISNULL(s.Tieu_De, N'Tài liệu lưu hành') AS Tieu_De_Sach,
            pm.Ngay_Muon, pm.Ngay_Hen_Tra, pm.Trang_Thai
        FROM dbo.Phieu_Muon pm
        INNER JOIN dbo.Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
        LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ct ON pm.Ma_So = ct.Phieu_Muon_Ma_So
        LEFT JOIN dbo.Ban_Sao_Sach bs ON ct.Ban_Sao_Sach_Ma_So = bs.Ma_So
        LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
        WHERE pm.Ngay_Muon >= @DauTuan AND pm.Ngay_Muon < @CuoiTuan
        ORDER BY pm.Ngay_Muon DESC";

            return await DatabaseHelper.ExecuteQueryAsync(query);
        }

        public (int TongDocGia, decimal TongTienPhat) LayKPIDocGiaVaTienPhat()
        {
            string queryDocGia = "SELECT COUNT(*) FROM dbo.Doc_Gia WHERE Trang_Thai = N'Hoạt động'";
            object? resDG = DatabaseHelper.ExecuteScalar(queryDocGia);
            int docGia = (resDG != null && resDG != DBNull.Value) ? Convert.ToInt32(resDG) : 0;

            string queryPhat = "SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM dbo.Phieu_Phat WHERE Da_Thanh_Toan = 1";
            object? resPhat = DatabaseHelper.ExecuteScalar(queryPhat);
            decimal tienPhat = (resPhat != null && resPhat != DBNull.Value) ? Convert.ToDecimal(resPhat) : 0m;

            return (docGia, tienPhat);
        }

        // 👉 5 hàm bổ sung phục vụ trực tiếp các chỉ số Tab 1
        public int LayTongSoDocGia()
        {
            string query = "SELECT COUNT(*) FROM dbo.Doc_Gia WHERE Trang_Thai = N'Hoạt động'";
            object? res = DatabaseHelper.ExecuteScalar(query);
            return (res != null && res != DBNull.Value) ? Convert.ToInt32(res) : 0;
        }

        public int LayTongSoDauSach()
        {
            string query = "SELECT COUNT(*) FROM dbo.Sach";
            object? res = DatabaseHelper.ExecuteScalar(query);
            return (res != null && res != DBNull.Value) ? Convert.ToInt32(res) : 0;
        }

        public int LayTongSachDangMuon()
        {
            string query = @"
                SELECT COUNT(*) 
                FROM dbo.Chi_Tiet_Phieu_Muon ct
                JOIN dbo.Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                WHERE ct.Ngay_Tra_Thuc_Te IS NULL
                  AND pm.Trang_Thai IN (N'Đang mượn', N'Quá hạn')";
            object? res = DatabaseHelper.ExecuteScalar(query);
            return (res != null && res != DBNull.Value) ? Convert.ToInt32(res) : 0;
        }

        public decimal LayTongTienPhatChuaThu()
        {
            string query = "SELECT ISNULL(SUM(So_Tien_Phat), 0) FROM dbo.Phieu_Phat WHERE Da_Thanh_Toan = 0 AND Trang_Thai = N'Chưa thu'";
            object? res = DatabaseHelper.ExecuteScalar(query);
            return (res != null && res != DBNull.Value) ? Convert.ToDecimal(res) : 0m;
        }

        public List<DoiSoatCaTrucDTO> LayDanhSachDoiSoatCaTruc(int chiNhanhMaSo, DateTime tuNgay, DateTime denNgay)
        {
            var list = new List<DoiSoatCaTrucDTO>();
            string query = @"
                SELECT 
                    ct.Ma_So,
                    ct.Ngay_Truc,
                    cn.Ten_Chi_Nhanh,
                    ct.Ten_Ca,
                    tt.Ho_Ten AS Ten_Thu_Thu,
                    ct.Tien_Dau_Ca,
                    ISNULL((
                        SELECT SUM(pt.So_Tien_Thu)
                        FROM Phat_Tien pt
                        JOIN Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                        CROSS APPLY (
                            SELECT TOP 1 ct2.Ma_So
                            FROM Ca_Truc ct2
                            WHERE ct2.Thu_Thu_Ma_So = pt.Thu_Thu_Ma_So
                              AND (pp.Chi_Nhanh_Ma_So IS NULL OR ct2.Chi_Nhanh_Ma_So = pp.Chi_Nhanh_Ma_So)
                              AND ct2.Ngay_Truc = CAST(pt.Ngay_Thu AS DATE)
                            ORDER BY
                                CASE
                                    WHEN CAST(pt.Ngay_Thu AS TIME) >= ct2.Gio_Bat_Dau
                                     AND CAST(pt.Ngay_Thu AS TIME) < ct2.Gio_Ket_Thuc THEN 0
                                    ELSE 1
                                END,
                                ABS(DATEDIFF(MINUTE, ct2.Gio_Bat_Dau, CAST(pt.Ngay_Thu AS TIME))),
                                ct2.Ma_So
                        ) chon
                        WHERE chon.Ma_So = ct.Ma_So
                    ), 0) AS Thu_Trong_Ca,
                    ct.Tien_Ket_Ca AS Tien_Thuc_Nop,
                    ct.Trang_Thai
                FROM Ca_Truc ct
                JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                WHERE (@ChiNhanhMaSo = 0 OR ct.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                  AND ct.Ngay_Truc BETWEEN @TuNgay AND @DenNgay
                ORDER BY ct.Ngay_Truc DESC, ct.Ma_So DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DoiSoatCaTrucDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Ngay_Truc = Convert.ToDateTime(row["Ngay_Truc"]),
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!,
                    Ten_Ca = row["Ten_Ca"].ToString()!,
                    Ten_Thu_Thu = row["Ten_Thu_Thu"].ToString()!,
                    Tien_Dau_Ca = Convert.ToDecimal(row["Tien_Dau_Ca"]),
                    Thu_Trong_Ca = Convert.ToDecimal(row["Thu_Trong_Ca"]),
                    Tien_Thuc_Nop = row["Tien_Thuc_Nop"] == DBNull.Value ? null : Convert.ToDecimal(row["Tien_Thuc_Nop"]),
                    Trang_Thai = row["Trang_Thai"].ToString()!
                });
            }
            return list;
        }
    }
}