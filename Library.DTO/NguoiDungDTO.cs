using System;

namespace Library.DTO
{
    public class NguoiDungDTO
    {
        public int Ma_So { get; set; }
        public string Ten_Dang_Nhap { get; set; } = string.Empty;
        public string Mat_Khau_Ma_Hoa { get; set; } = string.Empty;
        public string Chuoi_Muoi { get; set; } = string.Empty;
        public string Vai_Tro { get; set; } = "Librarian"; // Admin | Librarian
        public bool Dang_Hoat_Dong { get; set; } = true;
        public DateTime Ngay_Tao { get; set; } = DateTime.Now;
    }
}