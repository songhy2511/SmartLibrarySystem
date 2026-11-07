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
    /// <summary>
    /// Kho sách: thêm đầu sách, sửa số lượng, xóa khi không còn cuốn đang mượn,
    /// thanh lý một bản hỏng, và chuyển một bản sao sang chi nhánh khác.
    /// </summary>
    public class SachBLL
    {
        private readonly SachDAL _dal = new SachDAL();

        /// <summary>Mã đầu sách kế tiếp dạng B0001. Chỉ để hiện trước; lúc lưu sẽ lấy lại mã mới.</summary>
        public string TaoMaSachMoi() => _dal.GetNextMaSach();

        /// <summary>Khả dụng không âm và không vượt tổng số bản. Đúng với CHECK của SQL.</summary>
        public bool KiemTraTinhToanVeng(SachDTO sach)
        {
            // Kiểm tra ràng buộc CHECK (So_Luong_Kha_Dung <= Tong_So_Luong) trong SQL
            return sach.So_Luong_Kha_Dung >= 0 && sach.So_Luong_Kha_Dung <= sach.Tong_So_Luong;
        }

        /// <summary>Nhập đầu sách mới. Mã do CSDL sinh lại ngay trước khi Insert để tránh hai người lấy trùng mã.</summary>
        public bool ThemSachMoi(SachDTO sach, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(sach.Tieu_De))
            {
                errorMessage = "Tiêu đề sách không được để trống!";
                return false;
            }

            if (!KiemTraTinhToanVeng(sach))
            {
                errorMessage = "Số lượng khả dụng không được lớn hơn tổng số lượng (0 <= Khả dụng <= Tổng)!";
                return false;
            }

            sach.Ma_Sach = _dal.GetNextMaSach();
            bool result = _dal.Insert(sach);

            if (result)
            {
                SystemLogger.Log(LogLevel.INFO, "Quản lý Kho Sách",
                    $"Nhập kho đầu sách {sach.Ma_Sach} - {sach.Tieu_De} (SL: {sach.Tong_So_Luong})", nguoiDungMaSo);
            }
            return result;
        }

        /// <summary>Sửa thông tin hoặc số lượng. Vẫn kiểm tra khả dụng không lớn hơn tổng.</summary>
        public bool CapNhatKhoSach(SachDTO sach, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!KiemTraTinhToanVeng(sach))
            {
                errorMessage = "Số lượng khả dụng không được lớn hơn tổng số lượng!";
                return false;
            }

            bool result = _dal.Update(sach);
            if (result)
            {
                SystemLogger.Log(LogLevel.INFO, "Quản lý Kho Sách",
                    $"Cập nhật thông tin/số lượng đầu sách {sach.Ma_Sach}", nguoiDungMaSo);
            }
            return result;
        }

        /// <summary>Các bản sao còn sẵn sàng của một đầu sách tại đúng chi nhánh, dùng khi điều phối.</summary>
        public DataTable LayBanSaoSanCoTaiChiNhanh(string maSach, int chiNhanhId)
        {
            return _dal.LayBanSaoSanCoTaiChiNhanh(maSach, chiNhanhId);
        }

        /// <summary>Chuyển một bản sao từ chi nhánh nguồn sang chi nhánh đích. Hai chi nhánh phải khác nhau.</summary>
        public (bool IsSuccess, string Message) DieuPhoiSach(int banSaoMaSo, string maVach, string tieuDe, int chiNhanhNguonId, int chiNhanhDichId, string ghiChu, int? adminUserId)
        {
            if (banSaoMaSo <= 0)
                return (false, "Vui lòng chọn cuốn sách (mã vạch) cần điều phối!");

            if (chiNhanhNguonId == chiNhanhDichId)
                return (false, "Chi nhánh nhận sách phải khác chi nhánh hiện tại!");

            bool result = _dal.ChuyenChiNhanhBanSao(banSaoMaSo, chiNhanhNguonId, chiNhanhDichId, ghiChu);
            if (result)
            {
                SystemLogger.Log(
                    LogLevel.INFO,
                    "Điều phối sách",
                    $"Quản trị viên đã luân chuyển cuốn '{tieuDe}' [{maVach}] từ chi nhánh ID {chiNhanhNguonId} sang chi nhánh ID {chiNhanhDichId}. Lý do: {ghiChu}",
                    adminUserId
                );
                return (true, "Điều phối sách giữa các chi nhánh thành công!");
            }

            return (false, "Điều phối thất bại! Cuốn sách có thể đã đổi trạng thái hoặc không còn sẵn sàng.");
        }
        /// <summary>
        /// Xóa đầu sách chỉ khi mọi bản đều còn trên kệ (khả dụng = tổng).
        /// Nếu khả dụng nhỏ hơn tổng thì còn bản đang cho mượn, không cho xóa.
        /// </summary>
        public bool XoaSach(string maSach, int? nguoiDungMaSo, out string errorMessage)
        {
            errorMessage = string.Empty;

            DataTable dt = _dal.TimKiemSachAsync(maSach).Result;
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                int tong = Convert.ToInt32(dr["Tong_So_Luong"]);
                int khaDung = Convert.ToInt32(dr["So_Luong_Kha_Dung"]);

                // Kiểm tra xem có sách đang cho mượn không
                if (khaDung < tong)
                {
                    errorMessage = $"Không thể xóa sách '{maSach}' vì đang có {tong - khaDung} cuốn đang được độc giả mượn!";
                    return false;
                }
            }



            bool result = _dal.Delete(maSach);
            if (result)
            {
                SystemLogger.Log(LogLevel.WARNING, "Quản lý Kho Sách",
                    $"Đã xóa thành công đầu sách {maSach} khỏi hệ thống", nguoiDungMaSo);
            }
            return result;
        }

        /// <summary>Giảm một bản khả dụng vì hỏng nặng. Không cho thanh lý khi kệ đã hết cuốn sẵn sàng.</summary>
        public bool DeXuatThanhLyCuonSach(string maSach, string tieuDe, int khaDung, int? currentUserId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(maSach))
            {
                errorMessage = "Chưa chọn đầu sách cần thanh lý!";
                return false;
            }

            if (khaDung <= 0)
            {
                errorMessage = $"Đầu sách '{tieuDe}' hiện không còn cuốn nào khả dụng trên kệ (có thể sách đang được mượn hết)!";
                return false;
            }

            bool result = _dal.ThanhLyMotCuonSach(maSach);
            if (result)
            {
                SystemLogger.Log(
                    LogLevel.WARNING,
                    "Thanh lý tài liệu",
                    $"Thủ thư đã thanh lý 1 cuốn hư hỏng thuộc đầu sách '{tieuDe}' ({maSach}).",
                    currentUserId
                );
            }
            else
            {
                errorMessage = "Lỗi thực thi trong cơ sở dữ liệu khi thanh lý sách!";
            }

            return result;
        }
        /// <summary>
        /// Chuyển tiếp truy vấn tìm kiếm sách bất đồng bộ từ giao diện xuống DAL
        /// </summary>
        public async Task<DataTable> TimKiemSachAsync(string tuKhoa)
        {
            // Gọi đúng tên hàm TimKiemSachAsync mà bạn vừa đổi ở tầng DAL
            return await _dal.TimKiemSachAsync(tuKhoa);
        }
    }
}