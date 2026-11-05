using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class DocGiaDAL
    {
        public string GetNextMaDocGia()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma_Doc_Gia, 3, 10) AS INT)), 0) + 1 FROM Doc_Gia";
            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNum = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 1;
            return $"DG{nextNum:D4}";
        }
        public bool Delete(string maDocGia)
        {
            // Xóa mềm: Chuyển Dang_Hoat_Dong = 0 để bảo toàn lịch sử phiếu mượn
            string query = "UPDATE Doc_Gia SET Dang_Hoat_Dong = 0, Trang_Thai_The = N'Khóa tạm thời' WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = { new SqlParameter("@Ma", maDocGia) };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Insert(DocGiaDTO dg)
        {
            string query = @"INSERT INTO Doc_Gia (Ma_Doc_Gia, Ho_Ten, Lop, So_Dien_Thoai, Email, Ngay_Het_Han_The, So_Lan_Vi_Pham, Trang_Thai_The) 
                            VALUES (@Ma, @Ten, @Lop, @SDT, @Email, @Han, @ViPham, @TrangThai)";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", dg.Ma_Doc_Gia),
                new SqlParameter("@Ten", dg.Ho_Ten),
                new SqlParameter("@Lop", (object?)dg.Lop ?? DBNull.Value),
                new SqlParameter("@SDT", (object?)dg.So_Dien_Thoai ?? DBNull.Value),
                new SqlParameter("@Email", (object?)dg.Email ?? DBNull.Value),
                new SqlParameter("@Han", dg.Ngay_Het_Han_The),
                new SqlParameter("@ViPham", dg.So_Lan_Vi_Pham),
                new SqlParameter("@TrangThai", dg.Trang_Thai_The)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool UpdateTrangThaiThe(string maDocGia, string trangThaiMoi)
        {
            string query = "UPDATE Doc_Gia SET Trang_Thai_The = @TrangThai WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = {
                new SqlParameter("@TrangThai", trangThaiMoi),
                new SqlParameter("@Ma", maDocGia)
            };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool GiaHanThe(string maDocGia, int soNamGiaHan)
        {
            string query = "UPDATE Doc_Gia SET Ngay_Het_Han_The = DATEADD(year, @SoNam, Ngay_Het_Han_The) WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = {
                new SqlParameter("@SoNam", soNamGiaHan),
                new SqlParameter("@Ma", maDocGia)
            };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = @"SELECT Ma_Doc_Gia, Ho_Ten, Lop, So_Dien_Thoai, Email, Ngay_Tao, Ngay_Het_Han_The, So_Lan_Vi_Pham, Trang_Thai_The 
                            FROM Doc_Gia 
                            WHERE Dang_Hoat_Dong = 1 AND (Ma_Doc_Gia LIKE @Kw OR Ho_Ten LIKE @Kw OR So_Dien_Thoai LIKE @Kw)";
            SqlParameter[] pars = { new SqlParameter("@Kw", $"%{keyword}%") };
            return DatabaseHelper.ExecuteQuery(query, pars);
        }
    }
}