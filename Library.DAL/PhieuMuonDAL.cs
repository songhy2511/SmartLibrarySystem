using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class PhieuMuonDAL
    {
        /// <summary>
        /// Lấy danh sách đầu sách kèm số lượng để nạp vào AutoComplete gợi ý tìm kiếm
        /// </summary>
        public DataTable LayDanhSachGoiYSach()
        {
            string query = @"
                SELECT Ma_Sach, Tieu_De, So_Luong_Kha_Dung 
                FROM dbo.Sach 
                WHERE Tong_So_Luong > 0 
                ORDER BY Tieu_De ASC";

            return DatabaseHelper.ExecuteQuery(query);
        }

        /// <summary>
        /// Kiểm tra sự tồn tại của đầu sách theo mã sách, mã vạch hoặc tên tương đối
        /// </summary>
        public bool KiemTraSachTonTai(string tuKhoa, out string tenSach, out int khaDung)
        {
            tenSach = string.Empty;
            khaDung = 0;

            string cleanKw = tuKhoa.Trim();
            if (cleanKw.Contains(" - "))
            {
                string[] parts = cleanKw.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0 && !string.IsNullOrWhiteSpace(parts[0]))
                {
                    cleanKw = parts[0].Trim();
                }
            }

            string query = @"
                SELECT TOP 1 s.Tieu_De, s.So_Luong_Kha_Dung
                FROM dbo.Sach s
                LEFT JOIN dbo.Ban_Sao_Sach bs ON s.Ma_So = bs.Sach_Ma_So
                WHERE s.Ma_Sach = @Kw 
                   OR bs.Ma_Vach = @Kw 
                   OR s.Tieu_De LIKE @KwLike
                   OR @Kw LIKE '%' + s.Ma_Sach + '%'";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Kw", cleanKw),
                new SqlParameter("@KwLike", "%" + cleanKw + "%")
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                tenSach = dt.Rows[0]["Tieu_De"].ToString() ?? "";
                khaDung = dt.Rows[0]["So_Luong_Kha_Dung"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["So_Luong_Kha_Dung"]) : 0;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tìm bản sao vật lý đang 'Sẵn sàng' theo mã vạch, mã sách hoặc tên sách tương đối
        /// </summary>
        public DataRow? TimKiemBanSaoKhaDung(string tuKhoa)
        {
            string cleanKw = tuKhoa.Trim();
            if (cleanKw.Contains(" - "))
            {
                string[] parts = cleanKw.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0 && !string.IsNullOrWhiteSpace(parts[0]))
                {
                    cleanKw = parts[0].Trim();
                }
            }

            string query = @"
                SELECT TOP 1 
                    bs.Ma_So AS BanSaoMaSo,
                    bs.Ma_Vach AS MaVach,
                    s.Ma_So AS SachMaSo,
                    s.Ma_Sach AS MaSach,
                    s.Tieu_De AS TenSach,
                    s.So_Luong_Kha_Dung AS KhaDung,
                    bs.Chi_Nhanh_Ma_So AS ChiNhanhMaSo
                FROM dbo.Ban_Sao_Sach bs
                INNER JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
                WHERE bs.Trang_Thai = N'Sẵn sàng'
                  AND (
                      bs.Ma_Vach = @Kw 
                      OR s.Ma_Sach = @Kw
                      OR s.Tieu_De LIKE @KwLike
                      OR @Kw LIKE '%' + s.Ma_Sach + '%'
                  )
                ORDER BY 
                    CASE 
                        WHEN bs.Ma_Vach = @Kw THEN 1
                        WHEN s.Ma_Sach = @Kw THEN 2
                        WHEN s.Tieu_De = @Kw THEN 3
                        ELSE 4
                    END,
                    bs.Ma_So ASC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Kw", cleanKw),
                new SqlParameter("@KwLike", "%" + cleanKw + "%")
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        /// <summary>
        /// Thực thi lập phiếu mượn, chi tiết phiếu mượn và cập nhật kho sách bằng Transaction
        /// </summary>
        public bool ThucHienMuonSach(string maPhieu, int docGiaMaSo, int thuThuMaSo, int chiNhanhMaSo,
                                     DateTime ngayMuon, DateTime ngayHenHan, int banSaoMaSo, int sachMaSo)
        {
            string query = @"
                BEGIN TRANSACTION;
                BEGIN TRY
                    -- 1. Tạo phiếu mượn tổng
                    INSERT INTO dbo.Phieu_Muon 
                    (Ma_Phieu_Muon, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Muon, Ngay_Hen_Tra, Trang_Thai, So_Lan_Gia_Han) 
                    VALUES 
                    (@MaPhieu, @DocGiaMaSo, @ThuThuMaSo, @ChiNhanhMaSo, @NgayMuon, @NgayHenHan, N'Đang mượn', 0);

                    DECLARE @NewPhieuId INT = SCOPE_IDENTITY();

                    -- 2. Gán chi tiết cuốn sách vào phiếu
                    INSERT INTO dbo.Chi_Tiet_Phieu_Muon
                    (Phieu_Muon_Ma_So, Ban_Sao_Sach_Ma_So, Tien_Phat)
                    VALUES
                    (@NewPhieuId, @BanSaoMaSo, 0);

                    -- 3. Cập nhật bản sao vật lý sang 'Đang cho mượn'
                    UPDATE dbo.Ban_Sao_Sach
                    SET Trang_Thai = N'Đang cho mượn'
                    WHERE Ma_So = @BanSaoMaSo;

                    -- 4. Trừ 1 số lượng khả dụng và tăng lượt mượn của đầu sách
                    UPDATE dbo.Sach
                    SET So_Luong_Kha_Dung = CASE WHEN So_Luong_Kha_Dung > 0 THEN So_Luong_Kha_Dung - 1 ELSE 0 END,
                        So_Lan_Muon = So_Lan_Muon + 1
                    WHERE Ma_So = @SachMaSo;

                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    THROW;
                END CATCH";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@DocGiaMaSo", docGiaMaSo),
                new SqlParameter("@ThuThuMaSo", thuThuMaSo),
                new SqlParameter("@ChiNhanhMaSo", chiNhanhMaSo),
                new SqlParameter("@NgayMuon", ngayMuon),
                new SqlParameter("@NgayHenHan", ngayHenHan),
                new SqlParameter("@BanSaoMaSo", banSaoMaSo),
                new SqlParameter("@SachMaSo", sachMaSo)
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

            string query = @"
            SELECT 
                pm.Ma_Phieu_Muon AS MaPhieu,
                dg.Ho_Ten AS TenDocGia,
                ISNULL(s.Tieu_De, N'Chưa liên kết sách') AS TenSach,
                ISNULL(bs.Ma_Vach, '--') AS MaVach,
                pm.Ngay_Muon AS NgayMuon,
                pm.Ngay_Hen_Tra AS NgayHenHan,
                ISNULL(pm.So_Lan_Gia_Han, 0) AS SoLanGiaHan,
                pm.Trang_Thai AS TrangThai
            FROM dbo.Phieu_Muon pm
            INNER JOIN dbo.Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
            LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ctpm ON pm.Ma_So = ctpm.Phieu_Muon_Ma_So
            LEFT JOIN dbo.Ban_Sao_Sach bs ON ctpm.Ban_Sao_Sach_Ma_So = bs.Ma_So
            LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
            WHERE pm.Doc_Gia_Ma_So = @DocGiaMaSo AND pm.Trang_Thai = N'Đang mượn'
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

        public bool CapNhatTraSach(string maPhieu, DateTime ngayTra, string trangThai)
        {
            string query = @"
                BEGIN TRANSACTION;
                BEGIN TRY
                    DECLARE @PhieuMaSo INT;
                    SELECT @PhieuMaSo = Ma_So 
                    FROM dbo.Phieu_Muon 
                    WHERE Ma_Phieu_Muon = @MaPhieu OR Ma_So = TRY_CAST(@MaPhieu AS INT);

                    IF @PhieuMaSo IS NOT NULL
                    BEGIN
                        -- 1. Cập nhật phiếu mượn
                        UPDATE dbo.Phieu_Muon 
                        SET Ngay_Tra = @NgayTra, Trang_Thai = @TrangThai 
                        WHERE Ma_So = @PhieuMaSo;

                        -- 2. Cập nhật ngày trả thực tế trong chi tiết
                        UPDATE dbo.Chi_Tiet_Phieu_Muon
                        SET Ngay_Tra_Thuc_Te = @NgayTra
                        WHERE Phieu_Muon_Ma_So = @PhieuMaSo;

                        -- 3. Trả lại trạng thái 'Sẵn sàng' cho bản sao vật lý
                        UPDATE dbo.Ban_Sao_Sach
                        SET Trang_Thai = N'Sẵn sàng'
                        WHERE Ma_So IN (SELECT Ban_Sao_Sach_Ma_So FROM dbo.Chi_Tiet_Phieu_Muon WHERE Phieu_Muon_Ma_So = @PhieuMaSo);

                        -- 4. Tăng lại 1 số lượng khả dụng cho đầu sách
                        UPDATE dbo.Sach
                        SET So_Luong_Kha_Dung = CASE WHEN So_Luong_Kha_Dung < Tong_So_Luong THEN So_Luong_Kha_Dung + 1 ELSE Tong_So_Luong END
                        WHERE Ma_So IN (
                            SELECT bs.Sach_Ma_So 
                            FROM dbo.Chi_Tiet_Phieu_Muon ct
                            INNER JOIN dbo.Ban_Sao_Sach bs ON ct.Ban_Sao_Sach_Ma_So = bs.Ma_So
                            WHERE ct.Phieu_Muon_Ma_So = @PhieuMaSo
                        );
                    END

                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    THROW;
                END CATCH";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@NgayTra", ngayTra),
                new SqlParameter("@TrangThai", trangThai)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Truy vấn danh sách mượn sách mở rộng: hỗ trợ xem tất cả độc giả, lọc quá hạn, tính số ngày mượn/trễ và lấy SĐT liên hệ
        /// </summary>
        public DataTable LayDanhSachDangMuonNangCao(int docGiaMaSo = 0, bool chiQuaHan = false, string tuKhoa = "")
        {
            string query = @"
        SELECT 
            pm.Ma_So AS PhieuMaSo,
            pm.Ma_Phieu_Muon AS MaPhieu,
            dg.Ma_So AS DocGiaMaSo,
            dg.Ma_Doc_Gia AS MaDocGia,
            dg.Ho_Ten AS TenDocGia,
            ISNULL(dg.So_Dien_Thoai, N'--') AS SoDienThoai,
            ISNULL(s.Tieu_De, N'Chưa liên kết sách') AS TenSach,
            ISNULL(bs.Ma_Vach, N'--') AS MaVach,
            pm.Ngay_Muon AS NgayMuon,
            pm.Ngay_Hen_Tra AS NgayHenHan,
            DATEDIFF(DAY, pm.Ngay_Muon, GETDATE()) AS SoNgayDaMuon,
            DATEDIFF(DAY, pm.Ngay_Hen_Tra, CAST(GETDATE() AS DATE)) AS SoNgayTre,
            DATEDIFF(DAY, CAST(GETDATE() AS DATE), pm.Ngay_Hen_Tra) AS SoNgayConLai,
            ISNULL(pm.So_Lan_Gia_Han, 0) AS SoLanGiaHan,
            pm.Trang_Thai AS TrangThai
        FROM dbo.Phieu_Muon pm
        INNER JOIN dbo.Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
        LEFT JOIN dbo.Chi_Tiet_Phieu_Muon ctpm ON pm.Ma_So = ctpm.Phieu_Muon_Ma_So
        LEFT JOIN dbo.Ban_Sao_Sach bs ON ctpm.Ban_Sao_Sach_Ma_So = bs.Ma_So
        LEFT JOIN dbo.Sach s ON bs.Sach_Ma_So = s.Ma_So
        WHERE pm.Trang_Thai = N'Đang mượn'
          AND (@DocGiaMaSo = 0 OR dg.Ma_So = @DocGiaMaSo)
          AND (@ChiQuaHan = 0 OR pm.Ngay_Hen_Tra < CAST(GETDATE() AS DATE))
          AND (@TuKhoa = '' 
               OR dg.Ho_Ten LIKE '%' + @TuKhoa + '%' 
               OR dg.Ma_Doc_Gia LIKE '%' + @TuKhoa + '%' 
               OR s.Tieu_De LIKE '%' + @TuKhoa + '%'
               OR bs.Ma_Vach LIKE '%' + @TuKhoa + '%')
        ORDER BY 
            CASE WHEN pm.Ngay_Hen_Tra < CAST(GETDATE() AS DATE) THEN 0 ELSE 1 END,
            pm.Ngay_Hen_Tra ASC,
            pm.Ngay_Muon DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DocGiaMaSo", docGiaMaSo),
        new SqlParameter("@ChiQuaHan", chiQuaHan ? 1 : 0),
        new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? "" : tuKhoa.Trim())
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        /// <summary>
        /// Cập nhật nhanh số điện thoại liên hệ của độc giả trực tiếp từ bàn lưu thông
        /// </summary>
        public bool CapNhatSoDienThoaiDocGia(int docGiaMaSo, string soDienThoai)
        {
            string query = "UPDATE dbo.Doc_Gia SET So_Dien_Thoai = @SDT WHERE Ma_So = @MaSo";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaSo", docGiaMaSo),
        new SqlParameter("@SDT", soDienThoai.Trim())
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Sinh mã phiếu mượn tự tăng theo định dạng BR + yyMMdd + 3 chữ số (BR261107001)
        /// </summary>
        public string GetNextMaPhieuMuon()
        {
            string prefix = "BR" + DateTime.Now.ToString("yyMMdd");
            string query = "SELECT MAX(Ma_Phieu_Muon) FROM dbo.Phieu_Muon WHERE Ma_Phieu_Muon LIKE @Prefix + '%'";

            var pars = new[] { new Microsoft.Data.SqlClient.SqlParameter("@Prefix", prefix) };
            object? result = DatabaseHelper.ExecuteScalar(query, pars);

            int nextIndex = 1;
            if (result != null && result != DBNull.Value)
            {
                string maxCode = result.ToString()!;
                if (maxCode.Length >= prefix.Length + 3 && int.TryParse(maxCode.Substring(prefix.Length), out int currentNum))
                {
                    nextIndex = currentNum + 1;
                }
            }
            return $"{prefix}{nextIndex:D3}";
        }
    }
}