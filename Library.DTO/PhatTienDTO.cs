using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Library.DTO
{
    public class PhatTienDTO
    {
        public string MaBienBan { get; set; } = string.Empty;
        public string MaDocGia { get; set; } = string.Empty;
        public string LoaiViPham { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public decimal SoTienPhat { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHenNop { get; set; }
        public string TrangThai { get; set; } = string.Empty;
        public string CanBoLap { get; set; } = string.Empty;
    }
}