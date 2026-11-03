using System;
using Library.DTO;

namespace Library.UI
{
    /// <summary>
    /// Lưu trữ ngữ cảnh phiên làm việc của người dùng hiện tại trong toàn bộ ứng dụng.
    /// </summary>
    public static class SessionContext
    {
        public static NguoiDungDTO? CurrentUser { get; set; }
        public static ThuThuDTO? CurrentLibrarian { get; set; }
        public static DateTime LoginTime { get; set; }

        public static bool IsAdmin => CurrentUser != null && CurrentUser.Vai_Tro == "Admin";
        public static bool IsLibrarian => CurrentUser != null && CurrentUser.Vai_Tro == "Librarian";

        public static void Clear()
        {
            CurrentUser = null;
            CurrentLibrarian = null;
            LoginTime = DateTime.MinValue;
        }
    }
}