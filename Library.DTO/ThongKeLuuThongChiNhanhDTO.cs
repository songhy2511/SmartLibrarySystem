namespace Library.DTO
{
    public class ThongKeLuuThongChiNhanhDTO
    {
        public int Chi_Nhanh_Ma_So { get; set; }
        public string Ma_Chi_Nhanh { get; set; } = string.Empty;
        public string Ten_Chi_Nhanh { get; set; } = string.Empty;
        public int So_Luot_Muon_Trong_Tuan { get; set; }
        public int So_Luot_Tra_Trong_Tuan { get; set; }
        public int So_Sach_Dang_Muon_Hien_Tai { get; set; }
    }
}