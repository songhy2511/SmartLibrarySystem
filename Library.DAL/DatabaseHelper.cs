using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Library.DAL
{
    /// <summary>
    /// Cửa duy nhất mở SQL Server. Mọi DAL gọi ba hàm này thay vì tự new SqlConnection.
    /// ExecuteQuery: SELECT trả nhiều dòng. ExecuteNonQuery: INSERT/UPDATE/DELETE, trả số dòng.
    /// ExecuteScalar: một giá trị (COUNT, mã kế tiếp). ExecuteQueryAsync: SELECT không khóa giao diện.
    /// Tham số SqlParameter chống ghép chuỗi SQL (SQL injection).
    /// </summary>
    public static class DatabaseHelper
    {
        // Chuỗi kết nối SQL Server (Sửa Data Source cho đúng tên máy nếu không dùng dấu chấm .)
        public static string ConnectionString { get; set; } =
            "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>Tạo kết nối mới. using ở hàm gọi sẽ đóng kết nối khi xong.</summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /// <summary>Chạy SELECT và đổ hết kết quả vào DataTable. Fill tự mở kết nối.</summary>
        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>Chạy lệnh ghi. Giá trị trả về là số dòng bị ảnh hưởng; 0 nghĩa là không sửa được dòng nào.</summary>
        public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        /// <summary>Lấy một ô, ví dụ Gia_Tri của một tham số cấu hình. Null nếu câu lệnh không ra dòng.</summary>
        public static object? ExecuteScalar(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteScalar();
        }

        /// <summary>
        /// Thực thi câu lệnh SELECT bất đồng bộ, trả về Task<DataTable> giúp không khóa luồng giao diện.
        /// </summary>
        public static async Task<DataTable> ExecuteQueryAsync(string query, SqlParameter[]? parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
    }
}