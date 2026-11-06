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
        private readonly PhieuPhatDAL _phieuPhatDAL = new PhieuPhatDAL();
        private readonly CauHinhHeThongBLL _cauHinhBLL = new CauHinhHeThongBLL();

        public int LaySoSachMuonToiDa()
        {
            try
            {
                string val = _cauHinhBLL.LayGiaTri("So_Sach_Muon_Toi_Da");
                return string.IsNullOrEmpty(val) ? 5 : int.Parse(val);
            }
            catch { return 5; }
        }

        public int LaySoNgayMuonToiDa()
        {
            try
            {
                string val = _cauHinhBLL.LayGiaTri("So_Ngay_Muon_Toi_Da");
                return string.IsNullOrEmpty(val) ? 14 : int.Parse(val);
            }
            catch { return 14; }
        }

        public decimal LayDonGiaPhatTreHan()
        {
            try
            {
                string val = _cauHinhBLL.LayGiaTri("Tien_Phat_Moi_Ngay");
                return string.IsNullOrEmpty(val) ? 5000m : decimal.Parse(val);
            }
            catch { return 5000m; }
        }

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            return _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
        }

        public string LapPhieuMuon(string maDocGia, string maSach, DateTime ngayMuon)
        {
            DataTable dtDangMuon = _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);

            // Fix: Use dynamic config instead of hardcoded '3'
            int maxBooks = LaySoSachMuonToiDa();
            if (dtDangMuon.Rows.Count >= maxBooks)
            {
                throw new Exception($"Độc giả đã đạt giới hạn mượn tối đa {maxBooks} cuốn sách!");
            }

            string maPhieu = "BR" + new Random().Next(1000, 9999);

            // Fix: Use dynamic config instead of hardcoded '14'
            int maxDays = LaySoNgayMuonToiDa();

            PhieuMuonDTO phieu = new PhieuMuonDTO
            {
                MaPhieu = maPhieu,
                MaDocGia = maDocGia,
                MaSach = maSach,
                NgayMuon = ngayMuon,
                NgayHenHan = ngayMuon.AddDays(maxDays),
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
                // Fix: Use dynamic fine rate instead of FINE_PER_DAY
                return soNgayTre * LayDonGiaPhatTreHan();
            }
            return 0;
        }

        public bool TraSach(string maPhieu, string maDocGia, DateTime ngayTra, DateTime ngayHenHan, int thuThuId, out decimal tienPhat)
        {
            tienPhat = TinhTienPhatTreHan(ngayHenHan, ngayTra);

            if (tienPhat > 0)
            {
                int soNgayTre = (ngayTra.Date - ngayHenHan.Date).Days;
                int.TryParse(maDocGia, out int docGiaMaSo);

                object? phieuIdObj = DatabaseHelper.ExecuteScalar(
                    "SELECT Ma_So FROM dbo.Phieu_Muon WHERE Ma_Phieu_Muon = @Ma OR Ma_So = TRY_CAST(@Ma AS INT)",
                    new[] { new Microsoft.Data.SqlClient.SqlParameter("@Ma", maPhieu) }
                );
                int phieuMuonMaSo = (phieuIdObj != null && phieuIdObj != DBNull.Value) ? Convert.ToInt32(phieuIdObj) : 0;

                PhieuPhatDTO phieuPhat = new PhieuPhatDTO
                {
                    Doc_Gia_Ma_So = docGiaMaSo > 0 ? docGiaMaSo : 1,
                    Phieu_Muon_Ma_So = phieuMuonMaSo > 0 ? phieuMuonMaSo : (int?)null,
                    Thu_Thu_Ma_So = thuThuId,
                    So_Tien_Phat = tienPhat,
                    Ly_Do = $"Trả trễ hạn {soNgayTre} ngày (Hạn: {ngayHenHan:dd/MM/yyyy})",
                    Ngay_Lap = DateTime.Now,
                    Trang_Thai = "Chưa thu",
                    Da_Thanh_Toan = false
                };

                _phieuPhatDAL.ThemPhieuPhat(phieuPhat);

                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE dbo.Doc_Gia SET So_Lan_Vi_Pham = ISNULL(So_Lan_Vi_Pham, 0) + 1 WHERE Ma_So = @DocGiaMaSo",
                    new[] { new Microsoft.Data.SqlClient.SqlParameter("@DocGiaMaSo", docGiaMaSo > 0 ? docGiaMaSo : 1) }
                );
            }

            return _phieuMuonDAL.CapNhatTraSach(maPhieu, ngayTra, "Đã hoàn thành");
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
    }
}



