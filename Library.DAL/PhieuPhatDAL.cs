using System;
using Microsoft.Data.SqlClient;

namespace Library.DAL
{
    public class PhieuPhatDAL
    {
        public void LapBienBanToanDien(int? phieuMuonMaSo, int docGiaMaSo, int thuThuId, int chiNhanhId, decimal soTien, string lyDo, string loaiViPham, int banSaoMaSo)
        {
            string query = "EXEC dbo.sp_LapBienBanViPham @PhieuMuonMaSo, @DocGiaMaSo, @ThuThuMaSo, @ChiNhanhMaSo, @SoTienPhat, @LyDo, @LoaiViPham, @BanSaoMaSo";

            var pars = new[] {
                new SqlParameter("@PhieuMuonMaSo", phieuMuonMaSo.HasValue && phieuMuonMaSo > 0 ? (object)phieuMuonMaSo.Value : DBNull.Value),
                new SqlParameter("@DocGiaMaSo", docGiaMaSo),
                new SqlParameter("@ThuThuMaSo", thuThuId),
                new SqlParameter("@ChiNhanhMaSo", chiNhanhId),
                new SqlParameter("@SoTienPhat", soTien),
                new SqlParameter("@LyDo", lyDo),
                new SqlParameter("@LoaiViPham", loaiViPham),
                new SqlParameter("@BanSaoMaSo", banSaoMaSo)
            };

            DatabaseHelper.ExecuteNonQuery(query, pars);
        }

        public void ThuTienPhatGiaoDich(int maBienBan, int thuThuId, decimal soTien)
        {
            string query = "EXEC dbo.sp_ThuTienPhat @MaBienBan, @ThuThuMaSo, @SoTien";
            var pars = new[] {
                new SqlParameter("@MaBienBan", maBienBan),
                new SqlParameter("@ThuThuMaSo", thuThuId),
                new SqlParameter("@SoTien", soTien)
            };

            DatabaseHelper.ExecuteNonQuery(query, pars);
        }
    }
}