using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    /// <summary>Hồ sơ bạn đọc: cấp thẻ, khóa thẻ, gia hạn, tìm kiếm. Ngày cấp là hôm nay, hạn thẻ mặc định 4 năm.</summary>
    public class DocGiaBLL
    {
        private readonly DocGiaDAL _dal = new DocGiaDAL();

        /// <summary>Mã thẻ kế tiếp để hiện trên form trước khi lưu.</summary>
        public string TaoMaDocGiaMoi() => _dal.GetNextMaDocGia();

        /// <summary>Tạo thẻ trạng thái "Hoạt động", hạn 4 năm kể từ hôm nay.</summary>
        public bool ThemDocGia(DocGiaDTO dg, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(dg.Ho_Ten))
            {
                errorMessage = "Họ tên độc giả không được để trống!";
                return false;
            }

            dg.Ngay_Cap_The = DateTime.Today;
            dg.Ngay_Het_Han_The = DateTime.Today.AddYears(4);
            dg.Ma_Doc_Gia = _dal.GetNextMaDocGia();
            dg.Trang_Thai = "Hoạt động";

            bool result = _dal.Insert(dg);
            if (result)
            {
                SystemLogger.Log(LogLevel.INFO, "Quản lý Bạn Đọc",
                    $"Thêm mới độc giả {dg.Ma_Doc_Gia} - {dg.Ho_Ten}", nguoiDungMaSo);
            }
            return result;
        }

        /// <summary>Ngừng hoạt động thẻ. DAL thường không xóa cứng để giữ lịch sử mượn.</summary>
        public bool XoaDocGia(string maDocGia, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(maDocGia))
            {
                errorMessage = "Chưa chọn độc giả cần xóa!";
                return false;
            }

            bool result = _dal.Delete(maDocGia);
            if (result)
            {
                SystemLogger.Log(LogLevel.WARNING, "Quản lý Bạn Đọc",
                    $"Đã xóa (ngừng hoạt động) tài khoản độc giả {maDocGia}", nguoiDungMaSo);
            }
            return result;
        }

        public bool CapNhatDocGia(DocGiaDTO dg, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(dg.Ma_Doc_Gia))
            {
                errorMessage = "Vui lòng chọn độc giả cần cập nhật từ danh sách!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(dg.Ho_Ten))
            {
                errorMessage = "Họ và tên độc giả không được để trống!";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(dg.Email) && !dg.Email.Contains('@'))
            {
                errorMessage = "Địa chỉ email không đúng định dạng!";
                return false;
            }

            bool result = _dal.Update(dg);
            if (result)
            {
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Quản lý Bạn Đọc",
                    $"Cập nhật thông tin độc giả [{dg.Ma_Doc_Gia}] - {dg.Ho_Ten} (SĐT: {dg.So_Dien_Thoai ?? "--"}, Email: {dg.Email ?? "--"}).",
                    nguoiDungMaSo
                );
            }
            else
            {
                errorMessage = "Cập nhật dữ liệu thất bại. Vui lòng kiểm tra lại kết nối!";
            }

            return result;
        }

        /// <summary>isKhoa = true thì "Khóa tạm thời", false thì trả về "Hoạt động".</summary>
        public bool ThayDoiTrangThaiKhoa(string maDocGia, bool isKhoa, int? nguoiDungMaSo)
        {
            string trangThaiMoi = isKhoa ? "Khóa tạm thời" : "Hoạt động";
            bool res = _dal.UpdateTrangThaiThe(maDocGia, trangThaiMoi);
            if (res)
            {
                SystemLogger.Log(LogLevel.INFO, "Quản lý Bạn Đọc",
                    $"Đã đổi trạng thái thẻ độc giả {maDocGia} sang '{trangThaiMoi}'", nguoiDungMaSo);
            }
            return res;
        }

        /// <summary>Cộng thêm số năm vào ngày hết hạn thẻ hiện tại.</summary>
        public bool GiaHanTheDocGia(string maDocGia, int soNam, int? nguoiDungMaSo)
        {
            bool res = _dal.GiaHanThe(maDocGia, soNam);
            if (res)
            {
                SystemLogger.Log(LogLevel.INFO, "Quản lý Bạn Đọc",
                    $"Gia hạn thẻ độc giả {maDocGia} thêm {soNam} năm", nguoiDungMaSo);
            }
            return res;
        }

        /// <summary>Tìm theo mã thẻ hoặc họ tên. Chuỗi rỗng trả về danh sách để form tự lọc.</summary>
        public DataTable TimKiemDocGia(string keyword) => _dal.Search(keyword);
    }
}