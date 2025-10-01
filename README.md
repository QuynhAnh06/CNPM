#  YÊU CẦU PHẦN MỀM: HỆ THỐNG QUẢN LÝ THƯ VIỆN

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
- [ ] JavaScript
- [ ] Có thể dùng ASP.NET Razor Pages/ASP.NET MVC

#### Backend
- [ ] C# ASP.NET

####  Database
- [ ] SQL Server

---

## 2. Phạm vi chức năng

### ** Quản lý Sách**
- Thêm, sửa, xóa, tìm kiếm sách
- Quản lý thông tin sách: tên, tác giả, NXB, năm XB, thể loại, số lượng, vị trí lưu trữ.
- Phân loại theo danh mục (giáo trình, tham khảo, báo, tạp chí...).

### Quản lý Độc giả
- Thêm / Sửa / Xóa độc giả (họ tên, ngày sinh, email, số điện thoại, loại độc giả: sinh viên/giảng viên).
- Cấp tài khoản đăng nhập cho độc giả để tra cứu sách.
- Quản lý thẻ thư viện, ngày hết hạn.

### Quy trình Mượn/Trả
- Lập phiếu mượn sách: mã phiếu, mã độc giả, ngày mượn, ngày hẹn trả.
- Cập nhật trạng thái trả sách (đúng hạn, trễ hạn).
- Tính toán tiền phạt (nếu trả trễ).
- Giới hạn số sách mượn cùng lúc theo loại độc giả.


### Báo cáo & Thống kê
- Thống kê sách mượn nhiều nhất
- Báo cáo tình hình mượn/trả
- Thống kê độc giả tích cực
- Báo cáo tồn kho sách

---

## 3.  Cơ sở dữ liệu

### **Các bảng chính**
| Tên bảng | Mô tả |
|----------|--------|
| `Books` | Thông tin sách |
| `Readers` | Thông tin độc giả |
| `BorrowTransactions` | Giao dịch mượn/trả |
| `Categories` | Thể loại sách |
| `Authors` | Tác giả |
| `Publishers` | Nhà xuất bản |

---

## 4. 👥 Đối tượng sử dụng

| Đối tượng | Quyền hạn |
|-----------|-----------|
| **Quản trị viên** | Toàn quyền hệ thống |
| **Thủ thư** | Quản lý mượn/trả, độc giả |
| **Độc giả** | Tìm kiếm sách, xem lịch sử mượn |

---

## 5.  Giao diện người dùng

### ** Trang chủ**
- Tìm kiếm sách nhanh
- Sách mới nhất
- Thông báo quan trọng

### ** Trang quản lý**
- Dashboard tổng quan
- Quản lý danh mục
- Xử lý giao dịch

---


---

*Document last updated: $(date)*
