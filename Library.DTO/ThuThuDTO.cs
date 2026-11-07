using System;

namespace Library.DTO
{
    /// <summary>
    /// Hồ sơ nhân sự. Ma_So là khóa số; Ma_Thu_Thu là mã hiển thị TT001.
    /// Nguoi_Dung_Ma_So trỏ về tài khoản đăng nhập. Ten_Dang_Nhap và Dang_Hoat_Dong là cột nối thêm khi liệt kê, không có trong bảng Thu_Thu.
    /// </summary>
    public class ThuThuDTO
    {
        public int Ma_So { get; set; }
        public int Nguoi_Dung_Ma_So { get; set; }
        public string Ma_Thu_Thu { get; set; } = string.Empty;
        public string Ho_Ten { get; set; } = string.Empty;
        public string? So_Dien_Thoai { get; set; }
        public string? Email { get; set; }
        public string Quay_Phu_Trach { get; set; } = "Quầy Mượn - Trả số 1";
        public DateTime Ngay_Vao_Lam { get; set; } = DateTime.Now;

        // Thuộc tính mở rộng để hỗ trợ hiển thị trên giao diện
        public string? Ten_Dang_Nhap { get; set; }
        public bool Dang_Hoat_Dong { get; set; }
    }
}