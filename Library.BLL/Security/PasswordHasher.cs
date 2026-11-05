using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.BLL.Security
{
    public static class PasswordHasher
    {
        private const int DefaultSaltSize = 16;        // 128-bit Salt
        private const int HashByteSize = 32;           // 256-bit Key (64 ký tự Hex)
        private const int Iterations = 100_000;        // 100.000 vòng lặp theo chuẩn OWASP/NIST
        private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA256;

        public static string GenerateSalt(int size = DefaultSaltSize)
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(size);
            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// Băm mật khẩu chậm bằng thuật toán PBKDF2-HMAC-SHA256 (100.000 vòng lặp)
        /// </summary>
        public static string HashPassword(string password, string salt)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Mật khẩu không được để trống.", nameof(password));

            if (string.IsNullOrEmpty(salt))
                throw new ArgumentException("Chuỗi muối (Salt) không được để trống.", nameof(salt));

            byte[] saltBytes = Convert.FromBase64String(salt);

            byte[] hashBytes = Rfc2898DeriveBytes.Pbkdf2(
                password,
                saltBytes,
                Iterations,
                Algorithm,
                HashByteSize
            );

            return Convert.ToHexString(hashBytes); // Trả về 64 ký tự Hex in hoa
        }

        /// <summary>
        /// Xác thực mật khẩu với thời gian cố định (FixedTimeEquals) chống Timing Attack
        /// </summary>
        public static bool VerifyPassword(string inputPassword, string storedHash, string storedSalt)
        {
            if (string.IsNullOrEmpty(inputPassword) || string.IsNullOrEmpty(storedHash) || string.IsNullOrEmpty(storedSalt))
                return false;

            try
            {
                string computedHash = HashPassword(inputPassword, storedSalt);
                byte[] computedBytes = Convert.FromHexString(computedHash);
                byte[] storedBytes = Convert.FromHexString(storedHash);

                return CryptographicOperations.FixedTimeEquals(computedBytes, storedBytes);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Sinh mật khẩu tạm thời ngẫu nhiên an toàn khi Admin Reset mật khẩu
        /// </summary>
        public static string GenerateTemporaryPassword(int length = 10)
        {
            const string upper = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijkmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*";

            var randomChars = new char[length];
            // Đảm bảo thỏa mãn đủ 4 tiêu chí độ mạnh
            randomChars[0] = upper[RandomNumberGenerator.GetInt32(upper.Length)];
            randomChars[1] = lower[RandomNumberGenerator.GetInt32(lower.Length)];
            randomChars[2] = digits[RandomNumberGenerator.GetInt32(digits.Length)];
            randomChars[3] = special[RandomNumberGenerator.GetInt32(special.Length)];

            string allChars = upper + lower + digits + special;
            for (int i = 4; i < length; i++)
            {
                randomChars[i] = allChars[RandomNumberGenerator.GetInt32(allChars.Length)];
            }

            // Trộn ngẫu nhiên vị trí các ký tự (Fisher-Yates)
            for (int i = length - 1; i > 0; i--)
            {
                int j = RandomNumberGenerator.GetInt32(i + 1);
                (randomChars[i], randomChars[j]) = (randomChars[j], randomChars[i]);
            }

            return new string(randomChars);
        }

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