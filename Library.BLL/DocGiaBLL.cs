using Library.DAL;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.BLL
{
    public class DocGiaBLL
    {
        private readonly DocGiaDAL _dal = new DocGiaDAL();

        public string TaoMaDocGiaMoi() => _dal.GetNextMaDocGia();

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

        public DataTable TimKiemDocGia(string keyword) => _dal.Search(keyword);
        public class DocGiaBLL
        {
            private readonly DocGiaDAL _dal = new DocGiaDAL();

            public string TaoMaDocGiaMoi() => _dal.GetNextMaDocGia();

            public bool ThemDocGia(DocGiaDTO dg, int? nguoiDungMaSo, out string errorMessage)
            {
                errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(dg.Ho_Ten))
                {
                    errorMessage = "Họ tên độc giả không được để trống!";
                    return false;
                }

                if (!string.IsNullOrWhiteSpace(dg.So_Dien_Thoai) && !Regex.IsMatch(dg.So_Dien_Thoai, @"^[0-9]{10,11}$"))
                {
                    errorMessage = "Số điện thoại không hợp lệ (phải từ 10-11 chữ số)!";
                    return false;
                }

                dg.Ngay_Het_Han_The = DateTime.Today.AddYears(4);
                dg.Ma_Doc_Gia = _dal.GetNextMaDocGia();
                dg.Trang_Thai_The = "Hoạt động";

                bool result = _dal.Insert(dg);
                if (result)
                {
                    SystemLogger.Log(LogLevel.INFO, "Quản lý Bạn Đọc",
                        $"Thêm mới độc giả {dg.Ma_Doc_Gia} - {dg.Ho_Ten}", nguoiDungMaSo);
                }
                return result;
            }

            public bool XoaDocGia(string maDocGia, int? nguoiDungMaSo, out string errorMessage)
            {
                errorMessage = string.Empty;
                if (string.IsNullOrWhiteSpace(maDocGia))
                {
                    errorMessage = "Mã độc giả không hợp lệ!";
                    return false;
                }

                bool result = _dal.Delete(maDocGia);
                if (result)
                {
                    SystemLogger.Log(LogLevel.WARNING, "Quản lý Bạn Đọc",
                        $"Đã xóa mềm tài khoản độc giả {maDocGia}", nguoiDungMaSo);
                }
                return result;
            }

            public DataTable TimKiemDocGia(string keyword) => _dal.Search(keyword);
        }
    }
}