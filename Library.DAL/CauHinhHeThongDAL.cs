using Library.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DAL
{
    /// <summary>Đọc và cập nhật từng dòng Ten_Tham_So / Gia_Tri. LayGiaTri trả chuỗi mặc định nếu chưa có dòng.</summary>
    public class CauHinhHeThongDAL
    {
        public List<CauHinhHeThongDTO> GetAll()
        {
            var list = new List<CauHinhHeThongDTO>();
            string query = @"SELECT Ma_So, Ten_Tham_So, Gia_Tri, Mo_Ta 
                             FROM Cau_Hinh_He_Thong 
                             ORDER BY Ma_So ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new CauHinhHeThongDTO
                {
                    Ma_So = Convert.ToInt32(row["Ma_So"]),
                    Ten_Tham_So = row["Ten_Tham_So"].ToString()!,
                    Gia_Tri = row["Gia_Tri"].ToString()!,
                    Mo_Ta = row["Mo_Ta"]?.ToString()
                });
            }
            return list;
        }

        public string LayGiaTri(string tenThamSo, string giaTriMacDinh = "")
        {
            string query = @"SELECT TOP 1 Gia_Tri 
                             FROM Cau_Hinh_He_Thong 
                             WHERE Ten_Tham_So = @TenThamSo";

            SqlParameter[] parameters = {
                new SqlParameter("@TenThamSo", tenThamSo)
            };

            object? result = DatabaseHelper.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? result.ToString()! : giaTriMacDinh;
        }

        public int LayGiaTriInt(string tenThamSo, int giaTriMacDinh)
        {
            string valStr = LayGiaTri(tenThamSo, giaTriMacDinh.ToString());
            return int.TryParse(valStr, out int giaTri) ? giaTri : giaTriMacDinh;
        }

        public bool CapNhatGiaTri(string tenThamSo, string giaTri)
        {
            string query = @"UPDATE Cau_Hinh_He_Thong 
                             SET Gia_Tri = @GiaTri 
                             WHERE Ten_Tham_So = @TenThamSo";

            SqlParameter[] parameters = {
                new SqlParameter("@GiaTri", giaTri),
                new SqlParameter("@TenThamSo", tenThamSo)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}