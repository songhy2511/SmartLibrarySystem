using System;

namespace Library.DTO
{
    public class ChiNhanhDTO
    {
        public int Ma_So { get; set; }
        public string Ma_Chi_Nhanh { get; set; } = string.Empty; // CN1, CN2...
        public string Ten_Chi_Nhanh { get; set; } = string.Empty;
        public string Dia_Chi { get; set; } = string.Empty;
        public string? So_Dien_Thoai { get; set; }
        public bool Dang_Hoat_Dong { get; set; } = true;
        public DateTime Ngay_Tao { get; set; } = DateTime.Now;
    }
}