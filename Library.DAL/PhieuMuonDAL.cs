using Library.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL
{
    public class PhieuMuonDAL
    {
        private int? LayMaSoDocGia(string maDocGia)
        {
            string sql = "SELECT Ma_So FROM Doc_Gia WHERE Ma_Doc_Gia = @MaDocGia";
            var p = new[] { new SqlParameter("@MaDocGia", maDocGia) };
            object result = DatabaseHelper.ExecuteScalar(sql, p);
            return (result == null || result == DBNull.Value) ? (int?)null : Convert.ToInt32(result);
        }
        private int? LayMaSoSach( string maSach)
        {
            string sql = " SELECT ma_So FROM Sach WHERE Ma_Sach = @MaSach";
            var p = new[] { new SqlParameter("@MaSach", maSach) };
            object result = DatabaseHelper.ExecuteScalar(sql, p);
            return (result == null || result == DBNull.Value) ? (int?)null : Convert.ToInt32(result);
        }
        private int? LayMaSoThuThu(string maThuThu)
        {
            string sql = " SELECT Ma_So FROM Thu_Thu WHERE Ma_Thu_Thu = @MaThuThu";
            var p = new[] { new SqlParameter("@MaThuThu", maThuThu) };
            object result = DatabaseHelper.ExecuteScalar(sql, p);
            return (result == null || result == DBNull.Value) ? (int?)null : Convert.ToInt32(result);
        }
        private int? LayMaSoPhieuMuon(string maPhieuMuon)
        {
            string sql = " SELECT Ma_So FROM Phieu_Muon WHERE Ma_Phieu_Muon = @MaPhieuMuon";
            var p = new[] { new SqlParameter("@MaPhieuMuon", maPhieuMuon) };
            object result = DatabaseHelper.ExecuteScalar(sql, p);
            return (result == null || result == DBNull.Value) ? (int?)null : Convert.ToInt32(result);
        }
        public string LayPhieuMuonTiepTheo()
        {
            string sql = " SELECT MAX(Ma_Phieu_Muon) FROM Phieu_Muon";
            object result = DatabaseHelper.ExecuteScalar(sql);
            if (result == null || result == DBNull.Value)
            {
                return "BR0001";
            }
            string last = result.ToString();
            int number = int.Parse(last.Substring(2)) + 1;
            return "BR" + number.ToString("D4");
        }
        public bool ThemPhieuMuon(PhieumuonDTO phieumuon)
        {
            int? maSoDocgia = LayMaSoDocGia(phieumuon.MaDocGia);
            int? maSoSach = LayMaSoSach(phieumuon.MaSach);
            int? maSoThuThu = LayMaSoThuThu(phieumuon.MaThuThuLapPhieu);
            if (maSoDocgia == null || maSoSach == null || maSoThuThu == null)
            {
                return false;
            }
            string sql = @"INSERT INTO Phieu_Muon (Ma_Phieu_Muon, Doc_Gia_Ma_So, Sach_Ma_So, Thu_Thu_Lap_Phieu_Ma_So,Ngay_Muon,Ngay_Het_han,So_Lan_Gia_Han,Trang_Thai))
                           VALUES (@MaPhieuMuon, @DocGiaMaSo, @SachMaSo, @ThuThuMaSo, @NgayMuon, @NgayHetHan,0, @TrangThai,)"; 
            var parameters = new[]
            {
                new SqlParameter("@MaPhieuMuon", phieumuon.MaPhieuMuon),
                new SqlParameter("@DocGiaMaSo", maSoDocgia.Value),
                new SqlParameter("@SachMaSo", maSoSach.Value),
                new SqlParameter("@ThuThuMaSo", maSoThuThu),
                new SqlParameter("@NgayMuon", phieumuon.NgayMuon),
                new SqlParameter("@NgayHetHan", phieumuon.NgayHetHan)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool CapNhatTraSach(string maPhieuMuon, string maThuThuNhanTra,DateTime ngayTra, string trangThai)
        {
            int? maSoThuThu = LayMaSoThuThu(maThuThuNhanTra);
            string sql = @"UPDATE Phieu_Muon
                            SET Ngay_Tra = @NgayTra, Thu_Thu_Nhan_Tra_Ma_So =@ThuThuMaSo, Trang_Thai=@TrangThai
                            WHERE Ma_Phieu_Muon = @MaPhieuMuon";
            var parameters = new[]
            {
                new SqlParameter("@NgayTra", ngayTra),
                new SqlParameter("@ThuThuMaSo", (object)maSoThuThu ?? DBNull.Value),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaPhieuMuon", maPhieuMuon)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool CapNhatGiaHan( string maPhieuMuon, DateTime ngayHetHanMoi, int soLanGiaHanMoi)
        {
            string sql = @"UPDATE Phieu_Muon
                            SET Ngay_Het_Han = @NgayHetHanMoi, So_Lan_Gia_Han=@SoLanGiaHanMoi
                            WHERE Ma_Phieu_Muon = @MaPhieuMuon";
            var parameters = new[]
            {
                new SqlParameter("@NgayHetHanMoi", ngayHetHanMoi),
                new SqlParameter("@SoLanGiaHanMoi", soLanGiaHanMoi),
                new SqlParameter("@MaPhieuMuon", maPhieuMuon)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public PhieumuonDTO LayPhieuMuonTheoMa(string maPhieuMuon)
        {
            string sql = @"SELECT pm.Ma_So,pm.Ma_Phieu_Muon, dg.Ma_Doc_Gia,s.Ma_Sach,ttLap.MaThuThu AS Ma_Thu_Thu_Lap,ttTra.Ma_Thu_Thu AS Ma_Thu_Thu_Tra,pm.Ngay_Muon,pm.Ngay_Het_Han,pm.Ngay_Tra,pm.So_Lan_Gia_Han,pm.Trang_Thai,pm.Ghi_Chu
                            FROM Phieu_Muon pm
                            JOIN Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
                            JOIN Sach s ON pm.Sach_Ma_So = s.Ma_So
                            JOIN Thu_Thu ttLap ON pm.Thu_Thu_Lap_Phieu_Muon_Ma_So= ttLap.Ma_So
                            LEFT JOIN Thu_Thu ttTra ON pm.Thu_Thu_Nhan_Tra_Ma_So = ttTra.Ma_So
                            WHERE pm.Ma_Phieu_Muon= @MaPhieuMuon";
            var parameters = new[] 
            { 
                new SqlParameter("@MaPhieuMuon", maPhieuMuon) 

            };
            DataTable table = DatabaseHelper.ExecuteQuery(sql, parameters);
            return table.Rows.Count == 0 ? null : MapRowToDTO(table.Rows[0]);
        }
        public List<PhieumuonDTO> LayDanhSachDangMuonCuaDocGia(string maDocGia)
        {
            string sql = @"SELECT pm.Ma_So,pm.Ma_Phieu_Muon, dg.Ma_Doc_Gia,s.Ma_Sach,ttLap.MaThuThu AS Ma_Thu_Thu_Lap,ttTra.Ma_Thu_Thu AS Ma_Thu_Thu_Tra,pm.Ngay_Muon,pm.Ngay_Het_Han,pm.Ngay_Tra,pm.So_Lan_Gia_Han,pm.Trang_Thai,pm.Ghi_Chu
                            FROM Phieu_Muon pm
                            JOIN Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
                            JOIN Sach s ON pm.Sach_Ma_So = s.Ma_So
                            JOIN Thu_Thu ttLap ON pm.Thu_Thu_Lap_Phieu_Muon_Ma_So= ttLap.Ma_So
                            LEFT JOIN Thu_Thu ttTra ON pm.Thu_Thu_Nhan_Tra_Ma_So = ttTra.Ma_So";
            var parameters = new SqlParameter[] { new SqlParameter("@MaDocGia", maDocGia) };
            DataTable table = DatabaseHelper.ExecuteQuery(sql, parameters);
            var list = new List<PhieumuonDTO>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(MapRowToDTO(row));
            }
            return list;
        }
        public int DemSoSachDangMuon(string maDocGia)
        {
            string sql = @"SELECT COUNT (*) FROM Phieu_Muon pm
                            JOIN Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
                            WHERE dg.Ma_Doc_Gia = @MaDocGia AND pm.Ngay_Tra IS NULL";
            var parameters = new SqlParameter[] { new SqlParameter("@MaDocGia", maDocGia) };
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }
        public bool KiemTraDocGiaCoSachQuaHan(string maDocGia)
        {
            string sql = @"SELECT COUNT(*) FROM Phieu_Muon pm
                            JOIN Doc_Gia dg ON pm.Doc_Gia_Ma_So = dg.Ma_So
                            WHERE dg.Ma_Doc_Gia = @MaDocGia AND pm.Ngay_Tra IS NULL AND pm.Ngay_Het_Han < @HomNay";
            var parameters = new SqlParameter[] 
            { 
                new SqlParameter("@MaDocGia", maDocGia),
                new SqlParameter("@HomNay", DateTime.Now.Date)
            };
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }
        private PhieumuonDTO MapRowToDTO(DataRow row)
        {
            return new PhieumuonDTO
            {
                MaSo = Convert.ToInt32(row["Ma_So"]),
                MaPhieuMuon = row["Ma_Phieu_Muon"].ToString(),
                MaDocGia = row["Ma_Doc_Gia"].ToString(),
                MaSach = row["Ma_Sach"].ToString(),
                MaThuThuLapPhieu = row["Ma_Thu_Thu_Lap"].ToString(),
                MaThuThuNhanTra = row["Ma_Thu_Thu_Tra"] == DBNull.Value ? null : row["Ma_Thu_Thu_Tra"].ToString(),
                NgayMuon = Convert.ToDateTime(row["Ngay_Muon"]),
                NgayHetHan = Convert.ToDateTime(row["Ngay_Het_Han"]),
                NgayTra = row["Ngay_Tra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["Ngay_Tra"]),
                SoLanGiaHan = Convert.ToInt32(row["So_Lan_Gia_Han"]),
                TrangThai = row["Trang_Thai"].ToString(),
                GhiChu = row["Ghi_Chu"] == DBNull.Value ? null : row["Ghi_Chu"].ToString()
            };
        }
        public bool TruSoLuongKhaDung (string maSach)
        {
            string sql = @"UPDATE Sach SET So_Luong_Kha_Dung = So_Luong_Kha_Dung - 1 WHERE Ma_Sach = @MaSach AND So_Luong_Kha_Dung > 0";
            var parameters = new[] { new SqlParameter("@MaSach", maSach) };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool CongSoLuongKhaDung(string maSach)
        {
            string sql = @"UPDATE Sach SET So_Luong_Kha_Dung = So_Luong_Kha_Dung + 1 WHERE Ma_Sach = @MaSach";
            var parameters = new[] { new SqlParameter("@MaSach", maSach) };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool TruVinhVienTongSoLuong(string maSach)
        {
            string sql = @"UPDATE Sach SET Tong_So_Luong = Tong_So_Luong - 1 WHERE Ma_Sach = @MaSach AND Tong_So_Luong > 0";
            var parameters = new[] { new SqlParameter("@MaSach", maSach) };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool TangSoLanMuonSach(string maSach)
        {
            string sql = @"UPDATE Sach SET So_Lan_Muon = So_Lan_Muon + 1 WHERE Ma_Sach = @MaSach";
            var parameters = new[] { new SqlParameter("@MaSach", maSach) };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public decimal? LayGiaBiaSach(string maSach)
        {
            string sql = "SELECT Gia_Bia FROM Sach WHERE Ma_Sach = @MaSach";
            var parameters = new[] { new SqlParameter("@MaSach", maSach) };
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return (result == null || result == DBNull.Value) ? (decimal?)null : Convert.ToDecimal(result);
        }
        public (bool TonTai,DateTime NgayHetHanThe,string TrangThaiThe,int SoLanViPham) LayThongTinDocGia(string maDocGia)
        {
            string sql = @"SELECT Ngay_Het_Han_The,Trang_Thai_The,So_Lan_Vi_Pham FROM Doc_Gia WHERE Ma_Doc_Gia = @MaDocGia";
            var parameters = new[] { new SqlParameter("@MaDocGia", maDocGia) };
            DataTable table = DatabaseHelper.ExecuteQuery(sql, parameters);
            if (table.Rows.Count == 0)
            {
                return (false, default, null, 0);
            }
            DataRow row = table.Rows[0];
            return( true, Convert.ToDateTime(row["Ngay_Het_Han_The"]), row["Trang_Thai_The"].ToString(), Convert.ToInt32(row["So_Lan_Vi_Pham"]));
        }
        public bool TangSoLanViPhamDocGia(string maDocGia)
        {
            string sql = @"UPDATE Doc_Gia SET So_Lan_Vi_Pham = So_Lan_Vi_Pham + 1 WHERE Ma_Doc_Gia = @MaDocGia";
            var parameters = new[] { new SqlParameter("@MaDocGia", maDocGia) };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool ThemPhatTien(PhatTienDTO phatTien)
        {
            int? maSoPhieuMuon = LayMaSoPhieuMuon(phatTien.MaPhieuMuon);
            int? maSoThuThu = LayMaSoThuThu(phatTien.MaThuThuXuLy);
            if(maSoPhieuMuon == null || maSoThuThu == null)
            {
                return false;
            }
            string sql = @"INSERT INTO Phat_Tien (Phieu_Muon_Ma_So, Thu_Thu_Xu_Ly_Ma_So, Loai_Vi_Pham, So_Ngay_Tre, So_Tien_Phat, Trang_Thai_Thanh_Toan)
                           VALUES (@PhieuMuonMaSo, @ThuThuMaSo, @LoaiViPham, @SoNgayTre, @SoTienPhat, @TrangThaiThanhToan)";
            var parameters = new[]
            {
                new SqlParameter("@PhieuMuonMaSo", maSoPhieuMuon.Value),
                new SqlParameter("@ThuThuMaSo", maSoThuThu.Value),
                new SqlParameter("@LoaiViPham", phatTien.LoaiViPham),
                new SqlParameter("@SoNgayTre", phatTien.SoNgayTre),
                new SqlParameter("@SoTienPhat", phatTien.SoTienPhat),
                new SqlParameter("@TrangThaiThanhToan", phatTien.TrangThaiThanhToan)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
        public bool CongTienVaoCaTrucDangHoatDong(string maThuThu, decimal soTien)
        {
            string sql = @"UPDATE Ca_Truc SET Tong_Tien_Thu = Tong_Tien_Thu + @SoTien
                WHERE Thu_Thu_Ma_So = (SELECT Ma_So FROM Thu_Thu WHERE Ma_Thu_Thu = @MaThuThu)
                  AND Ngay_Truc = CAST(GETDATE() AS DATE)
                  AND Trang_Thai = N'Đang trực'";
            var parameters = new[]
            {
                new SqlParameter("@SoTien", soTien),
                new SqlParameter("@MaThuThu", maThuThu)
                
            };
            return DatabaseHelper.ExecuteNonQuery(sql, parameters) > 0;
        }
    }
}
