-- ============================================================================
-- DỰ ÁN: SMART LIBRARY SYSTEM (.NET 8 WinForms 3-Tier Architecture)
-- TẬP TIN: LibraryDB.sql
-- MÔ TẢ: Khởi tạo toàn diện Cơ sở dữ liệu và dữ liệu mẫu kiểm thử
-- ============================================================================

USE master;
GO

-- Xóa database cũ nếu đã tồn tại để thiết lập lại đồng bộ
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'LibraryDB')
BEGIN
    ALTER DATABASE LibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE LibraryDB;
END
GO

CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO

-- ============================================================================
-- 1. TÀI KHOẢN, PHÂN QUYỀN & CHI NHÁNH
-- ============================================================================

-- Bảng tài khoản đăng nhập hệ thống
CREATE TABLE Nguoi_Dung (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Dang_Nhap   VARCHAR(50) NOT NULL UNIQUE,
    Mat_Khau_Ma_Hoa VARCHAR(256) NOT NULL, -- SHA-256 + Salt
    Chuoi_Muoi      VARCHAR(100) NOT NULL,
    Vai_Tro         NVARCHAR(20) NOT NULL DEFAULT N'Librarian', -- 'Admin', 'Librarian'
    Dang_Hoat_Dong  BIT NOT NULL DEFAULT 1,
    Ngay_Tao        DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Bảng mạng lưới chi nhánh thư viện
CREATE TABLE Chi_Nhanh (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Chi_Nhanh    VARCHAR(20) NOT NULL UNIQUE, -- CN1, CN2, CN3...
    Ten_Chi_Nhanh   NVARCHAR(100) NOT NULL,
    Dia_Chi         NVARCHAR(255) NOT NULL,
    So_Dien_Thoai   VARCHAR(20) NULL,
    Dang_Hoat_Dong  BIT NOT NULL DEFAULT 1,
    Ngay_Tao        DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Bảng hồ sơ nhân sự thủ thư
CREATE TABLE Thu_Thu (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Nguoi_Dung_Ma_So INT NOT NULL UNIQUE,
    Ma_Thu_Thu      VARCHAR(20) NOT NULL UNIQUE, -- TT001, TT002...
    Ho_Ten          NVARCHAR(100) NOT NULL,
    So_Dien_Thoai   VARCHAR(20) NULL,
    Email           VARCHAR(100) NULL,
    Quay_Phu_Trach  NVARCHAR(100) NOT NULL DEFAULT N'Quầy Mượn - Trả số 1',
    Ngay_Vao_Lam    DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_ThuThu_NguoiDung FOREIGN KEY (Nguoi_Dung_Ma_So) REFERENCES Nguoi_Dung(Ma_So) ON DELETE CASCADE
);
GO

-- Bảng phân ca làm việc & đối soát tiền mặt
CREATE TABLE Ca_Truc (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Thu_Thu_Ma_So   INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ngay_Truc       DATE NOT NULL,
    Ten_Ca          NVARCHAR(50) NOT NULL CONSTRAINT CK_CaTruc_TenCa CHECK (Ten_Ca IN (N'Ca Sáng', N'Ca Chiều')),
    Gio_Bat_Dau     TIME NOT NULL DEFAULT '07:30:00',
    Gio_Ket_Thuc    TIME NOT NULL DEFAULT '12:00:00',
    Tien_Dau_Ca     DECIMAL(18, 2) NOT NULL DEFAULT 0,
    Tien_Ket_Ca     DECIMAL(18, 2) NULL,
    Trang_Thai      NVARCHAR(50) NOT NULL DEFAULT N'Chưa bắt đầu', -- 'Chưa bắt đầu', 'Đang trực', 'Đã kết ca'
    Ghi_Chu         NVARCHAR(500) NULL,
    CONSTRAINT FK_CaTruc_ThuThu FOREIGN KEY (Thu_Thu_Ma_So) REFERENCES Thu_Thu(Ma_So),
    CONSTRAINT FK_CaTruc_ChiNhanh FOREIGN KEY (Chi_Nhanh_Ma_So) REFERENCES Chi_Nhanh(Ma_So)
);
GO

-- ============================================================================
-- 2. QUẢN LÝ ĐỘC GIẢ, DANH MỤC & KHO SÁCH
-- ============================================================================

-- Bảng hồ sơ độc giả
CREATE TABLE Doc_Gia (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Doc_Gia      VARCHAR(20) NOT NULL UNIQUE, -- DG0001...
    Ho_Ten          NVARCHAR(100) NOT NULL,
    Ngay_Sinh       DATE NULL,
    Gioi_Tinh       NVARCHAR(10) NULL,
    So_Dien_Thoai   VARCHAR(20) NULL,
    Email           VARCHAR(100) NULL,
    Dia_Chi         NVARCHAR(255) NULL,
    Ngay_Dang_Ky    DATETIME NOT NULL DEFAULT GETDATE(),
    Ngay_Het_Han    DATETIME NOT NULL,
    Dang_Hoat_Dong  BIT NOT NULL DEFAULT 1
);
GO

-- Bảng phân loại thể loại sách
CREATE TABLE The_Loai (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_The_Loai     VARCHAR(20) NOT NULL UNIQUE,
    Ten_The_Loai    NVARCHAR(100) NOT NULL,
    Mo_Ta           NVARCHAR(255) NULL
);
GO

-- Bảng thông tin đầu sách
CREATE TABLE Sach (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Sach         VARCHAR(20) NOT NULL UNIQUE, -- S0001...
    The_Loai_Ma_So  INT NOT NULL,
    Tieu_De         NVARCHAR(200) NOT NULL,
    Tac_Gia         NVARCHAR(150) NOT NULL,
    Nha_Xuat_Ban    NVARCHAR(150) NULL,
    Nam_Xuat_Ban    INT NULL,
    Gia_Bia         DECIMAL(18, 2) NOT NULL DEFAULT 0,
    Tong_So_Luong   INT NOT NULL DEFAULT 0,
    So_Luong_San_Co INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Sach_TheLoai FOREIGN KEY (The_Loai_Ma_So) REFERENCES The_Loai(Ma_So)
);
GO

-- Bảng bản sao sách vật lý phân bổ theo từng chi nhánh
CREATE TABLE Ban_Sao_Sach (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Sach_Ma_So      INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ma_Vach         VARCHAR(50) NOT NULL UNIQUE,
    Tinh_Trang      NVARCHAR(50) NOT NULL DEFAULT N'Còn tốt',
    Trang_Thai      NVARCHAR(50) NOT NULL DEFAULT N'Sẵn sàng', -- 'Sẵn sàng', 'Đang cho mượn', 'Bảo trì'
    CONSTRAINT FK_BanSao_Sach FOREIGN KEY (Sach_Ma_So) REFERENCES Sach(Ma_So),
    CONSTRAINT FK_BanSao_ChiNhanh FOREIGN KEY (Chi_Nhanh_Ma_So) REFERENCES Chi_Nhanh(Ma_So)
);
GO

-- ============================================================================
-- 3. MƯỢN TRẢ & XỬ LÝ VI PHẠM (ĐỐI SOÁT TÀI CHÍNH)
-- ============================================================================

-- Bảng phiếu mượn sách
CREATE TABLE Phieu_Muon (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Phieu        VARCHAR(20) NOT NULL UNIQUE,
    Doc_Gia_Ma_So   INT NOT NULL,
    Thu_Thu_Ma_So   INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ngay_Muon       DATETIME NOT NULL DEFAULT GETDATE(),
    Ngay_Hen_Tra    DATETIME NOT NULL,
    Trang_Thai      NVARCHAR(50) NOT NULL DEFAULT N'Đang mượn', -- 'Đang mượn', 'Đã trả đủ', 'Quá hạn'
    Ghi_Chu         NVARCHAR(500) NULL,
    CONSTRAINT FK_PhieuMuon_DocGia FOREIGN KEY (Doc_Gia_Ma_So) REFERENCES Doc_Gia(Ma_So),
    CONSTRAINT FK_PhieuMuon_ThuThu FOREIGN KEY (Thu_Thu_Ma_So) REFERENCES Thu_Thu(Ma_So),
    CONSTRAINT FK_PhieuMuon_ChiNhanh FOREIGN KEY (Chi_Nhanh_Ma_So) REFERENCES Chi_Nhanh(Ma_So)
);
GO

-- Bảng chi tiết sách trong phiếu mượn
CREATE TABLE Chi_Tiet_Phieu_Muon (
    Ma_So               INT IDENTITY(1,1) PRIMARY KEY,
    Phieu_Muon_Ma_So    INT NOT NULL,
    Ban_Sao_Sach_Ma_So  INT NOT NULL,
    Ngay_Tra_Thuc_Te    DATETIME NULL,
    Tinh_Trang_Khi_Tra  NVARCHAR(100) NULL,
    Tien_Phat           DECIMAL(18, 2) NOT NULL DEFAULT 0,
    CONSTRAINT FK_CTPM_PhieuMuon FOREIGN KEY (Phieu_Muon_Ma_So) REFERENCES Phieu_Muon(Ma_So) ON DELETE CASCADE,
    CONSTRAINT FK_CTPM_BanSao FOREIGN KEY (Ban_Sao_Sach_Ma_So) REFERENCES Ban_Sao_Sach(Ma_So)
);
GO

-- Bảng phiếu phạt vi phạm và thu tiền trực tiếp trong ca
CREATE TABLE Phieu_Phat (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Phieu_Phat   VARCHAR(20) NOT NULL UNIQUE,
    Phieu_Muon_Ma_So INT NULL,
    Doc_Gia_Ma_So   INT NOT NULL,
    Thu_Thu_Ma_So   INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ly_Do           NVARCHAR(255) NOT NULL,
    So_Tien_Phat    DECIMAL(18, 2) NOT NULL,
    Da_Thanh_Toan   BIT NOT NULL DEFAULT 0,
    Ngay_Tao        DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_PhieuPhat_PhieuMuon FOREIGN KEY (Phieu_Muon_Ma_So) REFERENCES Phieu_Muon(Ma_So),
    CONSTRAINT FK_PhieuPhat_DocGia FOREIGN KEY (Doc_Gia_Ma_So) REFERENCES Doc_Gia(Ma_So),
    CONSTRAINT FK_PhieuPhat_ThuThu FOREIGN KEY (Thu_Thu_Ma_So) REFERENCES Thu_Thu(Ma_So),
    CONSTRAINT FK_PhieuPhat_ChiNhanh FOREIGN KEY (Chi_Nhanh_Ma_So) REFERENCES Chi_Nhanh(Ma_So)
);
GO

-- ============================================================================
-- 4. THAM SỐ QUY CHẾ & NHẬT KÝ HỆ THỐNG
-- ============================================================================

CREATE TABLE Cau_Hinh_He_Thong (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Tham_So     VARCHAR(50) NOT NULL UNIQUE,
    Gia_Tri         NVARCHAR(200) NOT NULL,
    Mo_Ta           NVARCHAR(255) NULL
);
GO

CREATE TABLE Nhat_Ky_He_Thong (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Nguoi_Dung_Ma_So INT NULL,
    Hanh_Dong       NVARCHAR(100) NOT NULL,
    Chi_Tiet        NVARCHAR(MAX) NULL,
    Thoi_Gian       DATETIME NOT NULL DEFAULT GETDATE(),
    Dia_Chi_IP      VARCHAR(50) NULL,
    CONSTRAINT FK_NhatKy_NguoiDung FOREIGN KEY (Nguoi_Dung_Ma_So) REFERENCES Nguoi_Dung(Ma_So) ON DELETE SET NULL
);
GO

-- ============================================================================
-- 5. NẠP DỮ LIỆU KHỞI TẠO (SEED DATA)
-- ============================================================================

-- Cấu hình tham số mượn trả
INSERT INTO Cau_Hinh_He_Thong (Ten_Tham_So, Gia_Tri, Mo_Ta) VALUES
('So_Sach_Muon_Toi_Da', '5', N'Số lượng sách tối đa một độc giả được mượn cùng lúc'),
('So_Ngay_Muon_Toi_Da', '14', N'Thời hạn mượn sách mặc định (ngày)'),
('Tien_Phat_Moi_Ngay', '5000', N'Số tiền phạt mỗi ngày trả trễ hạn (VNĐ/ngày)'),
('Thoi_Han_The_Thang', '12', N'Thời hạn hiệu lực của thẻ độc giả (tháng)');

-- Chi nhánh
INSERT INTO Chi_Nhanh (Ma_Chi_Nhanh, Ten_Chi_Nhanh, Dia_Chi, So_Dien_Thoai) VALUES
('CN1', N'Thư viện Trung Tâm', N'Số 01 Đường Lê Duẩn, TP. Vũng Tàu', '0254.3852111'),
('CN2', N'Chi nhánh Thư viện Trẻ', N'Số 45 Đường Trần Phú, Phước Hải', '0254.3852222');

-- Tài khoản:
-- admin: 'admin' / 'Admin@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('admin', 'x3QOwh/cK3vB1d2H1qZvZ+mY8bU9kL2k+jH7Zf7iG5o=', 'bXlzYWx0MTIzNDU2Nzg5MA==', 'Admin', 1);

-- thuthu1: 'thuthu1' / 'Librarian@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('thuthu1', 'e2KlwS2gT6H+jM4k5P8wY9xZ1aB3cD5eF7gH9iJ1kL3=', 'c2FsdHRodXRodTEyMzQ1Njc4', 'Librarian', 1);

-- thuthu2: 'thuthu2' / 'Librarian@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('thuthu2', 'e2KlwS2gT6H+jM4k5P8wY9xZ1aB3cD5eF7gH9iJ1kL3=', 'c2FsdHRodXRodTEyMzQ1Njc4', 'Librarian', 1);

-- Hồ sơ Thủ thư
INSERT INTO Thu_Thu (Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach) VALUES
(2, 'TT001', N'Nguyễn Thu Hà', '0981234567', 'ha.nt@smartlibrary.vn', N'Quầy Mượn - Trả số 1'),
(3, 'TT002', N'Lê Minh Tuấn', '0979888777', 'tuan.lm@smartlibrary.vn', N'Quầy Quản lý Kho & Kiểm kê');

-- Độc giả mẫu (hiển thị KPI)
INSERT INTO Doc_Gia (Ma_Doc_Gia, Ho_Ten, So_Dien_Thoai, Email, Ngay_Dang_Ky, Ngay_Het_Han, Dang_Hoat_Dong) VALUES
('DG0001', N'Phạm Song Hỷ', '0912345678', 'hy.ps@student.edu.vn', GETDATE(), DATEADD(YEAR, 1, GETDATE()), 1),
('DG0002', N'Trần Văn An', '0988776655', 'an.tv@gmail.com', GETDATE(), DATEADD(YEAR, 1, GETDATE()), 1),
('DG0003', N'Võ Hoàng Quyên', '0933221100', 'quyen.vh@gmail.com', GETDATE(), DATEADD(YEAR, 1, GETDATE()), 1);

-- Thể loại sách & Đầu sách mẫu
INSERT INTO The_Loai (Ma_The_Loai, Ten_The_Loai, Mo_Ta) VALUES
('TL01', N'Công Nghệ Thông Tin', N'Lập trình, thuật toán, C#, AI'),
('TL02', N'Kinh Tế & Quản Trị', N'Quản trị dự án, tài chính doanh nghiệp');

INSERT INTO Sach (Ma_Sach, The_Loai_Ma_So, Tieu_De, Tac_Gia, Nha_Xuat_Ban, Nam_Xuat_Ban, Gia_Bia, Tong_So_Luong, So_Luong_San_Co) VALUES
('S0001', 1, N'Lập Trình C# .NET Nâng Cao', N'Nguyễn Hữu Anh', N'KHKT', 2024, 180000, 10, 8),
('S0002', 1, N'Kiến Trúc Phần Mềm Đa Tầng', N'Trần Minh Hải', N'ĐHQG', 2025, 220000, 5, 5);

-- Bản sao sách mẫu
INSERT INTO Ban_Sao_Sach (Sach_Ma_So, Chi_Nhanh_Ma_So, Ma_Vach, Tinh_Trang, Trang_Thai) VALUES
(1, 1, 'BC-S0001-01', N'Còn tốt', N'Sẵn sàng'),
(1, 1, 'BC-S0001-02', N'Còn tốt', N'Sẵn sàng'),
(1, 2, 'BC-S0001-03', N'Còn tốt', N'Sẵn sàng'),
(2, 1, 'BC-S0002-01', N'Còn tốt', N'Sẵn sàng');

-- Ca trực mẫu (hiển thị bảng Đối soát)
INSERT INTO Ca_Truc (Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Truc, Ten_Ca, Gio_Bat_Dau, Gio_Ket_Thuc, Tien_Dau_Ca, Tien_Ket_Ca, Trang_Thai, Ghi_Chu) VALUES
(1, 1, CAST(GETDATE() AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 500000, 550000, N'Đã kết ca', N'Bàn giao đầy đủ ca sáng'),
(2, 2, CAST(GETDATE() AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 500000, NULL, N'Đang trực', N'Đang mở quầy phục vụ');

-- Phiếu phạt mẫu đã thanh toán (hiển thị thu nhập phạt trong ca)
INSERT INTO Phieu_Phat (Ma_Phieu_Phat, Doc_Gia_Ma_So, Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ly_Do, So_Tien_Phat, Da_Thanh_Toan, Ngay_Tao) VALUES
('PP0001', 1, 1, 1, N'Trả sách trễ hạn 10 ngày', 50000, 1, GETDATE());
GO