using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Library.DAL;

namespace Library.BLL
{
    public enum LogLevel
    {
        INFO,       // Hoạt động nghiệp vụ thông thường (Mượn, Trả, Xem báo cáo)
        WARNING,    // Cảnh báo quy chế, tiền lệch, sửa đổi tham số
        ERROR,      // Lỗi hệ thống, ngoại lệ CSDL, thất bại tác vụ
        SECURITY    // Đăng nhập, đăng xuất, đổi mật khẩu, phân quyền
    }

    public static class SystemLogger
    {
        private static readonly NhatKyHeThongDAL _dal = new NhatKyHeThongDAL();
        private static readonly object _fileLock = new object();

        // Đường dẫn thư mục lưu file log text cho lập trình viên
        private static readonly string LogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        /// <summary>
        /// Ghi nhận toàn bộ hoạt động hệ thống vào cả CSDL và File text
        /// </summary>
        public static void Log(LogLevel level, string hanhDong, string chiTiet, int? nguoiDungMaSo = null, string? ip = null)
        {
            DateTime now = DateTime.Now;
            string clientIp = string.IsNullOrWhiteSpace(ip) ? LayDiaChiIP() : ip;
            string levelStr = level.ToString();

            // 1. Ghi vào CSDL SQL Server (để nạp lên FormNhatKyHeThong)
            try
            {
                _dal.GhiNhatKyCoMucDo(nguoiDungMaSo, levelStr, hanhDong, chiTiet, clientIp);
            }
            catch (Exception ex)
            {
                GhiFileText(now, "ERROR", "SystemLogger", $"Lỗi ghi Database: {ex.Message}", clientIp, nguoiDungMaSo);
            }

            // 2. Ghi vào File Text cho lập trình viên kiểm tra
            GhiFileText(now, levelStr, hanhDong, chiTiet, clientIp, nguoiDungMaSo);
        }

        private static void GhiFileText(DateTime time, string level, string action, string detail, string ip, int? userId)
        {
            try
            {
                lock (_fileLock)
                {
                    if (!Directory.Exists(LogDirectory))
                    {
                        Directory.CreateDirectory(LogDirectory);
                    }

                    string logFilePath = Path.Combine(LogDirectory, $"system_audit_{time:yyyyMMdd}.log");
                    string userTag = userId.HasValue ? $"UserID:{userId.Value}" : "Anonymous/System";

                    // Định dạng dòng text log chuẩn
                    string logLine = $"[{time:yyyy-MM-dd HH:mm:ss.fff}] [{level,-8}] [{userTag}] [IP:{ip}] [{action}] - {detail}{Environment.NewLine}";

                    File.AppendAllText(logFilePath, logLine);
                }
            }
            catch
            {
                // Không ngắt luồng ứng dụng nếu việc ghi file text gặp trở ngại I/O
            }
        }

        public static string LayThuMucLog()
        {
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }
            return LogDirectory;
        }

        private static string LayDiaChiIP()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch { }
            return "127.0.0.1";
        }
    }
}