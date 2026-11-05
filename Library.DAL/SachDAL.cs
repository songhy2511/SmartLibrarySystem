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
    public class SachDAL
    {
        public string GetNextMaSach()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma_Sach, 2, 10) AS INT)), 0) + 1 FROM Sach";
            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNum = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 1;
            return $"B{nextNum:D4}";
        }
        public bool Delete(string maSach)
        {
            string query = "DELETE FROM Sach WHERE Ma_Sach = @Ma";
            SqlParameter[] pars = { new SqlParameter("@Ma", maSach) };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }
        public bool Insert(SachDTO sach)
        {
            string query = @"INSERT INTO Sach (Ma_Sach, Tieu_De, Tac_Gia, The_Loai, Nam_Xuat_Ban, Vi_Tri_Ke, Gia_Bia, Tong_So_Luong, So_Luong_Kha_Dung)
                            VALUES (@Ma, @TieuDe, @TacGia, @TheLoai, @NamXB, @ViTriKe, @GiaBia, @Tong, @KhaDung)";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", sach.Ma_Sach),
                new SqlParameter("@TieuDe", sach.Tieu_De),
                new SqlParameter("@TacGia", sach.Tac_Gia),
                new SqlParameter("@TheLoai", sach.The_Loai),
                new SqlParameter("@NamXB", sach.Nam_Xuat_Ban),
                new SqlParameter("@ViTriKe", sach.Vi_Tri_Ke),
                new SqlParameter("@GiaBia", sach.Gia_Bia),
                new SqlParameter("@Tong", sach.Tong_So_Luong),
                new SqlParameter("@KhaDung", sach.So_Luong_Kha_Dung)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public bool Update(SachDTO sach)
        {
            string query = @"UPDATE Sach 
                            SET Tieu_De = @TieuDe, Tac_Gia = @TacGia, The_Loai = @TheLoai, Nam_Xuat_Ban = @NamXB, 
                                Vi_Tri_Ke = @ViTriKe, Gia_Bia = @GiaBia, Tong_So_Luong = @Tong, So_Luong_Kha_Dung = @KhaDung
                            WHERE Ma_Sach = @Ma";

            SqlParameter[] pars = {
                new SqlParameter("@Ma", sach.Ma_Sach),
                new SqlParameter("@TieuDe", sach.Tieu_De),
                new SqlParameter("@TacGia", sach.Tac_Gia),
                new SqlParameter("@TheLoai", sach.The_Loai),
                new SqlParameter("@NamXB", sach.Nam_Xuat_Ban),
                new SqlParameter("@ViTriKe", sach.Vi_Tri_Ke),
                new SqlParameter("@GiaBia", sach.Gia_Bia),
                new SqlParameter("@Tong", sach.Tong_So_Luong),
                new SqlParameter("@KhaDung", sach.So_Luong_Kha_Dung)
            };

            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = @"SELECT Ma_Sach, Tieu_De, Tac_Gia, The_Loai, Nam_Xuat_Ban, Vi_Tri_Ke, Gia_Bia, Tong_So_Luong, So_Luong_Kha_Dung, So_Lan_Muon 
                            FROM Sach 
                            WHERE Ma_Sach LIKE @Kw OR Tieu_De LIKE @Kw OR Tac_Gia LIKE @Kw OR The_Loai LIKE @Kw";
            SqlParameter[] pars = { new SqlParameter("@Kw", $"%{keyword}%") };
            return DatabaseHelper.ExecuteQuery(query, pars);
        }
    }
}