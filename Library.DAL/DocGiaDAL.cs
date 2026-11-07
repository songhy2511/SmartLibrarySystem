using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class DocGiaDAL
    {
        public string GetNextMaDocGia()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma_Doc_Gia, 3, 10) AS INT)), 0) + 1 FROM dbo.Doc_Gia";
            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNum = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 1;
            return $"DG{nextNum:D4}";
        }

        public bool Delete(string maDocGia)
        {
            // Xóa mềm: Chuyển Trang_Thai = N'Khóa tạm thời' để không mất lịch sử phiếu mượn
            string query = "UPDATE dbo.Doc_Gia SET Trang_Thai = N'Khóa tạm thời' WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = { new SqlParameter("@Ma", maDocGia) };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Insert(DocGiaDTO dg)
        {
            string query = @"
                INSERT INTO dbo.Doc_Gia 
                (Ma_Doc_Gia, Ho_Ten, So_Dien_Thoai, Email, Dia_Chi, Ngay_Cap_The, Ngay_Het_Han_The, Trang_Thai, So_Lan_Vi_Pham) 
                VALUES 
                (@Ma, @Ten, @SDT, @Email, @DiaChi, @NgayCap, @Han, @TrangThai, @ViPham)";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", dg.Ma_Doc_Gia),
                new SqlParameter("@Ten", dg.Ho_Ten),
                new SqlParameter("@SDT", (object?)dg.So_Dien_Thoai ?? DBNull.Value),
                new SqlParameter("@Email", (object?)dg.Email ?? DBNull.Value),
                new SqlParameter("@DiaChi", (object?)dg.Dia_Chi ?? "Chưa cập nhật"),
                new SqlParameter("@NgayCap", dg.Ngay_Cap_The),
                new SqlParameter("@Han", dg.Ngay_Het_Han_The),
                new SqlParameter("@TrangThai", dg.Trang_Thai),
                new SqlParameter("@ViPham", dg.So_Lan_Vi_Pham)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Update(DocGiaDTO dg)
        {
            string query = @"
        UPDATE dbo.Doc_Gia 
        SET Ho_Ten = @Ten, 
            So_Dien_Thoai = @SDT, 
            Email = @Email 
        WHERE Ma_Doc_Gia = @Ma";

            SqlParameter[] pars = {
        new SqlParameter("@Ten", dg.Ho_Ten),
        new SqlParameter("@SDT", (object?)dg.So_Dien_Thoai ?? DBNull.Value),
        new SqlParameter("@Email", (object?)dg.Email ?? DBNull.Value),
        new SqlParameter("@Ma", dg.Ma_Doc_Gia)
    };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool UpdateTrangThaiThe(string maDocGia, string trangThaiMoi)
        {
            string query = "UPDATE dbo.Doc_Gia SET Trang_Thai = @TrangThai WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = {
                new SqlParameter("@TrangThai", trangThaiMoi),
                new SqlParameter("@Ma", maDocGia)
            };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool GiaHanThe(string maDocGia, int soNamGiaHan)
        {
            string query = "UPDATE dbo.Doc_Gia SET Ngay_Het_Han_The = DATEADD(year, @SoNam, Ngay_Het_Han_The), Trang_Thai = N'Hoạt động' WHERE Ma_Doc_Gia = @Ma";
            SqlParameter[] pars = {
                new SqlParameter("@SoNam", soNamGiaHan),
                new SqlParameter("@Ma", maDocGia)
            };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = @"
                SELECT Ma_Doc_Gia, Ho_Ten, So_Dien_Thoai, Email, Dia_Chi, Ngay_Cap_The, Ngay_Het_Han_The, Trang_Thai, So_Lan_Vi_Pham 
                FROM dbo.Doc_Gia 
                WHERE Ma_Doc_Gia LIKE @Kw OR Ho_Ten LIKE @Kw OR So_Dien_Thoai LIKE @Kw
                ORDER BY Ma_So DESC";

            SqlParameter[] pars = { new SqlParameter("@Kw", $"%{keyword}%") };
            return DatabaseHelper.ExecuteQuery(query, pars);
        }
    }
}