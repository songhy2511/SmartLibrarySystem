using Library.DAL;
using Library.DTO;
using Library.BLL.Security;

namespace Library.BLL
{
    public class NguoiDungBLL
    {
        private readonly NguoiDungDAL _dal = new NguoiDungDAL();

        public (bool IsSuccess, string Message, NguoiDungDTO? User) DangNhap(string username, string password)
        {
            // 1. Kiểm tra tài khoản tồn tại trong CSDL
            var user = _dal.GetByUsername(username);
            if (user == null)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
            }

            // 2. Kiểm tra cờ trạng thái hoạt động (IsActive)
            if (!user.Dang_Hoat_Dong)
            {
                return (false, "Tài khoản của bạn đã bị khóa bởi Quản trị viên!", null);
            }

            // 3. Xác thực mã băm SHA-256 + Salt
            bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.Mat_Khau_Ma_Hoa, user.Chuoi_Muoi);
            if (!isPasswordCorrect)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
            }

            return (true, "Đăng nhập thành công!", user);
        }
    }
}