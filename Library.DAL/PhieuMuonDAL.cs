using Library.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Library.DAL
{
    public class PhieuMuonDAL
    {
        public List<PhieuMuonDTO> LayDanhSachPhieuMuon()
        {
            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();
            string query = "SELECT Ma_Phieu_Muon, Ma_Doc_Gia, Ma_Sach, Ma_Thu_Thu, Ngay_Muon, Ngay_Het_Han, Ngay_Tra, Trang_Thai, Da_Gia_Han FROM Phieu_Muon";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PhieuMuonDTO
                    {
                        MaPhieuMuon = reader["Ma_Phieu_Muon"].ToString(),
                        MaDocGia = reader["Ma_Doc_Gia"].ToString(),
                        MaSach = reader["Ma_Sach"].ToString(),
                        MaThuThu = reader["Ma_Thu_Thu"].ToString(),
                        NgayMuon = Convert.ToDateTime(reader["Ngay_Muon"]),
                        NgayHetHan = Convert.ToDateTime(reader["Ngay_Het_Han"]),
                        NgayTra = reader["Ngay_Tra"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["Ngay_Tra"]) : null,
                        TrangThai = Convert.ToInt32(reader["Trang_Thai"]),
                        DaGiaHan = Convert.ToBoolean(reader["Da_Gia_Han"])
                    });
                }
            }
            return list;
        }

        public bool TaoPhieuMuon(PhieuMuonDTO pm)
        {
            string query = @"INSERT INTO Phieu_Muon (Ma_Phieu_Muon, Ma_Doc_Gia, Ma_Sach, Ma_Thu_Thu, Ngay_Muon, Ngay_Het_Han, Trang_Thai, Da_Gia_Han) 
                            VALUES (@MaPhieuMuon, @MaDocGia, @MaSach, @MaThuThu, @NgayMuon, @NgayHetHan, 0, 0);
                            UPDATE Sach SET So_Luong_Kha_Dung = So_Luong_Kha_Dung - 1 WHERE Ma_So = @MaSach;";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", pm.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaDocGia", pm.MaDocGia);
                cmd.Parameters.AddWithValue("@MaSach", pm.MaSach);
                cmd.Parameters.AddWithValue("@MaThuThu", pm.MaThuThu);
                cmd.Parameters.AddWithValue("@NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayHetHan", pm.NgayHetHan);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhatTraSach(string maPhieuMuon, DateTime ngayTra)
        {
            string query = @"UPDATE Phieu_Muon 
                            SET Ngay_Tra = @NgayTra, Trang_Thai = 1 
                            WHERE Ma_Phieu_Muon = @MaPhieuMuon;
                            UPDATE Sach SET So_Luong_Kha_Dung = So_Luong_Kha_Dung + 1 
                            WHERE Ma_So = (SELECT Ma_Sach FROM Phieu_Muon WHERE Ma_Phieu_Muon = @MaPhieuMuon);";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                cmd.Parameters.AddWithValue("@NgayTra", ngayTra);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int DemSoSachDangMuon(string maDocGia)
        {
            string query = "SELECT COUNT(*) FROM Phieu_Muon WHERE Ma_Doc_Gia = @MaDocGia AND Trang_Thai = 0";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
