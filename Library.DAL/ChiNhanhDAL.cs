using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    /// <summary>Bảng Chi_Nhanh. GetNextMaChiNhanh sinh CN01, CN02 từ số lớn nhất hiện có.</summary>
    public class ChiNhanhDAL
    {
        public List<ChiNhanhDTO> GetAll()
        {
            var list = new List<ChiNhanhDTO>();
            string query = @"SELECT Ma_So, Ma_Chi_Nhanh, Ten_Chi_Nhanh, Dia_Chi, So_Dien_Thoai, Dang_Hoat_Dong, Ngay_Tao 
                             FROM Chi_Nhanh 
                             ORDER BY Ma_So ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ChiNhanhDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Ma_Chi_Nhanh = row["Ma_Chi_Nhanh"].ToString()!,
                    Ten_Chi_Nhanh = row["Ten_Chi_Nhanh"].ToString()!,
                    Dia_Chi = row["Dia_Chi"].ToString()!,
                    So_Dien_Thoai = row["So_Dien_Thoai"]?.ToString(),
                    Dang_Hoat_Dong = Convert.ToBoolean(row["Dang_Hoat_Dong"]),
                    Ngay_Tao = Convert.ToDateTime(row["Ngay_Tao"])
                });
            }
            return list;
        }

        // Tự sinh mã CN1, CN2, CN3... dựa trên số lớn nhất
        public string GetNextMaChiNhanh()
        {
            string query = @"SELECT MAX(CAST(SUBSTRING(Ma_Chi_Nhanh, 3, LEN(Ma_Chi_Nhanh) - 2) AS INT)) 
                             FROM Chi_Nhanh 
                             WHERE Ma_Chi_Nhanh LIKE 'CN[0-9]%'";

            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNumber = 1;
            if (result != null && result != DBNull.Value)
            {
                nextNumber = Convert.ToInt32(result) + 1;
            }
            return $"CN{nextNumber}";
        }

        public bool ThemChiNhanh(ChiNhanhDTO cn)
        {
            string query = @"INSERT INTO Chi_Nhanh (Ma_Chi_Nhanh, Ten_Chi_Nhanh, Dia_Chi, So_Dien_Thoai, Dang_Hoat_Dong) 
                             VALUES (@MaChiNhanh, @TenChiNhanh, @DiaChi, @SoDienThoai, @DangHoatDong)";

            SqlParameter[] parameters = {
                new SqlParameter("@MaChiNhanh", cn.Ma_Chi_Nhanh),
                new SqlParameter("@TenChiNhanh", cn.Ten_Chi_Nhanh),
                new SqlParameter("@DiaChi", cn.Dia_Chi),
                new SqlParameter("@SoDienThoai", (object?)cn.So_Dien_Thoai ?? DBNull.Value),
                new SqlParameter("@DangHoatDong", cn.Dang_Hoat_Dong)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}