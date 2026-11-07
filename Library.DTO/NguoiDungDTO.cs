using System;

namespace Library.DTO
{
    /// <summary>
    /// Một dòng bảng Nguoi_Dung. Mat_Khau_Ma_Hoa là bản băm hex, không phải mật khẩu người dùng gõ.
    /// Chuoi_Muoi là muối Base64 dùng lại khi kiểm tra mật khẩu.
    /// </summary>
    public class NguoiDungDTO
    {
        public int Ma_So { get; set; }
        public string Ten_Dang_Nhap { get; set; } = string.Empty;
        public string Mat_Khau_Ma_Hoa { get; set; } = string.Empty;
        public string Chuoi_Muoi { get; set; } = string.Empty;
        public string Vai_Tro { get; set; } = "Librarian"; // Chỉ hai giá trị form đang phân nhánh: "Admin" hoặc "Librarian"
        public bool Dang_Hoat_Dong { get; set; } = true;   // false thì đăng nhập bị từ chối dù mật khẩu đúng
        public DateTime Ngay_Tao { get; set; } = DateTime.Now;
    }
}