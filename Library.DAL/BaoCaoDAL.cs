using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Library.DAL
{
    /// <summary>
    /// Câu SELECT báo cáo. Hằng ChonCa nối mỗi phiếu phạt với đúng ca của thủ thư trong ngày,
    /// để tiền thu được cộng vào quỹ ca chứ không bị tính trùng.
    /// </summary>
    public class BaoCaoDAL
    {
        // Subquery chọn đúng ca trực của thủ thư thu tiền / lập phiếu tại chi nhánh trong ngày
        private const string ChonCa = @"
            CROSS APPLY (
                SELECT TOP 1 ct2.Ma_So
                FROM Ca_Truc ct2
                WHERE ct2.Thu_Thu_Ma_So = {alias}.Thu_Thu_Ma_So
                  AND ({chiNhanh} IS NULL OR ct2.Chi_Nhanh_Ma_So = {chiNhanh})
                  AND ct2.Ngay_Truc = CAST({moc} AS DATE)
                ORDER BY
                    CASE
                        WHEN CAST({moc} AS TIME) >= ct2.Gio_Bat_Dau
                         AND CAST({moc} AS TIME) < ct2.Gio_Ket_Thuc THEN 0
                        ELSE 1
                    END,
                    ABS(DATEDIFF(MINUTE, ct2.Gio_Bat_Dau, CAST({moc} AS TIME))),
                    ct2.Ma_So
            ) chon";

        /// <summary>
        /// Lấy dữ liệu tổng quan KPI (Tiền phạt đã thu, nợ phạt, lượt mượn, ca lệch quỹ, cảnh báo không gắn ca)
        /// </summary>
        public DataTable GetKPISummary(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string chonThu = ChonCa
                .Replace("{alias}", "pt")
                .Replace("{chiNhanh}", "pp.Chi_Nhanh_Ma_So")
                .Replace("{moc}", "pt.Ngay_Thu");

            string query = $@"
                SELECT
                    (SELECT COUNT(*)
                     FROM Doc_Gia
                     WHERE Trang_Thai = N'Hoạt động'
                       AND Ngay_Cap_The <= @DenNgay) AS TongDocGia,
                    (SELECT COUNT(*)
                     FROM Ban_Sao_Sach
                     WHERE Trang_Thai = N'Sẵn sàng'
                       AND (@ChiNhanhMaSo IS NULL OR Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS SachSanCo,
                    (SELECT COUNT(*)
                     FROM Chi_Tiet_Phieu_Muon ct
                     JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                     WHERE ct.Ngay_Tra_Thuc_Te IS NULL
                       AND pm.Trang_Thai IN (N'Đang mượn', N'Quá hạn')
                       AND (@ChiNhanhMaSo IS NULL OR pm.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS LuotDangMuon,
                    (SELECT ISNULL(SUM(pt.So_Tien_Thu), 0)
                     FROM Phat_Tien pt
                     JOIN Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                     WHERE pt.Ngay_Thu >= @TuNgay
                       AND pt.Ngay_Thu < DATEADD(DAY, 1, @DenNgay)
                       AND (@ChiNhanhMaSo IS NULL OR pp.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS TongTienPhatDaThu,
                    (SELECT ISNULL(SUM(CASE
                            WHEN pp.So_Tien_Phat > ISNULL(da.DaThu, 0) THEN pp.So_Tien_Phat - ISNULL(da.DaThu, 0)
                            ELSE 0 END), 0)
                     FROM Phieu_Phat pp
                     OUTER APPLY (
                         SELECT SUM(pt.So_Tien_Thu) AS DaThu
                         FROM Phat_Tien pt
                         WHERE pt.Phieu_Phat_Ma_So = pp.Ma_So
                     ) da
                     WHERE pp.Ngay_Lap >= @TuNgay
                       AND pp.Ngay_Lap < DATEADD(DAY, 1, @DenNgay)
                       AND (@ChiNhanhMaSo IS NULL OR pp.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS TongTienPhatChuaThu,
                    (SELECT COUNT(*)
                     FROM Chi_Tiet_Phieu_Muon ct
                     JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                     WHERE pm.Ngay_Muon >= @TuNgay
                       AND pm.Ngay_Muon < DATEADD(DAY, 1, @DenNgay)
                       AND (@ChiNhanhMaSo IS NULL OR pm.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS LuotMuonTrongKy,
                    (SELECT COUNT(*)
                     FROM Ca_Truc
                     WHERE Trang_Thai IN (N'Đã kết ca', N'Đã hoàn thành')
                       AND Ngay_Truc >= @TuNgay AND Ngay_Truc <= @DenNgay
                       AND (@ChiNhanhMaSo IS NULL OR Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS TongCaDaKetThuc,
                    (SELECT COUNT(*)
                     FROM Ca_Truc ct
                     CROSS APPLY (
                         SELECT ISNULL(SUM(pt.So_Tien_Thu), 0) AS TienDaThu
                         FROM Phat_Tien pt
                         JOIN Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                         {chonThu}
                         WHERE chon.Ma_So = ct.Ma_So
                           AND pt.Ngay_Thu >= @TuNgay
                           AND pt.Ngay_Thu < DATEADD(DAY, 1, @DenNgay)
                     ) thu
                     WHERE ct.Trang_Thai IN (N'Đã kết ca', N'Đã hoàn thành')
                       AND ct.Tien_Ket_Ca IS NOT NULL
                       AND ABS(ct.Tien_Ket_Ca - (ct.Tien_Dau_Ca + thu.TienDaThu)) > 0.009
                       AND ct.Ngay_Truc >= @TuNgay AND ct.Ngay_Truc <= @DenNgay
                       AND (@ChiNhanhMaSo IS NULL OR ct.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)) AS SoCaLechTien,
                    (SELECT COUNT(*)
                     FROM Phieu_Phat pp
                     WHERE pp.Ngay_Lap >= @TuNgay
                       AND pp.Ngay_Lap < DATEADD(DAY, 1, @DenNgay)
                       AND (@ChiNhanhMaSo IS NULL OR pp.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                       AND NOT EXISTS (
                           SELECT 1 FROM Ca_Truc ct2
                           WHERE ct2.Thu_Thu_Ma_So = pp.Thu_Thu_Ma_So
                             AND (pp.Chi_Nhanh_Ma_So IS NULL OR ct2.Chi_Nhanh_Ma_So = pp.Chi_Nhanh_Ma_So)
                             AND ct2.Ngay_Truc = CAST(pp.Ngay_Lap AS DATE)
                       )) AS PhieuKhongGanCa,
                    (SELECT COUNT(*)
                     FROM Phat_Tien pt
                     JOIN Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                     WHERE pt.Ngay_Thu >= @TuNgay
                       AND pt.Ngay_Thu < DATEADD(DAY, 1, @DenNgay)
                       AND (@ChiNhanhMaSo IS NULL OR pp.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                       AND NOT EXISTS (
                           SELECT 1 FROM Ca_Truc ct2
                           WHERE ct2.Thu_Thu_Ma_So = pt.Thu_Thu_Ma_So
                             AND (pp.Chi_Nhanh_Ma_So IS NULL OR ct2.Chi_Nhanh_Ma_So = pp.Chi_Nhanh_Ma_So)
                             AND ct2.Ngay_Truc = CAST(pt.Ngay_Thu AS DATE)
                       )) AS ThuKhongGanCa";

            return DatabaseHelper.ExecuteQuery(query, TaoThamSoKy(tuNgay, denNgay, chiNhanhMaSo));
        }

        /// <summary>
        /// Thống kê chi tiết đối soát thu tiền phạt và lệch quỹ theo ca trực
        /// </summary>
        public DataTable GetDoanhThuTheoCa(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string chonPhieu = ChonCa
                .Replace("{alias}", "pp")
                .Replace("{chiNhanh}", "pp.Chi_Nhanh_Ma_So")
                .Replace("{moc}", "pp.Ngay_Lap");
            string chonThu = ChonCa
                .Replace("{alias}", "pt")
                .Replace("{chiNhanh}", "pp.Chi_Nhanh_Ma_So")
                .Replace("{moc}", "pt.Ngay_Thu");

            string query = $@"
                SELECT
                    ct.Ngay_Truc AS NgayTruc,
                    ct.Ten_Ca AS TenCa,
                    tt.Ho_Ten AS ThuThu,
                    cn.Ten_Chi_Nhanh AS ChiNhanh,
                    ct.Trang_Thai AS TrangThai,
                    ct.Tien_Dau_Ca AS TienDauCa,
                    ISNULL(phat.SoPhieu, 0) AS SoPhieuPhat,
                    ISNULL(phat.TongPhat, 0) AS TienPhatLap,
                    ISNULL(thu.TienDaThu, 0) AS TienDaThu,
                    ISNULL(phat.ConNo, 0) AS TienConNo,
                    ct.Tien_Dau_Ca + ISNULL(thu.TienDaThu, 0) AS TienLyThuyet,
                    ct.Tien_Ket_Ca AS TienKetCa,
                    CASE
                        WHEN ct.Tien_Ket_Ca IS NULL THEN NULL
                        ELSE ct.Tien_Ket_Ca - (ct.Tien_Dau_Ca + ISNULL(thu.TienDaThu, 0))
                    END AS ChenhLech
                FROM Ca_Truc ct
                JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                OUTER APPLY (
                    SELECT
                        COUNT(*) AS SoPhieu,
                        SUM(pp.So_Tien_Phat) AS TongPhat,
                        SUM(CASE
                            WHEN pp.So_Tien_Phat > ISNULL(da.DaThu, 0) THEN pp.So_Tien_Phat - ISNULL(da.DaThu, 0)
                            ELSE 0 END) AS ConNo
                    FROM Phieu_Phat pp
                    OUTER APPLY (
                        SELECT SUM(pt.So_Tien_Thu) AS DaThu
                        FROM Phat_Tien pt
                        WHERE pt.Phieu_Phat_Ma_So = pp.Ma_So
                    ) da
                    {chonPhieu}
                    WHERE chon.Ma_So = ct.Ma_So
                      AND pp.Ngay_Lap >= @TuNgay
                      AND pp.Ngay_Lap < DATEADD(DAY, 1, @DenNgay)
                ) phat
                OUTER APPLY (
                    SELECT SUM(pt.So_Tien_Thu) AS TienDaThu
                    FROM Phat_Tien pt
                    JOIN Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                    {chonThu}
                    WHERE chon.Ma_So = ct.Ma_So
                      AND pt.Ngay_Thu >= @TuNgay
                      AND pt.Ngay_Thu < DATEADD(DAY, 1, @DenNgay)
                ) thu
                WHERE ct.Ngay_Truc >= @TuNgay AND ct.Ngay_Truc <= @DenNgay
                  AND (@ChiNhanhMaSo IS NULL OR ct.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                ORDER BY ct.Ngay_Truc DESC, ct.Gio_Bat_Dau, ct.Ma_So";

            return DatabaseHelper.ExecuteQuery(query, TaoThamSoKy(tuNgay, denNgay, chiNhanhMaSo));
        }

        /// <summary>
        /// Báo cáo top các đầu sách có lượt mượn cao nhất trong khoảng thời gian chọn
        /// </summary>
        public DataTable GetTopHotBooksByFilter(int limit, DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string query = @"
                SELECT TOP (@Limit)
                    ROW_NUMBER() OVER (ORDER BY COUNT(ct.Ma_So) DESC, b.Ma_Sach) AS Hang,
                    b.Ma_Sach AS MaSach,
                    b.Tieu_De AS TieuDe,
                    b.Tac_Gia AS TacGia,
                    ISNULL(b.The_Loai, N'Chưa phân loại') AS TheLoai,
                    COUNT(ct.Ma_So) AS SoLuotMuon
                FROM Sach b
                JOIN Ban_Sao_Sach bs ON b.Ma_So = bs.Sach_Ma_So
                JOIN Chi_Tiet_Phieu_Muon ct ON bs.Ma_So = ct.Ban_Sao_Sach_Ma_So
                JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                WHERE pm.Ngay_Muon >= @TuNgay
                  AND pm.Ngay_Muon < DATEADD(DAY, 1, @DenNgay)
                  AND (@ChiNhanhMaSo IS NULL OR pm.Chi_Nhanh_Ma_So = @ChiNhanhMaSo)
                GROUP BY b.Ma_Sach, b.Tieu_De, b.Tac_Gia, b.The_Loai
                ORDER BY SoLuotMuon DESC, b.Ma_Sach";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Limit", SqlDbType.Int) { Value = limit <= 0 ? 10 : limit }
            };
            parameters.AddRange(TaoThamSoKy(tuNgay, denNgay, chiNhanhMaSo));
            return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        /// <summary>
        /// Thống kê hiệu suất và tỷ lệ quay vòng của bản sao sách theo chi nhánh
        /// </summary>
        public DataTable GetQuayVongChiNhanh(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            string query = @"
                SELECT
                    cn.Ten_Chi_Nhanh AS ChiNhanh,
                    ISNULL(Kho.SoBanSao, 0) AS SoBanSao,
                    ISNULL(Kho.SanSang, 0) AS SanSang,
                    ISNULL(Kho.DangMuon, 0) AS DangMuon,
                    ISNULL(LuotMuon.TongLuot, 0) AS LuotMuon,
                    CAST(CASE
                        WHEN ISNULL(Kho.SoBanSao, 0) = 0 THEN 0
                        ELSE ISNULL(LuotMuon.TongLuot, 0) * 1.0 / Kho.SoBanSao
                    END AS DECIMAL(10, 2)) AS TyLeQuayVong
                FROM Chi_Nhanh cn
                LEFT JOIN (
                    SELECT
                        Chi_Nhanh_Ma_So,
                        COUNT(*) AS SoBanSao,
                        SUM(CASE WHEN Trang_Thai = N'Sẵn sàng' THEN 1 ELSE 0 END) AS SanSang,
                        SUM(CASE WHEN Trang_Thai = N'Đang cho mượn' THEN 1 ELSE 0 END) AS DangMuon
                    FROM Ban_Sao_Sach
                    WHERE Trang_Thai IN (N'Sẵn sàng', N'Đang cho mượn')
                    GROUP BY Chi_Nhanh_Ma_So
                ) Kho ON cn.Ma_So = Kho.Chi_Nhanh_Ma_So
                LEFT JOIN (
                    SELECT pm.Chi_Nhanh_Ma_So, COUNT(ct.Ma_So) AS TongLuot
                    FROM Chi_Tiet_Phieu_Muon ct
                    JOIN Phieu_Muon pm ON ct.Phieu_Muon_Ma_So = pm.Ma_So
                    WHERE pm.Ngay_Muon >= @TuNgay
                      AND pm.Ngay_Muon < DATEADD(DAY, 1, @DenNgay)
                    GROUP BY pm.Chi_Nhanh_Ma_So
                ) LuotMuon ON cn.Ma_So = LuotMuon.Chi_Nhanh_Ma_So
                WHERE cn.Dang_Hoat_Dong = 1
                  AND (@ChiNhanhMaSo IS NULL OR cn.Ma_So = @ChiNhanhMaSo)
                ORDER BY TyLeQuayVong DESC, cn.Ten_Chi_Nhanh";

            return DatabaseHelper.ExecuteQuery(query, TaoThamSoKy(tuNgay, denNgay, chiNhanhMaSo));
        }

        private static SqlParameter[] TaoThamSoKy(DateTime tuNgay, DateTime denNgay, int? chiNhanhMaSo)
        {
            return new[]
            {
                new SqlParameter("@TuNgay", SqlDbType.Date) { Value = tuNgay.Date },
                new SqlParameter("@DenNgay", SqlDbType.Date) { Value = denNgay.Date },
                new SqlParameter("@ChiNhanhMaSo", SqlDbType.Int) { Value = (object?)chiNhanhMaSo ?? DBNull.Value }
            };
        }
    }
}