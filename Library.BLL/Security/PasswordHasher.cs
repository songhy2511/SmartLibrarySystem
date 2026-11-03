using System;
using System.Security.Cryptography;
using System.Text;

namespace Library.BLL.Security
{
    public static class PasswordHasher
    {
        // Sinh chuỗi Salt ngẫu nhiên chuẩn an ninh Cryptography
        public static string GenerateSalt(int size = 16)
        {
            byte[] saltBytes = new byte[size];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        // Băm SHA-256 kết hợp chuỗi muối (Salt) ra chuỗi Hex 64 ký tự (khớp SQL HASHBYTES)
        public static string HashPassword(string password, string salt)
        {
            using var sha256 = SHA256.Create();
            byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = sha256.ComputeHash(combinedBytes);
            return Convert.ToHexString(hashBytes);
        }

        // So khớp mật khẩu người dùng nhập với Hash trong CSDL
        public static bool VerifyPassword(string inputPassword, string storedHash, string storedSalt)
        {
            string computedHash = HashPassword(inputPassword, storedSalt);
            return string.Equals(computedHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}