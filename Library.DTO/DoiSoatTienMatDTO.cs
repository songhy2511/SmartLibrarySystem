using System;

namespace Library.DTO
{
    public class DoiSoatTienMatDTO
    {
        public int Ma_Ca { get; set; }
        public DateTime Ngay_Truc { get; set; }
        public string Ten_Chi_Nhanh { get; set; } = string.Empty;
        public string Ten_Ca { get; set; } = string.Empty;
        public string Ma_Thu_Thu { get; set; } = string.Empty;
        public string Ho_Ten { get; set; } = string.Empty;
        public decimal Tien_Dau_Ca { get; set; }
        public decimal Tien_Thu_Trong_Ca { get; set; } // Tổng tiền phạt/dịch vụ thu trong ca
        public decimal Tien_Ly_Thuyet => Tien_Dau_Ca + Tien_Thu_Trong_Ca; // Tiền phải có trong két
        public decimal? Tien_Ket_Ca { get; set; } // Tiền thực tế thủ thư kiểm đếm khi bàn giao
        public decimal? Chenh_Lech => Tien_Ket_Ca.HasValue ? Tien_Ket_Ca.Value - Tien_Ly_Thuyet : null;
        public string Trang_Thai { get; set; } = string.Empty;
        public string? Ghi_Chu { get; set; }
    }
}