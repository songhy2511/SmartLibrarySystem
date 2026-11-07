using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BLL;

namespace Library.Tests
{
    [TestClass]
    public class CirculationBusinessRuleTests
    {
        private PhieuMuonBLL _phieuMuonBLL = null!;

        [TestInitialize]
        public void Setup()
        {
            _phieuMuonBLL = new PhieuMuonBLL();
        }

        #region 1. TEST TÍNH TIỀN PHẠT TRỄ HẠN

        [TestMethod]
        [TestCategory("Circulation")]
        public void TinhTienPhatTreHan_TraDungHanHoacSomHon_TienPhatBangKhong()
        {
            DateTime ngayHenHan = DateTime.Today;
            DateTime ngayTraDungHan = DateTime.Today;
            DateTime ngayTraSom = DateTime.Today.AddDays(-2);

            decimal phatDungHan = _phieuMuonBLL.TinhTienPhatTreHan(ngayHenHan, ngayTraDungHan);
            decimal phatSom = _phieuMuonBLL.TinhTienPhatTreHan(ngayHenHan, ngayTraSom);

            Assert.AreEqual(0m, phatDungHan, "Trả sách đúng hạn không được tính tiền phạt!");
            Assert.AreEqual(0m, phatSom, "Trả sách trước hạn không được tính tiền phạt!");
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(10)]
        [TestCategory("Circulation")]
        public void TinhTienPhatTreHan_TraTreHan_TienPhatChinhXacTheoSoNgay(int soNgayTre)
        {
            DateTime ngayHenHan = DateTime.Today.AddDays(-soNgayTre);
            DateTime ngayTra = DateTime.Today;

            decimal donGiaPhat = _phieuMuonBLL.LayDonGiaPhatTreHan();
            decimal tienPhatThucTe = _phieuMuonBLL.TinhTienPhatTreHan(ngayHenHan, ngayTra);

            decimal tienPhatKyVong = soNgayTre * donGiaPhat;
            Assert.AreEqual(tienPhatKyVong, tienPhatThucTe, $"Tiền phạt cho {soNgayTre} ngày trễ phải bằng số ngày nhân đơn giá quy định!");
        }

        #endregion

        #region 2. TEST RÀNG BUỘC GIA HẠN SÁCH

        [TestMethod]
        [TestCategory("Circulation")]
        public void GiaHanPhieu_DaGiaHanTuTruoc_QuangNgoaiLeToiDaMotLan()
        {
            string maPhieu = "BR260101001";
            int soLanDaGiaHan = 1; // Đã gia hạn 1 lần
            DateTime ngayHenHanChuaQua = DateTime.Today.AddDays(3);

            var ex = Assert.ThrowsExactly<Exception>(() =>
                _phieuMuonBLL.GiaHanPhieu(maPhieu, soLanDaGiaHan, ngayHenHanChuaQua));

            StringAssert.Contains(ex.Message, "tối đa (1 lần)");
        }

        [TestMethod]
        [TestCategory("Circulation")]
        public void GiaHanPhieu_PhieuDaQuaHan_QuangNgoaiLeKhongChoGiaHan()
        {
            string maPhieu = "BR260101002";
            int soLanDaGiaHan = 0;
            DateTime ngayHenHanDaQua = DateTime.Today.AddDays(-2); // Đã trễ hạn

            var ex = Assert.ThrowsExactly<Exception>(() =>
                _phieuMuonBLL.GiaHanPhieu(maPhieu, soLanDaGiaHan, ngayHenHanDaQua));

            StringAssert.Contains(ex.Message, "quá hạn");
        }

        #endregion
    }
}