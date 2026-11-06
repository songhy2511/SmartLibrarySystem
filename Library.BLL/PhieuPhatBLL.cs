using System;
using System.Data;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    public class PhieuPhatBLL
    {
        private readonly PhieuPhatDAL _phieuPhatDAL = new PhieuPhatDAL();

        public DataTable LayDanhSachBienBan()
        {
            return _phieuPhatDAL.LayDanhSachPhieuPhat();
        }

        public (bool IsSuccess, string Message) LapBienBan(string maDocGia, decimal soTien, string lyDo, int thuThuId, int? chiNhanhId)
        {
            if (string.IsNullOrWhiteSpace(maDocGia))
                return (false, "Vui lòng nhập mã hoặc chọn độc giả vi phạm!");

            if (soTien <= 0)
                return (false, "Số tiền phạt phải lớn hơn 0 VNĐ!");

            if (string.IsNullOrWhiteSpace(lyDo))
                return (false, "Vui lòng ghi rõ lý do hoặc mô tả biên bản vi phạm!");

            DataTable dtDG = _phieuPhatDAL.LayDocGiaTheoMa(maDocGia.Trim());
            if (dtDG.Rows.Count == 0)
                return (false, $"Không tìm thấy độc giả với mã '{maDocGia}' trong hệ thống!");

            int docGiaId = Convert.ToInt32(dtDG.Rows[0]["Ma_So"]);

            var dto = new PhieuPhatDTO
            {
                Doc_Gia_Ma_So = docGiaId,
                Thu_Thu_Ma_So = thuThuId,
                Chi_Nhanh_Ma_So = chiNhanhId ?? 1,
                So_Tien_Phat = soTien,
                Ly_Do = lyDo.Trim(),
                Ngay_Lap = DateTime.Now,
                Trang_Thai = "Chưa thu",
                Da_Thanh_Toan = false
            };

            bool res = _phieuPhatDAL.ThemPhieuPhat(dto);
            return res ? (true, "Lập biên bản vi phạm thành công!") : (false, "Lỗi kết nối cơ sở dữ liệu khi lưu biên bản!");
        }
    }
}