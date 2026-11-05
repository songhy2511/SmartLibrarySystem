using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class ChiNhanhBLL
    {
        private readonly ChiNhanhDAL _chiNhanhDal = new ChiNhanhDAL();

        public List<ChiNhanhDTO> LayDanhSachChiNhanh()
        {
            return _chiNhanhDal.GetAll();
        }

        public string LayMaChiNhanhTiepTheo()
        {
            return _chiNhanhDal.GetNextMaChiNhanh();
        }

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