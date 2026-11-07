using System;
using System.Data;
using Library.DAL;
using Library.DTO;

namespace Library.BLL
{
    /// <summary>
    /// Nghiệp vụ mượn, trả, gia hạn tại quầy.
    /// Quy chế (số sách, số ngày, tiền phạt/ngày) đọc từ bảng Cau_Hinh_He_Thong mỗi lần gọi,
    /// nên Admin sửa tham số là các phiếu mới áp dụng ngay, không cần sửa code.
    /// </summary>
    public class PhieuMuonBLL
    {
        private readonly PhieuMuonDAL _phieuMuonDAL = new PhieuMuonDAL();

        #region Đọc Quy Chế Tham Số Động Từ Database
        /// <summary>Đơn giá phạt trễ một ngày. Lỗi CSDL hoặc chưa có dòng cấu hình thì dùng 5.000đ.</summary>
        public decimal LayDonGiaPhatTreHan()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'Tien_Phat_Moi_Ngay'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && decimal.TryParse(val.ToString(), out decimal donGia))
                    return donGia;
            }
            catch { }
            return 5000m;
        }

        /// <summary>Số ngày được mượn khi lập phiếu mới. Mặc định 14 nếu chưa cấu hình.</summary>
        public int LaySoNgayMuonToiDa()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'So_Ngay_Muon_Toi_Da'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && int.TryParse(val.ToString(), out int soNgay))
                    return soNgay;
            }
            catch { }
            return 14;
        }

        /// <summary>Số cuốn đang mượn tối đa của một bạn đọc. Mặc định 5.</summary>
        public int LaySoSachMuonToiDa()
        {
            try
            {
                string query = "SELECT Gia_Tri FROM dbo.Cau_Hinh_He_Thong WHERE Ten_Tham_So = 'So_Sach_Muon_Toi_Da'";
                object? val = DatabaseHelper.ExecuteScalar(query);
                if (val != null && int.TryParse(val.ToString(), out int soSach))
                    return soSach;
            }
            catch { }
            return 5;
        }
        #endregion

        /// <summary>Danh sách đầu sách để ô tìm kiếm gợi ý mã, tên và số lượng còn.</summary>
        public DataTable LayDanhSachGoiYSach()
        {
            return _phieuMuonDAL.LayDanhSachGoiYSach();
        }

        /// <summary>Các phiếu chưa trả của một bạn đọc, dùng để đếm giới hạn trước khi cho mượn thêm.</summary>
        public DataTable LayDanhSachDangMuon(string maDocGia)
        {
            return _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
        }

        /// <summary>
        /// Lập một phiếu mượn. Ném Exception kèm câu tiếng Việt khi vi phạm quy chế (form bắt và hiện hộp thoại).
        /// Thứ tự kiểm tra: còn hạn mức sách, đầu sách tồn tại, còn bản trên kệ, có bản sao trạng thái Sẵn sàng.
        /// Hạn trả = ngày mượn + số ngày tối đa trong quy chế. Trả về mã phiếu, hoặc chuỗi rỗng nếu DAL thất bại.
        /// </summary>
        public string LapPhieuMuon(string maDocGia, string inputSach, DateTime ngayMuon, int? thuThuMaSo = null, int? chiNhanhMaSo = null)
        {
            if (string.IsNullOrWhiteSpace(inputSach))
                throw new Exception("Vui lòng nhập mã sách, mã vạch hoặc tên sách cần mượn!");

            // 1. Kiểm tra giới hạn số lượng mượn theo quy chế hệ thống
            DataTable dtDangMuon = _phieuMuonDAL.LayDanhSachDangMuon(maDocGia);
            int maxBooks = LaySoSachMuonToiDa();
            if (dtDangMuon.Rows.Count >= maxBooks)
            {
                throw new Exception($"Độc giả đã đạt giới hạn mượn tối đa {maxBooks} cuốn sách theo quy định!");
            }

            // 2. Kiểm tra tồn tại đầu sách
            if (!_phieuMuonDAL.KiemTraSachTonTai(inputSach, out string tenSach, out int khaDung))
            {
                throw new Exception($"Không tìm thấy đầu sách hoặc mã vạch nào khớp với '{inputSach}'!");
            }

            // 3. Kiểm tra số lượng sách còn khả dụng trên kệ
            if (khaDung <= 0)
            {
                throw new Exception($"Đầu sách '{tenSach}' hiện đã hết cuốn khả dụng trên kệ (đang cho mượn hết hoặc bảo trì)!");
            }

            // 4. Tìm kiếm bản sao vật lý sẵn sàng
            DataRow? banSao = _phieuMuonDAL.TimKiemBanSaoKhaDung(inputSach);
            if (banSao == null)
            {
                throw new Exception($"Không tìm thấy bản sao vật lý nào ở trạng thái 'Sẵn sàng' cho cuốn '{tenSach}'!");
            }

            int banSaoMaSo = Convert.ToInt32(banSao["BanSaoMaSo"]);
            int sachMaSo = Convert.ToInt32(banSao["SachMaSo"]);
            int chiNhanhId = chiNhanhMaSo ?? Convert.ToInt32(banSao["ChiNhanhMaSo"]); // Ưu tiên chi nhánh ca trực hôm nay
            int thuThuId = thuThuMaSo ?? 1; // Form luôn truyền mã thủ thư đang đăng nhập; 1 chỉ là phương án dự phòng

            int.TryParse(maDocGia, out int docGiaId);
            if (docGiaId <= 0) docGiaId = 1;

            string maPhieu = _phieuMuonDAL.GetNextMaPhieuMuon();
            DateTime ngayHenHan = ngayMuon.AddDays(LaySoNgayMuonToiDa());

            bool success = _phieuMuonDAL.ThucHienMuonSach(maPhieu, docGiaId, thuThuId, chiNhanhId, ngayMuon, ngayHenHan, banSaoMaSo, sachMaSo);
            return success ? maPhieu : string.Empty;
        }

        /// <summary>
        /// Tiền phạt = số ngày trễ × đơn giá/ngày. So theo .Date nên cùng một ngày thì không phạt.
        /// Trả đúng hạn hoặc sớm hơn thì bằng 0.
        /// </summary>
        public decimal TinhTienPhatTreHan(DateTime ngayHenHan, DateTime ngayTra)
        {
            if (ngayTra.Date > ngayHenHan.Date)
            {
                int soNgayTre = (ngayTra.Date - ngayHenHan.Date).Days;
                return soNgayTre * LayDonGiaPhatTreHan();
            }
            return 0;
        }

        /// <summary>
        /// Ghi nhận trả: tính phạt rồi cập nhật phiếu sang "Đã hoàn thành".
        /// tienPhat là tham số out để form báo số tiền, không ghi công nợ ở hàm này
        /// (biên bản phạt riêng nằm ở PhieuPhatBLL).
        /// </summary>
        public bool TraSach(string maPhieu, DateTime ngayTra, DateTime ngayHenHan, out decimal tienPhat)
        {
            tienPhat = TinhTienPhatTreHan(ngayHenHan, ngayTra);
            string trangThai = "Đã hoàn thành";
            return _phieuMuonDAL.CapNhatTraSach(maPhieu, ngayTra, trangThai);
        }

        /// <summary>
        /// Gia hạn đúng một lần, cộng thêm 7 ngày vào hạn hiện tại.
        /// Từ chối nếu đã gia hạn rồi, hoặc hôm nay đã quá hạn trả.
        /// </summary>
        public bool GiaHanPhieu(string maPhieu, int soLanGiaHanHienTai, DateTime ngayHenHanHienTai)
        {
            if (soLanGiaHanHienTai >= 1)
            {
                throw new Exception("Phiếu mượn này đã được gia hạn tối đa (1 lần)!");
            }
            if (DateTime.Now.Date > ngayHenHanHienTai.Date)
            {
                throw new Exception("Không thể gia hạn phiếu mượn đã quá hạn!");
            }

            DateTime ngayMoi = ngayHenHanHienTai.AddDays(7); // Cố định +7 ngày, không lấy từ quy chế số ngày mượn
            return _phieuMuonDAL.GiaHanPhieu(maPhieu, ngayMoi, soLanGiaHanHienTai + 1);
        }

        /// <summary>Lưới quầy. docGiaMaSo = 0 nghĩa là mọi bạn đọc. chiQuaHan = true thì chỉ phiếu đã quá hạn.</summary>
        public DataTable LayDanhSachDangMuonNangCao(int docGiaMaSo = 0, bool chiQuaHan = false, string tuKhoa = "")
        {
            return _phieuMuonDAL.LayDanhSachDangMuonNangCao(docGiaMaSo, chiQuaHan, tuKhoa);
        }

        /// <summary>Sửa số điện thoại ngay tại quầy, không cần mở màn quản lý bạn đọc.</summary>
        public bool CapNhatSoDienThoaiDocGia(int docGiaMaSo, string soDienThoai)
        {
            if (docGiaMaSo <= 0 || string.IsNullOrWhiteSpace(soDienThoai)) return false;
            return _phieuMuonDAL.CapNhatSoDienThoaiDocGia(docGiaMaSo, soDienThoai);
        }
    }
}