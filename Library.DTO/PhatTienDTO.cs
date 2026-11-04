using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class PhatTienDTO
    {
        public int MaSo { get; set; }
        public string MaPhieuMuon { get; set; }
        public string MaThuThuXuLy { get; set; }
        public string LoaiViPham { get; set; }
        public int SoNgayTre { get; set; }
        public decimal SoTienPhat { get; set; }
        public string TrangThaiThanhToan { get; set; }
        public DateTime NgayTao { get; set; }

    }
}
