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
    }
}