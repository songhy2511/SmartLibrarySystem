using System;

namespace Library.DTO
{
    public class DoiSoatCaTrucDTO
    {
        public int Ma_So { get; set; }
        public DateTime Ngay_Truc { get; set; }
        public string Ten_Chi_Nhanh { get; set; } = string.Empty;
        public string Ten_Ca { get; set; } = string.Empty;
        public string Ten_Thu_Thu { get; set; } = string.Empty;
        public decimal Tien_Dau_Ca { get; set; }
        public decimal Thu_Trong_Ca { get; set; }
        public decimal Tien_Ly_Thuyet => Tien_Dau_Ca + Thu_Trong_Ca;
        public decimal? Tien_Thuc_Nop { get; set; }
        public decimal? Chenh_Lech => Tien_Thuc_Nop.HasValue ? (Tien_Thuc_Nop.Value - Tien_Ly_Thuyet) : null;
        public string Trang_Thai { get; set; } = string.Empty;
    }
}