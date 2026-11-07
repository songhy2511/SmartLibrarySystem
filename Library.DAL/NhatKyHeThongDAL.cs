using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    /// <summary>Ghi và lọc bảng Nhat_Ky_He_Thong. Bộ lọc mức/hành động rỗng nghĩa là không siết điều kiện đó.</summary>
    public class NhatKyHeThongDAL
    {
        public List<NhatKyHeThongDTO> LayDanhSachNhatKy(DateTime tuNgay, DateTime denNgay, string? mucDo, string? hanhDong, string? tuKhoa)
        {
            var list = new List<NhatKyHeThongDTO>();
            string query = @"
                SELECT 
                    nk.Ma_So,
                    nk.Nguoi_Dung_Ma_So,
                    ISNULL(nd.Ten_Dang_Nhap, N'Hệ thống') AS Ten_Dang_Nhap,
                    ISNULL(nd.Vai_Tro, N'System') AS Vai_Tro,
                    ISNULL(nk.Muc_Do, N'INFO') AS Muc_Do,
                    nk.Hanh_Dong,
                    nk.Chi_Tiet,
                    nk.Thoi_Gian,
                    nk.Dia_Chi_IP
                FROM Nhat_Ky_He_Thong nk
                LEFT JOIN Nguoi_Dung nd ON nk.Nguoi_Dung_Ma_So = nd.Ma_So
                WHERE CAST(nk.Thoi_Gian AS DATE) BETWEEN @TuNgay AND @DenNgay
                  AND (@MucDo = N'' OR nk.Muc_Do = @MucDo)
                  AND (@HanhDong = N'' OR nk.Hanh_Dong = @HanhDong)
                  AND (@TuKhoa = N'' OR nk.Chi_Tiet LIKE '%' + @TuKhoa + '%' OR nd.Ten_Dang_Nhap LIKE '%' + @TuKhoa + '%')
                ORDER BY nk.Thoi_Gian DESC, nk.Ma_So DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date),
                new SqlParameter("@MucDo", string.IsNullOrWhiteSpace(mucDo) ? "" : mucDo),
                new SqlParameter("@HanhDong", string.IsNullOrWhiteSpace(hanhDong) ? "" : hanhDong),
                new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? "" : tuKhoa.Trim())
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new NhatKyHeThongDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Nguoi_Dung_Ma_So = row["Nguoi_Dung_Ma_So"] == DBNull.Value ? null : Convert.ToInt32(row["Nguoi_Dung_Ma_So"]),
                    Ten_Dang_Nhap = row["Ten_Dang_Nhap"].ToString()!,
                    Vai_Tro = row["Vai_Tro"].ToString()!,
                    Muc_Do = row["Muc_Do"].ToString()!,
                    Hanh_Dong = row["Hanh_Dong"].ToString()!,
                    Chi_Tiet = row["Chi_Tiet"]?.ToString(),
                    Thoi_Gian = Convert.ToDateTime(row["Thoi_Gian"]),
                    Dia_Chi_IP = row["Dia_Chi_IP"]?.ToString()
                });
            }
            return list;
        }

        public bool GhiNhatKyCoMucDo(int? nguoiDungMaSo, string mucDo, string hanhDong, string chiTiet, string diaChiIp)
        {
            string query = @"
                INSERT INTO Nhat_Ky_He_Thong (Nguoi_Dung_Ma_So, Muc_Do, Hanh_Dong, Chi_Tiet, Dia_Chi_IP, Thoi_Gian)
                VALUES (@NguoiDungMaSo, @MucDo, @HanhDong, @ChiTiet, @DiaChiIP, GETDATE())";

            SqlParameter[] parameters = {
                new SqlParameter("@NguoiDungMaSo", (object?)nguoiDungMaSo ?? DBNull.Value),
                new SqlParameter("@MucDo", mucDo),
                new SqlParameter("@HanhDong", hanhDong),
                new SqlParameter("@ChiTiet", chiTiet),
                new SqlParameter("@DiaChiIP", diaChiIp)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<string> LayDanhSachLoaiHanhDong()
        {
            var list = new List<string>();
            string query = @"SELECT DISTINCT Hanh_Dong FROM Nhat_Ky_He_Thong WHERE Hanh_Dong IS NOT NULL AND Hanh_Dong <> '' ORDER BY Hanh_Dong";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["Hanh_Dong"].ToString()!);
            }
            return list;
        }
    }
}