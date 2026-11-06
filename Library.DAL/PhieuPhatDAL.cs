using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class PhieuPhatDAL
    {
        public DataTable LayDanhSachPhieuPhat()
        {
            string query = @"
                SELECT 
                    pp.Ma_So AS MaBienBan,
                    dg.Ma_Doc_Gia AS MaDocGia,
                    dg.Ho_Ten AS TenDocGia,
                    pp.Ly_Do AS LyDoViPham,
                    pp.So_Tien_Phat AS SoTienPhat,
                    pp.Ngay_Lap AS NgayLap,
                    pp.Trang_Thai AS TrangThai,
                    tt.Ho_Ten AS CanBoLap
                FROM dbo.Phieu_Phat pp
                INNER JOIN dbo.Doc_Gia dg ON pp.Doc_Gia_Ma_So = dg.Ma_So
                INNER JOIN dbo.Thu_Thu tt ON pp.Thu_Thu_Ma_So = tt.Ma_So
                ORDER BY pp.Ngay_Lap DESC";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool ThemPhieuPhat(PhieuPhatDTO dto)
        {
            string query = @"
                INSERT INTO dbo.Phieu_Phat 
                (Phieu_Muon_Ma_So, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, So_Tien_Phat, Ly_Do, Ngay_Lap, Trang_Thai, Da_Thanh_Toan)
                VALUES 
                (@PhieuMuonId, @DocGiaId, @ThuThuId, @ChiNhanhId, @SoTien, @LyDo, @NgayLap, @TrangThai, @DaThanhToan)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PhieuMuonId", (object?)dto.Phieu_Muon_Ma_So ?? DBNull.Value),
                new SqlParameter("@DocGiaId", dto.Doc_Gia_Ma_So),
                new SqlParameter("@ThuThuId", dto.Thu_Thu_Ma_So),
                new SqlParameter("@ChiNhanhId", (object?)dto.Chi_Nhanh_Ma_So ?? DBNull.Value),
                new SqlParameter("@SoTien", dto.So_Tien_Phat),
                new SqlParameter("@LyDo", dto.Ly_Do),
                new SqlParameter("@NgayLap", dto.Ngay_Lap),
                new SqlParameter("@TrangThai", dto.Trang_Thai),
                new SqlParameter("@DaThanhToan", dto.Da_Thanh_Toan)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable LayDocGiaTheoMa(string maDocGia)
        {
            string query = "SELECT Ma_So, Ma_Doc_Gia, Ho_Ten FROM dbo.Doc_Gia WHERE Ma_Doc_Gia = @MaDG OR Ma_So = TRY_CAST(@MaDG AS INT)";

            // Bọc tham số vào trong một mảng new SqlParameter[]
            return DatabaseHelper.ExecuteQuery(query, new SqlParameter[]
            {
        new SqlParameter("@MaDG", maDocGia)
            });
        }
    }
}