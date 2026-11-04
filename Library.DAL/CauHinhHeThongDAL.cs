using Microsoft.Data.SqlClient;
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
