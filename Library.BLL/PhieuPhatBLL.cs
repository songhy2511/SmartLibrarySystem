using System;
using Library.DAL;

namespace Library.BLL
{
    public class PhieuPhatBLL
    {
        private readonly PhieuPhatDAL _dal = new PhieuPhatDAL();

        public (bool IsSuccess, string Message) LapBienBanToanDien(int? phieuMuonMaSo, int docGiaMaSo, int thuThuId, int chiNhanhId, decimal soTien, string lyDo, string loaiViPham, int banSaoMaSo)
        {
            try
            {
                _dal.LapBienBanToanDien(phieuMuonMaSo, docGiaMaSo, thuThuId, chiNhanhId, soTien, lyDo, loaiViPham, banSaoMaSo);
                return (true, "Lập biên bản vi phạm thành công! Thông tin công nợ và trạng thái tài sản đã được đồng bộ.");
            }
            catch (Exception ex)
            {
                return (false, "Lỗi hệ thống khi lập biên bản: " + ex.Message);
            }
        }

        public (bool IsSuccess, string Message) ThuTienPhatGiaoDich(int maBienBan, int thuThuId, decimal soTien)
        {
            try
            {
                _dal.ThuTienPhatGiaoDich(maBienBan, thuThuId, soTien);
                return (true, "Thu tiền phạt thành công! Đã ghi nhận dòng tiền đối soát ca trực.");
            }
            catch (Exception ex)
            {
                return (false, "Lỗi hệ thống khi thu tiền: " + ex.Message);
            }
        }
    }
}