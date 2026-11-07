using System;
using Library.DTO;

namespace Library.UI
{
    /// <summary>
    /// Phiên làm việc hiện tại, dùng chung cho mọi form (biến tĩnh, sống suốt lúc app chạy).
    /// Form đăng nhập gán giá trị; dashboard và các màn con đọc lại để biết ai đang thao tác.
    /// </summary>
    public static class SessionContext
    {
        /// <summary>Tài khoản vừa đăng nhập (Admin hoặc Librarian). Null khi chưa đăng nhập hoặc đã đăng xuất.</summary>
        public static NguoiDungDTO? CurrentUser { get; set; }

        /// <summary>Hồ sơ thủ thư (họ tên, quầy). Chỉ có giá trị khi vai trò là Librarian; Admin thì null.</summary>
        public static ThuThuDTO? CurrentLibrarian { get; set; }

        /// <summary>Thời điểm đăng nhập thành công, hiển thị trên thanh tiêu đề dashboard.</summary>
        public static DateTime LoginTime { get; set; }

        /// <summary>True khi đã đăng nhập và cột Vai_Tro đúng chữ "Admin".</summary>
        public static bool IsAdmin => CurrentUser != null && CurrentUser.Vai_Tro == "Admin";

        /// <summary>True khi đã đăng nhập và cột Vai_Tro đúng chữ "Librarian".</summary>
        public static bool IsLibrarian => CurrentUser != null && CurrentUser.Vai_Tro == "Librarian";

        /// <summary>Xóa sạch phiên. Gọi khi thủ thư đăng xuất để form sau không còn dùng nhầm người cũ.</summary>
        public static void Clear()
        {
            CurrentUser = null;
            CurrentLibrarian = null;
            LoginTime = DateTime.MinValue;
        }
    }
}