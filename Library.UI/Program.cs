using Library.DTO;

namespace Library.UI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        SessionContext.CurrentUser = new NguoiDungDTO
        {
            Ma_So = 1,
            Ten_Dang_Nhap = "admin",
            Vai_Tro = "Admin"
        };

        // Gán mốc thời gian hiện tại để tránh lỗi 01/01/0001
        SessionContext.LoginTime = DateTime.Now;

        Application.Run(new FormAdminDashboard());
        Application.Run(new FormDangNhap());
    }    
}