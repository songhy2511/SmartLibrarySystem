using System;
using Library.DAL;

namespace Library.BLL
{
    /// <summary>
    /// Biên bản vi phạm và thu phạt. Việc ghi nhiều bảng (biên bản, trạng thái bản sao, quỹ ca)
    /// nằm trong stored procedure ở DAL, nên lớp này chỉ bọc kết quả thành (thành công, thông báo).
    /// </summary>
    public class PhieuPhatBLL
    {
        private readonly PhieuPhatDAL _dal = new PhieuPhatDAL();

        /// <summary>
        /// Gọi sp_LapBienBanViPham. loaiViPham quyết định bản sao chuyển sang Hư hỏng hay Mất/Thanh lý.
        /// phieuMuonMaSo có thể null khi vi phạm không gắn một phiếu mượn cụ thể.
        /// </summary>
        public (bool IsSuccess, string Message) LapBienBanToanDien(int? phieuMuonMaSo, int docGiaMaSo, int thuThuId, int chiNhanhId, decimal soTien, string lyDo, string loaiViPham, int banSaoMaSo)
        {
            try
            {
                _dal.LapBienBanToanDien(phieuMuonMaSo, docGiaMaSo, thuThuId, chiNhanhId, soTien, lyDo, loaiViPham, banSaoMaSo);
                return (true, "Lập biên bản vi phạm thành công! Thông tin công nợ và trạng thái tài sản đã được đồng bộ.");
            }
            catch (Exception ex)
            {
                SystemLogger.Log(LogLevel.ERROR, "Lỗi lập biên bản", ex.Message);
                return (false, "Không thể lập biên bản vi phạm do lỗi kết nối dữ liệu. Vui lòng thử lại sau!");
            }
        }

        /// <summary>Gọi sp_ThuTienPhat: đánh dấu đã thu và cộng số tiền vào quỹ ca trực hiện tại của thủ thư.</summary>
        public (bool IsSuccess, string Message) ThuTienPhatGiaoDich(int maBienBan, int thuThuId, decimal soTien)
        {
            try
            {
                _dal.ThuTienPhatGiaoDich(maBienBan, thuThuId, soTien);
                return (true, "Thu tiền phạt thành công! Đã ghi nhận dòng tiền đối soát ca trực.");
            }
            catch (Exception ex)
            {
                SystemLogger.Log(LogLevel.ERROR, "Lỗi thu tiền phạt", ex.Message);
                return (false, "Giao dịch thu tiền phạt chưa thành công do hệ thống bận. Vui lòng kiểm tra lại ca trực!");
            }
        }
    }
}