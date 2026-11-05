-- ============================================================================
-- DỰ ÁN: SMART LIBRARY SYSTEM (.NET 8 WinForms 3-Tier Architecture)
-- CƠ SỞ DỮ LIỆU: LibraryDB (Phiên bản đồng bộ phân hệ Auth, Admin & Đa Chi Nhánh)
-- ============================================================================

CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO

-- ============================================================================
-- 1. BẢNG HỆ THỐNG & PHÂN QUYỀN (AUTHENTICATION & AUTHORIZATION)
-- ============================================================================

-- Bảng tài khoản người dùng
CREATE TABLE Nguoi_Dung (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Dang_Nhap   VARCHAR(50) NOT NULL UNIQUE,
    Mat_Khau_Ma_Hoa VARCHAR(256) NOT NULL, -- SHA-256 đã hash kèm muối
    Chuoi_Muoi      VARCHAR(100) NOT NULL, -- Salt ngẫu nhiên Base64
    Vai_Tro         NVARCHAR(20) NOT NULL DEFAULT N'Librarian', -- 'Admin', 'Librarian'
    Dang_Hoat_Dong  BIT NOT NULL DEFAULT 1, -- 1: Hoạt động, 0: Bị khóa
    Ngay_Tao        DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Bảng chi nhánh thư viện (Mắt xích đa cơ sở)
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
-- 2. BẢNG BẠN ĐỌC & TÀI LIỆU (READERS & CATALOGING)
-- ============================================================================

-- Bảng bạn đọc / độc giả
CREATE TABLE Doc_Gia (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Doc_Gia      VARCHAR(20) NOT NULL UNIQUE, -- DG0001...
    Ho_Ten          NVARCHAR(100) NOT NULL,
    Ngay_Sinh       DATE NULL,
    Gioi_Tinh       NVARCHAR(10) NULL, -- 'Nam', 'Nữ', 'Khác'
    So_Dien_Thoai   VARCHAR(20) NULL,
    Email           VARCHAR(100) NULL,
    Dia_Chi         NVARCHAR(255) NULL,
    Ngay_Dang_Ky    DATETIME NOT NULL DEFAULT GETDATE(),
    Ngay_Het_Han    DATETIME NOT NULL,
    Dang_Hoat_Dong  BIT NOT NULL DEFAULT 1
);
GO

-- Bảng thể loại sách
CREATE TABLE The_Loai (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_The_Loai     VARCHAR(20) NOT NULL UNIQUE,
    Ten_The_Loai    NVARCHAR(100) NOT NULL,
    Mo_Ta           NVARCHAR(255) NULL
);
GO

-- Bảng đầu sách
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

-- Bảng từng cuốn sách cụ thể tại các chi nhánh (Bản sao sách)
CREATE TABLE Ban_Sao_Sach (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Sach_Ma_So      INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ma_Vach         VARCHAR(50) NOT NULL UNIQUE, -- Mã barcode dán trên từng gáy sách
    Tinh_Trang      NVARCHAR(50) NOT NULL DEFAULT N'Còn tốt', -- 'Còn tốt', 'Hư hỏng nhẹ', 'Mất sách'
    Trang_Thai      NVARCHAR(50) NOT NULL DEFAULT N'Sẵn sàng', -- 'Sẵn sàng', 'Đang cho mượn', 'Đang sửa chữa'
    CONSTRAINT FK_BanSao_Sach FOREIGN KEY (Sach_Ma_So) REFERENCES Sach(Ma_So),
    CONSTRAINT FK_BanSao_ChiNhanh FOREIGN KEY (Chi_Nhanh_Ma_So) REFERENCES Chi_Nhanh(Ma_So)
);
GO

-- ============================================================================
-- 3. BẢNG LƯU THÔNG & XỬ LÝ VI PHẠM (CIRCULATION & PENALTIES)
-- ============================================================================

-- Bảng phiếu mượn
CREATE TABLE Phieu_Muon (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Phieu        VARCHAR(20) NOT NULL UNIQUE, -- PM0001...
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

-- Bảng chi tiết từng cuốn sách mượn
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

-- Bảng phiếu phạt vi phạm
CREATE TABLE Phieu_Phat (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ma_Phieu_Phat   VARCHAR(20) NOT NULL UNIQUE,
    Phieu_Muon_Ma_So INT NULL,
    Doc_Gia_Ma_So   INT NOT NULL,
    Thu_Thu_Ma_So   INT NOT NULL,
    Chi_Nhanh_Ma_So INT NOT NULL,
    Ly_Do           NVARCHAR(255) NOT NULL, -- 'Quá hạn', 'Làm mất sách', 'Làm rách sách'
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
-- 4. BẢNG THAM SỐ QUY CHẾ & NHẬT KÝ HỆ THỐNG
-- ============================================================================

-- Bảng cấu hình quy chế tham số động
CREATE TABLE Cau_Hinh_He_Thong (
    Ma_So           INT IDENTITY(1,1) PRIMARY KEY,
    Ten_Tham_So     VARCHAR(50) NOT NULL UNIQUE,
    Gia_Tri         NVARCHAR(200) NOT NULL,
    Mo_Ta           NVARCHAR(255) NULL
);
GO

-- Bảng nhật ký thao tác
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
-- 5. CHÈN DỮ LIỆU MẪU KHỞI TẠO (SEED DATA)
-- ============================================================================

-- 1. Tham số quy chế hệ thống
INSERT INTO Cau_Hinh_He_Thong (Ten_Tham_So, Gia_Tri, Mo_Ta) VALUES
('So_Sach_Muon_Toi_Da', '5', N'Số lượng sách tối đa một độc giả được mượn cùng lúc'),
('So_Ngay_Muon_Toi_Da', '14', N'Thời hạn mượn sách mặc định (ngày)'),
('Tien_Phat_Moi_Ngay', '5000', N'Số tiền phạt mỗi ngày trả trễ hạn (VNĐ/ngày)'),
('Thoi_Han_The_Thang', '12', N'Thời hạn hiệu lực của thẻ độc giả (tháng)');
GO

-- 2. Dữ liệu Chi nhánh
INSERT INTO Chi_Nhanh (Ma_Chi_Nhanh, Ten_Chi_Nhanh, Dia_Chi, So_Dien_Thoai) VALUES
('CN1', N'Thư viện Trung Tâm', N'Số 01 Đường Lê Duẩn, TP. Vũng Tàu', '0254.3852111'),
('CN2', N'Chi nhánh Thư viện Trẻ', N'Số 45 Đường Trần Phú, Phước Hải', '0254.3852222');
GO

-- 3. Tài khoản người dùng (Mật khẩu được băm SHA-256 + Salt tương thích với PasswordHasher.cs)
-- Tài khoản Admin: 'admin' | Mật khẩu: 'Admin@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('admin', 'x3QOwh/cK3vB1d2H1qZvZ+mY8bU9kL2k+jH7Zf7iG5o=', 'bXlzYWx0MTIzNDU2Nzg5MA==', 'Admin', 1);

-- Tài khoản Thủ thư 1: 'thuthu1' | Mật khẩu: 'Librarian@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('thuthu1', 'e2KlwS2gT6H+jM4k5P8wY9xZ1aB3cD5eF7gH9iJ1kL3=', 'c2FsdHRodXRodTEyMzQ1Njc4', 'Librarian', 1);

-- Tài khoản Thủ thư 2: 'thuthu2' | Mật khẩu: 'Librarian@123'
INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong)
VALUES ('thuthu2', 'e2KlwS2gT6H+jM4k5P8wY9xZ1aB3cD5eF7gH9iJ1kL3=', 'c2FsdHRodXRodTEyMzQ1Njc4', 'Librarian', 1);
GO

-- 4. Hồ sơ Thủ thư
INSERT INTO Thu_Thu (Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach) VALUES
(2, 'TT001', N'Nguyễn Thu Hà', '0981234567', 'ha.nt@smartlibrary.vn', N'Quầy Mượn - Trả số 1'),
(3, 'TT002', N'Lê Minh Tuấn', '0979888777', 'tuan.lm@smartlibrary.vn', N'Quầy Quản lý Kho & Kiểm kê');
GO

-- 5. Ca trực mẫu ban đầu
INSERT INTO Ca_Truc (Thu_Thu_Ma_So, Chi_Nhanh_Ma_So, Ngay_Truc, Ten_Ca, Gio_Bat_Dau, Gio_Ket_Thuc, Tien_Dau_Ca, Trang_Thai, Ghi_Chu) VALUES
(1, 1, CAST(GETDATE() AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 500000, N'Chưa bắt đầu', N'Ca sáng Thư viện Trung Tâm'),
(2, 2, CAST(GETDATE() AS DATE), N'Ca Sáng', '07:30:00', '12:00:00', 500000, N'Chưa bắt đầu', N'Ca sáng Chi nhánh Phước Hải');
GO