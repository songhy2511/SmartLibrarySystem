using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BLL;
using Library.BLL.Security;

namespace Library.Tests
{
    [TestClass]
    public class AdminBusinessRuleTests
    {
        private CaTrucBLL _caTrucBLL = null!;
        private CauHinhHeThongBLL _cauHinhBLL = null!;

        [TestInitialize]
        public void Setup()
        {
            _caTrucBLL = new CaTrucBLL();
            _cauHinhBLL = new CauHinhHeThongBLL();
        }

        #region 1. TEST XÁC THỰC TƯƠNG THÍCH CHUẨN VỚI SCRIPT SQL SEED

        [TestMethod]
        [TestCategory("Authentication")]
        public void VerifyPassword_AdminSeedAccount_MatchesExpectedSqlHash()
        {
            // Arrange: Chuỗi muối và mật khẩu khai báo đúng trong script Database Seed
            string plainPass = "Admin@123";
            string seedSalt = "Salt_Admin_2026_Secure_Key==";

            // Băm thử nghiệm theo thuật toán C#
            string computedHash = PasswordHasher.HashPassword(plainPass, seedSalt);

            // Act & Assert
            // 1. Phải là chuỗi Hex 64 ký tự (256 bits) viết hoa
            Assert.AreEqual(64, computedHash.Length);
            Assert.AreEqual(computedHash.ToUpper(), computedHash);

            // 2. Hàm verify phải chấp thuận mật khẩu seed
            bool isCorrect = PasswordHasher.VerifyPassword(plainPass, computedHash, seedSalt);
            Assert.IsTrue(isCorrect, "Hàm VerifyPassword không khớp với tài khoản seed Admin trong SQL!");

            // 3. Nhập sai mật khẩu phải từ chối ngay lập tức
            bool isWrong = PasswordHasher.VerifyPassword("Admin@999", computedHash, seedSalt);
            Assert.IsFalse(isWrong, "Hệ thống vẫn xác thực thành công khi nhập sai mật khẩu Admin!");
        }

        [TestMethod]
        [TestCategory("Authentication")]
        public void VerifyPassword_LibrarianSeedAccount_MatchesCorrectHash()
        {
            // Arrange: Salt của thủ thư 1 trong script SQL
            string plainPass = "Librarian@123";
            string seedSalt = "Salt_TT001_Key_Lib2026==";

            string computedHash = PasswordHasher.HashPassword(plainPass, seedSalt);

            // Act & Assert
            bool isCorrect = PasswordHasher.VerifyPassword(plainPass, computedHash, seedSalt);
            Assert.IsTrue(isCorrect, "Hàm VerifyPassword không khớp với tài khoản seed Thủ thư!");
        }

        #endregion

        #region 2. TEST CHÍNH SÁCH ĐỘ MẠNH MẬT KHẨU (PASSWORD STRENGTH)

        [TestMethod]
        [DataRow("", "không được để trống")]
        [DataRow("12345", "tối thiểu từ 6 ký tự")]
        [DataRow("admin123@", "ít nhất một chữ cái in hoa")]
        [DataRow("ADMIN123@", "ít nhất một chữ cái in thường")]
        [DataRow("AdminPassword@", "ít nhất một chữ số")]
        [DataRow("AdminPassword123", "ít nhất một ký tự đặc biệt")]
        [TestCategory("Security")]
        public void ValidatePasswordStrength_InvalidPasswords_ReturnsFalse(string weakPassword, string expectedErrorSubString)
        {
            // Act
            var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(weakPassword);

            // Assert
            Assert.IsFalse(isValid, $"Mật khẩu yếu '{weakPassword}' đáng lẽ phải bị từ chối!");
            StringAssert.Contains(errorMsg, expectedErrorSubString);
        }

        [TestMethod]
        [DataRow("Admin@123")]
        [DataRow("Librarian#2026")]
        [DataRow("SongHy$Pass1")]
        [TestCategory("Security")]
        public void ValidatePasswordStrength_ValidPasswords_ReturnsTrue(string strongPassword)
        {
            // Act
            var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(strongPassword);

            // Assert
            Assert.IsTrue(isValid, $"Mật khẩu hợp lệ '{strongPassword}' bị báo lỗi: {errorMsg}");
            Assert.AreEqual(string.Empty, errorMsg);
        }

        #endregion

        #region 3. TEST RÀNG BUỘC NGHIỆP VỤ PHÂN CA TRỰC (CA TRỰC BLL)

        [TestMethod]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_NgayTrongQuaKhu_ReturnsFailure()
        {
            // Arrange
            DateTime ngayQuaKhu = DateTime.Today.AddDays(-1);
            TimeSpan batDau = new TimeSpan(7, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0);

            // Act: Phân ca cho ngày hôm qua
            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(1, 1, ngayQuaKhu, "Ca Sáng", batDau, ketThuc, 500000, null);

            // Assert
            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "quá khứ");
        }

        [TestMethod]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_GioBatDauSauGioKetThuc_ReturnsFailure()
        {
            // Arrange
            DateTime ngayMai = DateTime.Today.AddDays(1);
            TimeSpan batDau = new TimeSpan(17, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0); // Giờ kết thúc trước giờ bắt đầu

            // Act
            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(1, 1, ngayMai, "Ca Chiều", batDau, ketThuc, 300000, null);

            // Assert
            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "trước giờ kết thúc");
        }

        [TestMethod]
        [DataRow(0, 1, "Vui lòng chọn nhân sự thủ thư!")]
        [DataRow(1, 0, "Vui lòng chọn chi nhánh làm việc!")]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_ThieuThuThuHoacChiNhanh_ReturnsFailure(int thuThuId, int chiNhanhId, string expectedMsg)
        {
            // Arrange
            DateTime ngayMai = DateTime.Today.AddDays(1);
            TimeSpan batDau = new TimeSpan(7, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0);

            // Act
            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(thuThuId, chiNhanhId, ngayMai, "Ca Sáng", batDau, ketThuc, 0, null);

            // Assert
            Assert.IsFalse(isSuccess);
            Assert.AreEqual(expectedMsg, message);
        }

        #endregion

        #region 4. TEST RÀNG BUỘC QUY CHẾ & CẤU HÌNH THAM SỐ ĐỘNG

        [TestMethod]
        [DataRow(0, 14, 5000, 12, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!")]     // Sách = 0
        [DataRow(55, 14, 5000, 12, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!")]    // Sách > 50
        [DataRow(5, 0, 5000, 12, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!")]     // Ngày = 0
        [DataRow(5, 200, 5000, 12, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!")]   // Ngày > 180
        [DataRow(5, 14, -1000, 12, "Tiền phạt trả trễ mỗi ngày không được âm!")]      // Phạt âm
        [DataRow(5, 14, 5000, 0, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!")]     // Hạn thẻ = 0
        [DataRow(5, 14, 5000, 72, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!")]    // Hạn thẻ > 60
        [TestCategory("SystemConfig")]
        public void LuuQuyChe_ThamSoNgoaiPhamViChoPhep_ReturnsFailure(
        int soSach, int soNgay, int tienPhat, int thoiHan, string expectedMsg) // 👉 Đổi kiểu decimal thành int
        {
            // Act: Ép kiểu sang (decimal) khi truyền vào hàm BLL
            var (isSuccess, message) = _cauHinhBLL.LuuQuyChe(soSach, soNgay, (decimal)tienPhat, thoiHan);

            // Assert
            Assert.IsFalse(isSuccess);
            Assert.AreEqual(expectedMsg, message);
        }

        #endregion
    }
}