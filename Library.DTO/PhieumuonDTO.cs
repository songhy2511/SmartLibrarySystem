using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    /// <summary>Phiếu mượn một cuốn. NgayTra null khi chưa trả. SoLanGiaHan tối đa 1.</summary>
    public class PhieuMuonDTO
    {
        public string MaPhieu { get; set; } = string.Empty;
        public string MaDocGia { get; set; } = string.Empty;
        public string MaSach { get; set; } = string.Empty;
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TrangThai { get; set; } = string.Empty;
        public int SoLanGiaHan { get; set; }
    }
}