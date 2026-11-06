USE [LibraryDB];
GO

-- =============================================
-- SP Lập biên bản vi phạm và tự động xử lý tài sản
-- =============================================
CREATE OR ALTER PROCEDURE dbo.sp_LapBienBanViPham
    @PhieuMuonMaSo INT = NULL,
    @DocGiaMaSo INT,
    @ThuThuMaSo INT,
    @ChiNhanhMaSo INT,
    @SoTienPhat DECIMAL(18,2),
    @LyDo NVARCHAR(255),
    @LoaiViPham NVARCHAR(100),
    @BanSaoMaSo INT = 0
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Tạo bản ghi phiếu phạt
        INSERT INTO dbo.Phieu_Phat 
        (Phieu_Muon_Ma_So, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, So_Tien_Phat, Ly_Do, Ngay_Lap, Trang_Thai, Da_Thanh_Toan)
        VALUES 
        (@PhieuMuonMaSo, @DocGiaMaSo, @ThuThuMaSo, @ChiNhanhMaSo, @SoTienPhat, @LyDo, GETDATE(), N'Chưa thu', 0);

        -- 2. Tăng số lần vi phạm của độc giả
        UPDATE dbo.Doc_Gia 
        SET So_Lan_Vi_Pham = ISNULL(So_Lan_Vi_Pham, 0) + 1 
        WHERE Ma_So = @DocGiaMaSo;

        -- 3. Xử lý trạng thái tài sản nếu làm mất hoặc hư hỏng nặng
        IF @LoaiViPham LIKE N'%mất%' AND @BanSaoMaSo > 0
        BEGIN
            UPDATE dbo.Ban_Sao_Sach 
            SET Trang_Thai = N'Mất/Thanh lý', Tinh_Trang = N'Đã mất', Ghi_Chu = N'Bạn đọc làm mất, đã lập biên bản bồi thường'
            WHERE Ma_So = @BanSaoMaSo;

            UPDATE dbo.Sach 
            SET Tong_So_Luong = CASE WHEN Tong_So_Luong > 0 THEN Tong_So_Luong - 1 ELSE 0 END 
            WHERE Ma_So = (SELECT Sach_Ma_So FROM dbo.Ban_Sao_Sach WHERE Ma_So = @BanSaoMaSo);
        END
        ELSE IF @LoaiViPham LIKE N'%hỏng nặng%' AND @BanSaoMaSo > 0
        BEGIN
            UPDATE dbo.Ban_Sao_Sach 
            SET Trang_Thai = N'Hư hỏng', Tinh_Trang = N'Hư hỏng nặng', Ghi_Chu = N'Bị hỏng nặng, đã lập biên bản đền bù 60%'
            WHERE Ma_So = @BanSaoMaSo;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- =============================================
-- SP Thu tiền phạt và ghi nhận quỹ đối soát ca trực
-- =============================================
CREATE OR ALTER PROCEDURE dbo.sp_ThuTienPhat
    @MaBienBan INT,
    @ThuThuMaSo INT,
    @SoTien DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE dbo.Phieu_Phat 
        SET Trang_Thai = N'Đã thu', Da_Thanh_Toan = 1 
        WHERE Ma_So = @MaBienBan;

        INSERT INTO dbo.Phat_Tien 
        (Phieu_Phat_Ma_So, Thu_Thu_Ma_So, So_Tien_Thu, Ngay_Thu, Hinh_Thuc_Thanh_Toan)
        VALUES 
        (@MaBienBan, @ThuThuMaSo, @SoTien, GETDATE(), N'Tiền mặt');

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO