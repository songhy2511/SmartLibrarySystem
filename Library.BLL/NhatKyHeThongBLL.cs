using System;
using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class NhatKyHeThongBLL
    {
        private readonly NhatKyHeThongDAL _dal = new NhatKyHeThongDAL();

        public List<NhatKyHeThongDTO> TraCuu(DateTime tuNgay, DateTime denNgay, string? mucDo, string? hanhDong, string? tuKhoa)
        {
            if (tuNgay > denNgay)
                throw new ArgumentException("Từ ngày không thể lớn hơn đến ngày!");

            return _dal.LayDanhSachNhatKy(tuNgay, denNgay, mucDo, hanhDong, tuKhoa);
        }

        public List<string> LayDanhSachMucDo()
        {
            return new List<string> { "-- Tất cả mức độ --", "INFO", "WARNING", "ERROR", "SECURITY" };
        }

        public List<string> LayDanhSachBoLocHanhDong()
        {
            var actions = _dal.LayDanhSachLoaiHanhDong();
            actions.Insert(0, "-- Tất cả hành động --");
            return actions;
        }
    }
}