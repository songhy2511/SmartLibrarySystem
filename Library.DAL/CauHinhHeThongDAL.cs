<<<<<<< HEAD
﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL
{
    public static class CauHinhHeThongDAL
    {
        public static int LayGiaTriInt(string tenThamSo,int giaTriMacDinh)
        {
            string sql = " SELECT Gia_Tri From Cau_Hinh_He_Thong WHERE Ten_Tham_So=@TenThamSo";
            var parameters = new[] { new SqlParameter("@TenThamSo", tenThamSo)};
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            if (result == null || result == DBNull.Value)
            {
                return giaTriMacDinh;
            }
            return int.TryParse(result.ToString(), out int giaTri) ? giaTri : giaTriMacDinh;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Library.DTO;

namespace Library.DAL
{
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
>>>>>>> 7d87851619aa3e47dfd2f64dcfc251f7899501d6
