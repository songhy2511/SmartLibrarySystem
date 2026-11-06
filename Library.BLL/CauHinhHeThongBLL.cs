using System;
using System.Collections.Generic;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class CauHinhHeThongBLL
    {
        private readonly CauHinhHeThongDAL _dal = new CauHinhHeThongDAL();

        // Định danh các tham số chuẩn của hệ thống
        public const string KEY_SO_SACH_MUON_TOI_DA = "So_Sach_Muon_Toi_Da";
        public const string KEY_SO_NGAY_MUON_TOI_DA = "So_Ngay_Muon_Toi_Da";
        public const string KEY_TIEN_PHAT_MOI_NGAY = "Tien_Phat_Moi_Ngay";
        public const string KEY_THOI_HAN_THE_THANG = "Thoi_Han_The_Thang";

        public List<CauHinhHeThongDTO> LayDanhSachCauHinh()
        {
            return _dal.GetAll();
        }

        public int LaySoSachMuonToiDa()
        {
            return int.TryParse(_dal.LayGiaTri(KEY_SO_SACH_MUON_TOI_DA, "5"), out int val) ? val : 5;
        }

        public int LaySoNgayMuonToiDa()
        {
            return int.TryParse(_dal.LayGiaTri(KEY_SO_NGAY_MUON_TOI_DA, "14"), out int val) ? val : 14;
        }

        public decimal LayTienPhatMoiNgay()
        {
            return decimal.TryParse(_dal.LayGiaTri(KEY_TIEN_PHAT_MOI_NGAY, "5000"), out decimal val) ? val : 5000m;
        }

        public int LayThoiHanTheThang()
        {
            return int.TryParse(_dal.LayGiaTri(KEY_THOI_HAN_THE_THANG, "12"), out int val) ? val : 12;
        }

        public (bool IsSuccess, string Message) LuuQuyChe(
            int soSachMuon,
            int soNgayMuon,
            decimal tienPhat,
            int thoiHanThe)
        {
            if (soSachMuon <= 0 || soSachMuon > 50)
                return (false, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!");

            if (soNgayMuon <= 0 || soNgayMuon > 180)
                return (false, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!");

            if (tienPhat < 0)
                return (false, "Tiền phạt trả trễ mỗi ngày không được âm!");

            if (thoiHanThe <= 0 || thoiHanThe > 60)
                return (false, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!");

            bool ok1 = _dal.CapNhatGiaTri(KEY_SO_SACH_MUON_TOI_DA, soSachMuon.ToString());
            bool ok2 = _dal.CapNhatGiaTri(KEY_SO_NGAY_MUON_TOI_DA, soNgayMuon.ToString());
            bool ok3 = _dal.CapNhatGiaTri(KEY_TIEN_PHAT_MOI_NGAY, tienPhat.ToString("0"));
            bool ok4 = _dal.CapNhatGiaTri(KEY_THOI_HAN_THE_THANG, thoiHanThe.ToString());

            if (ok1 && ok2 && ok3 && ok4)
            {
                return (true, "Đã cập nhật quy chế và tham số hệ thống thành công!");
            }

            return (false, "Lưu tham số thất bại. Vui lòng kiểm tra lại kết nối CSDL!");
        }
        public string LayGiaTri(string tenCauHinh)
        {
            return _dal.LayGiaTri(tenCauHinh, "");
        }
    }
}   