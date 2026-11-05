using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class PhieuMuonBLL
    {
        private readonly PhieuMuonDAL _phieuMuonDAL = new PhieuMuonDAL();

        public decimal TinhTienPhatTreHan(DateTime ngayHetHan, DateTime ngayTraActual)
        {
            if (ngayTraActual <= ngayHetHan)
                return 0;

            int soNgayTre = (ngayTraActual.Date - ngayHetHan.Date).Days;
            const decimal MAX_FINE_PER_DAY = 5000m; // 5.000 VNĐ / ngày trễ
            return soNgayTre * MAX_FINE_PER_DAY;
        }

        public (bool IsValid, string Message) KiemTraDieuKienMuon(string maDocGia)
        {
            int soSachDangMuon = _phieuMuonDAL.DemSoSachDangMuon(maDocGia);
            if (soSachDangMuon >= 3)
            {
                return (false, "Độc giả đã mượn tối đa 3 cuốn sách, không thể mượn thêm.");
            }
            return (true, "Đủ điều kiện mượn sách.");
        }

        public bool LapPhieuMuon(PhieuMuonDTO pm, out string errorMessage)
        {
            var check = KiemTraDieuKienMuon(pm.MaDocGia);
            if (!check.IsValid)
            {
                errorMessage = check.Message;
                return false;
            }

            pm.NgayMuon = DateTime.Now;
            pm.NgayHetHan = pm.NgayMuon.AddDays(14); // Hạn mượn mặc định 14 ngày

            errorMessage = string.Empty;
            return _phieuMuonDAL.TaoPhieuMuon(pm);
        }

        public decimal TraSach(string maPhieuMuon, DateTime ngayTra, DateTime ngayHetHan)
        {
            bool thanhCong = _phieuMuonDAL.CapNhatTraSach(maPhieuMuon, ngayTra);
            if (thanhCong)
            {
                return TinhTienPhatTreHan(ngayHetHan, ngayTra);
            }
            return 0;
        }
    }
}
