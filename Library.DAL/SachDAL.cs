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

        public async Task<DataTable> TimKiemSachAsync(string tuKhoa)
        {
            string query = @"
        SELECT 
            Ma_So, Ma_Sach, Tieu_De, Tac_Gia, The_Loai,
            Nam_Xuat_Ban, Nha_Xuat_Ban, Tong_So_Luong, 
            So_Luong_Kha_Dung, So_Lan_Muon, Vi_Tri_Ke 
        FROM dbo.Sach 
        WHERE Tieu_De LIKE '%' + @TuKhoa + '%' 
           OR Tac_Gia LIKE '%' + @TuKhoa + '%' 
           OR Ma_Sach LIKE '%' + @TuKhoa + '%' 
           OR The_Loai LIKE '%' + @TuKhoa + '%'
        ORDER BY Ma_Sach ASC";

            SqlParameter[] parameters = {
        new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? "" : tuKhoa.Trim())
    };

            return await DatabaseHelper.ExecuteQueryAsync(query, parameters);
        }

        public bool ThanhLyMotCuonSach(string maSach)
        {
            string query = @"
            BEGIN TRANSACTION;
            BEGIN TRY
                -- 1. Giảm 1 tổng số lượng và 1 khả dụng ở bảng Sach
                UPDATE dbo.Sach 
                SET Tong_So_Luong = Tong_So_Luong - 1,
                    So_Luong_Kha_Dung = So_Luong_Kha_Dung - 1
                WHERE Ma_Sach = @MaSach;

                -- 2. Đổi trạng thái 1 bản sao sẵn sàng thành 'Mất/Thanh lý'
                UPDATE TOP (1) dbo.Ban_Sao_Sach
                SET Trang_Thai = N'Mất/Thanh lý',
                    Tinh_Trang = N'Hư hỏng nặng',
                    Ghi_Chu = N'Đã thanh lý do hư hỏng'
                WHERE Sach_Ma_So = (SELECT Ma_So FROM dbo.Sach WHERE Ma_Sach = @MaSach)
                  AND Trang_Thai = N'Sẵn sàng';

                COMMIT TRANSACTION;
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION;
                THROW;
            END CATCH";

            SqlParameter[] pars = { new SqlParameter("@MaSach", maSach) };
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

        public bool Delete(string maSach)
        {
            string query = "DELETE FROM Sach WHERE Ma_Sach = @Ma";
            SqlParameter[] pars = { new SqlParameter("@Ma", maSach) };
            return DatabaseHelper.ExecuteNonQuery(query, pars) > 0;
        }

        /// <summary>
        /// Lấy danh sách các bản sao sách đang có sẵn trên kệ tại một chi nhánh cụ thể
        /// </summary>
        public DataTable LayBanSaoSanCoTaiChiNhanh(string maSach, int chiNhanhId)
        {
            string query = @"
        SELECT 
            bs.Ma_So AS BanSaoMaSo,
            bs.Ma_Vach AS MaVach,
            bs.Tinh_Trang AS TinhTrang
        FROM dbo.Ban_Sao_Sach bs
        INNER JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
        WHERE s.Ma_Sach = @MaSach
          AND bs.Chi_Nhanh_Ma_So = @ChiNhanhId
          AND bs.Trang_Thai = N'Sẵn sàng'
        ORDER BY bs.Ma_Vach ASC";

            var parameters = new[]
            {
        new Microsoft.Data.SqlClient.SqlParameter("@MaSach", maSach),
        new Microsoft.Data.SqlClient.SqlParameter("@ChiNhanhId", chiNhanhId)
    };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        /// <summary>
        /// Thực hiện luân chuyển bản sao sách sang chi nhánh đích trong một giao dịch an toàn
        /// </summary>
        public bool ChuyenChiNhanhBanSao(int banSaoMaSo, int chiNhanhNguonId, int chiNhanhDichId, string ghiChu)
        {
            string query = @"
        UPDATE dbo.Ban_Sao_Sach
        SET Chi_Nhanh_Ma_So = @ChiNhanhDichId,
            Ghi_Chu = CASE 
                        WHEN @GhiChu <> '' THEN @GhiChu 
                        ELSE N'Luân chuyển từ chi nhánh #' + CAST(@ChiNhanhNguonId AS NVARCHAR) 
                      END
        WHERE Ma_So = @BanSaoMaSo AND Trang_Thai = N'Sẵn sàng'";

            var parameters = new[]
            {
        new Microsoft.Data.SqlClient.SqlParameter("@BanSaoMaSo", banSaoMaSo),
        new Microsoft.Data.SqlClient.SqlParameter("@ChiNhanhNguonId", chiNhanhNguonId),
        new Microsoft.Data.SqlClient.SqlParameter("@ChiNhanhDichId", chiNhanhDichId),
        new Microsoft.Data.SqlClient.SqlParameter("@GhiChu", string.IsNullOrWhiteSpace(ghiChu) ? "" : ghiChu.Trim())
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}