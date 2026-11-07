using Library.DAL;
using Library.DTO;
using Library.BLL.Security;

namespace Library.BLL
{
    public class NguoiDungBLL
    {
        private readonly NguoiDungDAL _userDal = new NguoiDungDAL();
        private readonly ThuThuDAL _thuThuDal = new ThuThuDAL();

        public (bool IsSuccess, string Message, NguoiDungDTO? User, ThuThuDTO? Librarian) DangNhap(string username, string password)
        {
            // 1. Kiểm tra tài khoản tồn tại trong CSDL
            var user = _userDal.GetByUsername(username);
            if (user == null)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null, null);
            }

            // 2. Kiểm tra cờ trạng thái hoạt động (Dang_Hoat_Dong)
            if (!user.Dang_Hoat_Dong)
            {
                return (false, "Tài khoản của bạn đã bị khóa bởi Quản trị viên!", null, null);
            }

            // 3. Xác thực mã băm SHA-256 + Salt
            bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.Mat_Khau_Ma_Hoa, user.Chuoi_Muoi);
            if (!isPasswordCorrect)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null, null);
            }

            // 4. Nếu là Thủ thư, nạp thêm thông tin hồ sơ thủ thư
            ThuThuDTO? librarian = null;
            if (user.Vai_Tro == "Librarian")
            {
                librarian = _thuThuDal.GetByNguoiDungMaSo(user.Ma_So);
            }

            return (true, "Đăng nhập thành công!", user, librarian);
        }

        public (bool IsSuccess, string Message) DoiMatKhau(int maSo, string matKhauCu, string matKhauMoi, string xacNhanMatKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhauCu))
                return (false, "Vui lòng nhập mật khẩu hiện tại!");

            if (string.IsNullOrWhiteSpace(matKhauMoi))
                return (false, "Vui lòng nhập mật khẩu mới!");

            var (isValid, errorMsg) = PasswordHasher.ValidatePasswordStrength(matKhauMoi);
            if (!isValid)
                return (false, errorMsg);

            if (matKhauMoi != xacNhanMatKhau)
                return (false, "Mật khẩu mới và xác nhận mật khẩu không trùng khớp!");

            if (matKhauMoi == matKhauCu)
                return (false, "Mật khẩu mới không được trùng với mật khẩu hiện tại!");

            var user = _userDal.GetById(maSo);
            if (user == null)
                return (false, "Không tìm thấy thông tin tài khoản người dùng!");

            bool isOldPasswordValid = PasswordHasher.VerifyPassword(matKhauCu, user.Mat_Khau_Ma_Hoa, user.Chuoi_Muoi);
            if (!isOldPasswordValid)
                return (false, "Mật khẩu hiện tại không chính xác!");

            string newSalt = PasswordHasher.GenerateSalt();
            string newHash = PasswordHasher.HashPassword(matKhauMoi, newSalt);

            bool isUpdated = _userDal.CapNhatMatKhau(maSo, newHash, newSalt);
            if (isUpdated)
            {
                user.Mat_Khau_Ma_Hoa = newHash;
                user.Chuoi_Muoi = newSalt;
                return (true, "Đổi mật khẩu thành công!");
            }

            return (false, "Cập nhật mật khẩu thất bại. Vui lòng thử lại!");
        }

        // Lấy danh sách toàn bộ nhân sự thủ thư
        public List<ThuThuDTO> LayDanhSachNhanSu()
        {
            return _thuThuDal.GetAll();
        }

        // Khóa hoặc mở khóa tài khoản
        public (bool IsSuccess, string Message) ChuyenTrangThaiTaiKhoan(int maNguoiDung, int currentAdminId)
        {
            if (maNguoiDung == currentAdminId)
            {
                return (false, "Bạn không thể tự khóa tài khoản Quản trị viên đang đăng nhập!");
            }

            var user = _userDal.GetById(maNguoiDung);
            if (user == null)
            {
                return (false, "Không tìm thấy thông tin tài khoản người dùng!");
            }

            bool trangThaiMoi = !user.Dang_Hoat_Dong;
            bool isUpdated = _userDal.CapNhatTrangThaiHoatDong(maNguoiDung, trangThaiMoi);

            if (isUpdated)
            {
                string statusText = trangThaiMoi ? "Mở khóa thành công!" : "Đã khóa tài khoản thành công!";
                return (true, statusText);
            }

            return (false, "Cập nhật trạng thái tài khoản thất bại. Vui lòng thử lại!");
        }

        public (bool IsSuccess, string Message, string MatKhauTam) ResetMatKhauTamThoi(int maNguoiDung)
        {
            var user = _userDal.GetById(maNguoiDung);
            if (user == null)
            {
                return (false, "Không tìm thấy thông tin tài khoản người dùng!", string.Empty);
            }

            string tempPassword = PasswordHasher.GenerateTemporaryPassword(10);
            string newSalt = PasswordHasher.GenerateSalt();
            string newHash = PasswordHasher.HashPassword(tempPassword, newSalt);

            bool isUpdated = _userDal.CapNhatMatKhau(maNguoiDung, newHash, newSalt);
            if (isUpdated)
            {
                return (true, $"Đã cấp lại mật khẩu tạm thành công cho tài khoản '{user.Ten_Dang_Nhap}'!", tempPassword);
            }

            return (false, "Reset mật khẩu thất bại. Vui lòng kiểm tra lại kết nối CSDL!", string.Empty);
        }

        public (bool IsSuccess, string Message) CapNhatThongTinThuThu(ThuThuDTO thuThu)
        {
            if (string.IsNullOrWhiteSpace(thuThu.Ho_Ten))
            {
                return (false, "Họ và tên thủ thư không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(thuThu.Quay_Phu_Trach))
            {
                return (false, "Vui lòng chọn quầy phụ trách cho thủ thư!");
            }

            if (!string.IsNullOrWhiteSpace(thuThu.Email) && !thuThu.Email.Contains("@"))
            {
                return (false, "Địa chỉ email không đúng định dạng!");
            }

            bool isUpdated = _thuThuDal.CapNhatThongTin(thuThu);
            if (isUpdated)
            {
                return (true, "Cập nhật thông tin thủ thư thành công!");
            }

            return (false, "Cập nhật dữ liệu thất bại. Vui lòng kiểm tra lại kết nối!");
        }

        // Lấy mã thủ thư gợi ý tiếp theo
        public string LayMaThuThuTiepTheo()
        {
            return _thuThuDal.GetNextMaThuThu();
        }

        // Xử lý tạo mới thủ thư và cấp tài khoản mặc định
        public (bool IsSuccess, string Message, string MaThuThu, string MatKhauKhoiTao) ThemThuThu(
            string tenDangNhap,
            string hoTen,
            string? soDienThoai,
            string? email,
            string quayPhuTrach)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return (false, "Tên đăng nhập không được để trống!", string.Empty, string.Empty);

            if (tenDangNhap.Contains(' '))
                return (false, "Tên đăng nhập không được chứa khoảng trắng!", string.Empty, string.Empty);

            if (string.IsNullOrWhiteSpace(hoTen))
                return (false, "Họ và tên thủ thư không được để trống!", string.Empty, string.Empty);

            if (string.IsNullOrWhiteSpace(quayPhuTrach))
                return (false, "Vui lòng chọn quầy trực phụ trách!", string.Empty, string.Empty);

            if (!string.IsNullOrWhiteSpace(email) && !email.Contains('@'))
                return (false, "Địa chỉ email không đúng định dạng!", string.Empty, string.Empty);

            // Kiểm tra tên đăng nhập đã tồn tại trong CSDL chưa
            var existingUser = _userDal.GetByUsername(tenDangNhap.Trim());
            if (existingUser != null)
                return (false, $"Tên đăng nhập '{tenDangNhap}' đã tồn tại, vui lòng chọn tên khác!", string.Empty, string.Empty);

            // Tự động sinh mã TT0xxx mới nhất
            string maThuThu = _thuThuDal.GetNextMaThuThu();

            // Sinh mật khẩu ngẫu nhiên tạm thời và băm PBKDF2
            string matKhauKhoiTao = PasswordHasher.GenerateTemporaryPassword(10);
            string salt = PasswordHasher.GenerateSalt();
            string hash = PasswordHasher.HashPassword(matKhauKhoiTao, salt);

            var thuThu = new ThuThuDTO
            {
                Ma_Thu_Thu = maThuThu,
                Ho_Ten = hoTen.Trim(),
                So_Dien_Thoai = string.IsNullOrWhiteSpace(soDienThoai) ? null : soDienThoai.Trim(),
                Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim(),
                Quay_Phu_Trach = quayPhuTrach,
                Ngay_Vao_Lam = DateTime.Now
            };

            try
            {
                bool isAdded = _thuThuDal.ThemThuThu(thuThu, tenDangNhap.Trim(), hash, salt);
                if (isAdded)
                {
                    return (true, "Thêm mới thủ thư thành công!", maThuThu, matKhauKhoiTao);
                }
                return (false, "Không thể lưu dữ liệu thủ thư vào hệ thống!", string.Empty, string.Empty);
            }
            catch (Exception ex)
            {
                SystemLogger.Log(LogLevel.ERROR, "Lỗi tạo tài khoản thủ thư", ex.Message);
                return (false, "Đã xảy ra lỗi khi tạo tài khoản và hồ sơ nhân sự. Vui lòng kiểm tra lại thông tin nhập!", string.Empty, string.Empty);
            }
        }

    }
}