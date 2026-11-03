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
            var user = _dal.GetByUsername(username);
            if (user == null)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
            }

            if (!user.Dang_Hoat_Dong)
            {
                return (false, "Tài khoản của bạn đã bị khóa bởi Quản trị viên!", null);
            }

            bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.Mat_Khau_Ma_Hoa, user.Chuoi_Muoi);
            if (!isPasswordCorrect)
            {
                return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
            }

            return (true, "Đăng nhập thành công!", user);
        }

        // Xử lý logic nghiệp vụ Đổi mật khẩu
        public (bool IsSuccess, string Message) DoiMatKhau(int maSo, string matKhauCu, string matKhauMoi, string xacNhanMatKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhauCu))
            {
                return (false, "Vui lòng nhập mật khẩu hiện tại!");
            }

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                return (false, "Vui lòng nhập mật khẩu mới!");
            }

            if (matKhauMoi.Length < 6)
            {
                return (false, "Mật khẩu mới phải có tối thiểu 6 ký tự!");
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                return (false, "Mật khẩu mới và xác nhận mật khẩu không trùng khớp!");
            }

            if (matKhauMoi == matKhauCu)
            {
                return (false, "Mật khẩu mới không được trùng với mật khẩu hiện tại!");
            }

            var user = _dal.GetById(maSo);
            if (user == null)
            {
                return (false, "Không tìm thấy thông tin tài khoản người dùng!");
            }

            // Kiểm tra mật khẩu cũ
            bool isOldPasswordValid = PasswordHasher.VerifyPassword(matKhauCu, user.Mat_Khau_Ma_Hoa, user.Chuoi_Muoi);
            if (!isOldPasswordValid)
            {
                return (false, "Mật khẩu hiện tại không chính xác!");
            }

            // Sinh chuỗi muối mới và băm mật khẩu mới bằng SHA-256
            string newSalt = PasswordHasher.GenerateSalt();
            string newHash = PasswordHasher.HashPassword(matKhauMoi, newSalt);

            bool isUpdated = _dal.CapNhatMatKhau(maSo, newHash, newSalt);
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