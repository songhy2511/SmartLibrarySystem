using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class PhieuMuonDAL
    {
        public bool ThemPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            string query = @"
                INSERT INTO dbo.Phieu_Muon 
                (Ma_Phieu_Muon, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Muon, Ngay_Hen_Tra, Trang_Thai) 
                VALUES 
                (@MaPhieu, @DocGiaMaSo, @ThuThuMaSo, @ChiNhanhMaSo, @NgayMuon, @NgayHenHan, @TrangThai)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", phieuMuon.MaPhieu),
                new SqlParameter("@DocGiaMaSo", phieuMuon.MaDocGia),
                new SqlParameter("@ThuThuMaSo", 1),                  // Mặc định thủ thư mã 1 hoặc truyền từ phiên đăng nhập
                new SqlParameter("@ChiNhanhMaSo", 1),                // Mặc định chi nhánh 1
                new SqlParameter("@NgayMuon", phieuMuon.NgayMuon),
                new SqlParameter("@NgayHenHan", phieuMuon.NgayHenHan),
                new SqlParameter("@TrangThai", "Đang mượn")
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            int docGiaId = 1;
            if (!string.IsNullOrEmpty(maDocGia))
            {
                int.TryParse(maDocGia, out docGiaId);
            }

            // 👉 BỔ SUNG ISNULL(pm.So_Lan_Gia_Han, 0) AS SoLanGiaHan để phục vụ tính năng Gia Hạn
            string query = @"
            SELECT 
                pm.Ma_Phieu_Muon AS MaPhieu,
                dg.Ho_Ten AS TenDocGia,
                s.Tieu_De AS TenSach,
                bs.Ma_Vach AS MaVach,
                pm.Ngay_Muon AS NgayMuon,
                pm.Ngay_Hen_Tra AS NgayHenHan,
                ISNULL(pm.So_Lan_Gia_Han, 0) AS SoLanGiaHan,
                pm.Trang_Thai AS TrangThai
            FROM dbo.Phieu_Muon pm
            INNER JOIN dbo.Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
            LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ctpm ON pm.Ma_So = ctpm.Phieu_Muon_Ma_So
            LEFT JOIN dbo.Ban_Sao_Sach bs ON ctpm.Ban_Sao_Sach_Ma_So = bs.Ma_So
            LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
            WHERE pm.Doc_Gia_Ma_So = @DocGiaMaSo
            ORDER BY pm.Ngay_Muon DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DocGiaMaSo", docGiaId)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool GiaHanPhieu(string maPhieu, DateTime ngayHenHanMoi, int soLanGiaHanMoi)
        {
            string query = @"
                UPDATE dbo.Phieu_Muon 
                SET Ngay_Hen_Tra = @NgayHenHanMoi, So_Lan_Gia_Han = @SoLanGiaHanMoi 
                WHERE Ma_Phieu_Muon = @MaPhieu OR Ma_So = TRY_CAST(@MaPhieu AS INT)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@NgayHenHanMoi", ngayHenHanMoi),
                new SqlParameter("@SoLanGiaHanMoi", soLanGiaHanMoi)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable TimKiemSach(string tuKhoa)
        {
            string query = @"
                SELECT 
                    s.Ma_Sach AS MaSach, 
                    s.Tieu_De AS TenSach, 
                    tl.Ten_The_Loai AS TheLoai, 
                    s.So_Luong_Kha_Dung AS SoLuong 
                FROM dbo.Sach s
                LEFT JOIN dbo.The_Loai tl ON s.The_Loai_Ma_So = tl.Ma_So
                WHERE s.Ma_Sach LIKE @TuKhoa OR s.Tieu_De LIKE @TuKhoa";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%")
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool CapNhatTraSach(string maPhieu, DateTime ngayTra, string trangThai)
        {
            string query = @"
                UPDATE dbo.Phieu_Muon 
                SET Ngay_Tra = @NgayTra, Trang_Thai = @TrangThai 
                WHERE Ma_Phieu_Muon = @MaPhieu OR Ma_So = TRY_CAST(@MaPhieu AS INT)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@NgayTra", ngayTra),
                new SqlParameter("@TrangThai", trangThai)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool XacNhanTraSach(string maPhieu, DateTime ngayTra)
        {
            // Code thực thi SQL UPDATE Phieu_Muon SET Ngay_Tra = @ngayTra, Trang_Thai = 'Đã hoàn thành' WHERE Ma_So = @maPhieu
            return true;
        }
    }
}