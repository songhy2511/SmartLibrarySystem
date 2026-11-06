using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class SachDAL
    {
        public string GetNextMaSach()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma_Sach, 2, 10) AS INT)), 0) + 1 FROM dbo.Sach";
            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNum = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 1;
            return $"B{nextNum:D4}";
        }

        public bool Delete(string maSach)
        {
            string query = "DELETE FROM dbo.Sach WHERE Ma_Sach = @Ma";
            SqlParameter[] pars = { new SqlParameter("@Ma", maSach) };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Insert(SachDTO sach)
        {
            // Tự động tìm The_Loai_Ma_So từ tên thể loại, nếu không có lấy mặc định là 1 (CNTT)
            string query = @"
                INSERT INTO dbo.Sach 
                (Ma_Sach, Tieu_De, Tac_Gia, The_Loai_Ma_So, The_Loai, Nam_Xuat_Ban, Vi_Tri_Ke, Tong_So_Luong, So_Luong_Kha_Dung, So_Lan_Muon)
                VALUES 
                (@Ma, @TieuDe, @TacGia, 
                 ISNULL((SELECT TOP 1 Ma_So FROM dbo.The_Loai WHERE Ten_The_Loai LIKE @TheLoai), 1),
                 @TheLoai, @NamXB, @ViTriKe, @Tong, @KhaDung, 0)";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", sach.Ma_Sach),
                new SqlParameter("@TieuDe", sach.Tieu_De),
                new SqlParameter("@TacGia", sach.Tac_Gia),
                new SqlParameter("@TheLoai", string.IsNullOrWhiteSpace(sach.The_Loai) ? "Công nghệ thông tin" : sach.The_Loai),
                new SqlParameter("@NamXB", sach.Nam_Xuat_Ban),
                new SqlParameter("@ViTriKe", sach.Vi_Tri_Ke),
                new SqlParameter("@Tong", sach.Tong_So_Luong),
                new SqlParameter("@KhaDung", sach.So_Luong_Kha_Dung)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Update(SachDTO sach)
        {
            string query = @"
                UPDATE dbo.Sach 
                SET Tieu_De = @TieuDe, 
                    Tac_Gia = @TacGia, 
                    The_Loai = @TheLoai, 
                    The_Loai_Ma_So = ISNULL((SELECT TOP 1 Ma_So FROM dbo.The_Loai WHERE Ten_The_Loai LIKE @TheLoai), The_Loai_Ma_So),
                    Nam_Xuat_Ban = @NamXB, 
                    Vi_Tri_Ke = @ViTriKe, 
                    Tong_So_Luong = @Tong, 
                    So_Luong_Kha_Dung = @KhaDung
                WHERE Ma_Sach = @Ma";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", sach.Ma_Sach),
                new SqlParameter("@TieuDe", sach.Tieu_De),
                new SqlParameter("@TacGia", sach.Tac_Gia),
                new SqlParameter("@TheLoai", string.IsNullOrWhiteSpace(sach.The_Loai) ? "Công nghệ thông tin" : sach.The_Loai),
                new SqlParameter("@NamXB", sach.Nam_Xuat_Ban),
                new SqlParameter("@ViTriKe", sach.Vi_Tri_Ke),
                new SqlParameter("@Tong", sach.Tong_So_Luong),
                new SqlParameter("@KhaDung", sach.So_Luong_Kha_Dung)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public DataTable Search(string keyword)
        {
            // Loại bỏ hoàn toàn cột Gia_Bia gây lỗi
            string query = @"
                SELECT Ma_Sach, Tieu_De, Tac_Gia, The_Loai, Nam_Xuat_Ban, Vi_Tri_Ke, Tong_So_Luong, So_Luong_Kha_Dung, So_Lan_Muon, Tinh_Trang
                FROM dbo.Sach 
                WHERE Ma_Sach LIKE @Kw OR Tieu_De LIKE @Kw OR Tac_Gia LIKE @Kw OR The_Loai LIKE @Kw
                ORDER BY Ma_So DESC";

            SqlParameter[] pars = { new SqlParameter("@Kw", $"%{keyword}%") };
            return DatabaseHelper.ExecuteQuery(query, pars);
        }
    }
}