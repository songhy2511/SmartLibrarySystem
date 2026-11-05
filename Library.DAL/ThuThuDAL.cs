using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
    public class ThuThuDAL
    {
        public ThuThuDTO? GetByNguoiDungMaSo(int nguoiDungMaSo)
        {
            string query = @"SELECT Ma_So, Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach, Ngay_Vao_Lam 
                             FROM Thu_Thu 
                             WHERE Nguoi_Dung_Ma_So = @NguoiDungMaSo";

            SqlParameter[] parameters = {
                new SqlParameter("@NguoiDungMaSo", nguoiDungMaSo)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new ThuThuDTO
            {
                Ma_So = Convert.ToInt32(row["Ma_So"]),
                Nguoi_Dung_Ma_So = Convert.ToInt32(row["Nguoi_Dung_Ma_So"]),
                Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                Ho_Ten = row["Ho_Ten"].ToString()!,
                So_Dien_Thoai = row["So_Dien_Thoai"]?.ToString(),
                Email = row["Email"]?.ToString(),
                Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                Ngay_Vao_Lam = Convert.ToDateTime(row["Ngay_Vao_Lam"])
            };
        }

        public List<ThuThuDTO> GetAll()
        {
            var list = new List<ThuThuDTO>();
            string query = @"SELECT tt.Ma_So, tt.Nguoi_Dung_Ma_So, tt.Ma_Thu_Thu, tt.Ho_Ten, 
                            tt.So_Dien_Thoai, tt.Email, tt.Quay_Phu_Trach, tt.Ngay_Vao_Lam,
                            nd.Ten_Dang_Nhap, nd.Dang_Hoat_Dong
                     FROM Thu_Thu tt
                     INNER JOIN Nguoi_Dung nd ON tt.Nguoi_Dung_Ma_So = nd.Ma_So
                     ORDER BY tt.Ma_So ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ThuThuDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Nguoi_Dung_Ma_So = Convert.ToInt32(row["Nguoi_Dung_Ma_So"]),
                    Ma_Thu_Thu = row["Ma_Thu_Thu"].ToString()!,
                    Ho_Ten = row["Ho_Ten"].ToString()!,
                    So_Dien_Thoai = row["So_Dien_Thoai"]?.ToString(),
                    Email = row["Email"]?.ToString(),
                    Quay_Phu_Trach = row["Quay_Phu_Trach"].ToString()!,
                    Ngay_Vao_Lam = Convert.ToDateTime(row["Ngay_Vao_Lam"]),
                    Ten_Dang_Nhap = row["Ten_Dang_Nhap"].ToString(),
                    Dang_Hoat_Dong = Convert.ToBoolean(row["Dang_Hoat_Dong"])
                });
            }
            return list;
        }

        public bool CapNhatThongTin(ThuThuDTO thuThu)
        {
            string query = @"UPDATE Thu_Thu 
                     SET Ho_Ten = @HoTen, 
                         So_Dien_Thoai = @SoDienThoai, 
                         Email = @Email, 
                         Quay_Phu_Trach = @QuayPhuTrach 
                     WHERE Ma_So = @MaSo";

            SqlParameter[] parameters = {
                new SqlParameter("@HoTen", thuThu.Ho_Ten),
                new SqlParameter("@SoDienThoai", (object?)thuThu.So_Dien_Thoai ?? DBNull.Value),
                new SqlParameter("@Email", (object?)thuThu.Email ?? DBNull.Value),
                new SqlParameter("@QuayPhuTrach", thuThu.Quay_Phu_Trach),
                new SqlParameter("@MaSo", thuThu.Ma_So)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;

        }


        // Tự động sinh mã thủ thư kế tiếp dạng TT001, TT002... dựa trên mã lớn nhất hiện có
        public string GetNextMaThuThu()
        {
            string query = @"SELECT MAX(CAST(SUBSTRING(Ma_Thu_Thu, 3, LEN(Ma_Thu_Thu) - 2) AS INT)) 
                     FROM Thu_Thu 
                     WHERE Ma_Thu_Thu LIKE 'TT[0-9]%'";

            object? result = DatabaseHelper.ExecuteScalar(query);
            int nextNumber = 1;

            if (result != null && result != DBNull.Value)
            {
                nextNumber = Convert.ToInt32(result) + 1;
            }

            return $"TT{nextNumber:D3}"; // Định dạng TT001, TT002, TT010...
        }

        // Thêm đồng thời tài khoản (Nguoi_Dung) và hồ sơ (Thu_Thu) qua SqlTransaction
        public bool ThemThuThu(ThuThuDTO thuThu, string tenDangNhap, string matKhauMaHoa, string chuoiMuoi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction();

            try
            {
                // 1. Thêm tài khoản vào bảng Nguoi_Dung
                string insertUserQuery = @"
            INSERT INTO Nguoi_Dung (Ten_Dang_Nhap, Mat_Khau_Ma_Hoa, Chuoi_Muoi, Vai_Tro, Dang_Hoat_Dong, Ngay_Tao)
            VALUES (@TenDangNhap, @MatKhauMaHoa, @ChuoiMuoi, 'Librarian', 1, GETDATE());
            SELECT SCOPE_IDENTITY();";

                int nguoiDungMaSo;
                using (var cmdUser = new SqlCommand(insertUserQuery, conn, trans))
                {
                    cmdUser.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmdUser.Parameters.AddWithValue("@MatKhauMaHoa", matKhauMaHoa);
                    cmdUser.Parameters.AddWithValue("@ChuoiMuoi", chuoiMuoi);
                    nguoiDungMaSo = Convert.ToInt32(cmdUser.ExecuteScalar());
                }

                // 2. Thêm hồ sơ vào bảng Thu_Thu
                string insertThuThuQuery = @"
            INSERT INTO Thu_Thu (Nguoi_Dung_Ma_So, Ma_Thu_Thu, Ho_Ten, So_Dien_Thoai, Email, Quay_Phu_Trach, Ngay_Vao_Lam)
            VALUES (@NguoiDungMaSo, @MaThuThu, @HoTen, @SoDienThoai, @Email, @QuayPhuTrach, @NgayVaoLam);";

                using (var cmdThuThu = new SqlCommand(insertThuThuQuery, conn, trans))
                {
                    cmdThuThu.Parameters.AddWithValue("@NguoiDungMaSo", nguoiDungMaSo);
                    cmdThuThu.Parameters.AddWithValue("@MaThuThu", thuThu.Ma_Thu_Thu);
                    cmdThuThu.Parameters.AddWithValue("@HoTen", thuThu.Ho_Ten);
                    cmdThuThu.Parameters.AddWithValue("@SoDienThoai", (object?)thuThu.So_Dien_Thoai ?? DBNull.Value);
                    cmdThuThu.Parameters.AddWithValue("@Email", (object?)thuThu.Email ?? DBNull.Value);
                    cmdThuThu.Parameters.AddWithValue("@QuayPhuTrach", thuThu.Quay_Phu_Trach);
                    cmdThuThu.Parameters.AddWithValue("@NgayVaoLam", thuThu.Ngay_Vao_Lam);
                    cmdThuThu.ExecuteNonQuery();
                }

                trans.Commit();
                thuThu.Nguoi_Dung_Ma_So = nguoiDungMaSo;
                return true;
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
    }
}