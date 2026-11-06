using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks; // Bắt buộc phải có thư viện này để dùng Task và async/await
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public partial class ThongKeBLL
    {
        private readonly ThongKeDAL _thongKeDAL = new ThongKeDAL();

        // Lấy thống kê lưu thông trong tuần hiện tại (hoặc khoảng ngày được chỉ định)
        public List<ThongKeLuuThongChiNhanhDTO> LayBaoCaoLuuThongTuan(DateTime? ngayBatDau = null)
        {
            DateTime refDate = ngayBatDau ?? DateTime.Today;
            int diff = (7 + (refDate.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime dauTuan = refDate.AddDays(-1 * diff).Date;
            DateTime cuoiTuan = dauTuan.AddDays(6).Date;

            return _thongKeDAL.LayThongKeMuonTraTuanCacChiNhanh(dauTuan, cuoiTuan);
        }

        public List<DoiSoatCaTrucDTO> LayDanhSachDoiSoatCaTruc(int chiNhanhMaSo, DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
                throw new ArgumentException("Từ ngày không thể lớn hơn đến ngày!");

            return _thongKeDAL.LayDanhSachDoiSoatCaTruc(chiNhanhMaSo, tuNgay, denNgay);
        }

        public (int TongDocGia, decimal TongTienPhat) LayKPIDocGiaVaTienPhat()
        {
            return _thongKeDAL.LayKPIDocGiaVaTienPhat();
        }

        public int LayTongSoDocGia()
        {
            return _thongKeDAL.LayTongSoDocGia();
        }

        public int LayTongSoDauSach()
        {
            return _thongKeDAL.LayTongSoDauSach();
        }

        public int LayTongSachDangMuon()
        {
            return _thongKeDAL.LayTongSachDangMuon();
        }

        public decimal LayTongTienPhatChuaThu()
        {
            return _thongKeDAL.LayTongTienPhatChuaThu();
        }

        // =========================================================
        // CÁC HÀM BẤT ĐỒNG BỘ (ASYNC/AWAIT) CHỐNG ĐƠ GIAO DIỆN
        // =========================================================

        public async Task<List<KhoSachChiNhanhDTO>> LayChiTietKhoSachChiNhanhAsync(int chiNhanhMaSo, string tuKhoa = "")
        {
            return await _thongKeDAL.LayKhoSachTheoChiNhanhAsync(chiNhanhMaSo, tuKhoa);
        }

        public async Task<DataTable> LayLuuThongTuanAsync()
        {
            return await _thongKeDAL.LayLuuThongTuanAsync();
        }
    }
}