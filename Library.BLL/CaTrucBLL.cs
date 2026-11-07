using System;
using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class CaTrucBLL
    {
        private readonly CaTrucDAL _caTrucDal = new CaTrucDAL();
        private readonly ThuThuDAL _thuThuDal = new ThuThuDAL();
        private readonly ChiNhanhDAL _chiNhanhDal = new ChiNhanhDAL();

        public List<ThuThuDTO> LayDanhSachThuThuDangHoatDong()
        {
            return _thuThuDal.GetAll().FindAll(x => x.Dang_Hoat_Dong);
        }

        public List<ChiNhanhDTO> LayDanhSachChiNhanhDangHoatDong()
        {
            return _chiNhanhDal.GetAll().FindAll(x => x.Dang_Hoat_Dong);
        }

        public List<CaTrucDTO> LayDanhSachCaTruc(DateTime fromDate, DateTime toDate)
        {
            return _caTrucDal.GetByDateRange(fromDate, toDate);
        }

        public (bool IsSuccess, string Message) PhanCaTruc(
            int thuThuMaSo,
            int chiNhanhMaSo,
            DateTime ngayTruc,
            string tenCa,
            TimeSpan gioBatDau,
            TimeSpan gioKetThuc,
            decimal tienDauCa,
            string? ghiChu)
        {
            if (thuThuMaSo <= 0)
                return (false, "Vui lòng chọn nhân sự thủ thư!");

            if (chiNhanhMaSo <= 0)
                return (false, "Vui lòng chọn chi nhánh làm việc!");

            if (ngayTruc.Date < DateTime.Today)
                return (false, "Không thể phân ca làm việc cho một ngày trong quá khứ!");

            if (gioBatDau >= gioKetThuc)
                return (false, "Giờ bắt đầu ca trực phải trước giờ kết thúc!");

            // 1. Kiểm tra ràng buộc: 1 ca ở 1 chi nhánh chỉ có duy nhất 1 thủ thư
            string? thuThuHienTai = _caTrucDal.LayTenThuThuDangTrucTaiChiNhanh(chiNhanhMaSo, ngayTruc, tenCa);
            if (!string.IsNullOrEmpty(thuThuHienTai))
            {
                return (false, $"Chi nhánh này đã có thủ thư '{thuThuHienTai}' trực '{tenCa}' vào ngày {ngayTruc:dd/MM/yyyy}! Mỗi ca tại một chi nhánh chỉ phân công đúng 1 người.");
            }

            // 2. Kiểm tra ràng buộc: Thủ thư đó không được có lịch cùng ca tại chi nhánh khác
            string? chiNhanhDaTruc = _caTrucDal.LayTenChiNhanhThuThuDangCoLich(thuThuMaSo, ngayTruc, tenCa);
            if (!string.IsNullOrEmpty(chiNhanhDaTruc))
            {
                return (false, $"Thủ thư này đã có lịch trực '{tenCa}' ngày {ngayTruc:dd/MM/yyyy} tại '{chiNhanhDaTruc}' rồi!");
            }

            var caTruc = new CaTrucDTO
            {
                Thu_Thu_Ma_So = thuThuMaSo,
                Chi_Nhanh_Ma_So = chiNhanhMaSo,
                Ngay_Truc = ngayTruc.Date,
                Ten_Ca = tenCa,
                Gio_Bat_Dau = gioBatDau,
                Gio_Ket_Thuc = gioKetThuc,
                Tien_Dau_Ca = tienDauCa,
                Trang_Thai = "Chưa bắt đầu",
                Ghi_Chu = ghiChu
            };

            bool isAdded = _caTrucDal.ThemCaTruc(caTruc);
            if (isAdded)
            {
                return (true, $"Phân công {tenCa} ngày {ngayTruc:dd/MM/yyyy} thành công!");
            }

            return (false, "Lỗi lưu ca trực vào cơ sở dữ liệu!");
        }

        public (bool IsSuccess, string Message) XoaCaTruc(int maSoCaTruc)
        {
            return _caTrucDal.XoaCaTruc(maSoCaTruc)
                ? (true, "Đã xóa ca trực thành công!")
                : (false, "Không thể xóa ca trực đã bắt đầu hoặc đã kết ca!");
        }

        public List<CaTrucDTO> LayLichTrucThuThu(int thuThuMaSo, DateTime fromDate, DateTime toDate)
        {
            if (thuThuMaSo <= 0)
                return new List<CaTrucDTO>();

            return _caTrucDal.GetByThuThuAndDateRange(thuThuMaSo, fromDate, toDate);
        }

        public (bool HasShift, int CaTrucId, string TenCa, decimal TienDauCa, decimal TienThuPhat) LayCaTrucHienTai(int thuThuMaSo)
        {
            return _caTrucDal.LayCaTrucHienTai(thuThuMaSo);
        }

        public (bool IsSuccess, string Message) ChotCaTruc(int caTrucId, decimal tienKetCaThucTe)
        {
            try
            {
                bool result = _caTrucDal.ChotCaTruc(caTrucId, tienKetCaThucTe);
                if (result)
                    return (true, "Chốt ca và đối soát quỹ thành công!");
                return (false, "Không tìm thấy ca trực hoặc ca trực đã được chốt từ trước.");
            }
            catch (Exception ex)
            {
                SystemLogger.Log(LogLevel.ERROR, "Lỗi chốt ca trực", ex.Message);
                return (false, "Không thể hoàn tất chốt ca trực lúc này. Vui lòng kiểm tra lại đường truyền cơ sở dữ liệu!");
            }
        }

        public int LayChiNhanhTrucHomNay(int thuThuMaSo)
        {
            if (thuThuMaSo <= 0) return 1;
            return _caTrucDal.LayChiNhanhTrucHomNay(thuThuMaSo);
        }
    }
}