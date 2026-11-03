using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class NguoiDungDAL
    {
        public NguoiDungDTO? GetByUsername(string username)
        {
            // Truy vấn an toàn bằng SqlParameter chống tấn công SQL Injection
            string query = @"SELECT Ma_So, Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong, Ngay_Tao 
                             FROM Nguoi_Dung 
                             WHERE Ten_Dang_Nhap = @Username";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new NguoiDungDTO
            {
                Ma_So = Convert.ToInt32(row["Ma_So"]),
                Ten_Dang_Nhap = row["Ten_Dang_Nhap"].ToString()!,
                Mat_Khau_Ma_Hoa = row["Mat_Khau_Ma_Hoa"].ToString()!,
                Chuoi_Muoi = row["Chuoi_Muoi"].ToString()!,
                Vai_Tro = row["Vai_Tro"].ToString()!,
                Dang_Hoat_Dong = Convert.ToBoolean(row["Dang_Hoat_Dong"]),
                Ngay_Tao = Convert.ToDateTime(row["Ngay_Tao"])
            };
        }
    }
}