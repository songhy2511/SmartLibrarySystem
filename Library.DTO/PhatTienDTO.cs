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
        public string MaBienBan { get; set; }
        public string MaDocGia { get; set; }
        public string LoaiViPham { get; set; } // Map với Loai_Vi_Pham ("Mất sách", "Trễ hạn", "Làm hư sách")[cite: 3]
        public string MoTa { get; set; }
        public decimal SoTienPhat { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayHenNop { get; set; }
        public string TrangThai { get; set; } // Map với Trang_Thai ("Chờ nộp", "Đã nộp")[cite: 3]
        public string CanBoLap { get; set; }
    }
}