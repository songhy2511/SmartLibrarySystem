using System;
using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    /// <summary>Tra cứu nhật ký cho màn Admin. Không ghi log; việc ghi nằm ở SystemLogger.</summary>
    public class NhatKyHeThongBLL
    {
        private readonly NhatKyHeThongDAL _dal = new NhatKyHeThongDAL();

        /// <summary>Lọc theo khoảng ngày, mức độ, loại hành động và từ khóa. Từ ngày sau đến ngày thì ném lỗi.</summary>
        public List<NhatKyHeThongDTO> TraCuu(DateTime tuNgay, DateTime denNgay, string? mucDo, string? hanhDong, string? tuKhoa)
        {
            if (tuNgay > denNgay)
                throw new ArgumentException("Từ ngày không thể lớn hơn đến ngày!");

            return _dal.LayDanhSachNhatKy(tuNgay, denNgay, mucDo, hanhDong, tuKhoa);
        }

        /// <summary>Các mức cố định cho combobox, kể cả mục "tất cả".</summary>
        public List<string> LayDanhSachMucDo()
        {
            return new List<string> { "-- Tất cả mức độ --", "INFO", "WARNING", "ERROR", "SECURITY" };
        }

        /// <summary>Các loại hành động đã từng ghi trong CSDL, thêm một dòng "tất cả" ở đầu.</summary>
        public List<string> LayDanhSachBoLocHanhDong()
        {
            var actions = _dal.LayDanhSachLoaiHanhDong();
            actions.Insert(0, "-- Tất cả hành động --");
            return actions;
        }
    }
}