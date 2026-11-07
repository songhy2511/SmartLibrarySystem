# 📚 HỆ THỐNG QUẢN LÝ THƯ VIỆN THÔNG MINH (SMART LIBRARY MANAGEMENT SYSTEM)

[![.NET Core](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-brightgreen.svg)]()
[![Database](https://img.shields.io/badge/Database-SQL%20Server%202019%2B-red.svg)]()
[![Tests](https://img.shields.io/badge/Unit%20Tests-54%2F54%20Passed-success.svg)]()
[![Security](https://img.shields.io/badge/Security-PBKDF2--SHA256%20(100k)-orange.svg)]()

---

## 📌 1. TỔNG QUAN HỆ THỐNG

**Smart Library Management System** là giải pháp phần mềm quản trị thư viện phân tán đa chi nhánh, giải quyết các bài toán lưu thông tài liệu, quản lý tài sản, điều phối sách giữa các kho và đối soát dòng tiền giao dịch theo ca làm việc của nhân sự. 

Hệ thống được thiết kế theo mô hình kiến trúc **3 lớp (3-Tier Architecture)**, đáp ứng các tiêu chuẩn bảo mật mật khẩu cấp doanh nghiệp (OWASP/NIST), quản lý kiểm toán độc lập (Dual Audit Logging) và khả năng xuất báo cáo chuyên nghiệp.

---

## 🏗️ 2. KIẾN TRÚC VÀ CÔNG NGHỆ SỬ DỤNG

### 2.1. Ngăn xếp công nghệ (Tech Stack)
* **Nền tảng phát triển:** C# 12, .NET 8.0 (Windows Desktop Runtime).
* **Giao diện người dùng (UI):** Windows Forms với cơ chế **Double Buffering** độc quyền triệt tiêu hiện tượng giật/nháy giao diện trên `DataGridView`.
* **Cơ sở dữ liệu:** Microsoft SQL Server (Collation: `Vietnamese_CI_AS`).
* **Truy xuất dữ liệu:** ADO.NET (`Microsoft.Data.SqlClient`) với Transaction, Parameterized Queries và Async/Await.
* **Xử lý tài liệu & Báo cáo:** `ClosedXML` (Xuất file Excel), `QuestPDF` (Biên dịch báo cáo vector PDF), `PrintDocument` (Hệ thống xem trước bản in Print Preview).
* **Kiểm thử tự động:** `MSTest` với bộ kiểm thử tự động 54 test cases bao phủ toàn diện các ràng buộc nghiệp vụ.

### 2.2. Cấu trúc Solution (3-Tier Architecture)

```text
SmartLibrarySystem/
├── Database/
│   └── LibraryDB.sql                 # Script CSDL hoàn chỉnh: Schema, Stored Procedures & Seed Data
├── Library.DTO/                       # Data Transfer Objects (Định nghĩa thực thể dữ liệu)
├── Library.DAL/                       # Data Access Layer (Truy vấn CSDL & Kết nối)
│   ├── DatabaseHelper.cs              # Bộ điều phối kết nối & thực thi ADO.NET
│   └── ...                            # Các DAL chuyên trách từng bảng
├── Library.BLL/                       # Business Logic Layer (Xử lý nghiệp vụ & Bảo mật)
│   ├── Security/PasswordHasher.cs     # Thuật toán mã hóa PBKDF2 100.000 iterations
│   ├── SystemLogger.cs                # Cơ chế kiểm toán ghi log kép (Database & File text)
│   └── ...                            # Các BLL xử lý nghiệp vụ
├── Library.UI/                        # Presentation Layer (Giao diện WinForms)
│   ├── FormAdminDashboard.cs          # Không gian làm việc của Quản trị viên
│   ├── FormThuThuDashboard.cs         # Bàn làm việc tác nghiệp của Thủ thư
│   └── ...                            # Màn hình chức năng chi tiết
└── Library.Tests/                     # Bộ kiểm thử đơn vị Unit Tests (MSTest)
```

---

## ⚙️ 3. TÍNH NĂNG CHI TIẾT CỦA HỆ THỐNG

### 3.1. Phân hệ Quản trị viên (Admin Dashboard)
1. **Tổng quan hệ thống & Đối soát KPI:** 
   * Giám sát thời gian thực số lượng bạn đọc hoạt động, tổng đầu sách, số sách đang lưu hành và công nợ phạt chưa thu.
   * Lưới kiểm soát lưu thông mượn - trả tự động cập nhật theo tuần.
2. **Quản lý đa chi nhánh:** Cấp phát mã tự động (`CN01`, `CN02`...), quản lý địa điểm và kích hoạt/ngừng hoạt động chi nhánh.
3. **Quản lý nhân sự & Phân quyền:**
   * Cấp hồ sơ thủ thư mới, tự sinh mật khẩu ngẫu nhiên đạt chuẩn an toàn thông tin (tối thiểu 1 chữ hoa, 1 chữ thường, 1 số, 1 ký tự đặc biệt) và tự động sao chép vào Clipboard.
   * Khóa/mở khóa tài khoản thủ thư (có cơ chế chống Admin tự khóa tài khoản chính mình).
   * Cấp lại mật khẩu tạm thời.
4. **Phân chia ca làm việc đa chi nhánh:**
   * Phân bổ ca sáng/chiều, định mức giờ trực và số tiền bàn giao đầu ca.
   * Ràng buộc nghiệp vụ chống trùng ca: Một ca tại một chi nhánh chỉ phân công 1 người; một thủ thư không thể trực 2 chi nhánh cùng một khung giờ.
5. **Quy chế & Cấu hình tham số động:**
   * Tùy chỉnh quy định mượn: Số sách tối đa, số ngày mượn, đơn giá phạt trễ hạn mỗi ngày, thời hạn thẻ.
   * Thiết lập tỷ lệ đền bù hư hỏng/mất sách (% theo giá bìa tài liệu).
6. **Nhật ký kiểm toán hệ thống (Audit Logs):**
   * Theo dõi vết hệ thống với 4 cấp độ: `INFO`, `WARNING`, `ERROR`, `SECURITY`.
   * Bộ lọc đa chiều theo mốc thời gian, mức độ, loại hành động và từ khóa.
   * Nút mở trực tiếp thư mục chứa file log văn bản (`.log`).
7. **Báo cáo tài chính & Thống kê nâng cao:**
   * Báo cáo đối soát doanh thu tiền phạt theo từng ca trực và tính toán chênh lệch quỹ:
     $$\text{Chênh lệch quỹ} = \text{Tiền kết ca thực tế} - (\text{Tiền đầu ca} + \text{Tiền phạt thu trong ca})$$
   * Thống kê Top sách mượn nhiều nhất và tỷ lệ quay vòng bản sao theo từng chi nhánh.
   * Xuất dữ liệu đa định dạng: **CSV**, **Excel (.xlsx)**, **PDF (.pdf)** và **Xem trước bản in (Print Preview)**.

### 3.2. Phân hệ Thủ thư (Librarian Dashboard)
1. **Bàn tác nghiệp lưu thông (Mượn - Trả sách):**
   * Cho mượn sách bằng AutoComplete thông minh (hỗ trợ nhập mã sách, mã vạch hoặc tên sách).
   * Giám sát hạn trả với trực quan màu sắc: Còn hạn (Xanh), Hạn chót hôm nay (Vàng), Quá hạn (Đỏ kèm số ngày trễ).
   * Gia hạn sách trực tiếp (+7 ngày), kiểm soát chặt chẽ tối đa 1 lần gia hạn và chặn gia hạn nếu đã quá hạn.
   * Trả sách một chạm, tự động tính tiền phạt trễ hạn dựa trên số ngày trễ và quy chế hiện hành.
   * Cập nhật nhanh số điện thoại liên lạc của bạn đọc trực tiếp tại quầy.
2. **Quản lý kho sách chi nhánh & Điều phối:**
   * Tra cứu tồn kho chi nhánh theo từng trạng thái: Tổng bản sao, Sẵn sàng, Đang mượn, Hư hỏng/Bảo trì.
   * Quản lý biểu ghi sách, cập nhật vị trí kệ sách và giá bìa đền bù.
   * Đề xuất thanh lý bản sao rách nát / hư hỏng nặng (tự động giảm số lượng khả dụng).
   * Điều phối bản sao sách sẵn sàng luân chuyển sang chi nhánh khác.
3. **Quản lý hồ sơ Bạn đọc (Độc giả):**
   * Cấp thẻ bạn đọc mới, tra cứu nhanh thông tin liên lạc.
   * Khóa/mở khóa thẻ độc giả, gia hạn hiệu lực thẻ thêm năm sử dụng.
   * Cảnh báo thẻ độc giả có $\ge 3$ lần vi phạm bằng nền màu cảnh báo.
4. **Lập biên bản vi phạm & Thu nộp phạt:**
   * Lập biên bản xử lý vi phạm linh hoạt: Quá hạn kéo dài, Làm rách/hỏng nhẹ (30%), Làm hỏng nặng (60%), Làm mất sách (100% giá bìa), Vi phạm khác.
   * Tự động cập nhật trạng thái tài sản sang `Hư hỏng` hoặc `Mất/Thanh lý` và trừ kho tương ứng.
   * Thu tiền phạt vi phạm và tự động kết chuyển dòng tiền mặt vào quỹ ca trực hiện tại.
5. **Lịch trực cá nhân & Bàn giao chốt ca:**
   * Xem lịch phân công theo tuần hoặc theo tháng.
   * Chốt ca trực cuối ngày: Bắt buộc kiểm đếm tiền mặt thực nộp, đối chiếu với tiền lý thuyết và ghi nhận chênh lệch trước khi đăng xuất.

---

## 🔒 4. KIẾN TRÚC AN TOÀN & BẢO MẬT

* **Mã hóa mật khẩu:** Mật khẩu được băm chậm thông qua thuật toán **PBKDF2-HMAC-SHA256** với **100.000 vòng lặp** (Iterations) kết hợp cùng chuỗi muối ngẫu nhiên (Salt 128-bit) sinh bằng CSPRNG (`RandomNumberGenerator`).
* **Chống Timing Attack:** Sử dụng phương thức `CryptographicOperations.FixedTimeEquals` so khớp byte cố định nhằm ngăn ngừa rò rỉ độ dài hoặc thời gian thực thi mã băm.
* **Kiểm soát phiên làm việc (SessionContext):** Mọi tác vụ nghiệp vụ đều ràng buộc chặt chẽ với ID người dùng thực tế đang đăng nhập, loại bỏ hoàn toàn fallback cứng.
* **Cơ chế ghi nhật ký kiểm toán kép (Dual Logging):**
  1. **CSDL SQL Server:** Ghi vào bảng `Nhat_Ky_He_Thong` phục vụ việc truy vấn, lọc và hiển thị trực tiếp cho Admin.
  2. **File text hệ thống:** Tự động ghi vào thư mục `/Logs/system_audit_yyyyMMdd.log` với khóa luồng `thread-safe lock`, giúp lập trình viên tra cứu độc lập ngay cả khi hệ thống mất kết nối CSDL.

---

## 🚀 5. HƯỚNG DẪN CÀI ĐẶT & CHẠY CHƯƠNG TRÌNH

### 5.1. Yêu cầu môi trường (Prerequisites)
* Hệ điều hành: Windows 10 / Windows 11 (64-bit).
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (phiên bản `8.0.x` trở lên).
* **Microsoft SQL Server 2019/2022** hoặc **SQL Server Express**.
* SQL Server Management Studio (SSMS) hoặc Azure Data Studio.
* Visual Studio 2022 (khuyến nghị bản 17.8+) với workload *.NET Desktop Development*.

---

### 5.2. Khởi tạo Cơ sở dữ liệu (Database Setup)

1. Mở phần mềm **SQL Server Management Studio (SSMS)** và kết nối vào máy chủ SQL của bạn.
2. Mở file script: `Database/LibraryDB.sql`.
3. Nhấn **Execute (F5)** để khởi tạo:
   * Tạo cơ sở dữ liệu `LibraryDB` với bảng mã tiếng Việt `Vietnamese_CI_AS`.
   * Khởi tạo 14 bảng dữ liệu, ràng buộc khóa ngoại `FOREIGN KEY` và ràng buộc toàn vẹn `CHECK`.
   * Biên dịch 2 Stored Procedures: `sp_LapBienBanViPham` và `sp_ThuTienPhat`.
   * Nạp toàn bộ dữ liệu mẫu (Seed Data) chuẩn xác về ca trực, tài khoản và danh mục sách.

---

### 5.3. Cấu hình Chuỗi kết nối (Connection String)

Mở tập tin **`Library.DAL/DatabaseHelper.cs`**, kiểm tra và cập nhật thuộc tính `ConnectionString` cho phù hợp với máy tính của bạn:

```csharp
// Sử dụng Windows Authentication (mặc định)
public static string ConnectionString { get; set; } =
    "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

// Hoặc nếu SQL Server có đặt tên Instance riêng (ví dụ SQLEXPRESS):
// "Data Source=.\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";
```

---

### 5.4. Biên dịch và Khởi chạy ứng dụng

Mở cửa sổ Terminal (Command Prompt hoặc Developer PowerShell) tại thư mục gốc của dự án `SmartLibrarySystem`:

```bash
# 1. Khôi phục các thư viện NuGet phụ thuộc
dotnet restore

# 2. Biên dịch toàn bộ Solution ở chế độ Debug
dotnet build SmartLibrarySystem.slnx

# 3. Khởi chạy ứng dụng Windows Forms
dotnet run --project Library.UI
```

Hoặc bạn có thể mở tệp giải pháp `SmartLibrarySystem.slnx` trực tiếp trong **Visual Studio 2022**, chọn Startup Project là `Library.UI` và nhấn **F5** để chạy.

---

## 🔑 6. TÀI KHOẢN ĐĂNG NHẬP MẪU (SEED ACCOUNTS)

Dữ liệu mẫu khởi tạo sẵn 3 tài khoản tương ứng với các vai trò trong hệ thống:

| Vai trò | Tên đăng nhập | Mật khẩu mặc định | Hồ sơ nhân sự / Phân công |
| :--- | :--- | :--- | :--- |
| **Quản trị viên (Admin)** | `admin` | `Admin@123` | Quản trị toàn hệ thống |
| **Thủ thư 1 (Librarian)** | `thuthu1` | `Librarian@2026!` | Lê Minh Tuấn (Quầy Mượn - Trả số 1, CN Trung Tâm) |
| **Thủ thư 2 (Librarian)** | `thuthu2` | `Librarian@2026!` | Nguyễn Thu Hà (Quầy Lưu Thông số 2, CN Trẻ) |

> ⚠️ **Lưu ý:** Các tài khoản đều sử dụng chuẩn băm bảo mật PBKDF2. Khi sao chép mật khẩu, hãy nhập chính xác từng ký tự hoa, thường và ký tự đặc biệt.

---

## 🧪 7. CHẠY KIỂM THỬ TỰ ĐỘNG (UNIT TESTS)

Dự án tích hợp đầy đủ bộ kiểm thử `Library.Tests` bao phủ 100% các quy chế nghiệp vụ quan trọng.

Để chạy kiểm thử từ dòng lệnh:

```bash
dotnet test
```

### Danh mục các Test Suite đã triển khai (54/54 Tests Passed):
* **`AuthTests`:** Kiểm tra thuật toán băm PBKDF2 khớp với seed SQL, tính ngẫu nhiên của Salt, cơ chế so khớp mật khẩu và bộ quy tắc thẩm định độ mạnh mật khẩu.
* **`AdminBusinessRuleTests`:** Kiểm tra ràng buộc phân ca (chặn ca trong quá khứ, giờ bắt đầu sau giờ kết thúc, thiếu nhân sự), ràng buộc tham số quy chế động, đổi mật khẩu và an toàn tài khoản Admin.
* **`BookInventoryTests`:** Kiểm tra tính toàn vẹn của số lượng tồn kho (khả dụng $\le$ tổng số lượng, không âm) và định dạng tự sinh mã sách (`B0xxx`).
* **`CirculationBusinessRuleTests`:** Kiểm thử tính tiền phạt trễ hạn chính xác theo số ngày, chặn gia hạn lần 2 và chặn gia hạn phiếu quá hạn.
* **`BaoCaoExportTests`:** Kiểm tra logic chặn ngày đảo ngược, tính đúng đắn khi xuất file CSV, Excel (.xlsx), PDF (.pdf) và độ chính xác của số liệu đối soát doanh thu ca trực.

---

## 👥 THÀNH VIÊN NHÓM PHÁT TRIỂN

* **Đồ án:** Công nghệ & Môi trường phát triển phần mềm (.NET 8 WinForms)
* **Phiên bản:** 2.3 - Hoàn thiện toàn diện nghiệp vụ, bảo mật & kiểm thử.