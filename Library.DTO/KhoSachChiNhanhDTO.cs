namespace Library.DTO
{
    public class KhoSachChiNhanhDTO
    {
        public int Sach_Ma_So { get; set; }
        public string Ma_Sach { get; set; } = string.Empty;
        public string Tieu_De { get; set; } = string.Empty;
        public string The_Loai { get; set; } = string.Empty;
        public string Tac_Gia { get; set; } = string.Empty;
        public int Tong_Ban_Sao { get; set; }
        public int Dang_Muon { get; set; }
        public int San_Co { get; set; }
        public int Bao_Tri { get; set; }
    }
}