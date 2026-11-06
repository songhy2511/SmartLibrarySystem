using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class CaTrucDAL
    {
        public List<CaTrucDTO> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            var list = new List<CaTrucDTO>();
            string query = @"
                SELECT ct.Ma_So, ct.Thu_Thu_Ma_So, ct.Chi_Nhanh_Ma_So, ct.Ngay_Truc, ct.Ten_Ca, 
                       ct.Gio_Bat_Dau, ct.Gio_Ket_Thuc, ct.Tien_Dau_Ca, ct.Tien_Ket_Ca, 
                       ct.Trang_Thai, ct.Ghi_Chu,
                       tt.Ma_Thu_Thu, tt.Ho_Ten, tt.Quay_Phu_Trach,
                       cn.Ma_Chi_Nhanh, cn.Ten_Chi_Nhanh
                FROM Ca_Truc ct
                INNER JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                INNER JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                WHERE CAST(ct.Ngay_Truc AS DATE) BETWEEN @FromDate AND @ToDate
                ORDER BY ct.Ngay_Truc DESC, cn.Ma_So ASC, ct.Gio_Bat_Dau ASC";

            SqlParameter[] parameters = {
                new SqlParameter("@FromDate", fromDate.Date),
                new SqlParameter("@ToDate", toDate.Date)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new CaTrucDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Thu_Thu_Ma_So = Convert.ToInt32(row["Thu_Thu_Ma_So"]),
                    Chi_Nhanh_Ma_So = Convert.ToInt32(row["Chi_Nhanh_Ma_So"]),
                    Ngay_Truc = Convert.ToDateTime(row["Ngay_Truc"]),
                    Ten_Ca = row["Ten_Ca"].ToString()!,
                    Gio_Bat_Dau = (TimeSpan)row["Gio_Bat_Dau"],
                    Gio_Ket_Thuc = (TimeSpan)row["Gio_Ket_Thuc"],
                    Tien_Dau_Ca = Convert.ToDecimal(row["Tien_Dau_Ca"]),
                    Tien_Ket_Ca = row["Tien_Ket_Ca"] == DBNull.Value ? null : Convert.ToDecimal(row["Tien_Ket_Ca"]),
                    Trang_Thai = row["Trang_Thai"].ToString()!,
                    Ghi_Chu = row["Ghi_Chu"]?.ToString(),
                    Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                    Ho_Ten = row["Ho_Ten"].ToString()!,
                    Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                    Ma_Chi_Nhanh = row["Ma_Chi_Nhanh"].ToString()!,
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!
                });
            }
            return list;
        }

        public List<CaTrucDTO> GetByThuThuAndDateRange(int thuThuMaSo, DateTime fromDate, DateTime toDate)
        {
            var list = new List<CaTrucDTO>();
            string query = @"
        SELECT ct.Ma_So, ct.Thu_Thu_Ma_So, ct.Chi_Nhanh_Ma_So, ct.Ngay_Truc, ct.Ten_Ca, 
               ct.Gio_Bat_Dau, ct.Gio_Ket_Thuc, ct.Tien_Dau_Ca, ct.Tien_Ket_Ca, 
               ct.Trang_Thai, ct.Ghi_Chu,
               tt.Ma_Thu_Thu, tt.Ho_Ten, tt.Quay_Phu_Trach,
               cn.Ma_Chi_Nhanh, cn.Ten_Chi_Nhanh
        FROM Ca_Truc ct
        INNER JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
        INNER JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
        WHERE ct.Thu_Thu_Ma_So = @ThuThuMaSo
          AND CAST(ct.Ngay_Truc AS DATE) BETWEEN @FromDate AND @ToDate
        ORDER BY ct.Ngay_Truc ASC, ct.Gio_Bat_Dau ASC";

            SqlParameter[] parameters = {
        new SqlParameter("@ThuThuMaSo", thuThuMaSo),
        new SqlParameter("@FromDate", fromDate.Date),
        new SqlParameter("@ToDate", toDate.Date)
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new CaTrucDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Thu_Thu_Ma_So = Convert.ToInt32(row["Thu_Thu_Ma_So"]),
                    Chi_Nhanh_Ma_So = Convert.ToInt32(row["Chi_Nhanh_Ma_So"]),
                    Ngay_Truc = Convert.ToDateTime(row["Ngay_Truc"]),
                    Ten_Ca = row["Ten_Ca"].ToString()!,
                    Gio_Bat_Dau = (TimeSpan)row["Gio_Bat_Dau"],
                    Gio_Ket_Thuc = (TimeSpan)row["Gio_Ket_Thuc"],
                    Tien_Dau_Ca = Convert.ToDecimal(row["Tien_Dau_Ca"]),
                    Tien_Ket_Ca = row["Tien_Ket_Ca"] == DBNull.Value ? null : Convert.ToDecimal(row["Tien_Ket_Ca"]),
                    Trang_Thai = row["Trang_Thai"].ToString()!,
                    Ghi_Chu = row["Ghi_Chu"]?.ToString(),
                    Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                    Ho_Ten = row["Ho_Ten"].ToString()!,
                    Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                    Ma_Chi_Nhanh = row["Ma_Chi_Nhanh"].ToString()!,
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!
                });
            }
            return list;
        }
        // RÀNG BUỘC 1: Tại chi nhánh X, ca Y ngày Z đã có thủ thư nào trực chưa?
        public string? LayTenThuThuDangTrucTaiChiNhanh(int chiNhanhMaSo, DateTime ngayTruc, string tenCa)
        {
            string query = @"SELECT TOP 1 tt.Ho_Ten 
                             FROM Ca_Truc ct
                             INNER JOIN Thu_Thu tt ON ct.Thu_Thu_Ma_So = tt.Ma_So
                             WHERE ct.Chi_Nhanh_Ma_So = @ChiNhanhMaSo 
                               AND CAST(ct.Ngay_Truc AS DATE) = @NgayTruc 
                               AND ct.Ten_Ca = @TenCa";

            SqlParameter[] parameters = {
                new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
                new SqlParameter("@NgayTruc", ngayTruc.Date),
                new SqlParameter("@TenCa", tenCa)
            };

            object? result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        // RÀNG BUỘC 2: Thủ thư này đã có lịch trực ở chi nhánh khác trong cùng ca và ngày đó chưa?
        public string? LayTenChiNhanhThuThuDangCoLich(int thuThuMaSo, DateTime ngayTruc, string tenCa)
        {
            string query = @"SELECT TOP 1 cn.Ten_Chi_Nhanh 
                             FROM Ca_Truc ct
                             INNER JOIN Chi_Nhanh cn ON ct.Chi_Nhanh_Ma_So = cn.Ma_So
                             WHERE ct.Thu_Thu_Ma_So = @ThuThuMaSo 
                               AND CAST(ct.Ngay_Truc AS DATE) = @NgayTruc 
                               AND ct.Ten_Ca = @TenCa";

            SqlParameter[] parameters = {
                new SqlParameter("@ThuThuMaSo", thuThuMaSo),
                new SqlParameter("@NgayTruc", ngayTruc.Date),
                new SqlParameter("@TenCa", tenCa)
            };

            object? result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        public bool ThemCaTruc(CaTrucDTO caTruc)
        {
            string query = @"
                INSERT INTO Ca_Truc (Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Truc, Ten_Ca, Gio_Bat_Dau, Gio_Ket_Thuc, Tien_Dau_Ca, Trang_Thai, Ghi_Chu)
                VALUES (@ThuThuMaSo, @ChiNhanhMaSo, @NgayTruc, @TenCa, @GioBatDau, @GioKetThuc, @TienDauCa, @TrangThai, @GhiChu)";

            SqlParameter[] parameters = {
                new SqlParameter("@ThuThuMaSo", caTruc.Thu_Thu_Ma_So),
                new SqlParameter("@ChiNhanhMaSo", caTruc.Chi_Nhanh_Ma_So),
                new SqlParameter("@NgayTruc", caTruc.Ngay_Truc.Date),
                new SqlParameter("@TenCa", caTruc.Ten_Ca),
                new SqlParameter("@GioBatDau", caTruc.Gio_Bat_Dau),
                new SqlParameter("@GioKetThuc", caTruc.Gio_Ket_Thuc),
                new SqlParameter("@TienDauCa", caTruc.Tien_Dau_Ca),
                new SqlParameter("@TrangThai", caTruc.Trang_Thai),
                new SqlParameter("@GhiChu", (object?)caTruc.Ghi_Chu ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool XoaCaTruc(int maSoCaTruc)
        {
            string query = @"DELETE FROM Ca_Truc 
                             WHERE Ma_So = @MaSo AND Trang_Thai = N'Chưa bắt đầu'";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSo", maSoCaTruc)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Lấy thông tin ca trực hiện tại trong ngày của thủ thư (chưa kết ca), bao gồm tổng tiền phạt đã thu.
        /// </summary>
        public (bool HasShift, int CaTrucId, string TenCa, decimal TienDauCa, decimal TienThuPhat) LayCaTrucHienTai(int thuThuMaSo)
        {
            string query = @"
        SELECT TOP 1
            ct.Ma_So,
            ct.Ten_Ca,
            ct.Tien_Dau_Ca,
            ISNULL((
                SELECT SUM(pt.So_Tien_Thu) 
                FROM dbo.Phat_Tien pt 
                JOIN dbo.Phieu_Phat pp ON pt.Phieu_Phat_Ma_So = pp.Ma_So
                WHERE pt.Thu_Thu_Ma_So = @ThuThuMaSo 
                  AND CAST(pt.Ngay_Thu AS DATE) = CAST(GETDATE() AS DATE)
            ), 0) AS Tien_Thu_Phat
        FROM dbo.Ca_Truc ct
        WHERE ct.Thu_Thu_Ma_So = @ThuThuMaSo
          AND CAST(ct.Ngay_Truc AS DATE) = CAST(GETDATE() AS DATE)
          AND ct.Trang_Thai <> N'Đã kết ca'
        ORDER BY ct.Ma_So DESC";

            var parameters = new[] { new Microsoft.Data.SqlClient.SqlParameter("@ThuThuMaSo", thuThuMaSo) };
            var dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return (
                    true,
                    Convert.ToInt32(dt.Rows[0]["Ma_So"]),
                    dt.Rows[0]["Ten_Ca"].ToString() ?? "",
                    Convert.ToDecimal(dt.Rows[0]["Tien_Dau_Ca"]),
                    Convert.ToDecimal(dt.Rows[0]["Tien_Thu_Phat"])
                );
            }
            return (false, 0, "", 0, 0);
        }

        /// <summary>
        /// Chốt ca trực, cập nhật tiền mặt thực tế và đổi trạng thái.
        /// </summary>
        public bool ChotCaTruc(int caTrucId, decimal tienKetCaThucTe)
        {
            string query = @"
        UPDATE dbo.Ca_Truc 
        SET Tien_Ket_Ca = @TienKetCa, 
            Trang_Thai = N'Đã kết ca' 
        WHERE Ma_So = @CaTrucId";

            var parameters = new[] {
        new Microsoft.Data.SqlClient.SqlParameter("@CaTrucId", caTrucId),
        new Microsoft.Data.SqlClient.SqlParameter("@TienKetCa", tienKetCaThucTe)
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}