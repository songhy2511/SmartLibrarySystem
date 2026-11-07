namespace Library.UI;

/// <summary>
/// Điểm vào của chương trình WinForms.
/// Luôn mở màn đăng nhập trước; sau khi đăng nhập thành công mới vào dashboard Admin hoặc Thủ thư.
/// </summary>
static class Program
{
    /// <summary>
    /// Khởi động ứng dụng. [STAThread] là bắt buộc với Windows Forms (giao diện chạy trên một luồng).
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize(); // Bật DPI cao và font mặc định của .NET 8
        Application.Run(new FormDangNhap());   // Vòng lặp thông điệp; app sống đến khi form đăng nhập đóng hẳn
    }
}