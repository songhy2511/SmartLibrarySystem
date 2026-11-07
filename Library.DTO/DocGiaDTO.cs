using System;

namespace Library.DTO
{
    /// <summary>Thẻ bạn đọc. So_Lan_Vi_Pham tăng khi lập biên bản; form tô cảnh báo khi số này từ 3 trở lên.</summary>
    public class DocGiaDTO
    {
        public int Ma_So { get; set; }
        public string Ma_Doc_Gia { get; set; } = string.Empty;
        public string Ho_Ten { get; set; } = string.Empty;
        public string? So_Dien_Thoai { get; set; }
        public string? Email { get; set; }
        public string? Dia_Chi { get; set; }
        public DateTime Ngay_Cap_The { get; set; } = DateTime.Now;
        public DateTime Ngay_Het_Han_The { get; set; } = DateTime.Today.AddYears(4);
        public int So_Lan_Vi_Pham { get; set; } = 0;
        public string Trang_Thai { get; set; } = "Hoạt động"; // "Hoạt động", "Khóa tạm thời", "Hết hạn". Chỉ "Hoạt động" mới được cho mượn ở quầy.
    }
}