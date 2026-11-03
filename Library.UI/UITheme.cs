using System.Drawing;

namespace Library.UI
{
    public static class UITheme
    {
        // Tông màu chủ đạo (Deep Slate & Navy)
        public static readonly Color Primary = Color.FromArgb(2, 132, 199);       // Xanh điểm nhấn (Sky Blue)
        public static readonly Color SidebarBg = Color.FromArgb(15, 23, 42);     // Nền Sidebar tối
        public static readonly Color SidebarHeader = Color.FromArgb(2, 6, 23);   // Nền Logo trên cùng
        public static readonly Color NavButtonActive = Color.FromArgb(30, 41, 59); // Nút menu đang chọn
        public static readonly Color NavButtonText = Color.FromArgb(203, 213, 225); // Màu chữ menu

        // Nền nội dung & Tiêu đề
        public static readonly Color ContentBg = Color.FromArgb(248, 250, 252);   // Nền vùng làm việc
        public static readonly Color HeaderBg = Color.White;                    // Nền thanh header
        public static readonly Color TitleText = Color.FromArgb(15, 23, 42);     // Màu chữ tiêu đề
        public static readonly Color SubText = Color.FromArgb(100, 116, 139);    // Màu chữ phụ

        // Nút hành động
        public static readonly Color Danger = Color.FromArgb(225, 29, 72);       // Nút đăng xuất/xóa
    }
}