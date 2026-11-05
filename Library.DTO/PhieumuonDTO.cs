using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class PhieuMuonDTO
    {
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public string MaThuThu { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public int TrangThai { get; set; } // 0: Đang mượn, 1: Đã trả, 2: Quá hạn, 3: Mất/Hư hỏng
        public bool DaGiaHan { get; set; }

        public PhieuMuonDTO() { }

        public PhieuMuonDTO(string maPhieuMuon, string maDocGia, string maSach, string maThuThu,
                           DateTime ngayMuon, DateTime ngayHetHan, DateTime? ngayTra, int trangThai, bool daGiaHan)
        {
            MaPhieuMuon = maPhieuMuon;
            MaDocGia = maDocGia;
            MaSach = maSach;
            MaThuThu = maThuThu;
            NgayMuon = ngayMuon;
            NgayHetHan = ngayHetHan;
            NgayTra = ngayTra;
            TrangThai = trangThai;
            DaGiaHan = daGiaHan;
        }
    }
}

