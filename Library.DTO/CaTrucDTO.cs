using System;

namespace Library.DTO
{
    public class CaTrucDTO
    {
        public int Ma_So { get; set; }
        public int Thu_Thu_Ma_So { get; set; }
        public int Chi_Nhanh_Ma_So { get; set; } // Mắt xích chi nhánh mới
        public DateTime Ngay_Truc { get; set; }
        public string Ten_Ca { get; set; } = "Ca Sáng";
        public TimeSpan Gio_Bat_Dau { get; set; }
        public TimeSpan Gio_Ket_Thuc { get; set; }
        public decimal Tien_Dau_Ca { get; set; } = 0;
        public decimal? Tien_Ket_Ca { get; set; }
        public string Trang_Thai { get; set; } = "Chưa bắt đầu";
        public string? Ghi_Chu { get; set; }

        // Dữ liệu hiển thị (Join)
        public string Ma_Thu_Thu { get; set; } = string.Empty;
        public string Ho_Ten { get; set; } = string.Empty;
        public string Quay_Phu_Trach { get; set; } = string.Empty;
        public string Ma_Chi_Nhanh { get; set; } = string.Empty;
        public string Ten_Chi_Nhanh { get; set; } = string.Empty;
    }
}