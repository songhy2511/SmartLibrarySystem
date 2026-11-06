using System;
using System.Data;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class PhieuMuonBLL
    {
        private readonly PhieuMuonDAL _phieuMuonDAL = new PhieuMuonDAL();

        #region Đọc Quy Chế Tham Số Động Từ Database
        public decimal LayDonGiaPhatTreHan()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'Tien_Phat_Moi_Ngay'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && decimal.TryParse(val.ToString(), out decimal donGia))
                    return donGia;
            }
            catch { }
            return 5000m;
        }

        public int LaySoNgayMuonToiDa()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'So_Ngay_Muon_Toi_Da'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && int.TryParse(val.ToString(), out int soNgay))
                    return soNgay;
            }
            catch { }
            return 14;
        }

        public int LaySoSachMuonToiDa()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'So_Sach_Muon_Toi_Da'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && int.TryParse(val.ToString(), out int soSach))
                    return soSach;
            }
            catch { }
            return 5;
        }
        #endregion

        public DataTable LayDanhSachGoiYSach()
        {
            return _phieuMuonDAL.LayDanhSachGoiYSach();
        }

        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            return _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
        }

        public string LapPhieuMuon(string maDocGia, string inputSach, DateTime ngayMuon, int? thuThuMaSo = null, int? chiNhanhMaSo = null)
        {
            if (string.IsNullOrWhiteSpace(inputSach))
                throw new Exception("Vui lòng nhập mã sách, mã vạch hoặc tên sách cần mượn!");

            // 1. Kiểm tra giới hạn số lượng mượn theo quy chế hệ thống
            DataTable dtDangMuon = _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
            int maxBooks = LaySoSachMuonToiDa();
            if (dtDangMuon.Rows.Count >= maxBooks)
            {
                throw new Exception($"Độc giả đã đạt giới hạn mượn tối đa {maxBooks} cuốn sách theo quy định!");
            }

            // 2. Kiểm tra tồn tại đầu sách
            if (!_phieuMuonDAL.KiemTraSachTonTai(inputSach, out string tenSach, out int khaDung))
            {
                throw new Exception($"Không tìm thấy đầu sách hoặc mã vạch nào khớp với '{inputSach}'!");
            }

            // 3. Kiểm tra số lượng sách còn khả dụng trên kệ
            if (khaDung <= 0)
            {
                throw new Exception($"Đầu sách '{tenSach}' hiện đã hết cuốn khả dụng trên kệ (đang cho mượn hết hoặc bảo trì)!");
            }

            // 4. Tìm kiếm bản sao vật lý sẵn sàng
            DataRow? banSao = _phieuMuonDAL.TimKiemBanSaoKhaDung(inputSach);
            if (banSao == null)
            {
                throw new Exception($"Không tìm thấy bản sao vật lý nào ở trạng thái 'Sẵn sàng' cho cuốn '{tenSach}'!");
            }

            int banSaoMaSo = Convert.ToInt32(banSao["BanSaoMaSo"]);
            int sachMaSo = Convert.ToInt32(banSao["SachMaSo"]);
            int chiNhanhId = chiNhanhMaSo ?? Convert.ToInt32(banSao["ChiNhanhMaSo"]);
            int thuThuId = thuThuMaSo ?? 1;

            int.TryParse(maDocGia, out int docGiaId);
            if (docGiaId <= 0) docGiaId = 1;

            string maPhieu = "BR" + DateTime.Now.ToString("yyMMdd") + new Random().Next(100, 999);
            DateTime ngayHenHan = ngayMuon.AddDays(LaySoNgayMuonToiDa());

            bool success = _phieuMuonDAL.ThucHienMuonSach(maPhieu, docGiaId, thuThuId, chiNhanhId, ngayMuon, ngayHenHan, banSaoMaSo, sachMaSo);
            return success ? maPhieu : string.Empty;
        }

        public decimal TinhTienPhatTreHan(DateTime ngayHenHan, DateTime ngayTra)
        {
            if (ngayTra.Date > ngayHenHan.Date)
            {
                int soNgayTre = (ngayTra.Date - ngayHenHan.Date).Days;
                return soNgayTre * LayDonGiaPhatTreHan();
            }
            return 0;
        }

        public bool TraSach(string maPhieu, DateTime ngayTra, DateTime ngayHenHan, out decimal tienPhat)
        {
            tienPhat = TinhTienPhatTreHan(ngayHenHan, ngayTra);
            string trangThai = "Đã hoàn thành";
            return _phieuMuonDAL.CapNhatTraSach(maPhieu, ngayTra, trangThai);
        }

        public bool GiaHanPhieu(string maPhieu, int soLanGiaHanHienTai, DateTime ngayHenHanHienTai)
        {
            if (soLanGiaHanHienTai >= 1)
            {
                throw new Exception("Phiếu mượn này đã được gia hạn tối đa (1 lần)!");
            }
            if (DateTime.Now.Date > ngayHenHanHienTai.Date)
            {
                throw new Exception("Không thể gia hạn phiếu mượn đã quá hạn!");
            }

            DateTime ngayMoi = ngayHenHanHienTai.AddDays(7);
            return _phieuMuonDAL.GiaHanPhieu(maPhieu, ngayMoi, soLanGiaHanHienTai + 1);
        }

        public DataTable LayDanhSachDangMuonNangCao(int docGiaMaSo = 0, bool chiQuaHan = false, string tuKhoa = "")
        {
            return _phieuMuonDAL.LayDanhSachDangMuonNangCao(docGiaMaSo, chiQuaHan, tuKhoa);
        }

        public bool CapNhatSoDienThoaiDocGia(int docGiaMaSo, string soDienThoai)
        {
            if (docGiaMaSo <= 0 || string.IsNullOrWhiteSpace(soDienThoai)) return false;
            return _phieuMuonDAL.CapNhatSoDienThoaiDocGia(docGiaMaSo, soDienThoai);
        }
    }
}