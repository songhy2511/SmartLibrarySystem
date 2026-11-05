USE [master];
GO

-- 1. TẠO MỚI CƠ SỞ DỮ LIỆU
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'LibraryDB')
BEGIN
    ALTER DATABASE [LibraryDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [LibraryDB];
END
GO

CREATE DATABASE [LibraryDB];
GO

USE [LibraryDB];
GO

-- ============================================================================
-- 2. TẠO TOÀN BỘ CẤU TRÚC BẢNG (SCHEMA)
-- ============================================================================

-- Bảng Người Dùng
CREATE TABLE [dbo].[Nguoi_Dung](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ten_Dang_Nhap] [nvarchar](50) NOT NULL UNIQUE,
	[Mat_Khau_Ma_Hoa] [nvarchar](128) NOT NULL,
	[Chuoi_Muoi] [nvarchar](64) NOT NULL,
	[Vai_Tro] [nvarchar](20) NOT NULL CHECK ([Vai_Tro] IN ('Admin', 'Librarian')),
	[Dang_Hoat_Dong] [bit] NOT NULL DEFAULT (1),
	[Ngay_Tao] [datetime] NOT NULL DEFAULT (GETDATE())
);
GO

-- Bảng Chi Nhánh
CREATE TABLE [dbo].[Chi_Nhanh](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ma_Chi_Nhanh] [varchar](20) NOT NULL UNIQUE,
	[Ten_Chi_Nhanh] [nvarchar](100) NOT NULL,
	[Dia_Chi] [nvarchar](255) NOT NULL,
	[So_Dien_Thoai] [varchar](20) NULL,
	[Dang_Hoat_Dong] [bit] NOT NULL DEFAULT (1),
	[Ngay_Tao] [datetime] NULL DEFAULT (GETDATE())
);
GO

-- Bảng Thủ Thư
CREATE TABLE [dbo].[Thu_Thu](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nguoi_Dung_Ma_So] [int] NOT NULL UNIQUE,
	[Ma_Thu_Thu] [nvarchar](20) NOT NULL UNIQUE,
	[Ho_Ten] [nvarchar](100) NOT NULL,
	[So_Dien_Thoai] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[Quay_Phu_Trach] [nvarchar](50) NOT NULL DEFAULT (N'Quầy Mượn - Trả số 1'),
	[Ngay_Vao_Lam] [date] NOT NULL DEFAULT (GETDATE()),
	FOREIGN KEY ([Nguoi_Dung_Ma_So]) REFERENCES [dbo].[Nguoi_Dung]([Ma_So]) ON DELETE CASCADE
);
GO

-- Bảng Độc Giả
CREATE TABLE [dbo].[Doc_Gia](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ma_Doc_Gia] [nvarchar](20) NOT NULL UNIQUE,
	[Ho_Ten] [nvarchar](100) NOT NULL,
	[Lop] [nvarchar](50) NULL,
	[So_Dien_Thoai] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[Ngay_Het_Han_The] [date] NOT NULL DEFAULT (DATEADD(YEAR, 4, GETDATE())),
	[So_Lan_Vi_Pham] [int] NOT NULL DEFAULT (0),
	[Trang_Thai_The] [nvarchar](30) NOT NULL DEFAULT (N'Hoạt động') CHECK ([Trang_Thai_The] IN (N'Hoạt động', N'Khóa tạm thời', N'Hết hạn')),
	[Ngay_Tao] [datetime] NOT NULL DEFAULT (GETDATE()),
	[Dang_Hoat_Dong] [bit] NOT NULL DEFAULT (1)
);
GO

-- Bảng Đầu Sách
CREATE TABLE [dbo].[Sach](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ma_Sach] [nvarchar](20) NOT NULL UNIQUE,
	[Tieu_De] [nvarchar](200) NOT NULL,
	[Tac_Gia] [nvarchar](100) NOT NULL,
	[The_Loai] [nvarchar](50) NOT NULL,
	[Nam_Xuat_Ban] [int] NOT NULL CHECK ([Nam_Xuat_Ban] BETWEEN 1900 AND 2100),
	[Vi_Tri_Ke] [nvarchar](50) NOT NULL DEFAULT (N'Kệ A-01'),
	[Gia_Bia] [decimal](18, 0) NOT NULL DEFAULT (50000),
	[Tong_So_Luong] [int] NOT NULL DEFAULT (1) CHECK ([Tong_So_Luong] >= 0),
	[So_Luong_Kha_Dung] [int] NOT NULL DEFAULT (1) CHECK ([So_Luong_Kha_Dung] >= 0),
	[So_Lan_Muon] [int] NOT NULL DEFAULT (0),
	[Ngay_Tao] [datetime] NOT NULL DEFAULT (GETDATE()),
	CONSTRAINT [CK_Sach_SoLuong] CHECK ([So_Luong_Kha_Dung] <= [Tong_So_Luong])
);
GO

-- Bảng Bản Sao Sách (Tồn kho từng chi nhánh)
CREATE TABLE [dbo].[Ban_Sao_Sach](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Sach_Ma_So] [int] NOT NULL,
	[Chi_Nhanh_Ma_So] [int] NOT NULL,
	[Ma_Vach] [varchar](50) NOT NULL UNIQUE,
	[Tinh_Trang] [nvarchar](50) NOT NULL DEFAULT (N'Còn tốt'),
	[Trang_Thai] [nvarchar](50) NOT NULL DEFAULT (N'Sẵn sàng'),
	FOREIGN KEY ([Sach_Ma_So]) REFERENCES [dbo].[Sach]([Ma_So]),
	FOREIGN KEY ([Chi_Nhanh_Ma_So]) REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- Bảng Phiếu Mượn
CREATE TABLE [dbo].[Phieu_Muon](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ma_Phieu] [varchar](20) NOT NULL UNIQUE,
	[Doc_Gia_Ma_So] [int] NOT NULL,
	[Thu_Thu_Ma_So] [int] NOT NULL,
	[Chi_Nhanh_Ma_So] [int] NOT NULL,
	[Ngay_Muon] [datetime] NOT NULL DEFAULT (GETDATE()),
	[Ngay_Hen_Tra] [datetime] NOT NULL,
	[Trang_Thai] [nvarchar](50) NOT NULL DEFAULT (N'Đang mượn'),
	[Ghi_Chu] [nvarchar](500) NULL,
	FOREIGN KEY ([Doc_Gia_Ma_So]) REFERENCES [dbo].[Doc_Gia]([Ma_So]),
	FOREIGN KEY ([Thu_Thu_Ma_So]) REFERENCES [dbo].[Thu_Thu]([Ma_So]),
	FOREIGN KEY ([Chi_Nhanh_Ma_So]) REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- Bảng Chi Tiết Phiếu Mượn
CREATE TABLE [dbo].[Chi_Tiet_Phieu_Muon](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Phieu_Muon_Ma_So] [int] NOT NULL,
	[Ban_Sao_Sach_Ma_So] [int] NOT NULL,
	[Ngay_Tra_Thuc_Te] [datetime] NULL,
	[Tinh_Trang_Khi_Tra] [nvarchar](100) NULL,
	[Tien_Phat] [decimal](18, 2) NOT NULL DEFAULT (0),
	FOREIGN KEY ([Phieu_Muon_Ma_So]) REFERENCES [dbo].[Phieu_Muon]([Ma_So]) ON DELETE CASCADE,
	FOREIGN KEY ([Ban_Sao_Sach_Ma_So]) REFERENCES [dbo].[Ban_Sao_Sach]([Ma_So])
);
GO

-- Bảng Ca Trực & Đối Soát Quỹ
CREATE TABLE [dbo].[Ca_Truc](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Thu_Thu_Ma_So] [int] NOT NULL,
	[Chi_Nhanh_Ma_So] [int] NOT NULL DEFAULT (1),
	[Ngay_Truc] [date] NOT NULL,
	[Ten_Ca] [nvarchar](30) NOT NULL,
	[Gio_Bat_Dau] [time](7) NOT NULL DEFAULT ('07:30:00'),
	[Gio_Ket_Thuc] [time](7) NOT NULL DEFAULT ('12:00:00'),
	[Tong_Tien_Thu] [decimal](18, 0) NOT NULL DEFAULT (0),
	[Tien_Dau_Ca] [decimal](18, 2) NOT NULL DEFAULT (0),
	[Tien_Ket_Ca] [decimal](18, 2) NULL,
	[Trang_Thai] [nvarchar](30) NOT NULL DEFAULT (N'Chưa bắt đầu') CHECK ([Trang_Thai] IN (N'Chưa bắt đầu', N'Đang trực', N'Đã chốt ca', N'Đã kết thúc', N'Vắng mặt')),
	[Ghi_Chu] [nvarchar](255) NULL,
	FOREIGN KEY ([Thu_Thu_Ma_So]) REFERENCES [dbo].[Thu_Thu]([Ma_So]),
	FOREIGN KEY ([Chi_Nhanh_Ma_So]) REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- Bảng Phiếu Phạt
CREATE TABLE [dbo].[Phieu_Phat](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ma_Phieu_Phat] [varchar](20) NOT NULL UNIQUE,
	[Phieu_Muon_Ma_So] [int] NULL,
	[Doc_Gia_Ma_So] [int] NOT NULL,
	[Thu_Thu_Ma_So] [int] NOT NULL,
	[Chi_Nhanh_Ma_So] [int] NOT NULL,
	[Ly_Do] [nvarchar](255) NOT NULL,
	[So_Tien_Phat] [decimal](18, 2) NOT NULL,
	[Da_Thanh_Toan] [bit] NOT NULL DEFAULT (0),
	[Ngay_Tao] [datetime] NOT NULL DEFAULT (GETDATE()),
	FOREIGN KEY ([Phieu_Muon_Ma_So]) REFERENCES [dbo].[Phieu_Muon]([Ma_So]),
	FOREIGN KEY ([Doc_Gia_Ma_So]) REFERENCES [dbo].[Doc_Gia]([Ma_So]),
	FOREIGN KEY ([Thu_Thu_Ma_So]) REFERENCES [dbo].[Thu_Thu]([Ma_So]),
	FOREIGN KEY ([Chi_Nhanh_Ma_So]) REFERENCES [dbo].[Chi_Nhanh]([Ma_So])
);
GO

-- Bảng Cấu Hình Tham Số Động
CREATE TABLE [dbo].[Cau_Hinh_He_Thong](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Ten_Tham_So] [varchar](50) NOT NULL UNIQUE,
	[Gia_Tri] [nvarchar](200) NOT NULL,
	[Mo_Ta] [nvarchar](255) NULL
);
GO

-- Bảng Nhật Ký Kiểm Toán Hoạt Động Hệ Thống
CREATE TABLE [dbo].[Nhat_Ky_He_Thong](
	[Ma_So] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nguoi_Dung_Ma_So] [int] NULL,
	[Hanh_Dong] [nvarchar](100) NOT NULL,
	[Chi_Tiet] [nvarchar](max) NULL,
	[Thoi_Gian] [datetime] NOT NULL DEFAULT (GETDATE()),
	[Dia_Chi_IP] [varchar](50) NULL,
	[Muc_Do] [nvarchar](20) NOT NULL DEFAULT (N'INFO'),
	FOREIGN KEY ([Nguoi_Dung_Ma_So]) REFERENCES [dbo].[Nguoi_Dung]([Ma_So]) ON DELETE SET NULL
);
GO

-- ============================================================================
-- 3. NẠP DỮ LIỆU SEED CHUẨN (TÀI KHOẢN, QUY CHẾ, CHI NHÁNH, KHO SÁCH)
-- ============================================================================

-- A. Cấu hình quy chế mặc định
INSERT INTO [dbo].[Cau_Hinh_He_Thong] ([Ten_Tham_So], [Gia_Tri], [Mo_Ta]) VALUES
('So_Sach_Muon_Toi_Da', '5', N'Số lượng tài liệu độc giả được mượn cùng lúc'),
('So_Ngay_Muon_Toi_Da', '14', N'Thời gian mượn tối đa cho mỗi lượt (ngày)'),
('Tien_Phat_Moi_Ngay', '5000', N'Tiền phạt quá hạn mỗi cuốn trên mỗi ngày trễ (VNĐ)'),
('Thoi_Han_The_Thang', '12', N'Thời hạn hiệu lực của thẻ độc giả (tháng)');
GO

-- B. Tài khoản Admin & Thủ thư (Mật khẩu băm SHA-256 + Salt chuẩn)
-- Mật khẩu tài khoản admin: Admin@123
DECLARE @SaltAdmin VARCHAR(64) = 'Salt_Admin_2026_Secure_Key==';
DECLARE @HashAdmin VARCHAR(128) = UPPER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin@123' + @SaltAdmin), 2));

INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('admin', @HashAdmin, @SaltAdmin, 'Admin', 1, GETDATE());

-- Mật khẩu các thủ thư: Librarian@123
DECLARE @SaltTT1 VARCHAR(64) = 'Salt_TT001_Key_Lib2026==';
DECLARE @HashTT1 VARCHAR(128) = UPPER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Librarian@123' + @SaltTT1), 2));
INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('thuthu1', @HashTT1, @SaltTT1, 'Librarian', 1, GETDATE());
DECLARE @UID_TT1 INT = SCOPE_IDENTITY();

DECLARE @SaltTT2 VARCHAR(64) = 'Salt_TT002_Key_Lib2026==';
DECLARE @HashTT2 VARCHAR(128) = UPPER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Librarian@123' + @SaltTT2), 2));
INSERT INTO [dbo].[Nguoi_Dung] ([Ten_Dang_Nhap], [Mat_Khau_Ma_Hoa], [Chuoi_Muoi], [Vai_Tro], [Dang_Hoat_Dong], [Ngay_Tao])
VALUES ('thuthu2', @HashTT2, @SaltTT2, 'Librarian', 1, GETDATE());
DECLARE @UID_TT2 INT = SCOPE_IDENTITY();

-- C. Danh mục Chi Nhánh
INSERT INTO [dbo].[Chi_Nhanh] ([Ma_Chi_Nhanh], [Ten_Chi_Nhanh], [Dia_Chi], [So_Dien_Thoai], [Dang_Hoat_Dong]) VALUES
('CN01', N'Thư viện Trung Tâm', N'Số 01 Võ Văn Ngân, TP. Thủ Đức', '02838968641', 1),
('CN02', N'Chi nhánh Thư viện Trẻ', N'Số 120 Điện Biên Phủ, Quận 1', '02838221456', 1),
('CN03', N'Chi nhánh Khu Công Nghệ', N'Khu Công nghệ cao, TP. Thủ Đức', '02839998888', 1),
('CN04', N'Chi nhánh Nam Sài Gòn', N'Đại lộ Nguyễn Văn Linh, Quận 7', '02837776666', 1);

-- D. Hồ sơ Thủ Thư
INSERT INTO [dbo].[Thu_Thu] ([Nguoi_Dung_Ma_So], [Ma_Thu_Thu], [Ho_Ten], [So_Dien_Thoai], [Email], [Quay_Phu_Trach], [Ngay_Vao_Lam]) VALUES
(@UID_TT1, 'TT001', N'Lê Minh Tuấn', '0903123456', 'tuan.lm@smartlibrary.vn', N'Quầy Mượn - Trả số 1', '2025-01-15'),
(@UID_TT2, 'TT002', N'Nguyễn Thu Hà', '0908765432', 'ha.nt@smartlibrary.vn', N'Quầy Lưu Thông số 2', '2025-03-20');

-- E. Hồ sơ Độc Giả
INSERT INTO [dbo].[Doc_Gia] ([Ma_Doc_Gia], [Ho_Ten], [Lop], [So_Dien_Thoai], [Email], [Ngay_Het_Han_The], [Trang_Thai_The]) VALUES
('DG0001', N'Trần Bảo Nam', N'22DTH01', '0912111222', 'nam.tb@student.edu.vn', DATEADD(YEAR, 3, GETDATE()), N'Hoạt động'),
('DG0002', N'Võ Hoàng Yến', N'22DTH02', '0912333444', 'yen.vh@student.edu.vn', DATEADD(YEAR, 3, GETDATE()), N'Hoạt động'),
('DG0003', N'Phạm Song Toàn', N'23DTH01', '0912555666', 'toan.ps@student.edu.vn', DATEADD(YEAR, 4, GETDATE()), N'Hoạt động');

-- F. Danh mục Đầu Sách
INSERT INTO [dbo].[Sach] ([Ma_Sach], [Tieu_De], [Tac_Gia], [The_Loai], [Nam_Xuat_Ban], [Vi_Tri_Ke], [Gia_Bia], [Tong_So_Luong], [So_Luong_Kha_Dung], [So_Lan_Muon]) VALUES
('B0101', N'Kỹ Thuật Lập Trình C# Hiện Đại', N'Nguyễn Văn Hoài', N'Công nghệ thông tin', 2024, N'Kệ A1-01', 125000, 4, 2, 12),
('B0102', N'Giải Tích Đại Cương 1', N'Đại học Bách Khoa', N'Toán học cơ bản', 2023, N'Kệ B1-03', 75000, 3, 3, 5),
('B0103', N'Thiết Kế Kiến Trúc Phần Mềm C# & .NET', N'Robert C. Martin', N'Công nghệ thông tin', 2023, N'Kệ A1-02', 185000, 3, 2, 8),
('B0104', N'Cơ Sở Dữ Liệu SQL Server Chuyên Sâu', N'Itzik Ben-Gan', N'Công nghệ thông tin', 2022, N'Kệ A1-03', 210000, 3, 2, 15),
('B0105', N'Nhập Môn Trí Tuệ Nhân Tạo & ML', N'Stuart Russell', N'Khoa học máy tính', 2024, N'Kệ B2-01', 250000, 3, 1, 20),
('B0106', N'Kính Vạn Hoa (Trọn Bộ Tuyển Tập)', N'Nguyễn Nhật Ánh', N'Văn học thiếu nhi', 2021, N'Kệ C3-05', 320000, 3, 2, 35);

-- G. Bản Sao Sách phân bổ các Chi Nhánh
INSERT INTO [dbo].[Ban_Sao_Sach] ([Sach_Ma_So], [Chi_Nhanh_Ma_So], [Ma_Vach], [Tinh_Trang], [Trang_Thai]) VALUES
(1, 1, 'BC-S101-01', N'Còn tốt', N'Sẵn sàng'),
(1, 1, 'BC-S101-02', N'Còn tốt', N'Đang cho mượn'),
(1, 2, 'BC-S101-03', N'Còn tốt', N'Đang cho mượn'),
(1, 3, 'BC-S101-04', N'Mới 100%', N'Sẵn sàng'),
(2, 1, 'BC-S102-01', N'Còn tốt', N'Sẵn sàng'),
(2, 2, 'BC-S102-02', N'Còn tốt', N'Sẵn sàng'),
(2, 4, 'BC-S102-03', N'Còn tốt', N'Sẵn sàng'),
(3, 1, 'BC-S103-01', N'Còn tốt', N'Sẵn sàng'),
(3, 2, 'BC-S103-02', N'Còn tốt', N'Đang cho mượn'),
(3, 3, 'BC-S103-03', N'Còn tốt', N'Sẵn sàng'),
(4, 1, 'BC-S104-01', N'Còn tốt', N'Đang cho mượn'),
(4, 3, 'BC-S104-02', N'Còn tốt', N'Sẵn sàng'),
(4, 4, 'BC-S104-03', N'Còn tốt', N'Sẵn sàng'),
(5, 1, 'BC-S105-01', N'Còn tốt', N'Đang cho mượn'),
(5, 2, 'BC-S105-02', N'Còn tốt', N'Sẵn sàng'),
(5, 4, 'BC-S105-03', N'Còn tốt', N'Đang cho mượn'),
(6, 2, 'BC-S106-01', N'Còn tốt', N'Sẵn sàng'),
(6, 3, 'BC-S106-02', N'Còn tốt', N'Đang cho mượn'),
(6, 4, 'BC-S106-03', N'Mới 100%', N'Sẵn sàng');

-- H. Phiếu Mượn & Chi Tiết Mượn Trả
INSERT INTO [dbo].[Phieu_Muon] ([Ma_Phieu], [Doc_Gia_Ma_So], [Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Muon], [Ngay_Hen_Tra], [Trang_Thai], [Ghi_Chu]) VALUES
('PM0001', 1, 1, 1, DATEADD(DAY, -6, GETDATE()), DATEADD(DAY, 8, GETDATE()), N'Đã trả đủ', N'Mượn học C#'),
('PM0002', 2, 1, 1, DATEADD(DAY, -4, GETDATE()), DATEADD(DAY, 10, GETDATE()), N'Đang mượn', N'Làm đồ án'),
('PM0003', 3, 2, 2, DATEADD(DAY, -3, GETDATE()), DATEADD(DAY, 11, GETDATE()), N'Đang mượn', N'Nghiên cứu C#'),
('PM0004', 1, 2, 2, DATEADD(DAY, -2, GETDATE()), DATEADD(DAY, 12, GETDATE()), N'Đang mượn', N'Đọc kiến trúc .NET'),
('PM0005', 2, 1, 3, DATEADD(DAY, -2, GETDATE()), DATEADD(DAY, 12, GETDATE()), N'Đang mượn', N'Đọc truyện thiếu nhi'),
('PM0006', 3, 2, 4, DATEADD(DAY, -1, GETDATE()), DATEADD(DAY, 13, GETDATE()), N'Đang mượn', N'Tham khảo Machine Learning');

INSERT INTO [dbo].[Chi_Tiet_Phieu_Muon] ([Phieu_Muon_Ma_So], [Ban_Sao_Sach_Ma_So], [Ngay_Tra_Thuc_Te], [Tinh_Trang_Khi_Tra], [Tien_Phat]) VALUES
(1, 1, DATEADD(DAY, -1, GETDATE()), N'Còn tốt', 0),
(2, 2, NULL, NULL, 0),
(3, 3, NULL, NULL, 0),
(4, 9, NULL, NULL, 0),
(5, 17, NULL, NULL, 0),
(6, 15, NULL, NULL, 0);

-- I. Ca Trực & Đối Soát Tiền Két
INSERT INTO [dbo].[Ca_Truc] ([Thu_Thu_Ma_So], [Chi_Nhanh_Ma_So], [Ngay_Truc], [Ten_Ca], [Gio_Bat_Dau], [Gio_Ket_Thuc], [Tong_Tien_Thu], [Tien_Dau_Ca], [Tien_Ket_Ca], [Trang_Thai], [Ghi_Chu]) VALUES
(1, 1, CAST(DATEADD(DAY, -2, GETDATE()) AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 0, 500000, 500000, N'Đã chốt ca', N'Bàn giao đầy đủ'),
(2, 2, CAST(DATEADD(DAY, -2, GETDATE()) AS DATE), N'Ca Chiều', '13:00:00', '17:30:00', 0, 300000, 300000, N'Đã chốt ca', N'Khớp tiền két'),
(1, 3, CAST(DATEADD(DAY, -1, GETDATE()) AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 0, 200000, 200000, N'Đã chốt ca', N'Khớp két'),
(2, 4, CAST(GETDATE() AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 0, 250000, NULL, N'Đang trực', N'Mở ca sáng');

-- J. Nhật ký ban đầu
INSERT INTO [dbo].[Nhat_Ky_He_Thong] ([Nguoi_Dung_Ma_So], [Hanh_Dong], [Chi_Tiet], [Thoi_Gian], [Dia_Chi_IP], [Muc_Do]) VALUES
(1, N'Khởi tạo hệ thống', N'Đã cấu hình CSDL và phân quyền quản trị thành công.', GETDATE(), '127.0.0.1', 'SECURITY');
GO