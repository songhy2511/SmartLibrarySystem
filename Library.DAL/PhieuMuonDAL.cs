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
        private readonly string _connectionString = "Server=My_Lap_of_Quyen\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool ThemPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            string query = "INSERT INTO Phieu_Muon (Ma_Phieu, Ma_Doc_Gia, Ma_Sach, Ngay_Muon, Ngay_Hen_Han, Trang_Thai, So_Lan_Gia_Han) " +
                           "VALUES (@MaPhieu, @MaDocGia, @MaSach, @NgayMuon, @NgayHenHan, @TrangThai, @SoLanGiaHan)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieu", phieuMuon.MaPhieu);
                cmd.Parameters.AddWithValue("@MaDocGia", phieuMuon.MaDocGia);
                cmd.Parameters.AddWithValue("@MaSach", phieuMuon.MaSach);
                cmd.Parameters.AddWithValue("@NgayMuon", phieuMuon.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayHenHan", phieuMuon.NgayHenHan);
                cmd.Parameters.AddWithValue("@TrangThai", phieuMuon.TrangThai);
                cmd.Parameters.AddWithValue("@SoLanGiaHan", phieuMuon.SoLanGiaHan);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            string query = "SELECT pm.Ma_Phieu AS MaPhieu, pm.Ma_Sach AS MaSach, s.Ten_Sach AS TenSach, " +
                           "pm.Ngay_Muon AS NgayMuon, pm.Ngay_Hen_Han AS NgayHenHan, pm.Trang_Thai AS TrangThai " +
                           "FROM Phieu_Muon pm JOIN Sach s ON pm.Ma_Sach = s.Ma_Sach " +
                           "WHERE pm.Ma_Doc_Gia = @MaDocGia AND pm.Trang_Thai = N'Chưa trả'";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public bool CapNhatTraSach(string maPhieu, DateTime ngayTra, string trangThai)
        {
            string query = "UPDATE Phieu_Muon SET Ngay_Tra = @NgayTra, Trang_Thai = @TrangThai WHERE Ma_Phieu = @MaPhieu";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool GiaHanPhieu(string maPhieu, DateTime ngayHenHanMoi, int soLanGiaHanMoi)
        {
            string query = "UPDATE Phieu_Muon SET Ngay_Hen_Han = @NgayHenHanMoi, So_Lan_Gia_Han = @SoLanGiaHanMoi WHERE Ma_Phieu = @MaPhieu";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                cmd.Parameters.AddWithValue("@NgayHenHanMoi", ngayHenHanMoi);
                cmd.Parameters.AddWithValue("@SoLanGiaHanMoi", soLanGiaHanMoi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ThemBienBanViPham(PhatTienDTO bb)
        {
            string query = "INSERT INTO Phat_Tien (Ma_Bien_Ban, Ma_Doc_Gia, Loai_Vi_Pham, Mo_Ta, So_Tien_Phat, Ngay_Lap, Ngay_Hen_Nop, Trang_Thai, Can_Bo_Lap) " +
                           "VALUES (@MaBB, @MaDG, @LoaiVP, @MoTa, @SoTien, @NgayLap, @NgayNop, @TrangThai, @CanBo)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaBB", bb.MaBienBan);
                cmd.Parameters.AddWithValue("@MaDG", bb.MaDocGia);
                cmd.Parameters.AddWithValue("@LoaiVP", bb.LoaiViPham);
                cmd.Parameters.AddWithValue("@MoTa", bb.MoTa);
                cmd.Parameters.AddWithValue("@SoTien", bb.SoTienPhat);
                cmd.Parameters.AddWithValue("@NgayLap", bb.NgayLap);
                cmd.Parameters.AddWithValue("@NgayNop", bb.NgayHenNop);
                cmd.Parameters.AddWithValue("@TrangThai", bb.TrangThai);
                cmd.Parameters.AddWithValue("@CanBo", bb.CanBoLap);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}