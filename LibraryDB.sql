USE LibraryDB;
GO
 
-- 1. XÓA CÁC BẢNG NẾU ĐÃ TỒN TẠI (THEO THỨ TỰ RÀNG BUỘC NGOẠI)
IF OBJECT_ID('dbo.Nhat_Ky_He_Thong', 'U') IS NOT NULL DROP TABLE dbo.Nhat_Ky_He_Thong;
IF OBJECT_ID('dbo.Phat_Tien', 'U') IS NOT NULL DROP TABLE dbo.Phat_Tien;
IF OBJECT_ID('dbo.Phieu_Muon', 'U') IS NOT NULL DROP TABLE dbo.Phieu_Muon;
IF OBJECT_ID('dbo.Ca_Truc', 'U') IS NOT NULL DROP TABLE dbo.Ca_Truc;
IF OBJECT_ID('dbo.Sach', 'U') IS NOT NULL DROP TABLE dbo.Sach;
IF OBJECT_ID('dbo.Doc_Gia', 'U') IS NOT NULL DROP TABLE dbo.Doc_Gia;
IF OBJECT_ID('dbo.Thu_Thu', 'U') IS NOT NULL DROP TABLE dbo.Thu_Thu;
IF OBJECT_ID('dbo.Nguoi_Dung', 'U') IS NOT NULL DROP TABLE dbo.Nguoi_Dung;
IF OBJECT_ID('dbo.Cau_Hinh_He_Thong', 'U') IS NOT NULL DROP TABLE dbo.Cau_Hinh_He_Thong;
GO
 
-- 2. TẠO CÁC BẢNG THỰC THỂ CHÍNH
 
-- Bảng Cấu hình tham số quy chế động
CREATE TABLE dbo.Cau_Hinh_He_Thong (
    Ten_Tham_So NVARCHAR(50) PRIMARY KEY,
    Gia_Tri NVARCHAR(100) NOT NULL,
    Mo_Ta NVARCHAR(255) NULL,
    Ngay_Cap_Nhat DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
-- Bảng Tài khoản & Bảo mật (SHA-256 + Salt)
CREATE TABLE dbo.Nguoi_Dung (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Dang_Nhap NVARCHAR(50) NOT NULL UNIQUE,
    Mat_Khau_Ma_Hoa NVARCHAR(128) NOT NULL, -- 64 ký tự Hex
    Chuoi_Muoi NVARCHAR(64) NOT NULL,
    Vai_Tro NVARCHAR(20) NOT NULL CHECK (Vai_Tro IN ('Admin', 'Librarian')),
    Dang_Hoat_Dong BIT NOT NULL DEFAULT 1,
    Ngay_Tao DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
-- Bảng Nhân sự Thủ thư (Liên kết 1-1 với Nguoi_Dung)
CREATE TABLE dbo.Thu_Thu (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Nguoi_Dung_Ma_So INT NOT NULL UNIQUE FOREIGN KEY REFERENCES dbo.Nguoi_Dung(Ma_So) ON DELETE CASCADE,
    Ma_Thu_Thu NVARCHAR(20) NOT NULL UNIQUE, -- TT001, TT002...
    Ho_Ten NVARCHAR(100) NOT NULL,
    So_Dien_Thoai NVARCHAR(15) NULL,
    Email NVARCHAR(100) NULL,
    Quay_Phu_Trach NVARCHAR(50) NOT NULL DEFAULT N'Quầy Mượn - Trả số 1',
    Ngay_Vao_Lam DATE NOT NULL DEFAULT GETDATE()
);
GO
 
-- Bảng Phân ca trực cho Thủ thư
CREATE TABLE dbo.Ca_Truc (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Thu_Thu_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Thu_Thu(Ma_So),
    Ngay_Truc DATE NOT NULL,
    Ten_Ca NVARCHAR(30) NOT NULL CHECK (Ten_Ca IN (N'Ca Sáng (07:30 - 11:30)', N'Ca Chiều (13:00 - 17:00)', N'Cả Ngày')),
    Tong_Tien_Thu DECIMAL(18,0) NOT NULL DEFAULT 0, -- Đối soát tiền mặt cuối ca
    Trang_Thai NVARCHAR(30) NOT NULL DEFAULT N'Chưa kết ca' CHECK (Trang_Thai IN (N'Đang trực', N'Đã kết ca', N'Chưa kết ca')),
    Ghi_Chu NVARCHAR(255) NULL
);
GO
 
-- Bảng Hồ sơ Bạn đọc
CREATE TABLE dbo.Doc_Gia (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Doc_Gia NVARCHAR(20) NOT NULL UNIQUE, -- DG0001, DG0042...
    Ho_Ten NVARCHAR(100) NOT NULL,
    Lop NVARCHAR(50) NULL,
    So_Dien_Thoai NVARCHAR(15) NULL,
    Email NVARCHAR(100) NULL,
    Ngay_Het_Han_The DATE NOT NULL DEFAULT DATEADD(YEAR, 4, GETDATE()),
    So_Lan_Vi_Pham INT NOT NULL DEFAULT 0,
    Trang_Thai_The NVARCHAR(30) NOT NULL DEFAULT N'Hoạt động' CHECK (Trang_Thai_The IN (N'Hoạt động', N'Khóa tạm thời', N'Hết hạn')),
    Ngay_Tao DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
-- Bảng Kho Sách & Vị trí Kệ
CREATE TABLE dbo.Sach (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Sach NVARCHAR(20) NOT NULL UNIQUE, -- B0101, B0231...
    Ten_Sach NVARCHAR(200) NOT NULL,
    Tac_Gia NVARCHAR(100) NOT NULL,
    The_Loai NVARCHAR(50) NOT NULL,
    Nam_Xuat_Ban INT NOT NULL CHECK (Nam_Xuat_Ban BETWEEN 1900 AND 2100),
    Vi_Tri_Ke NVARCHAR(50) NOT NULL DEFAULT N'Kệ A-01', -- Dãy B - Kệ 03 - Tầng 2
    Gia_Bia DECIMAL(18,0) NOT NULL DEFAULT 50000,       -- Giá bìa phục vụ đền bù
    Tong_So_Luong INT NOT NULL DEFAULT 1 CHECK (Tong_So_Luong >= 0),
    So_Luong_Kha_Dung INT NOT NULL DEFAULT 1 CHECK (So_Luong_Kha_Dung >= 0),
    So_Lan_Muon INT NOT NULL DEFAULT 0,
    Ngay_Tao DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_Sach_SoLuong CHECK (So_Luong_Kha_Dung <= Tong_So_Luong)
);
GO
 
-- Bảng Phiếu Mượn - Trả Lưu Thông
CREATE TABLE dbo.Phieu_Muon (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Phieu_Muon NVARCHAR(20) NOT NULL UNIQUE, -- BR0001...
    Doc_Gia_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Doc_Gia(Ma_So),
    Sach_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Sach(Ma_So),
    Thu_Thu_Lap_Phieu_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Thu_Thu(Ma_So),
    Ngay_Muon DATETIME NOT NULL DEFAULT GETDATE(),
    Ngay_Het_Han DATETIME NOT NULL,
    Ngay_Tra DATETIME NULL,
    Thu_Thu_Nhan_Tra_Ma_So INT NULL FOREIGN KEY REFERENCES dbo.Thu_Thu(Ma_So),
    So_Lan_Gia_Han INT NOT NULL DEFAULT 0,
    Trang_Thai NVARCHAR(30) NOT NULL DEFAULT N'Đang mượn' CHECK (Trang_Thai IN (N'Đang mượn', N'Đã trả', N'Quá hạn', N'Mất sách')),
    Ghi_Chu NVARCHAR(255) NULL
);
GO
 
-- Bảng Xử Lý Vi Phạm & Phạt Tiền
CREATE TABLE dbo.Phat_Tien (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Phieu_Muon_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Phieu_Muon(Ma_So),
    Thu_Thu_Xu_Ly_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Thu_Thu(Ma_So),
    Loai_Vi_Pham NVARCHAR(50) NOT NULL, -- Quá hạn, Hư hại nhẹ, Hỏng nặng, Làm mất
    So_Ngay_Tre INT NOT NULL DEFAULT 0,
    So_Tien_Phat DECIMAL(18,0) NOT NULL DEFAULT 0,
    Trang_Thai_Thanh_Toan NVARCHAR(30) NOT NULL DEFAULT N'Đã thu' CHECK (Trang_Thai_Thanh_Toan IN (N'Đã thu', N'Chưa thu', N'Được miễn giảm')),
    Ngay_Tao DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
-- Bảng Nhật Ký Kiểm Toán Hệ Thống (Audit Log - Dành cho Admin giám sát)
CREATE TABLE dbo.Nhat_Ky_He_Thong (
    Ma_So INT IDENTITY(1,1) PRIMARY KEY,
    Nguoi_Dung_Ma_So INT NOT NULL FOREIGN KEY REFERENCES dbo.Nguoi_Dung(Ma_So),
    Loai_Thao_Tac NVARCHAR(50) NOT NULL, -- INSERT, UPDATE, DELETE, PENALTY, SYSTEM_CONFIG
    Chi_Tiet NVARCHAR(MAX) NOT NULL,
    Dia_Chi_IP NVARCHAR(50) NULL DEFAULT '127.0.0.1',
    Ngay_Tao DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
-- ============================================================================
-- 3. NẠP DỮ LIỆU MẪU BAN ĐẦU (SEED DATA)
-- ============================================================================
 
-- Cấu hình tham số mặc định
INSERT INTO dbo.Cau_Hinh_He_Thong (Ten_Tham_So, Gia_Tri, Mo_Ta) VALUES
('MAX_BORROW_DAYS', '14', N'Số ngày tối đa cho mỗi lượt mượn sách'),
('MAX_BORROW_BOOKS', '3', N'Số cuốn sách tối đa một độc giả được mượn cùng lúc'),
('DAILY_FINE_AMOUNT', '5000', N'Số tiền phạt mỗi ngày khi trả sách trễ hạn (VNĐ)'),
('MAX_RENEW_TIMES', '1', N'Số lần tối đa được phép gia hạn một phiếu mượn');
 
-- Tài khoản mẫu:
-- 1. Admin: admin / Admin@123 (Salt: 'SALT_ADMIN_KEY_2026')
-- 2. Thủ thư 1: thuthu1 / Librarian@123 (Salt: 'SALT_LIB1_KEY_2026')
-- 3. Thủ thư 2: thuthu2 / Librarian@123 (Salt: 'SALT_LIB2_KEY_2026')
INSERT INTO dbo.Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong) VALUES
('admin', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Admin@123' + 'SALT_ADMIN_KEY_2026'), 2), 'SALT_ADMIN_KEY_2026', 'Admin', 1),
('thuthu1', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Librarian@123' + 'SALT_LIB1_KEY_2026'), 2), 'SALT_LIB1_KEY_2026', 'Librarian', 1),
('thuthu2', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Librarian@123' + 'SALT_LIB2_KEY_2026'), 2), 'SALT_LIB2_KEY_2026', 'Librarian', 1);
 
-- Thông tin Thủ thư
INSERT INTO dbo.Thu_Thu (Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach) VALUES
(2, 'TT001', N'Nguyễn Thu Hà', '0981234567', 'ha.nt@smartlibrary.edu.vn', N'Quầy Mượn - Trả số 1'),
(3, 'TT002', N'Lê Minh Tuấn', '0979888777', 'tuan.lm@smartlibrary.edu.vn', N'Quầy Quản lý Kho & Kiểm kê');
 
-- Lịch trực mẫu
INSERT INTO dbo.Ca_Truc (Thu_Thu_Ma_So, Ngay_Truc, Ten_Ca, Tong_Tien_Thu, Trang_Thai) VALUES
(1, CAST(GETDATE() AS DATE), N'Ca Sáng (07:30 - 11:30)', 45000, N'Đang trực'),
(2, CAST(GETDATE() AS DATE), N'Ca Chiều (13:00 - 17:00)', 0, N'Chưa kết ca');
 
-- Độc giả mẫu
INSERT INTO dbo.Doc_Gia (Ma_Doc_Gia, Ho_Ten, Lop, So_Dien_Thoai, Email, So_Lan_Vi_Pham, Trang_Thai_The) VALUES
('DG0001', N'Trần Anh Tuấn', 'DH22PM01', '0912345678', 'tuan.ta@student.edu.vn', 0, N'Hoạt động'),
('DG0002', N'Lê Hoàng Long', 'DH22CN02', '0945678901', 'long.lh@student.edu.vn', 3, N'Khóa tạm thời'),
('DG0003', N'Võ Thị Ngọc Mai', 'DH23KT01', '0933221100', 'mai.vtn@student.edu.vn', 1, N'Hoạt động');
 
-- Kho sách mẫu
INSERT INTO dbo.Sach (Ma_Sach, Ten_Sach, Tac_Gia, The_Loai, Nam_Xuat_Ban, Vi_Tri_Ke, Gia_Bia, Tong_So_Luong, So_Luong_Kha_Dung, So_Lan_Muon) VALUES
('B0101', N'Kỹ Thuật Lập Trình C# Hiện Đại', N'Nguyễn Văn Hoài', N'Công nghệ thông tin', 2024, N'Dãy A - Kệ 01 - Tầng 2', 95000, 10, 8, 45),
('B0102', N'Giải Tích Đại Cương 1', N'Đại học Bách Khoa', N'Toán học cơ bản', 2023, N'Dãy B - Kệ 02 - Tầng 1', 60000, 5, 0, 38),
('B0103', N'Đắc Nhân Tâm', N'Dale Carnegie', N'Kỹ năng sống', 2022, N'Dãy C - Kệ 01 - Tầng 1', 78000, 12, 6, 32),
('B0104', N'Vật Lý Đại Cương', N'Bộ Giáo Dục', N'Khoa học tự nhiên', 2023, N'Dãy B - Kệ 03 - Tầng 2', 55000, 8, 4, 29),
('B0105', N'Nhập Môn Học Máy & AI', N'Trần Minh', N'Công nghệ thông tin', 2025, N'Dãy A - Kệ 03 - Tầng 3', 120000, 6, 3, 25);
GO