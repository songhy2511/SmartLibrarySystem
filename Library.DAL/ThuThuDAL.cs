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
    }
}