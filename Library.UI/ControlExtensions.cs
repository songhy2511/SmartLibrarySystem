using System.Reflection;
using System.Windows.Forms;

namespace Library.UI
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Kích hoạt bộ đệm kép (Double Buffering) ẩn của hệ điều hành cho DataGridView để chống nháy/giật màn hình.
        /// </summary>
        public static void EnableDoubleBuffered(this DataGridView dgv, bool setting = true)
        {
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dgv,
                new object[] { setting }
            );
        }
    }
}