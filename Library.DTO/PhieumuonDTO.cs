using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class PhieumuonDTO
    {
        public int MaSo { get; set; }
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public string MaThuThuLapPhieu { get; set; }
        public string MaThuThuNhanTra { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public int SoLanGiaHan { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

    }
}
