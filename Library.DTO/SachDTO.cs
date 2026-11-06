using System;

namespace Library.DTO
{
    public class SachDTO
    {
        public int Ma_So { get; set; }
        public string Ma_Sach { get; set; } = string.Empty;
        public string Tieu_De { get; set; } = string.Empty;
        public string Tac_Gia { get; set; } = string.Empty;
        public int The_Loai_Ma_So { get; set; } = 1; // Mặc định 1 (CNTT)
        public string The_Loai { get; set; } = string.Empty;
        public int Nam_Xuat_Ban { get; set; } = 2024;
        public string Vi_Tri_Ke { get; set; } = "Kệ A1-01";
        public int Tong_So_Luong { get; set; } = 1;
        public int So_Luong_Kha_Dung { get; set; } = 1;
        public int So_Lan_Muon { get; set; } = 0;
    }
}