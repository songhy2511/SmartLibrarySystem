using Library.DTO;

namespace Library.UI
{
    public static class SessionContext
    {
        public static NguoiDungDTO? CurrentUser { get; set; }
    }
}