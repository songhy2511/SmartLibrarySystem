using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.BLL.Security
{
    /// <summary>
    /// Cung cấp các tiện ích mã hóa mật khẩu chuẩn SHA-256 kết hợp chuỗi muối (Salt)
    /// Đảm bảo tương thích 100% với hàm HASHBYTES('SHA2_256', ...) của SQL Server.
    /// </summary>
    public static class PasswordHasher
    {
        private const int DefaultSaltSize = 16; // 128-bit Salt

        /// <summary>
        /// Sinh chuỗi muối (Salt) ngẫu nhiên an toàn bằng bộ sinh số ngẫu nhiên mật mã (CSPRNG).
        /// </summary>
        /// <param name="size">Kích thước byte của muối (mặc định 16 bytes)</param>
        /// <returns>Chuỗi Salt biểu diễn dưới dạng Base64</returns>
        public static string GenerateSalt(int size = DefaultSaltSize)
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(size);
            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// Băm mật khẩu kết hợp với Salt bằng thuật toán SHA-256.
        /// Kết quả trả về là chuỗi Hex 64 ký tự in hoa, khớp với định dạng CONVERT(VARCHAR(64), HASHBYTES(...), 2) trong CSDL.
        /// </summary>
        /// <param name="password">Mật khẩu thô dạng văn bản rõ</param>
        /// <param name="salt">Chuỗi muối đã sinh</param>
        /// <returns>Chuỗi băm Hex 64 ký tự</returns>
        public static string HashPassword(string password, string salt)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Mật khẩu không được để trống.", nameof(password));

            if (string.IsNullOrEmpty(salt))
                throw new ArgumentException("Chuỗi muối (Salt) không được để trống.", nameof(salt));

            // Ghép password thô và salt theo đúng thứ tự trong kịch bản CSDL (password + salt)
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = SHA256.HashData(combinedBytes);

            // Chuyển sang chuỗi HEX viết hoa (không có dấu gạch ngang)
            return Convert.ToHexString(hashBytes);
        }

        /// <summary>
        /// So khớp mật khẩu nhập vào với mã băm lưu trữ trong CSDL.
        /// Sử dụng CryptographicOperations.FixedTimeEquals để ngăn chặn tấn công Timing Attack.
        /// </summary>
        /// <param name="inputPassword">Mật khẩu người dùng nhập</param>
        /// <param name="storedHash">Mã băm lưu trong CSDL (cột Mat_Khau_Ma_Hoa)</param>
        /// <param name="storedSalt">Chuỗi muối lưu trong CSDL (cột Chuoi_Muoi)</param>
        /// <returns>True nếu mật khẩu hợp lệ, False nếu sai</returns>
        public static bool VerifyPassword(string inputPassword, string storedHash, string storedSalt)
        {
            if (string.IsNullOrEmpty(inputPassword) || string.IsNullOrEmpty(storedHash) || string.IsNullOrEmpty(storedSalt))
                return false;

            try
            {
                // Tính toán mã băm cho mật khẩu vừa nhập
                string computedHash = HashPassword(inputPassword, storedSalt);

                // Chuyển cả 2 chuỗi Hex về mảng byte để so sánh với thời gian cố định
                byte[] computedBytes = Convert.FromHexString(computedHash);
                byte[] storedBytes = Convert.FromHexString(storedHash);

                return CryptographicOperations.FixedTimeEquals(computedBytes, storedBytes);
            }
            catch
            {
                // Bắt ngoại lệ nếu chuỗi Hex trong DB bị hỏng hoặc định dạng sai
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra độ mạnh của mật khẩu theo chuẩn an toàn thông tin:
        /// Tối thiểu 6 ký tự, có ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ký tự đặc biệt.
        /// </summary>
        /// <param name="password">Mật khẩu cần thẩm định</param>
        /// <returns>(IsValid, Thông báo chi tiết)</returns>
        public static (bool IsValid, string ErrorMessage) ValidatePasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return (false, "Mật khẩu không được để trống.");

            if (password.Length < 6)
                return (false, "Mật khẩu phải có độ dài tối thiểu từ 6 ký tự trở lên.");

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return (false, "Mật khẩu phải chứa ít nhất một chữ cái in hoa (A-Z).");

            if (!Regex.IsMatch(password, @"[a-z]"))
                return (false, "Mật khẩu phải chứa ít nhất một chữ cái in thường (a-z).");

            if (!Regex.IsMatch(password, @"[0-9]"))
                return (false, "Mật khẩu phải chứa ít nhất một chữ số (0-9).");

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?/:;{}|<>]"))
                return (false, "Mật khẩu phải chứa ít nhất một ký tự đặc biệt (!@#$%^&*...).");

            return (true, string.Empty);
        }
    }
}