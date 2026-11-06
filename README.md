# HƯỚNG DẪN DỰ ÁN & QUY CHUẨN PHÁT TRIỂN PHẦN MỀM
# SMART LIBRARY SYSTEM (LibraryDB)

> **Tài liệu nội bộ nhóm phát triển Smart Library System.**  
> Tất cả thành viên bắt buộc phải đọc kỹ tài liệu này trước khi tạo nhánh hoặc viết code để đảm bảo tính nhất quán về kiến trúc, bảo mật, cơ sở dữ liệu và quy trình Git.

---

## 1. TỔNG QUAN HỆ THỐNG & CÔNG NGHỆ

### 1.1. Công nghệ sử dụng
* **Nền tảng & Ngôn ngữ**: C# WinForms (.NET 8.0 trở lên).
* **Cơ sở dữ liệu**: Microsoft SQL Server 2019/2022.
* **Tầng truy cập dữ liệu (DAL)**: ADO.NET thuần qua `Microsoft.Data.SqlClient`. Cam kết sử dụng **100% `SqlParameter`** (tuyệt đối không cộng chuỗi SQL để chống SQL Injection).
* **Kiểm thử tự động**: MSTest Framework v3.
* **Giao diện chuẩn hóa**: Bảng màu hiện đại **Deep Slate & Navy** định nghĩa tập trung trong `UITheme.cs`.

### 1.2. Mô hình phân tầng kiến trúc (3-Tier Layered Architecture)
Hệ thống được tổ chức thành các Project riêng biệt theo nguyên tắc đơn trách nhiệm:
* **`Library.DTO`**: Chứa các lớp thực thể (Data Transfer Object / POCO), không chứa logic hay truy vấn SQL.
* **`Library.DAL`**: Thao tác trực tiếp với SQL Server thông qua `DatabaseHelper.cs`. Trả về `DataTable`, `int`, `object` hoặc ánh xạ thành danh sách DTO. Không nhúng logic nghiệp vụ hay gọi giao diện WinForms tại đây.
* **`Library.BLL`**: Xử lý toàn bộ logic nghiệp vụ, thẩm định dữ liệu đầu vào (Validation), kiểm tra điều kiện biên và kích hoạt cơ chế ghi vết kiểm toán (`SystemLogger`).
* **`Library.UI`**: Tầng giao diện người dùng WinForms. Nhận/gửi dữ liệu độc quyền qua tầng BLL. Tuyệt đối không viết câu lệnh SQL trong Form.
* **`Library.Tests`**: Project chứa bộ Unit Test độc lập, kiểm tra logic nghiệp vụ thuần túy không phụ thuộc vào UI hay trạng thái database.

---

## 2. HƯỚNG DẪN CÀI ĐẶT MÔI TRƯỜNG & CHẠY DỰ ÁN

### 2.1. Cài đặt Cơ sở dữ liệu (`LibraryDB.sql`)
1. Mở **SQL Server Management Studio (SSMS)** hoặc **Azure Data Studio**.
2. Mở file kịch bản CSDL chính của dự án: **`LibraryDB.sql`** (nằm tại thư mục gốc của Solution).
3. Nhấn **Execute (F5)** để khởi tạo Database `LibraryDB` bao gồm toàn bộ bảng, khóa chính, khóa ngoại, ràng buộc và dữ liệu mẫu chuẩn (Seed Data).

### 2.2. Cấu hình Chuỗi kết nối (Connection String)
Chuỗi kết nối được quản lý tập trung trong file `Library.DAL/DatabaseHelper.cs`:
```csharp
public static string ConnectionString { get; set; } =
    "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";
```
* Nếu máy bạn dùng Named Instance, sửa `Data Source=.` thành `Data Source=.\\SQLEXPRESS` hoặc tên máy tính của bạn.

### 2.3. Danh sách Tài khoản Kiểm thử Mặc định (Seed Data)
| Tên đăng nhập | Mật khẩu thô | Vai trò | Chuỗi muối (Salt Seed) | Quầy / Chi nhánh |
| :--- | :--- | :--- | :--- | :--- |
| **`admin`** | `Admin@123` | Quản trị viên (Admin) | `Salt_Admin_2026_Secure_Key==` | Toàn hệ thống |
| **`thuthu1`** | `Librarian@123` | Thủ thư (Librarian) | `Salt_TT001_Key_Lib2026==` | TT001 - Quầy 1 (CN01) |
| **`thuthu2`** | `Librarian@123` | Thủ thư (Librarian) | `Salt_TT002_Key_Lib2026==` | TT002 - Quầy 2 (CN02) |

---

## 3. BẢNG PHÂN CÔNG NHIỆM VỤ CHI TIẾT & TIẾN ĐỘ THỰC HIỆN

### 3.1. THÀNH VIÊN 1: PHẠM SONG HỶ (TRƯỞNG NHÓM - ARCHITECTURE & SECURITY)
* **Nhánh Git phụ trách**: `feature/auth-and-admin-management` *(Đã merge vào `main`)*
* **Tình trạng tiến độ**: **HOÀN THÀNH 100% (ĐÃ ĐƯỢC BẢO VỆ TRÊN MAIN)**
* **Chi tiết các hạng mục đã hoàn thành (CÁC THÀNH VIÊN KHÔNG LÀM LẠI)**:
  1. **Xác thực & Bảo mật Core**:
     * Xây dựng `PasswordHasher.cs`: Băm SHA-256 kết hợp chuỗi muối 128-bit (Salt), chống tấn công Timing Attack bằng `CryptographicOperations.FixedTimeEquals`, hàm `ValidatePasswordStrength` kiểm tra chuẩn bảo mật.
     * Xây dựng `SessionContext.cs`: Lưu trạng thái phiên đăng nhập toàn cục (`CurrentUser`, `CurrentLibrarian`, `LoginTime`, cờ phân quyền `IsAdmin`, `IsLibrarian`).
     * Màn hình `FormDangNhap.cs`: Xác thực đăng nhập 2 vai trò, ghi log cảnh báo `WARNING` nếu thất bại, log `SECURITY` nếu thành công.
     * Màn hình `FormDoiMatKhau.cs`: Đổi mật khẩu cho cả Admin và Thủ thư, băm lại salt/hash mới, ghi log `SECURITY`.
     * Quản trị tài khoản nhân sự: Khóa/Mở khóa tài khoản (`Dang_Hoat_Dong = 0/1`), Reset mật khẩu về mặc định `Librarian@123`.
  2. **Quản trị Nhân sự & Ca trực (Chỉ Admin)**:
     * Quản lý hồ sơ thủ thư (`Thu_Thu`): Sinh tự động mã `TT0xxx` tăng dần, thêm thủ thư đồng thời tạo tài khoản qua `SqlTransaction` an toàn.
     * Màn hình `FormQuanLyNhanSu.cs`, `FormThemThuThu.cs`, `FormSuaThuThu.cs`.
     * Phân ca làm việc (`FormPhanCaTruc.cs` & `CaTrucBLL.cs`): Chặn xếp lịch ngày quá khứ, kiểm tra va chạm trùng ca tại chi nhánh, chặn thủ thư nhận 2 ca trùng giờ khác chi nhánh.
  3. **Quản trị Chi nhánh & Quy chế**:
     * Quản lý chi nhánh (`FormQuanLyChiNhanh.cs` & `ChiNhanhBLL.cs`): Tự sinh mã `CNx`, thêm chi nhánh mới.
     * Quy chế hệ thống (`FormQuyCheThamSo.cs` & `CauHinhHeThongBLL.cs`): Cấu hình 4 tham số động (`So_Sach_Muon_Toi_Da`, `So_Ngay_Muon_Toi_Da`, `Tien_Phat_Moi_Ngay`, `Thoi_Han_The_Thang`).
  4. **Dashboard Quản trị & Hệ thống Ghi vết Kiểm toán**:
     * `FormAdminDashboard.cs`: Menu Sidebar theo bảng màu `UITheme`, nạp dynamic form con, hiển thị thông tin phiên.
     * `FormThuThuDashboard.cs`: Bàn làm việc thủ thư, bảo vệ quyền truy cập, ghi log đăng xuất.
     * `FormTongQuanHeThong.cs`: Dashboard KPI lưu thông tuần, đối soát quỹ ca trực 7 ngày, quản lý kho sách theo chi nhánh.
     * Cơ chế Audit Kép `SystemLogger.cs`: Ghi đồng thời vào bảng `Nhat_Ky_He_Thong` và file log quay vòng theo ngày trong thư mục `Logs/`. Màn hình tra cứu `FormNhatKyHeThong.cs`.
  5. **Unit Test & Cơ sở dữ liệu**:
     * Soạn thảo và chuẩn hóa toàn bộ file kịch bản **`LibraryDB.sql`**.
     * Xây dựng bộ test **`AdminBusinessRuleTests.cs`** (26/26 tests passed: Verify chuẩn xác hash seed CSDL, Password strength, logic phân ca, ràng buộc tham số quy chế).
     * Thiết lập Branch Ruleset bảo vệ nhánh `main` trên GitHub.

---

### 3.2. THÀNH VIÊN 2: NGUYỄN VĂN A (CIRCULATION & PENALTIES)
* **Nhánh Git phụ trách**: `feature/circulation-and-penalties`
* **Tình trạng tiến độ**: **ĐANG PHÁT TRIỂN**
* **Phân hệ phụ trách**:
  1. **Bàn Lưu thông Quầy**:
     * Thiết kế giao diện `FormBanLuuThong.cs` (Gồm 2 Tab: Mượn Sách & Trả Sách).
     * Tìm kiếm độc giả qua ComboBox lọc tương đối (`AutoCompleteMode.SuggestAppend`).
     * Tự động kiểm tra điều kiện mượn: Thẻ độc giả còn hạn, không có sách quá hạn chưa trả, tổng số sách mượn chưa vượt quá tham số `So_Sach_Muon_Toi_Da` (lấy từ `CauHinhHeThongBLL`).
     * Lập phiếu mượn mới: Tự sinh mã `PM0xxx` (hoặc `BR0xxx`), trừ số lượng tồn kho khả dụng ($So\_Luong\_Kha\_Dung - 1$) và chuyển `Ban_Sao_Sach.Trang_Thai = N'Đang cho mượn'` qua `SqlTransaction`.
     * Tiếp nhận trả sách: So sánh `Ngay_Tra_Thuc_Te` với `Ngay_Hen_Tra`. Nếu quá hạn, tự động tính tiền phạt trễ hạn:
       $$\text{Tiền phạt} = (\text{Số ngày trễ}) \times \text{Tien\_Phat\_Moi\_Ngay}$$
     * Gia hạn thời gian mượn: Kiểm tra sách chưa từng gia hạn, chưa bị quá hạn, không có độc giả khác đặt trước.
  2. **Xử lý Vi phạm & Bồi thường**:
     * Giao diện `FormLapBienBanViPham.cs`: Lập biên bản sách bị hư hỏng hoặc làm mất (trừ vĩnh viễn $Tong\_So\_Luong$ và cập nhật trạng thái bản sao).
     * Thu tiền phạt, lưu vào bảng `Phieu_Phat`, cập nhật tiền mặt ca trực của thủ thư.
* **File code chính**: `PhieuMuonDTO.cs`, `PhatTienDTO.cs`, `PhieuMuonDAL.cs`, `PhieuMuonBLL.cs`, `FormBanLuuThong.cs`, `FormLapBienBanViPham.cs`.
* **Bài Test phụ trách**: `CirculationTests.cs` (Kiểm thử công thức tính tiền phạt trễ hạn, kiểm thử logic gia hạn mượn và ràng buộc số sách tối đa).

---

### 3.3. THÀNH VIÊN 3: NGUYỄN VĂN B (BOOK INVENTORY & READERS)
* **Nhánh Git phụ trách**: `feature/book-catalog-and-readers`
* **Tình trạng tiến độ**: **ĐANG PHÁT TRIỂN**
* **Phân hệ phụ trách**:
  1. **Quản lý Bạn đọc**:
     * Thiết kế giao diện `FormQuanLyDocGia.cs`.
     * Cấp mới thẻ độc giả, tự sinh mã định dạng `DG0xxx` (Ví dụ: `DG0001`, `DG0002`...).
     * Mặc định thời hạn thẻ là 4 năm tính từ ngày cấp (`DateTime.Today.AddYears(4)`).
     * Chức năng khóa thẻ tạm thời, mở khóa hoặc gia hạn thời hạn thẻ.
     * Cảnh báo vi phạm: Độc giả có $So\_Lan\_Vi\_Pham \ge 3$ phải được hiển thị nổi bật bằng màu đỏ để thủ thư nhận biết ngay lập tức.
  2. **Quản lý Kho Sách & Vị trí Kệ**:
     * Thiết kế giao diện `FormQuanLySach.cs`.
     * Thêm mới đầu sách, tự sinh mã `B0xxx` (Ví dụ: `B0101`, `B0102`...).
     * Phân bổ vị trí lưu trữ chuẩn hóa theo định dạng: Dãy - Kệ - Tầng (Ví dụ: `Kệ A1-01`, `Kệ B2-03`).
     * Cập nhật số lượng sách nhập kho, sửa thông tin sách, tìm kiếm đa tiêu chí (Mã sách, Tên sách, Tác giả, Thể loại).
     * Màn hình đối soát kiểm kê kho thực tế (Stocktaking): Kiểm tra tính toàn vẹn:
       $$Tong\_So\_Luong = So\_Luong\_Kha\_Dung + Dang\_Muon + Bao\_Tri$$
       Luôn đảm bảo điều kiện biên:
       $$0 \le So\_Luong\_Kha\_Dung \le Tong\_So\_Luong$$
     * Đề xuất xóa/thanh lý đầu sách gửi Admin duyệt.
* **File code chính**: `DocGiaDTO.cs`, `SachDTO.cs`, `DocGiaDAL.cs`, `SachDAL.cs`, `DocGiaBLL.cs`, `SachBLL.cs`, `FormQuanLySach.cs`, `FormQuanLyDocGia.cs`.
* **Bài Test phụ trách**: `BookInventoryTests.cs` (Kiểm thử hàm tự sinh mã `B0xxx`, kiểm thử ràng buộc $So\_Luong\_Kha\_Dung \le Tong\_So\_Luong$ và tính toàn vẹn số lượng nhập kho).

---

### 3.4. THÀNH VIÊN 4: NGUYỄN VĂN C (AUDIT, REPORTS & QA / TESTING)
* **Nhánh Git phụ trách**: `feature/reports-audit-and-testing`
* **Tình trạng tiến độ**: **ĐANG PHÁT TRIỂN**
* **Phân hệ phụ trách**:
  1. **Báo cáo Thống kê & Mở rộng Kiểm toán**:
     * Thiết kế giao diện `FormBaoCaoThongKe.cs` (kết hợp với `FormNhatKyHeThong.cs` đã được xây dựng sẵn bởi Trưởng nhóm).
     * Tận dụng `SystemLogger.cs` và `NhatKyHeThongBLL.cs` có sẵn để bổ sung các bộ lọc nâng cao.
     * Dashboard báo cáo chuyên sâu: Top 10 Sách Hot được mượn nhiều nhất, Doanh thu tiền phạt theo từng ca trực, Tỷ lệ quay vòng sách giữa các chi nhánh.
     * Xuất báo cáo ra định dạng file Excel / CSV (`.csv`).
  2. **Đảm bảo Chất lượng & Minh chứng Báo cáo**:
     * Quản lý bộ chạy Unit Test tập trung trong `Library.Tests`, đảm bảo toàn bộ test của 4 thành viên đều xanh (Pass).
     * Phụ trách chụp ảnh minh chứng kiểm thử và debug (lỗi Breakpoint, màn hình xanh của MSTest, đoạn code fix lỗi) phục vụ Chương 6 Báo cáo.
     * Tổng hợp và hoàn thiện cấu trúc Báo cáo 7 Chương theo đúng đề cương hướng dẫn của Thầy Đặng Thế Hân.
* **File code chính**: `BaoCaoDAL.cs`, `BaoCaoBLL.cs`, `FormBaoCaoThongKe.cs` (kế thừa `NhatKyHeThongDTO.cs`, `NhatKyHeThongDAL.cs`, `SystemLogger.cs`).
* **Bài Test phụ trách**: `AuditLogTests.cs` (Kiểm thử định dạng log timestamp, kiểm thử logic bộ lọc báo cáo thống kê và xuất file).

---

## 4. QUY CHUẨN CODE & BẢO MẬT BẮT BUỘC

### 4.1. Quy chuẩn Thao tác Cơ sở dữ liệu (DAL)
* **Chống SQL Injection**: Bắt buộc dùng `SqlParameter`. Tuyệt đối không dùng kỹ thuật ghép chuỗi:
  ```csharp
  // ĐÚNG:
  string query = "SELECT * FROM Sach WHERE Ma_Sach = @MaSach";
  SqlParameter[] pars = { new SqlParameter("@MaSach", maSach) };
  DataTable dt = DatabaseHelper.ExecuteQuery(query, pars);

  // SAI (NGHIÊM CẤM):
  // string query = "SELECT * FROM Sach WHERE Ma_Sach = '" + maSach + "'";
  ```
* **Bắt buộc dùng SqlTransaction khi sửa đổi nhiều bảng**:
  ```csharp
  using var conn = DatabaseHelper.GetConnection();
  conn.Open();
  using var trans = conn.BeginTransaction();
  try {
      // Thực thi các lệnh có cmd.Transaction = trans;
      trans.Commit();
  } catch {
      trans.Rollback();
      throw;
  }
  ```

### 4.2. Quy chuẩn Ghi vết Kiểm toán (`SystemLogger.cs`)
Bất kỳ nghiệp vụ tạo mới, cập nhật, xóa, cho mượn, trả sách hay xử lý vi phạm đều phải ghi log:
```csharp
SystemLogger.Log(
    LogLevel.INFO, // Hoặc WARNING, ERROR, SECURITY
    "Cho mượn sách",
    $"Thủ thư đã lập phiếu mượn PM0012 cho độc giả DG0003 (2 cuốn)",
    SessionContext.CurrentUser?.Ma_So
);
```

### 4.3. Quy chuẩn Giao diện (`UITheme.cs`)
Sử dụng các hằng số màu sắc từ `Library.UI.UITheme` để đồng bộ giao diện:
* Sidebar: `UITheme.SidebarBg` (`#0F172A`)
* Điểm nhấn / Nút chính: `UITheme.Primary` (`#0284C7`)
* Nền nội dung: `UITheme.ContentBg` (`#F8FAFC`)
* Nút Hủy / Xóa: `UITheme.Danger` (`#E11D48`)

---

## 5. QUY TRÌNH LÀM VIỆC VỚI GIT & GITHUB

### 5.1. Quy tắc làm việc trên nhánh
* **Tuyệt đối không push trực tiếp lên nhánh `main`** (Nhánh `main` đã được bật GitHub Ruleset bảo vệ).
* Mỗi thành viên chỉ làm việc trên đúng nhánh tính năng được phân công:
  * Thành viên 2: `feature/circulation-and-penalties`
  * Thành viên 3: `feature/book-catalog-and-readers`
  * Thành viên 4: `feature/reports-audit-and-testing`

### 5.2. Các bước cập nhật code hàng ngày
Trước khi bắt đầu viết code mỗi ngày, hãy kéo code mới nhất từ `main` về nhánh của mình:
```bash
git checkout main
git pull origin main
git checkout feature/<nhanh-cua-ban>
git merge main
```

### 5.3. Chuẩn hóa Commit Message (Conventional Commits)
* `feat(<module>)`: Thêm tính năng mới (Ví dụ: `feat(readers): add reader registration with 4-year expiry`)
* `fix(<module>)`: Sửa lỗi (Ví dụ: `fix(circulation): fix fine calculation for overdue days`)
* `test(<module>)`: Viết thêm unit test (Ví dụ: `test(catalog): add test for auto book code B0xxx`)

### 5.4. Quy trình Merge vào nhánh `main`
1. Đẩy code lên nhánh của mình: `git push origin feature/<nhanh-cua-ban>`.
2. Truy cập GitHub: `https://github.com/songhy2511/SmartLibrarySystem`.
3. Nhấn **Compare & pull request**.
4. Kiểm tra xem có bị xung đột (conflict) không. Nếu có xung đột, giải quyết trước khi merge.
5. Sau khi kiểm tra hoàn tất, nhấn **Merge pull request** $\rightarrow$ **Confirm merge**.