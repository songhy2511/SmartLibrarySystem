using System;
using System.Collections.Generic;
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
            // Xác định ngày Thứ 2 đầu tuần và Chủ nhật cuối tuần
            int diff = (7 + (refDate.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime dauTuan = refDate.AddDays(-1 * diff).Date;
            DateTime cuoiTuan = dauTuan.AddDays(6).Date;

            return _thongKeDAL.LayThongKeMuonTraTuanCacChiNhanh(dauTuan, cuoiTuan);
        }

        // Lấy danh sách tồn kho sách của chi nhánh được chọn
        public List<KhoSachChiNhanhDTO> LayChiTietKhoSachChiNhanh(int chiNhanhMaSo, string tuKhoa = "")
        {
            return _thongKeDAL.LayKhoSachTheoChiNhanh(chiNhanhMaSo, tuKhoa);
        }

        public List<DoiSoatCaTrucDTO> LayDanhSachDoiSoatCaTruc(int chiNhanhMaSo, DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
                throw new ArgumentException("Từ ngày không thể lớn hơn đến ngày!");

            return _thongKeDAL.LayDanhSachDoiSoatCaTruc(chiNhanhMaSo, tuNgay, denNgay);
        }
    }
}