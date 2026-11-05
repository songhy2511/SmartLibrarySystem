using System;
using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class ThongKeBLL
    {
        private readonly ThongKeDAL _thongKeDal = new ThongKeDAL();
        private readonly ChiNhanhDAL _chiNhanhDal = new ChiNhanhDAL();

        public BaoCaoKPIDTO LayDuLieuKPI()
        {
            return _thongKeDal.LayThongKeKPI();
        }

        public List<ChiNhanhDTO> LayDanhSachChiNhanhBoLoc()
        {
            var list = _chiNhanhDal.GetAll();
            list.Insert(0, new ChiNhanhDTO { Ma_So = 0, Ten_Chi_Nhanh = "-- Tất cả chi nhánh --" });
            return list;
        }

        public List<DoiSoatTienMatDTO> LayDuLieuDoiSoat(int chiNhanhMaSo, DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
            {
                throw new ArgumentException("Từ ngày không được lớn hơn đến ngày!");
            }
            return _thongKeDal.LayBangDoiSoatTienMat(chiNhanhMaSo, tuNgay, denNgay);
        }
    }
}