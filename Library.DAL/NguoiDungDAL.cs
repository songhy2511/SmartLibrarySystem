using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    /// <summary>Đọc/ghi bảng Nguoi_Dung: tìm theo tên đăng nhập hoặc mã, cập nhật mật khẩu và cờ khóa.</summary>
    public class NguoiDungDAL
    {
        /// <summary>Dùng lúc đăng nhập. Không thấy tên thì trả null, BLL sẽ báo sai tài khoản.</summary>
        public NguoiDungDTO? GetByUsername(string username)
        {
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

        // Truy vấn người dùng theo khóa chính Ma_So
        public NguoiDungDTO? GetById(int maSo)
        {
            string query = @"SELECT Ma_So, Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong, Ngay_Tao 
                             FROM Nguoi_Dung 
                             WHERE Ma_So = @MaSo";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSo", maSo)
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

        // Cập nhật Hash và Salt mật khẩu mới vào CSDL
        public bool CapNhatMatKhau(int maSo, string matKhauMaHoaMoi, string chuoiMuoiMoi)
        {
            string query = @"UPDATE Nguoi_Dung 
                             SET Mat_Khau_Ma_Hoa = @MatKhau, Chuoi_Muoi = @ChuoiMuoi 
                             WHERE Ma_So = @MaSo";

            SqlParameter[] parameters = {
                new SqlParameter("@MatKhau", matKhauMaHoaMoi),
                new SqlParameter("@ChuoiMuoi", chuoiMuoiMoi),
                new SqlParameter("@MaSo", maSo)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CapNhatTrangThaiHoatDong(int maSoNguoiDung, bool dangHoatDong)
        {
            string query = @"UPDATE Nguoi_Dung 
                     SET Dang_Hoat_Dong = @DangHoatDong 
                     WHERE Ma_So = @MaSo";

            SqlParameter[] parameters = {
        new SqlParameter("@DangHoatDong", dangHoatDong),
        new SqlParameter("@MaSo", maSoNguoiDung)
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}