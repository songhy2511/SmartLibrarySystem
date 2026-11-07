using Library.BLL;
using Library.BLL.Security;
using Library.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        namespace Library.Tests
    {
        [TestClass]
        public class AdminBusinessRuleTests
        {
            [TestMethod]
            public void Test_DefaultReaderCardExpiry_IsFourYearsFromToday()
            {
                var dg = new DocGiaDTO();
                int expectedYear = DateTime.Today.AddYears(4).Year;
                Assert.AreEqual(expectedYear, dg.Ngay_Het_Han_The.Year, "Thời hạn thẻ độc giả mặc định phải là 4 năm kể từ ngày tạo");
            }
        }
    }

    #region 1. TEST XÁC THỰC TƯƠNG THÍCH CHUẨN VỚI SCRIPT SQL SEED

    [TestMethod]
        [TestCategory("Authentication")]
        public void VerifyPassword_Pbkdf2_SeedAdminMatchesCorrectHash()
        {
            // Mật khẩu và Salt của Admin trong LibraryDB.sql
            string plainPass = "Admin@123";
            string salt = "q3Z8vX1mK9pL2oW5yR7tEw==";
            string expectedHash = "03FC1949AB5D0389D245EAC6834C156273213A780EB92A922CA04EAC0BE8636E";

            bool isCorrect = PasswordHasher.VerifyPassword(plainPass, expectedHash, salt);
            Assert.IsTrue(isCorrect, "PBKDF2 không xác thực khớp với hash seed của Admin!");

            bool isWrong = PasswordHasher.VerifyPassword("WrongPass@123", expectedHash, salt);
            Assert.IsFalse(isWrong, "Mật khẩu sai vẫn được PBKDF2 chấp thuận!");
        }

        [TestMethod]
        [TestCategory("Authentication")]
        public void VerifyPassword_Pbkdf2_SeedLibrarianMatchesCorrectHash()
        {
            // Mật khẩu và Salt của Thủ thư trong LibraryDB.sql
            string plainPass = "Librarian@2026!";
            string salt = "a1B2c3D4e5F6g7H8i9J0kL==";
            string expectedHash = "DF978233A0C6131B80D26D45D9C9BFB2D81760E9DFB81599CA8D58BD71DE3D21";

            bool isCorrect = PasswordHasher.VerifyPassword(plainPass, expectedHash, salt);
            Assert.IsTrue(isCorrect, "PBKDF2 không xác thực khớp với hash seed của Thủ thư!");

            bool isWrong = PasswordHasher.VerifyPassword("WrongPass@123", expectedHash, salt);
            Assert.IsFalse(isWrong, "Mật khẩu sai vẫn được PBKDF2 chấp thuận!");
        }

        [TestMethod]
        [TestCategory("Security")]
        public void GenerateTemporaryPassword_MeetsAllComplexityRequirements()
        {
            for (int i = 0; i < 50; i++)
            {
                string tempPass = PasswordHasher.GenerateTemporaryPassword(12);
                var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(tempPass);

                Assert.IsTrue(isValid, $"Mật khẩu tạm thời '{tempPass}' không đạt chuẩn: {errorMsg}");
            }
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
            var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(weakPassword);

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
            var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(strongPassword);

            Assert.IsTrue(isValid, $"Mật khẩu hợp lệ '{strongPassword}' bị báo lỗi: {errorMsg}");
            Assert.AreEqual(string.Empty, errorMsg);
        }

        #endregion

        #region 3. TEST RÀNG BUỘC NGHIỆP VỤ PHÂN CA TRỰC (CA TRỰC BLL)

        [TestMethod]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_NgayTrongQuaKhu_ReturnsFailure()
        {
            DateTime ngayQuaKhu = DateTime.Today.AddDays(-1);
            TimeSpan batDau = new TimeSpan(7, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0);

            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(1, 1, ngayQuaKhu, "Ca Sáng", batDau, ketThuc, 500000, null);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "quá khứ");
        }

        [TestMethod]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_GioBatDauSauGioKetThuc_ReturnsFailure()
        {
            DateTime ngayMai = DateTime.Today.AddDays(1);
            TimeSpan batDau = new TimeSpan(17, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0);

            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(1, 1, ngayMai, "Ca Chiều", batDau, ketThuc, 300000, null);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "trước giờ kết thúc");
        }

        [TestMethod]
        [DataRow(0, 1, "Vui lòng chọn nhân sự thủ thư!")]
        [DataRow(1, 0, "Vui lòng chọn chi nhánh làm việc!")]
        [TestCategory("ShiftManagement")]
        public void PhanCaTruc_ThieuThuThuHoacChiNhanh_ReturnsFailure(int thuThuId, int chiNhanhId, string expectedMsg)
        {
            DateTime ngayMai = DateTime.Today.AddDays(1);
            TimeSpan batDau = new TimeSpan(7, 30, 0);
            TimeSpan ketThuc = new TimeSpan(12, 0, 0);

            var (isSuccess, message) = _caTrucBLL.PhanCaTruc(thuThuId, chiNhanhId, ngayMai, "Ca Sáng", batDau, ketThuc, 0, null);

            Assert.IsFalse(isSuccess);
            Assert.AreEqual(expectedMsg, message);
        }

        #endregion

        #region 4. TEST RÀNG BUỘC QUY CHẾ & CẤU HÌNH THAM SỐ ĐỘNG

        [TestMethod]
        [DataRow(0, 14, 5000, 12, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!")]
        [DataRow(55, 14, 5000, 12, "Số sách mượn tối đa phải từ 1 đến 50 cuốn!")]
        [DataRow(5, 0, 5000, 12, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!")]
        [DataRow(5, 200, 5000, 12, "Số ngày mượn tối đa phải từ 1 đến 180 ngày!")]
        [DataRow(5, 14, -1000, 12, "Tiền phạt trả trễ mỗi ngày không được âm!")]
        [DataRow(5, 14, 5000, 0, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!")]
        [DataRow(5, 14, 5000, 72, "Thời hạn thẻ độc giả phải từ 1 đến 60 tháng!")]
        [TestCategory("SystemConfig")]
        public void LuuQuyChe_ThamSoNgoaiPhamViChoPhep_ReturnsFailure(
            int soSach, int soNgay, int tienPhat, int thoiHan, string expectedMsg)
        {
            var (isSuccess, message) = _cauHinhBLL.LuuQuyChe(soSach, soNgay, (decimal)tienPhat, thoiHan);

            Assert.IsFalse(isSuccess);
            Assert.AreEqual(expectedMsg, message);
        }

        #endregion

        #region 5. TEST RÀNG BUỘC ĐỔI MẬT KHẨU & NHÂN SỰ (NGƯỜI DÙNG BLL)

        [TestMethod]
        [TestCategory("UserManagement")]
        public void ChuyenTrangThaiTaiKhoan_AdminTuKhoaChinhMinh_ReturnsFailure()
        {
            var bll = new NguoiDungBLL();
            int currentAdminId = 1;

            var (isSuccess, message) = bll.ChuyenTrangThaiTaiKhoan(currentAdminId, currentAdminId);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "tự khóa tài khoản Quản trị viên");
        }

        [TestMethod]
        [DataRow("MatKhauCu@123", "MatKhauCu@123", "MatKhauCu@123", "trùng với mật khẩu hiện tại")]
        [DataRow("MatKhauCu@123", "MatKhauMoi@123", "KhacMatKhauMoi@123", "không trùng khớp")]
        [DataRow("", "MatKhauMoi@123", "MatKhauMoi@123", "nhập mật khẩu hiện tại")]
        [DataRow("MatKhauCu@123", "", "", "nhập mật khẩu mới")]
        [TestCategory("UserManagement")]
        public void DoiMatKhau_DuLieuNhapKhongHopLe_ReturnsFailure(string oldP, string newP, string confirmP, string subError)
        {
            var bll = new NguoiDungBLL();
            var (isSuccess, message) = bll.DoiMatKhau(1, oldP, newP, confirmP);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, subError);
        }

        [TestMethod]
        [DataRow("", "Nguyễn Văn A", "Quầy 1", "email@smartlib.vn", "Tên đăng nhập không được để trống")]
        [DataRow("admin user", "Nguyễn Văn A", "Quầy 1", "email@smartlib.vn", "chứa khoảng trắng")]
        [DataRow("thuthumoi", "", "Quầy 1", "email@smartlib.vn", "Họ và tên thủ thư không được để trống")]
        [DataRow("thuthumoi", "Nguyễn Văn A", "", "email@smartlib.vn", "chọn quầy trực")]
        [DataRow("thuthumoi", "Nguyễn Văn A", "Quầy 1", "emailsaikhongcoacong", "định dạng")]
        [TestCategory("UserManagement")]
        public void ThemThuThu_ThongTinKhongHopLe_ReturnsFailure(string username, string name, string desk, string email, string subError)
        {
            var bll = new NguoiDungBLL();
            var (isSuccess, message, _, _) = bll.ThemThuThu(username, name, "0901234567", email, desk);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, subError);
        }

        #endregion

        #region 6. TEST RÀNG BUỘC ĐIỀU PHỐI SÁCH & TRA CỨU NHẬT KÝ

        [TestMethod]
        [TestCategory("BookManagement")]
        public void DieuPhoiSach_ChiNhanhDichTrungChiNhanhNguon_ReturnsFailure()
        {
            var sachBLL = new SachBLL();
            int chiNhanhId = 1;

            var (isSuccess, message) = sachBLL.DieuPhoiSach(10, "BC-001", "Sách mẫu", chiNhanhId, chiNhanhId, "Ghi chú", 1);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(message, "khác chi nhánh hiện tại");
        }

        [TestMethod]
        [TestCategory("BookManagement")]
        public void DeXuatThanhLyCuonSach_SachHetKhaDung_ReturnsFailure()
        {
            var sachBLL = new SachBLL();

            bool isSuccess = sachBLL.DeXuatThanhLyCuonSach("B0001", "Sách mẫu", 0, 1, out string err);

            Assert.IsFalse(isSuccess);
            StringAssert.Contains(err, "không còn cuốn nào khả dụng");
        }

        [TestMethod]
        [TestCategory("SystemAudit")]
        public void TraCuuNhatKy_TuNgayLonHonDenNgay_ThrowsArgumentException()
        {
            var auditBLL = new NhatKyHeThongBLL();
            DateTime tuNgay = DateTime.Today;
            DateTime denNgay = DateTime.Today.AddDays(-3);

            Assert.ThrowsExactly<ArgumentException>(() =>
                auditBLL.TraCuu(tuNgay, denNgay, null, null, null));
        }

        #endregion
    }
}