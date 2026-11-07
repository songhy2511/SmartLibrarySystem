using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BLL;
using Library.DTO;

namespace Library.Tests
{
    [TestClass]
    public class BookInventoryTests
    {
        private SachBLL _sachBLL = null!;

        [TestInitialize]
        public void Setup()
        {
            _sachBLL = new SachBLL();
        }

        [TestMethod]
        public void Test_StockIntegrity_ValidValues_ReturnsTrue()
        {
            var sach = new SachDTO
            {
                Tong_So_Luong = 10,
                So_Luong_Kha_Dung = 7
            };

            bool isValid = _sachBLL.KiemTraTinhToanVeng(sach);
            Assert.IsTrue(isValid, "Số lượng khả dụng nhỏ hơn hoặc bằng tổng số lượng phải trả về true");
        }

        [TestMethod]
        public void Test_StockIntegrity_KhaDungExceedsTotal_ReturnsFalse()
        {
            var sach = new SachDTO
            {
                Tong_So_Luong = 5,
                So_Luong_Kha_Dung = 6 // Vượt quá tổng số lượng
            };

            bool isValid = _sachBLL.KiemTraTinhToanVeng(sach);
            Assert.IsFalse(isValid, "Khả dụng lớn hơn Tổng số lượng phải trả về false");
        }

        [TestMethod]
        public void Test_StockIntegrity_NegativeKhaDung_ReturnsFalse()
        {
            var sach = new SachDTO
            {
                Tong_So_Luong = 5,
                So_Luong_Kha_Dung = -1 // Số âm
            };

            bool isValid = _sachBLL.KiemTraTinhToanVeng(sach);
            Assert.IsFalse(isValid, "Số lượng khả dụng âm phải trả về false");
        }

        [TestMethod]
        public void Test_AutoGenerateBookCode_FormatB0xxx()
        {
            string newCode = _sachBLL.TaoMaSachMoi();
            StringAssert.StartsWith(newCode, "B0", "Mã sách phải có định dạng bắt đầu bằng B0xxx");
        }
        [TestMethod]
        public void Test_StockIntegrity_KhaDungExceedsTotal_ReturnsFalse()
        {
            var sach = new SachDTO
            {
                Tong_So_Luong = 5,
                So_Luong_Kha_Dung = 8
            };

            bool isValid = _sachBLL.KiemTraTinhToanVeng(sach);
            Assert.IsFalse(isValid, "Khả dụng lớn hơn Tổng số lượng phải trả về false");
        }
    }
}