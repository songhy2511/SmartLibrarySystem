using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    /// <summary>Danh mục chi nhánh. Mã CN01, CN02 do DAL sinh. Chi nhánh mới luôn được bật hoạt động.</summary>
    public class ChiNhanhBLL
    {
        private readonly ChiNhanhDAL _chiNhanhDal = new ChiNhanhDAL();

        /// <summary>Mọi chi nhánh, kể cả chi nhánh đã ngừng, để lưới quản trị vẫn thấy.</summary>
        public List<ChiNhanhDTO> LayDanhSachChiNhanh()
        {
            return _chiNhanhDal.GetAll();
        }

        /// <summary>Mã gợi ý kế tiếp, hiện sẵn trên form trước khi bấm lưu.</summary>
        public string LayMaChiNhanhTiepTheo()
        {
            return _chiNhanhDal.GetNextMaChiNhanh();
        }

        /// <summary>Thêm chi nhánh. Tên và địa chỉ bắt buộc; điện thoại được phép bỏ trống.</summary>
        public (bool IsSuccess, string Message) ThemChiNhanh(string tenChiNhanh, string diaChi, string? soDienThoai)
        {
            if (string.IsNullOrWhiteSpace(tenChiNhanh))
                return (false, "Tên chi nhánh không được để trống!");

            if (string.IsNullOrWhiteSpace(diaChi))
                return (false, "Địa chỉ chi nhánh không được để trống!");

            string maChiNhanh = _chiNhanhDal.GetNextMaChiNhanh();
            var cn = new ChiNhanhDTO
            {
                Ma_Chi_Nhanh = maChiNhanh,
                Ten_Chi_Nhanh = tenChiNhanh.Trim(),
                Dia_Chi = diaChi.Trim(),
                So_Dien_Thoai = string.IsNullOrWhiteSpace(soDienThoai) ? null : soDienThoai.Trim(),
                Dang_Hoat_Dong = true
            };

            bool isAdded = _chiNhanhDal.ThemChiNhanh(cn);
            if (isAdded)
            {
                return (true, $"Thêm chi nhánh [{maChiNhanh} - {tenChiNhanh}] thành công!");
            }
            return (false, "Thêm chi nhánh thất bại. Vui lòng thử lại!");
        }
    }
}