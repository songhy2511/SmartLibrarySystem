using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BLL.Security;

namespace Library.Tests
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void HashPassword_MatchesSqlSeedData_AdminAccount()
        {
            // Arrange (Dữ liệu chuẩn xác của tài khoản Admin từ script LibraryDB.sql)
            string plainPassword = "Admin@123";
            string salt = "q3Z8vX1mK9pL2oW5yR7tEw=="; // Chuỗi Base64 chuẩn
            string expectedHash = "03FC1949AB5D0389D245EAC6834C156273213A780EB92A922CA04EAC0BE8636E";

            // Act (Thực thi băm)
            string actualHash = PasswordHasher.HashPassword(plainPassword, salt);

            // Assert (Xác minh mã băm sinh ra đủ 64 ký tự Hex, khớp với CSDL và xác thực thành công)
            Assert.AreEqual(64, actualHash.Length);
            Assert.AreEqual(expectedHash, actualHash, "Mã băm sinh ra phải khớp với mã băm khởi tạo trong CSDL!");
            bool isMatch = PasswordHasher.VerifyPassword(plainPassword, actualHash, salt);
            Assert.IsTrue(isMatch);
        }

        [TestMethod]
        public void VerifyPassword_WrongPassword_ReturnsFalse()
        {
            // Arrange
            string correctPassword = "Librarian@123";
            string wrongPassword = "WrongPassword@2026";
            string salt = PasswordHasher.GenerateSalt();
            string storedHash = PasswordHasher.HashPassword(correctPassword, salt);

            // Act
            bool result = PasswordHasher.VerifyPassword(wrongPassword, storedHash, salt);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GenerateSalt_GeneratesUniqueValues()
        {
            // Act
            string salt1 = PasswordHasher.GenerateSalt();
            string salt2 = PasswordHasher.GenerateSalt();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(salt1));
            Assert.IsFalse(string.IsNullOrEmpty(salt2));
            Assert.AreNotEqual(salt1, salt2);
        }

        [TestMethod]
        public void ValidatePasswordStrength_WeakPasswords_FailsValidation()
        {
            // Case 1: Quá ngắn (< 6 ký tự)
            var (validShort, _) = PasswordHasher.ValidatePasswordStrength("123");
            Assert.IsFalse(validShort);

            // Case 2: Không có ký tự in hoa
            var (validNoUpper, _) = PasswordHasher.ValidatePasswordStrength("admin@123");
            Assert.IsFalse(validNoUpper);

            // Case 3: Đạt chuẩn bảo mật
            var (validStrong, _) = PasswordHasher.ValidatePasswordStrength("Admin@123");
            Assert.IsTrue(validStrong);
        }
    }
}