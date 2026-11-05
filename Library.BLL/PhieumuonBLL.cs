using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.DTO;
using System.Data;

namespace Library.BLL
{
    public class PhieuMuonBLL
    {
        private readonly PhieuMuonDAL _phieuMuonDAL = new PhieuMuonDAL();
        private const decimal FINE_PER_DAY = 5000m; // Định mức phạt trễ hạn 5.000đ/ngày

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            return _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
        }

        public string LapPhieuMuon(string maDocGia, string maSach, DateTime ngayMuon)
        {
            // Kiểm tra điều kiện mượn tối đa 3 cuốn[cite: 1, 2]
            DataTable dtDangMuon = _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
            if (dtDangMuon.Rows.Count >= 3)
            {
                throw new Exception("Độc giả đã đạt giới hạn mượn tối đa 3 cuốn sách!");
            }

            string maPhieu = "BR" + new Random().Next(1000, 9999);
            PhieuMuonDTO phieu = new PhieuMuonDTO
            {
                MaPhieu = maPhieu,
                MaDocGia = maDocGia,
                MaSach = maSach,
                NgayMuon = ngayMuon,
                NgayHenHan = ngayMuon.AddDays(14),
                TrangThai = "Chưa trả",
                SoLanGiaHan = 0
            };

            bool success = _phieuMuonDAL.ThemPhieuMuon(phieu);
            return success ? maPhieu : string.Empty;
        }

        public decimal TinhTienPhatTreHan(DateTime ngayHenHan, DateTime ngayTra)
        {
            if (ngayTra > ngayHenHan)
            {
                int soNgayTre = (ngayTra - ngayHenHan).Days;
                return soNgayTre * FINE_PER_DAY;
            }
            return 0;
        }

        public bool TraSach(string maPhieu, DateTime ngayTra, DateTime ngayHenHan, out decimal tienPhat)
        {
            tienPhat = TinhTienPhatTreHan(ngayHenHan, ngayTra);
            string trangThai = "Đã trả";
            return _phieuMuonDAL.CapNhatTraSach(maPhieu, ngayTra, trangThai);
        }

        public bool GiaHanPhieu(string maPhieu, int soLanGiaHanHienTai, DateTime ngayHenHanHienTai)
        {
            if (soLanGiaHanHienTai >= 1)
            {
                throw new Exception("Phiếu mượn này đã được gia hạn tối đa!");
            }
            if (DateTime.Now > ngayHenHanHienTai)
            {
                throw new Exception("Không thể gia hạn phiếu đã quá hạn!");
            }

            DateTime ngayMoi = ngayHenHanHienTai.AddDays(7);
            return _phieuMuonDAL.GiaHanPhieu(maPhieu, ngayMoi, soLanGiaHanHienTai + 1);
        }

        public bool LapBienBanViPham(PhatTienDTO bienBan)
        {
            return _phieuMuonDAL.ThemBienBanViPham(bienBan);
        }
    }
}