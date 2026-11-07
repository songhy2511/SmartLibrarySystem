using System;

namespace Library.DTO
{
    /// <summary>Biên bản phạt. Da_Thanh_Toan false thì còn nằm trong công nợ chưa thu trên KPI.</summary>
    public class PhieuPhatDTO
    {
        public int Ma_So { get; set; }
        public int? Phieu_Muon_Ma_So { get; set; }
        public int Doc_Gia_Ma_So { get; set; }
        public string Ma_Doc_Gia { get; set; } = string.Empty;
        public string Ho_Ten_Doc_Gia { get; set; } = string.Empty;
        public int Thu_Thu_Ma_So { get; set; }
        public string Ten_Thu_Thu { get; set; } = string.Empty;
        public int? Chi_Nhanh_Ma_So { get; set; }
        public decimal So_Tien_Phat { get; set; }
        public string Ly_Do { get; set; } = string.Empty;
        public DateTime Ngay_Lap { get; set; } = DateTime.Now;
        public string Trang_Thai { get; set; } = "Chưa thu"; // 'Chưa thu' hoặc 'Đã thu'
        public bool Da_Thanh_Toan { get; set; } = false;
    }
}