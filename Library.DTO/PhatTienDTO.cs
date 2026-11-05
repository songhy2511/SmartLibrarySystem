using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class PhatTienDTO
    {
        public string MaBiEnBan { get; set; }
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string LyDoPhat { get; set; } // Trễ hạn, Hư hỏng, Mất sách
        public decimal SoTienPhat { get; set; }
        public DateTime NgayLap { get; set; }
        public bool DaThanhToan { get; set; }
        public string GhiChu { get; set; }

        public PhatTienDTO() { }

        public PhatTienDTO(string maBiEnBan, string maPhieuMuon, string maDocGia,
                           string lyDoPhat, decimal soTienPhat, DateTime ngayLap, bool daThanhToan, string ghiChu)
        {
            MaBiEnBan = maBiEnBan;
            MaPhieuMuon = maPhieuMuon;
            MaDocGia = maDocGia;
            LyDoPhat = lyDoPhat;
            SoTienPhat = soTienPhat;
            NgayLap = ngayLap;
            DaThanhToan = daThanhToan;
            GhiChu = ghiChu;
        }
    }
}