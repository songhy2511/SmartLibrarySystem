using System;

namespace Library.DTO
{
    public class NhatKyHeThongDTO
    {
        public int Ma_So { get; set; }
        public int? Nguoi_Dung_Ma_So { get; set; }
        public string Ten_Dang_Nhap { get; set; } = string.Empty;
        public string Vai_Tro { get; set; } = string.Empty;
        public string Muc_Do { get; set; } = "INFO"; // INFO, WARNING, ERROR, SECURITY
        public string Hanh_Dong { get; set; } = string.Empty;
        public string? Chi_Tiet { get; set; }
        public DateTime Thoi_Gian { get; set; }
        public string? Dia_Chi_IP { get; set; }
    }
}