using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class ThuThuDAL
    {
        public ThuThuDTO? GetByNguoiDungMaSo(int nguoiDungMaSo)
        {
            string query = @"SELECT Ma_So, Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach, Ngay_Vao_Lam 
                             FROM Thu_Thu 
                             WHERE Nguoi_Dung_Ma_So = @NguoiDungMaSo";

            SqlParameter[] parameters = {
                new SqlParameter("@NguoiDungMaSo", nguoiDungMaSo)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new ThuThuDTO
            {
                Ma_So = Convert.ToInt32(row["Ma_So"]),
                Nguoi_Dung_Ma_So = Convert.ToInt32(row["Nguoi_Dung_Ma_So"]),
                Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                Ho_Ten = row["Ho_Ten"].ToString()!,
                So_Dien_Thoai = row["So_Dien_Thoai"]?.ToString(),
                Email = row["Email"]?.ToString(),
                Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                Ngay_Vao_Lam = Convert.ToDateTime(row["Ngay_Vao_Lam"])
            };
        }

        public List<ThuThuDTO> GetAll()
        {
            var list = new List<ThuThuDTO>();
            string query = @"SELECT tt.Ma_So, tt.Nguoi_Dung_Ma_So, tt.Ma_Thu_Thu, tt.Ho_Ten, 
                            tt.So_Dien_Thoai, tt.Email, tt.Quay_Phu_Trach, tt.Ngay_Vao_Lam,
                            nd.Ten_Dang_Nhap, nd.Dang_Hoat_Dong
                     FROM Thu_Thu tt
                     INNER JOIN Nguoi_Dung nd ON tt.Nguoi_Dung_Ma_So = nd.Ma_So
                     ORDER BY tt.Ma_So ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ThuThuDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Nguoi_Dung_Ma_So = Convert.ToInt32(row["Nguoi_Dung_Ma_So"]),
                    Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                    Ho_Ten = row["Ho_Ten"].ToString()!,
                    So_Dien_Thoai = row["So_Dien_Thoai"]?.ToString(),
                    Email = row["Email"]?.ToString(),
                    Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                    Ngay_Vao_Lam = Convert.ToDateTime(row["Ngay_Vao_Lam"]),
                    Ten_Dang_Nhap = row["Ten_Dang_Nhap"].ToString(),
                    Dang_Hoat_Dong = Convert.ToBoolean(row["Dang_Hoat_Dong"])
                });
            }
            return list;
        }

        public bool CapNhatThongTin(ThuThuDTO thuThu)
        {
            string query = @"UPDATE Thu_Thu 
                     SET Ho_Ten = @HoTen, 
                         So_Dien_Thoai = @SoDienThoai, 
                         Email = @Email, 
                         Quay_Phu_Trach = @QuayPhuTrach 
                     WHERE Ma_So = @MaSo";

            SqlParameter[] parameters = {
        new SqlParameter("@HoTen", thuThu.Ho_Ten),
        new SqlParameter("@SoDienThoai", (object?)thuThu.So_Dien_Thoai ?? DBNull.Value),
        new SqlParameter("@Email", (object?)thuThu.Email ?? DBNull.Value),
        new SqlParameter("@QuayPhuTrach", thuThu.Quay_Phu_Trach),
        new SqlParameter("@MaSo", thuThu.Ma_So)
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}