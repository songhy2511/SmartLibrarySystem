using Library.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Library.DAL
{
    public class PhieuMuonDAL
    {
        private readonly string _connectionString = "Server=My_Lap_of_Quyen\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool ThemPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            // Sửa lại tên cột khớp hoàn toàn với cấu trúc bảng Phieu_Muon trong CSDL
            string query = "INSERT INTO Phieu_Muon (Ma_Phieu_Muon, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Muon, Ngay_Hen_Tra, Trang_Thai) " +
                           "VALUES (@MaPhieu, @DocGiaMaSo, @ThuThuMaSo, @ChiNhanhMaSo, @NgayMuon, @NgayHenHan, @TrangThai)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieu", phieuMuon.MaPhieu);
                cmd.Parameters.AddWithValue("@DocGiaMaSo", phieuMuon.MaDocGia); // ID số của độc giả (Doc_Gia_Ma_So)
                cmd.Parameters.AddWithValue("@ThuThuMaSo", 1);                  // ID thủ thư đang đăng nhập (mặc định là 1 hoặc lấy từ session)
                cmd.Parameters.AddWithValue("@ChiNhanhMaSo", 1);                // ID chi nhánh thư viện (mặc định là 1)
                cmd.Parameters.AddWithValue("@NgayMuon", phieuMuon.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayHenHan", phieuMuon.NgayHenHan);
                cmd.Parameters.AddWithValue("@TrangThai", "Đang mượn");

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            // Bỏ tạm điều kiện Trang_Thai để kiểm tra xem dữ liệu có đổ vào lưới được không
            int docGiaId = 1;
            if (!string.IsNullOrEmpty(maDocGia))
            {
                // Chuyển đổi mã độc giả (hoặc ID số) thành số nguyên để khớp với cột Doc_Gia_Ma_So trong CSDL
                int.TryParse(maDocGia, out docGiaId);
            }

            string query = @"
        SELECT 
            pm.Ma_Phieu_Muon AS MaPhieu,
            dg.Ho_Ten AS TenDocGia,
            s.Tieu_De AS TenSach,
            bs.Ma_Vach AS MaVach,
            pm.Ngay_Muon AS NgayMuon,
            pm.Ngay_Hen_Tra AS NgayHenHan,
            pm.Trang_Thai AS TrangThai
        FROM Phieu_Muon pm
        INNER JOIN Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
        INNER JOIN Chi_Tiet_Phieu_Muon ctpm ON pm.Ma_So = ctpm.Phieu_Muon_Ma_So
        INNER JOIN Ban_Sao_Sach bs ON ctpm.Ban_Sao_Sach_Ma_So = bs.Ma_So
        INNER JOIN Sach s ON bs.Sach_Ma_So = s.Ma_So
        WHERE pm.Doc_Gia_Ma_So = @DocGiaMaSo";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Truyền đúng tham số ID độc giả vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@DocGiaMaSo", docGiaId);
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
        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = "SELECT Ma_Sach AS MaSach, Ten_Sach AS TenSach, The_Loai AS TheLoai, So_Luong AS SoLuong " +
                           "FROM Sach " +
                           "WHERE Ma_Sach LIKE @TuKhoa OR Ten_Sach LIKE @TuKhoa";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}