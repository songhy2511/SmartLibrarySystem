-- ============================================================================
-- DỰ ÁN: SMART LIBRARY MANAGEMENT SYSTEM
-- TẬP TIN: LibraryDB.sql
-- MÔ TẢ: Khởi tạo toàn bộ Database, thiết lập bảng và nạp dữ liệu mẫu hoàn chỉnh
-- PHIÊN BẢN: 2.0 (Chuẩn PBKDF2-HMAC-SHA256, Đầy đủ ràng buộc và dữ liệu đối soát)
-- ============================================================================

USE [master];
GO

-- 1. Giải phóng kết nối đang mở và tạo mới Database
IF DB_ID('LibraryDB') IS NOT NULL
BEGIN
    ALTER DATABASE [LibraryDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [LibraryDB];
END
GO

CREATE DATABASE [LibraryDB] COLLATE Vietnamese_CI_AS;
GO

USE [LibraryDB];
GO

-- ============================================================================
-- PHẦN I: KHỞI TẠO CẤU TRÚC BẢNG (TABLE SCHEMAS)
-- ============================================================================

-- 1. Bảng Cấu hình tham số quy chế hệ thống
CREATE TABLE [dbo].[Cau_Hinh_He_Thong] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ten_Tham_So] VARCHAR(50) NOT NULL UNIQUE,
    [Gia_Tri] NVARCHAR(100) NOT NULL,
    [Mo_Ta] NVARCHAR(255) NULL
);
GO

-- 2. Bảng Tài khoản người dùng (Bảo mật PBKDF2 100.000 vòng lặp)
CREATE TABLE [dbo].[Nguoi_Dung] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ten_Dang_Nhap] NVARCHAR(50) NOT NULL UNIQUE,
    [Mat_Khau_Ma_Hoa] NVARCHAR(128) NOT NULL,
    [Chuoi_Muoi] NVARCHAR(64) NOT NULL,
    [Vai_Tro] NVARCHAR(20) NOT NULL CHECK ([Vai_Tro] IN ('Admin', 'Librarian')),
    [Dang_Hoat_Dong] BIT NOT NULL DEFAULT 1,
    [Ngay_Tao] DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- 3. Bảng Chi nhánh thư viện
CREATE TABLE [dbo].[Chi_Nhanh] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ma_Chi_Nhanh] VARCHAR(20) NOT NULL UNIQUE,
    [Ten_Chi_Nhanh] NVARCHAR(150) NOT NULL,
    [Dia_Chi] NVARCHAR(255) NULL,
    [So_Dien_Thoai] VARCHAR(15) NULL,
    [Dang_Hoat_Dong] BIT NOT NULL DEFAULT 1,
    [Ngay_Tao] DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- 4. Bảng Hồ sơ Thủ thư
CREATE TABLE [dbo].[Thu_Thu] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Nguoi_Dung_Ma_So] INT NOT NULL UNIQUE,
    [Ma_Thu_Thu] VARCHAR(20) NOT NULL UNIQUE,
    [Ho_Ten] NVARCHAR(100) NOT NULL,
    [So_Dien_Thoai] VARCHAR(15) NULL,
    [Email] VARCHAR(100) NULL,
    [Quay_Phu_Trach] NVARCHAR(100) NULL,
    [Ngay_Vao_Lam] DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_ThuThu_NguoiDung] FOREIGN KEY ([Nguoi_Dung_Ma_So]) 
        REFERENCES [dbo].[Nguoi_Dung]([Ma_So]) ON DELETE CASCADE
);
GO

-- 5. Bảng Phân ca trực và Quản lý dòng tiền
CREATE TABLE [dbo].[Ca_Truc] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Thu_Thu_Ma_So] INT NOT NULL,
    [Chi_Nhanh_Ma_So] INT NOT NULL,
    [Ngay_Truc] DATE NOT NULL,
    [Ten_Ca] NVARCHAR(50) NOT NULL,
    [Gio_Bat_Dau] TIME NOT NULL,
    [Gio_Ket_Thuc] TIME NOT NULL,
    [Tien_Mat_Dau_Ca] DECIMAL(18,2) NOT NULL DEFAULT 0,
    [Tien_Mat_Cuoi_Ca] DECIMAL(18,2) NULL,
    [Tien_Dau_Ca] DECIMAL(18,2) NOT NULL DEFAULT 0,
    [Tien_Ket_Ca] DECIMAL(18,2) NULL,
    [Trang_Thai] NVARCHAR(50) NOT NULL DEFAULT N'Chưa trực',
    [Ghi_Chu] NVARCHAR(255) NULL,
    [Ngay_Tao] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_CaTruc_ThuThu] FOREIGN KEY ([Thu_Thu_Ma_So]) 
        REFERENCES [dbo].[Thu_Thu]([Ma_So]),
    CONSTRAINT [FK_CaTruc_ChiNhanh] FOREIGN KEY ([Chi_Nhanh_Ma_So]) 
        REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- 6. Bảng Thể loại sách
CREATE TABLE [dbo].[The_Loai] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ma_The_Loai] VARCHAR(20) NOT NULL UNIQUE,
    [Ten_The_Loai] NVARCHAR(100) NOT NULL,
    [Mo_Ta] NVARCHAR(255) NULL
);
GO

-- 7. Bảng Đầu sách (Danh mục sách)
CREATE TABLE [dbo].[Sach] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ma_Sach] VARCHAR(20) NOT NULL UNIQUE,
    [Tieu_De] NVARCHAR(200) NOT NULL,
    [Tac_Gia] NVARCHAR(150) NOT NULL,
    [The_Loai_Ma_So] INT NOT NULL,
    [The_Loai] NVARCHAR(100) NULL,
    [Nam_Xuat_Ban] INT NULL,
    [Nha_Xuat_Ban] NVARCHAR(150) NULL,
    [Tong_So_Luong] INT NOT NULL DEFAULT 0,
    [So_Luong_Kha_Dung] INT NOT NULL DEFAULT 0,
    [So_Lan_Muon] INT NOT NULL DEFAULT 0,
    [Vi_Tri_Day] NVARCHAR(50) NULL,
    [Vi_Tri_Ke] NVARCHAR(50) NULL,
    [Vi_Tri_Tang] NVARCHAR(50) NULL,
    [Tinh_Trang] NVARCHAR(50) NOT NULL DEFAULT N'Bình thường',
    CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY ([The_Loai_Ma_So]) 
        REFERENCES [dbo].[The_Loai]([Ma_So]),
    CONSTRAINT [CK_Sach_SoLuong] CHECK ([So_Luong_Kha_Dung] <= [Tong_So_Luong] AND [So_Luong_Kha_Dung] >= 0)
);
GO

-- 8. Bảng Bản sao sách vật lý (Từng cuốn có mã vạch riêng)
CREATE TABLE [dbo].[Ban_Sao_Sach] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Sach_Ma_So] INT NOT NULL,
    [Chi_Nhanh_Ma_So] INT NOT NULL,
    [Ma_Vach] VARCHAR(50) NOT NULL UNIQUE,
    [Trang_Thai] NVARCHAR(50) NOT NULL DEFAULT N'Sẵn sàng' 
        CHECK ([Trang_Thai] IN (N'Sẵn sàng', N'Đang cho mượn', N'Hư hỏng', N'Mất/Thanh lý')),
    [Tinh_Trang] NVARCHAR(50) NOT NULL DEFAULT N'Bình thường',
    [Ghi_Chu] NVARCHAR(255) NULL,
    CONSTRAINT [FK_BanSao_Sach] FOREIGN KEY ([Sach_Ma_So]) 
        REFERENCES [dbo].[Sach]([Ma_So]) ON DELETE CASCADE,
    CONSTRAINT [FK_BanSao_ChiNhanh] FOREIGN KEY ([Chi_Nhanh_Ma_So]) 
        REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- 9. Bảng Bạn đọc / Độc giả
CREATE TABLE [dbo].[Doc_Gia] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ma_Doc_Gia] VARCHAR(20) NOT NULL UNIQUE,
    [Ho_Ten] NVARCHAR(100) NOT NULL,
    [So_Dien_Thoai] VARCHAR(15) NULL,
    [Email] VARCHAR(100) NULL,
    [Dia_Chi] NVARCHAR(255) NULL,
    [Ngay_Cap_The] DATE NOT NULL DEFAULT GETDATE(),
    [Ngay_Het_Han_The] DATE NOT NULL,
    [Trang_Thai] NVARCHAR(50) NOT NULL DEFAULT N'Hoạt động'
        CHECK ([Trang_Thai] IN (N'Hoạt động', N'Khóa tạm thời', N'Hết hạn')),
    [So_Lan_Vi_Pham] INT NOT NULL DEFAULT 0
);
GO

-- 10. Bảng Phiếu mượn sách
CREATE TABLE [dbo].[Phieu_Muon] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Ma_Phieu_Muon] VARCHAR(20) NOT NULL UNIQUE,
    [Doc_Gia_Ma_So] INT NOT NULL,
    [Thu_Thu_Ma_So] INT NOT NULL,
    [Chi_Nhanh_Ma_So] INT NOT NULL,
    [Ngay_Muon] DATETIME NOT NULL DEFAULT GETDATE(),
    [Ngay_Hen_Tra] DATETIME NOT NULL,
    [Trang_Thai] NVARCHAR(50) NOT NULL DEFAULT N'Đang mượn'
        CHECK ([Trang_Thai] IN (N'Đang mượn', N'Đã hoàn thành', N'Quá hạn')),
    [Ghi_Chu] NVARCHAR(255) NULL,
    [Ngay_Tao] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY ([Doc_Gia_Ma_So]) 
        REFERENCES [dbo].[Doc_Gia]([Ma_So]),
    CONSTRAINT [FK_PhieuMuon_ThuThu] FOREIGN KEY ([Thu_Thu_Ma_So]) 
        REFERENCES [dbo].[Thu_Thu]([Ma_So]),
    CONSTRAINT [FK_PhieuMuon_ChiNhanh] FOREIGN KEY ([Chi_Nhanh_Ma_So]) 
        REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- 11. Bảng Chi tiết phiếu mượn
CREATE TABLE [dbo].[Chi_Tiet_Phieu_Muon] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Phieu_Muon_Ma_So] INT NOT NULL,
    [Ban_Sao_Sach_Ma_So] INT NOT NULL,
    [Ngay_Tra_Thuc_Te] DATETIME NULL,
    [Tinh_Trang_Khi_Tra] NVARCHAR(100) NULL,
    [Tien_Phat] DECIMAL(18,2) NOT NULL DEFAULT 0,
    CONSTRAINT [FK_ChiTiet_PhieuMuon] FOREIGN KEY ([Phieu_Muon_Ma_So]) 
        REFERENCES [dbo].[Phieu_Muon]([Ma_So]) ON DELETE CASCADE,
    CONSTRAINT [FK_ChiTiet_BanSao] FOREIGN KEY ([Ban_Sao_Sach_Ma_So]) 
        REFERENCES [dbo].[Ban_Sao_Sach]([Ma_So])
);
GO

-- 12. Bảng Phiếu phạt vi phạm
CREATE TABLE [dbo].[Phieu_Phat] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Phieu_Muon_Ma_So] INT NULL,
    [Doc_Gia_Ma_So] INT NOT NULL,
    [Thu_Thu_Ma_So] INT NOT NULL,
    [Chi_Nhanh_Ma_So] INT NULL,
    [So_Tien_Phat] DECIMAL(18,2) NOT NULL,
    [Ly_Do] NVARCHAR(255) NOT NULL,
    [Ngay_Lap] DATETIME NOT NULL DEFAULT GETDATE(),
    [Trang_Thai] NVARCHAR(50) NOT NULL DEFAULT N'Chưa thu'
        CHECK ([Trang_Thai] IN (N'Chưa thu', N'Đã thu')),
    [Da_Thanh_Toan] BIT NOT NULL DEFAULT 0,
    [Ngay_Tao] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_PhieuPhat_PhieuMuon] FOREIGN KEY ([Phieu_Muon_Ma_So]) 
        REFERENCES [dbo].[Phieu_Muon]([Ma_So]),
    CONSTRAINT [FK_PhieuPhat_DocGia] FOREIGN KEY ([Doc_Gia_Ma_So]) 
        REFERENCES [dbo].[Doc_Gia]([Ma_So]),
    CONSTRAINT [FK_PhieuPhat_ThuThu] FOREIGN KEY ([Thu_Thu_Ma_So]) 
        REFERENCES [dbo].[Thu_Thu]([Ma_So]),
    CONSTRAINT [FK_PhieuPhat_ChiNhanh] FOREIGN KEY ([Chi_Nhanh_Ma_So]) 
        REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- 13. Bảng Biên lai thu tiền phạt
CREATE TABLE [dbo].[Phat_Tien] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Phieu_Phat_Ma_So] INT NOT NULL,
    [Thu_Thu_Ma_So] INT NOT NULL,
    [So_Tien_Thu] DECIMAL(18,2) NOT NULL,
    [Ngay_Thu] DATETIME NOT NULL DEFAULT GETDATE(),
    [Hinh_Thuc_Thanh_Toan] NVARCHAR(50) NOT NULL DEFAULT N'Tiền mặt',
    CONSTRAINT [FK_PhatTien_PhieuPhat] FOREIGN KEY ([Phieu_Phat_Ma_So]) 
        REFERENCES [dbo].[Phieu_Phat]([Ma_So]),
    CONSTRAINT [FK_PhatTien_ThuThu] FOREIGN KEY ([Thu_Thu_Ma_So]) 
        REFERENCES [dbo].[Thu_Thu]([Ma_So])
);
GO

-- 14. Bảng Nhật ký kiểm toán hệ thống (Audit Logs)
CREATE TABLE [dbo].[Nhat_Ky_He_Thong] (
    [Ma_So] INT IDENTITY(1,1) PRIMARY KEY,
    [Nguoi_Dung_Ma_So] INT NULL,
    [Thoi_Gian] DATETIME NOT NULL DEFAULT GETDATE(),
    [Muc_Do] NVARCHAR(20) NOT NULL CHECK ([Muc_Do] IN ('INFO', 'WARNING', 'ERROR', 'SECURITY')),
    [Hanh_Dong] NVARCHAR(100) NOT NULL,
    [Chi_Tiet] NVARCHAR(MAX) NULL,
    [Dia_Chi_IP] VARCHAR(50) NULL DEFAULT '127.0.0.1',
    CONSTRAINT [FK_NhatKy_NguoiDung] FOREIGN KEY ([Nguoi_Dung_Ma_So]) 
        REFERENCES [dbo].[Nguoi_Dung]([Ma_So]) ON DELETE SET NULL
);
GO

-- ============================================================================
-- PHẦN II: NẠP DỮ LIỆU KHỞI TẠO (SEED DATA)
-- ============================================================================

-- A. Quy chế hệ thống mặc định
INSERT INTO [dbo].[Cau_Hinh_He_Thong] ([Ten_Tham_So], [Gia_Tri], [Mo_Ta]) VALUES
('So_Sach_Muon_Toi_Da', '5', N'Số lượng tài liệu độc giả được mượn cùng lúc'),
('So_Ngay_Muon_Toi_Da', '14', N'Thời gian mượn tối đa cho mỗi lượt (ngày)'),
('Tien_Phat_Moi_Ngay', '5000', N'Tiền phạt quá hạn mỗi cuốn trên mỗi ngày trễ (VNĐ)'),
('Thoi_Han_The_Thang', '48', N'Thời hạn hiệu lực mặc định của thẻ độc giả (tháng)');
GO

-- B. Tài khoản Người dùng & Hồ sơ Thủ thư (PBKDF2-HMAC-SHA256 chuẩn)
DECLARE @SaltAdmin VARCHAR(64) = 'q3Z8vX1mK9pL2oW5yR7tEw==';
DECLARE @SaltTT    VARCHAR(64) = 'a1B2c3D4e5F6g7H8i9J0kL==';

-- 1. Tài khoản Quản trị viên (Mật khẩu: Admin@123)
INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('admin', '03FC1949AB5D0389D245EAC6834C156273213A780EB92A922CA04EAC0BE8636E', @SaltAdmin, 'Admin', 1, GETDATE());

-- 2. Tài khoản Thủ thư 1 (Mật khẩu: Librarian@2026!)
INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('thuthu1', 'DF978233A0C6131B80D26D45D9C9BFB2D81760E9DFB81599CA8D58BD71DE3D21', @SaltTT, 'Librarian', 1, GETDATE());
DECLARE @UID_TT1 INT = SCOPE_IDENTITY();

-- 3. Tài khoản Thủ thư 2 (Mật khẩu: Librarian@2026!)
INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('thuthu2', 'DF978233A0C6131B80D26D45D9C9BFB2D81760E9DFB81599CA8D58BD71DE3D21', @SaltTT, 'Librarian', 1, GETDATE());
DECLARE @UID_TT2 INT = SCOPE_IDENTITY();

-- 4. Tạo hồ sơ Thủ thư liên kết
INSERT INTO [dbo].[Thu_Thu] ([Nguoi_Dung_Ma_So], [Ma_Thu_Thu], [Ho_Ten], [So_Dien_Thoai], [Email], [Quay_Phu_Trach], [Ngay_Vao_Lam]) VALUES
(@UID_TT1, 'TT001', N'Lê Minh Tuấn', '0903123456', 'tuan.lm@smartlibrary.vn', N'Quầy Mượn - Trả số 1', '2025-01-15'),
(@UID_TT2, 'TT002', N'Nguyễn Thu Hà', '0908765432', 'ha.nt@smartlibrary.vn', N'Quầy Lưu Thông số 2', '2025-03-20');
GO

-- C. Danh mục Chi nhánh
INSERT INTO [dbo].[Chi_Nhanh] ([Ma_Chi_Nhanh], [Ten_Chi_Nhanh], [Dia_Chi], [So_Dien_Thoai], [Dang_Hoat_Dong], [Ngay_Tao]) VALUES
('CN01', N'Thư viện Trung Tâm', N'Số 01 Võ Văn Ngân, TP. Thủ Đức', '02838968641', 1, '2025-01-01'),
('CN02', N'Chi nhánh Thư viện Trẻ', N'Số 120 Điện Biên Phủ, Quận 1', '02838221456', 1, '2025-02-15'),
('CN03', N'Chi nhánh Khu Công Nghệ', N'Khu Công nghệ cao, TP. Thủ Đức', '02839998888', 1, '2025-04-10');
GO

-- D. Danh mục Thể loại sách
INSERT INTO [dbo].[The_Loai] ([Ma_The_Loai], [Ten_The_Loai], [Mo_Ta]) VALUES
('TL01', N'Công nghệ thông tin', N'Sách lập trình, kiến trúc hệ thống, an ninh mạng và AI'),
('TL02', N'Kinh tế & Quản trị', N'Sách kinh doanh, quản trị tài chính, khởi nghiệp và marketing'),
('TL03', N'Văn học nghệ thuật', N'Tiểu thuyết, truyện ngắn, tác phẩm văn học trong nước và quốc tế'),
('TL04', N'Khoa học xã hội', N'Tâm lý học, lịch sử, nhân chủng học và văn hóa xã hội');
GO

-- E. Dữ liệu Đầu sách phong phú
INSERT INTO [dbo].[Sach] 
([Ma_Sach], [Tieu_De], [Tac_Gia], [The_Loai_Ma_So], [The_Loai], [Nam_Xuat_Ban], [Nha_Xuat_Ban], [Tong_So_Luong], [So_Luong_Kha_Dung], [So_Lan_Muon], [Vi_Tri_Day], [Vi_Tri_Ke], [Vi_Tri_Tang], [Tinh_Trang])
VALUES
-- CNTT
('B0001', N'Clean Code - Mã Sạch', N'Robert C. Martin', 1, N'Công nghệ thông tin', 2020, N'NXB Thông Tin & Truyền Thông', 5, 4, 15, N'Dãy A', N'Kệ 01', N'Tầng 2', N'Bình thường'),
('B0002', N'Design Patterns Explained', N'Alan Shalloway', 1, N'Công nghệ thông tin', 2019, N'NXB Khoa Học & Kỹ Thuật', 3, 3, 8, N'Dãy A', N'Kệ 02', N'Tầng 2', N'Bình thường'),
('B0005', N'Lập trình C# 12 và .NET 8', N'Mark J. Price', 1, N'Công nghệ thông tin', 2024, N'NXB Thông Tin & Truyền Thông', 8, 7, 15, N'Dãy A', N'Kệ 01', N'Tầng 2', N'Bình thường'),
('B0006', N'Refactoring - Cải tiến mã hiện có', N'Martin Fowler', 1, N'Công nghệ thông tin', 2021, N'NXB Khoa Học & Kỹ Thuật', 5, 4, 18, N'Dãy A', N'Kệ 02', N'Tầng 2', N'Bảo trì'),
('B0007', N'Designing Data-Intensive Applications', N'Martin Kleppmann', 1, N'Công nghệ thông tin', 2023, N'NXB Bách Khoa', 6, 6, 9, N'Dãy A', N'Kệ 03', N'Tầng 2', N'Bình thường'),
('B0008', N'Nhập môn Trí tuệ nhân tạo & ML', N'Stuart Russell', 1, N'Công nghệ thông tin', 2022, N'NXB Đại Học Quốc Gia', 7, 5, 22, N'Dãy A', N'Kệ 04', N'Tầng 2', N'Bình thường'),

-- Kinh tế & Quản trị
('B0009', N'Khởi nghiệp tinh gọn (The Lean Startup)', N'Eric Ries', 2, N'Kinh tế & Quản trị', 2020, N'NXB Trẻ', 10, 8, 34, N'Dãy B', N'Kệ 01', N'Tầng 1', N'Bình thường'),
('B0010', N'Nhà đầu tư thông minh', N'Benjamin Graham', 2, N'Kinh tế & Quản trị', 2021, N'NXB Lao Động Xã Hội', 8, 6, 27, N'Dãy B', N'Kệ 02', N'Tầng 1', N'Bình thường'),
('B0011', N'Kinh tế học hài hước (Freakonomics)', N'Steven D. Levitt', 2, N'Kinh tế & Quản trị', 2019, N'NXB Thế Giới', 5, 5, 12, N'Dãy B', N'Kệ 03', N'Tầng 1', N'Bình thường'),

-- Văn học nghệ thuật
('B0003', N'Đắc Nhân Tâm', N'Dale Carnegie', 3, N'Văn học nghệ thuật', 2021, N'NXB Tổng Hợp TP.HCM', 10, 9, 45, N'Dãy C', N'Kệ 01', N'Tầng 1', N'Bình thường'),
('B0004', N'Kính Vạn Hoa', N'Nguyễn Nhật Ánh', 3, N'Văn học nghệ thuật', 2022, N'NXB Kim Đồng', 6, 5, 20, N'Dãy C', N'Kệ 02', N'Tầng 1', N'Bình thường'),
('B0012', N'Mắt Biếc', N'Nguyễn Nhật Ánh', 3, N'Văn học nghệ thuật', 2021, N'NXB Trẻ', 12, 10, 52, N'Dãy C', N'Kệ 01', N'Tầng 1', N'Bình thường'),
('B0013', N'Cho Tôi Xin Một Vé Đi Tuổi Thơ', N'Nguyễn Nhật Ánh', 3, N'Văn học nghệ thuật', 2022, N'NXB Trẻ', 9, 7, 41, N'Dãy C', N'Kệ 01', N'Tầng 1', N'Bình thường'),
('B0014', N'Rừng Na Uy', N'Haruki Murakami', 3, N'Văn học nghệ thuật', 2020, N'NXB Hội Nhà Văn', 6, 5, 30, N'Dãy C', N'Kệ 02', N'Tầng 1', N'Bình thường'),
('B0015', N'Nhà Giả Kim (The Alchemist)', N'Paulo Coelho', 3, N'Văn học nghệ thuật', 2023, N'NXB Phụ Nữ', 15, 12, 85, N'Dãy C', N'Kệ 03', N'Tầng 1', N'Bình thường'),

-- Khoa học xã hội & Tâm lý
('B0016', N'Tư Duy Nhanh Và Chậm', N'Daniel Kahneman', 4, N'Khoa học xã hội', 2021, N'NXB Thế Giới', 8, 7, 39, N'Dãy D', N'Kệ 01', N'Tầng 3', N'Bình thường'),
('B0017', N'Tâm Lý Học Tội Phạm', N'Stanton E. Samenow', 4, N'Khoa học xã hội', 2022, N'NXB Công An Nhân Dân', 5, 4, 16, N'Dãy D', N'Kệ 02', N'Tầng 3', N'Bình thường'),
('B0018', N'Sapiens: Lược Sử Loài Người', N'Yuval Noah Harari', 4, N'Khoa học xã hội', 2023, N'NXB Tri Thức', 10, 8, 64, N'Dãy D', N'Kệ 03', N'Tầng 3', N'Bình thường');
GO

-- F. Dữ liệu Bản sao sách vật lý
INSERT INTO [dbo].[Ban_Sao_Sach] ([Sach_Ma_So], [Chi_Nhanh_Ma_So], [Ma_Vach], [Trang_Thai], [Tinh_Trang], [Ghi_Chu]) VALUES
(1, 1, 'BC-B0001-01', N'Sẵn sàng', N'Bình thường', N'Sách mới 100%'),
(1, 1, 'BC-B0001-02', N'Đang cho mượn', N'Bình thường', N'Độc giả đang mượn'),
(1, 2, 'BC-B0001-03', N'Sẵn sàng', N'Bình thường', N'Bản lưu trữ CN2'),
(2, 1, 'BC-B0002-01', N'Sẵn sàng', N'Bình thường', N'Nguyên vẹn'),
(3, 1, 'BC-B0005-01', N'Sẵn sàng', N'Bình thường', N'Sách mới nhập'),
(3, 1, 'BC-B0005-02', N'Đang cho mượn', N'Bình thường', N'Lưu hành quầy 1'),
(4, 1, 'BC-B0006-01', N'Sẵn sàng', N'Bảo trì', N'Gáy sách bị sờn, đang bảo quản'),
(4, 2, 'BC-B0006-02', N'Đang cho mượn', N'Bình thường', N'Chuyển về CN Trẻ'),
(5, 1, 'BC-B0007-01', N'Sẵn sàng', N'Bình thường', N'Kho chính'),
(6, 1, 'BC-B0008-01', N'Sẵn sàng', N'Bình thường', N'Kho chính'),
(7, 1, 'BC-B0009-01', N'Sẵn sàng', N'Bình thường', N'Kho chính'),
(7, 3, 'BC-B0009-02', N'Đang cho mượn', N'Bình thường', N'CN Khu Công Nghệ'),
(10, 1, 'BC-B0003-01', N'Đang cho mượn', N'Bình thường', N'Phiếu mượn quá hạn'),
(11, 1, 'BC-B0004-01', N'Sẵn sàng', N'Bảo trì', N'Rách trang phụ, chờ dán'),
(12, 1, 'BC-B0012-01', N'Sẵn sàng', N'Bình thường', N'Ấn bản bìa mềm'),
(15, 1, 'BC-B0015-01', N'Sẵn sàng', N'Bình thường', N'Tái bản kỷ niệm');
GO

-- G. Dữ liệu Độc giả đầy đủ trạng thái
INSERT INTO [dbo].[Doc_Gia] 
([Ma_Doc_Gia], [Ho_Ten], [So_Dien_Thoai], [Email], [Dia_Chi], [Ngay_Cap_The], [Ngay_Het_Han_The], [Trang_Thai], [So_Lan_Vi_Pham])
VALUES
('DG0001', N'Trần Văn An', '0912345678', 'an.tran@gmail.com', N'Phước Hải, Bà Rịa - Vũng Tàu', '2024-01-01', '2028-01-01', N'Hoạt động', 0),
('DG0002', N'Nguyễn Thị Mai', '0987654321', 'mai.nguyen@gmail.com', N'Thủ Đức, TP. Hồ Chí Minh', '2024-03-15', '2028-03-15', N'Hoạt động', 0),
('DG0003', N'Lê Hoàng Phúc', '0933221100', 'phuc.le@gmail.com', N'Quận 1, TP. Hồ Chí Minh', '2023-05-10', '2027-05-10', N'Hoạt động', 3),
('DG0004', N'Phạm Song Hỷ', '0937123999', 'songhy@student.edu.vn', N'Bà Rịa - Vũng Tàu', '2024-09-01', '2028-09-01', N'Hoạt động', 0),
('DG0005', N'Đỗ Quốc Bảo', '0909456781', 'bao.do@gmail.com', N'P. Linh Trung, TP. Thủ Đức', '2024-02-10', '2028-02-10', N'Hoạt động', 0),
('DG0006', N'Hoàng Thị Bích Ngọc', '0918776655', 'bichngoc.hoang@gmail.com', N'Bình Thạnh, TP. Hồ Chí Minh', '2023-11-20', '2027-11-20', N'Hoạt động', 1),
('DG0007', N'Vũ Đình Khang', '0988112233', 'khang.vu@outlook.com', N'Dĩ An, Bình Dương', '2022-05-15', '2026-05-15', N'Hoạt động', 0),
('DG0008', N'Bùi Phương Thảo', '0977445566', 'thao.bui@gmail.com', N'Quận 3, TP. Hồ Chí Minh', '2024-04-05', '2028-04-05', N'Hoạt động', 0),
('DG0009', N'Đặng Thế Hân', '0903889900', 'han.dang@smartlibrary.vn', N'Số 01 Võ Văn Ngân, Thủ Đức', '2023-01-01', '2027-01-01', N'Hoạt động', 0),
('DG0010', N'Ngô Gia Khiêm', '0945667788', 'khiem.ngo@gmail.com', N'Biên Hòa, Đồng Nai', '2021-08-10', '2025-08-10', N'Hết hạn', 2),
('DG0011', N'Lê Quốc Cường', '0932114477', 'cuong.le@yahoo.com', N'Tân Phú, TP. Hồ Chí Minh', '2023-09-12', '2027-09-12', N'Khóa tạm thời', 4);
GO

-- H. Dữ liệu Phân ca trực và Quản lý tiền mặt
INSERT INTO [dbo].[Ca_Truc]
([Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Truc], [Ten_Ca], [Gio_Bat_Dau], [Gio_Ket_Thuc], [Tien_Mat_Dau_Ca], [Tien_Mat_Cuoi_Ca], [Tien_Dau_Ca], [Tien_Ket_Ca], [Trang_Thai], [Ghi_Chu], [Ngay_Tao])
VALUES
-- Ca hôm qua
(1, 1, DATEADD(DAY, -1, CAST(GETDATE() AS DATE)), N'Ca Sáng (07:30 - 12:00)', '07:30', '12:00', 500000, 560000, 500000, 560000, N'Đã hoàn thành', N'Bàn giao đủ tiền mặt và biên lai', DATEADD(DAY, -2, GETDATE())),
(2, 1, DATEADD(DAY, -1, CAST(GETDATE() AS DATE)), N'Ca Chiều (12:30 - 17:00)', '12:30', '17:00', 500000, 520000, 500000, 520000, N'Đã hoàn thành', N'Không có sự cố phát sinh', DATEADD(DAY, -2, GETDATE())),

-- Ca hôm nay
(1, 1, CAST(GETDATE() AS DATE), N'Ca Sáng (07:30 - 12:00)', '07:30', '12:00', 500000, 500000, 500000, 500000, N'Đang trực', N'Đang phục vụ độc giả tại quầy', DATEADD(DAY, -1, GETDATE())),
(2, 2, CAST(GETDATE() AS DATE), N'Ca Chiều (12:30 - 17:00)', '12:30', '17:00', 300000, NULL, 300000, NULL, N'Chưa trực', N'Phụ trách chi nhánh Trẻ', DATEADD(DAY, -1, GETDATE())),

-- Ca ngày mai & ngày mốt
(1, 1, DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), N'Ca Sáng (07:30 - 12:00)', '07:30', '12:00', 500000, NULL, 500000, NULL, N'Chưa trực', N'Trực quầy mượn trả trung tâm', GETDATE()),
(2, 1, DATEADD(DAY, 1, CAST(GETDATE() AS DATE)), N'Ca Chiều (12:30 - 17:00)', '12:30', '17:00', 500000, NULL, 500000, NULL, N'Chưa trực', N'Kiểm kê kho sách tầng 2', GETDATE()),
(1, 3, DATEADD(DAY, 2, CAST(GETDATE() AS DATE)), N'Ca Chiều (12:30 - 17:00)', '12:30', '17:00', 300000, NULL, 300000, NULL, N'Chưa trực', N'Tăng cường cho CN Khu Công Nghệ', GETDATE());
GO

-- I. Dữ liệu Lưu thông Mượn - Trả sách
-- Phiếu mượn 1: Đã hoàn thành (mượn tuần trước, đã trả đúng hạn)
INSERT INTO [dbo].[Phieu_Muon] ([Ma_Phieu_Muon], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Muon], [Ngay_Hen_Tra], [Trang_Thai], [Ghi_Chu], [Ngay_Tao])
VALUES ('BR0001', 1, 1, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, 4, GETDATE()), N'Đã hoàn thành', N'Độc giả trả sách đúng hẹn', DATEADD(DAY, -10, GETDATE()));
DECLARE @PM1 INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[Chi_Tiet_Phieu_Muon] ([Phieu_Muon_Ma_So], [Ban_Sao_Sach_Ma_So], [Ngay_Tra_Thuc_Te], [Tinh_Trang_Khi_Tra], [Tien_Phat])
VALUES (@PM1, 1, DATEADD(DAY, -2, GETDATE()), N'Bình thường', 0);

-- Phiếu mượn 2: Đang mượn (còn hạn)
INSERT INTO [dbo].[Phieu_Muon] ([Ma_Phieu_Muon], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Muon], [Ngay_Hen_Tra], [Trang_Thai], [Ghi_Chu], [Ngay_Tao])
VALUES ('BR0002', 2, 1, 1, DATEADD(DAY, -3, GETDATE()), DATEADD(DAY, 11, GETDATE()), N'Đang mượn', N'Mượn phục vụ nghiên cứu', DATEADD(DAY, -3, GETDATE()));
DECLARE @PM2 INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[Chi_Tiet_Phieu_Muon] ([Phieu_Muon_Ma_So], [Ban_Sao_Sach_Ma_So], [Ngay_Tra_Thuc_Te], [Tinh_Trang_Khi_Tra], [Tien_Phat])
VALUES (@PM2, 6, NULL, NULL, 0);

-- Phiếu mượn 3: Quá hạn (mượn 20 ngày trước, hạn 14 ngày)
INSERT INTO [dbo].[Phieu_Muon] ([Ma_Phieu_Muon], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Muon], [Ngay_Hen_Tra], [Trang_Thai], [Ghi_Chu], [Ngay_Tao])
VALUES ('BR0003', 3, 2, 1, DATEADD(DAY, -20, GETDATE()), DATEADD(DAY, -6, GETDATE()), N'Quá hạn', N'Quá hạn 6 ngày chưa thấy trả', DATEADD(DAY, -20, GETDATE()));
DECLARE @PM3 INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[Chi_Tiet_Phieu_Muon] ([Phieu_Muon_Ma_So], [Ban_Sao_Sach_Ma_So], [Ngay_Tra_Thuc_Te], [Tinh_Trang_Khi_Tra], [Tien_Phat])
VALUES (@PM3, 13, NULL, NULL, 30000);
GO

-- J. Dữ liệu Vi phạm & Thu tiền phạt
-- Phiếu phạt 1: Quá hạn đã thanh toán
INSERT INTO [dbo].[Phieu_Phat] ([Phieu_Muon_Ma_So], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [So_Tien_Phat], [Ly_Do], [Ngay_Lap], [Trang_Thai], [Da_Thanh_Toan], [Ngay_Tao])
VALUES (1, 1, 1, 1, 20000, N'Trả sách trễ 4 ngày', DATEADD(DAY, -2, GETDATE()), N'Đã thu', 1, DATEADD(DAY, -2, GETDATE()));
DECLARE @PP1 INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[Phat_Tien] ([Phieu_Phat_Ma_So], [Thu_Thu_Ma_So], [So_Tien_Thu], [Ngay_Thu], [Hinh_Thuc_Thanh_Toan])
VALUES (@PP1, 1, 20000, DATEADD(DAY, -2, GETDATE()), N'Tiền mặt');

-- Phiếu phạt 2: Rách mục lục sách (chưa thu)
INSERT INTO [dbo].[Phieu_Phat] ([Phieu_Muon_Ma_So], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [So_Tien_Phat], [Ly_Do], [Ngay_Lap], [Trang_Thai], [Da_Thanh_Toan], [Ngay_Tao])
VALUES (NULL, 3, 2, 1, 50000, N'Làm ướt và rách trang mục lục sách Kính Vạn Hoa', DATEADD(DAY, -1, GETDATE()), N'Chưa thu', 0, DATEADD(DAY, -1, GETDATE()));
GO

-- K. Dữ liệu Nhật ký hệ thống phong phú
INSERT INTO [dbo].[Nhat_Ky_He_Thong] ([Nguoi_Dung_Ma_So], [Thoi_Gian], [Muc_Do], [Hanh_Dong], [Chi_Tiet], [Dia_Chi_IP])
VALUES
(1, DATEADD(MINUTE, -120, GETDATE()), 'SECURITY', N'Đăng nhập hệ thống', N'Quản trị viên đăng nhập thành công vào trang quản trị.', '192.168.1.105'),
(1, DATEADD(MINUTE, -110, GETDATE()), 'INFO', N'Cập nhật quy chế', N'Thay đổi thời hạn thẻ độc giả thành 48 tháng.', '192.168.1.105'),
(1, DATEADD(MINUTE, -95, GETDATE()), 'INFO', N'Phân ca trực', N'Phân bổ ca trực sáng và chiều cho thủ thư Lê Minh Tuấn tại Thư viện Trung Tâm.', '192.168.1.105'),
(2, DATEADD(MINUTE, -60, GETDATE()), 'SECURITY', N'Đăng nhập hệ thống', N'Thủ thư Lê Minh Tuấn đăng nhập phiên làm việc ca sáng.', '192.168.1.120'),
(2, DATEADD(MINUTE, -45, GETDATE()), 'INFO', N'Lập phiếu mượn', N'Tạo thành công phiếu mượn mã BR0002 cho bạn đọc Nguyễn Thị Mai (DG0002).', '192.168.1.120'),
(2, DATEADD(MINUTE, -30, GETDATE()), 'INFO', N'Thu tiền phạt', N'Thu thành công 20.000 VNĐ tiền phạt quá hạn của độc giả Trần Văn An (Phiếu thu PT001).', '192.168.1.120'),
(3, DATEADD(MINUTE, -15, GETDATE()), 'WARNING', N'Cảnh báo quá hạn', N'Hệ thống phát hiện phiếu mượn BR0003 của độc giả Lê Hoàng Phúc quá hạn 6 ngày.', '127.0.0.1'),
(1, DATEADD(MINUTE, -5, GETDATE()), 'INFO', N'Đồng bộ kho', N'Kiểm tra và nạp bổ sung danh mục 18 đầu sách và bản sao vào hệ thống.', '127.0.0.1');
GO

