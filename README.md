# QUẢN LÝ DỰ ÁN

- [Nhấn vào link sau ](https://trello.com/invite/b/68d2d18659674a93d647ec73/ATTId9a5c96829b12125f603539d5fd045561F317549/dự-an-website-quản-ly-thư-viện) để có thể theo dõi tiến trình làm việc qua các tuần

#  PHẦN MỀM: HỆ THỐNG QUẢN LÝ THƯ VIỆN
## Giới thiệu

* Đây là ứng dụng được sử dụng làm đồ án cuối kì cho môn Nhập môn Công nghệ phần mềm.
* Ứng dụng được xây dựng theo mô hình 3 lớp, sử dụng Entity Framework, cài đặt giao diện bằng C# Winforms.
* Thông tin chi tiết về project có thể tìm đọc trong file Report.docx

### Giảng viên hướng dẫn

* ThS. Lê Thanh Thoại - Khoa Công Nghệ Thông Tin, Trường ĐH Sư Phạm TPHCM

### Sinh viên thực hiện

|**STT**|**MSSV**|  **Họ và tên**  |       **Email**      |
|-------|-------------|---------------------|-------------------------|
|   1   |49.01.103.004|Nguyễn Thúy Quỳnh Anh|4901103004@student.edu.vn|
|   2   |             |                     |                         |
|   3   |             |                     |                         |

## Chạy thử project

### Yêu cầu để thực thi project

* Visual Studio 2022
* .NET Framework 4.7.2
* Entity Framework 6.4.4
* SQL Server
* Siticone UI/UX Framework

### Bước 1: Khởi tạo database

* Thực thi file QLTV.sql để khởi tạo database

### Bước 2: Thực thi chương trình

* Mở solution trong Visual Studio
* Tải về bằng Nuget nếu VS không tự động tải: Entity Framework 6.4.4, Siticone UI/UX Framework
* Debug

## Release

* Chương trình đã có bản release. Có thể download file installer về cài đặt và dùng thử


## 1. Thông tin chung

### Tên đề tài 
Quản lý thư viện

### **Mục tiêu**
- [ ] Quản lý tập trung sách, tài liệu và độc giả
- [ ] Hỗ trợ mượn/trả sách nhanh chóng, chính xác
- [ ] Cung cấp công cụ thống kê, báo cáo giúp quản lý thư viện hiệu quả

### **Nền tảng** 
Website

### **Ngôn ngữ & Công nghệ**

#### Frontend
- [ ] HTML5
- [ ] CSS3
- [ ] JavaScript ( Có thể dùng ASP.NET Razor Pages/ASP.NET MVC )

#### Backend
- [ ] C# .Net Winforms

####  Database
- [ ] SQL Server

---

## 2. Yêu cầu chức năng ( Functional Requirements )

### 2.1. Quản lý Sách & Tài liệu
- Thêm / Sửa / Xóa sách, tài liệu.
- Quản lý thông tin sách: tên, tác giả, NXB, năm XB, thể loại, số lượng, vị trí lưu trữ.
- Phân loại theo danh mục (giáo trình, tham khảo, báo, tạp chí...).

### 2.2. Quản lý Độc giả
- Thêm / Sửa / Xóa độc giả (họ tên, ngày sinh, email, số điện thoại, loại độc giả: sinh viên/giảng viên).
- Cấp tài khoản đăng nhập cho độc giả để tra cứu sách.
- Quản lý thẻ thư viện, ngày hết hạn.

### 2.3. Quản lý mươn / trả sách
- Lập phiếu mượn sách: mã phiếu, mã độc giả, ngày mượn, ngày hẹn trả.
- Cập nhật trạng thái trả sách (đúng hạn, trễ hạn).
- Tính toán tiền phạt (nếu trả trễ).
- Giới hạn số sách mượn cùng lúc theo loại độc giả.

### 2.4. Tìm kím sách
- Tìm kím theo **tên, tác giả, thể loại, năm XB**
- Hiển thị tình trạng sách ( còn / đã mượn )


### 2.5.Quản lý thống kê & báo cáo
- Thống kê số lượng sách còn, sách đang được mượn.
- Thống kê độc giả mượn nhiều nhất, sách được mượn nhiều nhất.
- Báo cáo theo tháng/quý/năm (số lượt mượn, trả, vi phạm trễ hạn).


### 2.6. Quản trị hệ thống
- Quản lý tài khoản admin / thủ thư.
- Phân quyền: admin (toàn quyền), thủ thư (quản lý mượn trả, thống kê), độc giả (tra cứu).


---

## 3.  Yêu cầu phi chức năng (Non-functional Requirements)

- **Hiệu năng:** xử lý thao tác tìm kiếm/mượn sách trong < 2 giây.
- **Bảo mật:** mật khẩu hash, phân quyền người dùng.
- **Khả năng:** mở rộng: dễ bổ sung module (ví dụ: quản lý sách điện tử eBook).
- **Khả năng:** sử dụng (Usability): giao diện thân thiện, dễ sử dụng với thủ thư và độc giả.
- **Triển khai:** chạy trên trình duyệt, hỗ trợ cả desktop & mobile (responsive).

---

## 4. Ràng buộc kỹ thuật

- Backend: ASP.NET (MVC hoặc WebForms) với C#.
- Frontend: HTML5, CSS3, JavaScript.
- Database: SQL Server (tối thiểu 5 bảng: Sach, DocGia, PhieuMuon, ChiTietPhieuMuon, TaiKhoan).
- ORM (khuyến khích): Entity Framework.
- Quản lý source code: GitHub/GitLab.

---

## 5. Deliverables (Kết quả yêu cầu nộp)

1. **Tài liệu yêu cầu (SRS).**
2. **Thiết kế CSDL:** ERD + script SQL Server.
3. **Thiết kế UI:** mockup giao diện (quản lý sách, mượn trả, thống kê).
4. **Source code:** ASP.NET (C#) + SQL Server.
5. **API Documentation (nếu dùng Web API).
6. **Tài liệu kiểm thử:** test case, bug report.
7. **Tài liệu hướng dẫn sử dụng & cài đặt.**
8. **Báo cáo cuối kỳ + Demo hệ thống.**

