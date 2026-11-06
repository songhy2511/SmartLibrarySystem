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

        // 👉 Các tham số tỷ lệ đền bù mới
        public const string KEY_TY_LE_PHAT_RACH = "Ty_Le_Phat_Rach";
        public const string KEY_TY_LE_PHAT_HONG = "Ty_Le_Phat_Hong";
        public const string KEY_TY_LE_PHAT_MAT = "Ty_Le_Phat_Mat";

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
            return decimal.TryParse(_dal.LayGiaTri(KEY_TIEN_PHAT_MOI_NGAY, "3000"), out decimal val) ? val : 3000m;
        }

        public int LayThoiHanTheThang()
        {
            return int.TryParse(_dal.LayGiaTri(KEY_THOI_HAN_THE_THANG, "12"), out int val) ? val : 12;
        }

        // 👉 Các hàm đọc tỷ lệ đền bù (%)
        public decimal LayTyLePhatRach()
        {
            return decimal.TryParse(_dal.LayGiaTri(KEY_TY_LE_PHAT_RACH, "30"), out decimal val) ? val : 30m;
        }

        public decimal LayTyLePhatHong()
        {
            return decimal.TryParse(_dal.LayGiaTri(KEY_TY_LE_PHAT_HONG, "60"), out decimal val) ? val : 60m;
        }

        public decimal LayTyLePhatMat()
        {
            return decimal.TryParse(_dal.LayGiaTri(KEY_TY_LE_PHAT_MAT, "100"), out decimal val) ? val : 100m;
        }

        public (bool IsSuccess, string Message) LuuQuyCheToanDien(
            int soSachMuon,
            int soNgayMuon,
            decimal tienPhat,
            int thoiHanThe,
            decimal tyLeRach,
            decimal tyLeHong,
            decimal tyLeMat)
        {
            if (soSachMuon <= 0 || soSachMuon > 50)
                return (false, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!");

            if (soNgayMuon <= 0 || soNgayMuon > 180)
                return (false, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!");

            if (tienPhat < 0)
                return (false, "Tiền phạt trả trễ mỗi ngày không được âm!");

            if (thoiHanThe <= 0 || thoiHanThe > 60)
                return (false, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!");

            if (tyLeRach < 0 || tyLeRach > 200 || tyLeHong < 0 || tyLeHong > 200 || tyLeMat < 0 || tyLeMat > 500)
                return (false, "Tỷ lệ đền bù (%) không hợp lệ!");

            bool ok1 = _dal.CapNhatGiaTri(KEY_SO_SACH_MUON_TOI_DA, soSachMuon.ToString());
            bool ok2 = _dal.CapNhatGiaTri(KEY_SO_NGAY_MUON_TOI_DA, soNgayMuon.ToString());
            bool ok3 = _dal.CapNhatGiaTri(KEY_TIEN_PHAT_MOI_NGAY, tienPhat.ToString("0"));
            bool ok4 = _dal.CapNhatGiaTri(KEY_THOI_HAN_THE_THANG, thoiHanThe.ToString());
            bool ok5 = _dal.CapNhatGiaTri(KEY_TY_LE_PHAT_RACH, tyLeRach.ToString("0"));
            bool ok6 = _dal.CapNhatGiaTri(KEY_TY_LE_PHAT_HONG, tyLeHong.ToString("0"));
            bool ok7 = _dal.CapNhatGiaTri(KEY_TY_LE_PHAT_MAT, tyLeMat.ToString("0"));

            if (ok1 && ok2 && ok3 && ok4 && ok5 && ok6 && ok7)
            {
                return (true, "Đã cập nhật quy chế và tham số hệ thống toàn diện thành công!");
            }

            return (false, "Lưu tham số thất bại. Vui lòng kiểm tra lại kết nối CSDL!");
        }

        public string LayGiaTri(string tenCauHinh)
        {
            return _dal.LayGiaTri(tenCauHinh, "");
        }
    }
}