using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class PhieuMuonDTO
    {
        public string MaPhieu { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TrangThai { get; set; } // Map với cột Trang_Thai trong CSDL
        public int SoLanGiaHan { get; set; }
    }
}