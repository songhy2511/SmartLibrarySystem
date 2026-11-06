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
                    SELECT Chi_Nhanh_Ma_So, COUNT(*) AS So_Luot_Muon
                    FROM Phieu_Muon
                    WHERE Ngay_Muon >= @TuNgay AND Ngay_Muon < DATEADD(DAY, 1, @DenNgay)
                    GROUP BY Chi_Nhanh_Ma_So
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

        public List<KhoSachChiNhanhDTO> LayKhoSachTheoChiNhanh(int chiNhanhMaSo, string tuKhoa)
        {
            var list = new List<KhoSachChiNhanhDTO>();

            // Sử dụng LEFT JOIN để không làm mất đầu sách, đồng thời quét đúng các trạng thái hư hỏng/thanh lý
            string query = @"
        SELECT 
            s.Ma_So AS Sach_Ma_So,
            s.Ma_Sach,
            s.Tieu_De,
            ISNULL(s.The_Loai, N'Chưa phân loại') AS The_Loai,
            s.Tac_Gia,
            COUNT(bss.Ma_So) AS Tong_Ban_Sao,
            SUM(CASE WHEN bss.Trang_Thai = N'Đang cho mượn' THEN 1 ELSE 0 END) AS Dang_Muon,
            SUM(CASE WHEN bss.Trang_Thai = N'Sẵn sàng' THEN 1 ELSE 0 END) AS San_Co,
            SUM(CASE WHEN bss.Trang_Thai IN (N'Bảo trì', N'Hư hỏng', N'Mất/Thanh lý') 
                          OR bss.Tinh_Trang LIKE N'%Hỏng%' 
                          OR bss.Tinh_Trang LIKE N'%Rách%' THEN 1 ELSE 0 END) AS Bao_Tri
        FROM dbo.Sach s
        LEFT JOIN dbo.Ban_Sao_Sach bss ON s.Ma_So = bss.Sach_Ma_So 
                                      AND (@ChiNhanhMaSo = 0 OR bss.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
        WHERE (@TuKhoa = '' OR s.Tieu_De LIKE '%' + @TuKhoa + '%' OR s.Ma_Sach LIKE '%' + @TuKhoa + '%' OR s.Tac_Gia LIKE '%' + @TuKhoa + '%')
          AND (@ChiNhanhMaSo = 0 OR bss.Ma_So IS NOT NULL)
        GROUP BY s.Ma_So, s.Ma_Sach, s.Tieu_De, s.The_Loai, s.Tac_Gia
        ORDER BY s.Ma_Sach ASC";

            SqlParameter[] parameters = {
        new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
        new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? "" : tuKhoa.Trim())
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
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

        // Bổ sung hàm lấy số liệu thực tế cho các thẻ KPI trên Tab 1
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
                        SELECT SUM(pp.So_Tien_Phat)
                        FROM Phieu_Phat pp
                        WHERE pp.Thu_Thu_Ma_So = ct.Thu_Thu_Ma_So
                          AND pp.Chi_Nhanh_Ma_So = ct.Chi_Nhanh_Ma_So
                          AND CAST(pp.Ngay_Tao AS DATE) = ct.Ngay_Truc
                          AND pp.Da_Thanh_Toan = 1
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