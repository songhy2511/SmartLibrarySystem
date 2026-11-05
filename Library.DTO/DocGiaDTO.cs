using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class DocGiaDTO
    {
        public int Ma_So { get; set; }
        public string Ma_Doc_Gia { get; set; } = string.Empty;
        public string Ho_Ten { get; set; } = string.Empty;
        public string? Lop { get; set; }
        public string? So_Dien_Thoai { get; set; }
        public string? Email { get; set; }
        public DateTime Ngay_Tao { get; set; } = DateTime.Now;
        public DateTime Ngay_Het_Han_The { get; set; } = DateTime.Today.AddYears(4);
        public int So_Lan_Vi_Pham { get; set; } = 0;
        public string Trang_Thai_The { get; set; } = "Hoạt động"; // N'Hoạt động', N'Khóa tạm thời', N'Hết hạn'
    }
}
