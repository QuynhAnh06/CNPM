# 📚 YÊU CẦU PHẦN MỀM: HỆ THỐNG QUẢN LÝ THƯ VIỆN

## 1. 📋 Thông tin chung

### **Tên đề tài** 
Quản lý thư viện

### **Mục tiêu**
- [ ] Quản lý tập trung sách, tài liệu và độc giả
- [ ] Hỗ trợ mượn/trả sách nhanh chóng, chính xác
- [ ] Cung cấp công cụ thống kê, báo cáo giúp quản lý thư viện hiệu quả

### **Nền tảng** 
Website

### **Ngôn ngữ & Công nghệ**

#### 🎨 Frontend
- [ ] HTML5
- [ ] CSS3
- [ ] JavaScript
- [ ] Có thể dùng ASP.NET Razor Pages/ASP.NET MVC

#### ⚙️ Backend
- [ ] C# ASP.NET

#### 🗄️ Database
- [ ] SQL Server

---

## 2. 🎯 Phạm vi chức năng

### **📚 Quản lý Sách**
- Thêm, sửa, xóa, tìm kiếm sách
- Quản lý thông tin sách: ISBN, tiêu đề, tác giả, thể loại, năm xuất bản
- Theo dõi tình trạng sách (có sẵn, đang mượn, bảo trì)

### **👥 Quản lý Độc giả**
- Đăng ký, cập nhật thông tin độc giả
- Quản lý thẻ thư viện
- Theo dõi lịch sử mượn/trả

### **🔄 Quy trình Mượn/Trả**
- Xử lý mượn sách
- Xử lý trả sách
- Tính phí phạt quá hạn (nếu có)
- Gia hạn thời gian mượn

### **📊 Báo cáo & Thống kê**
- Thống kê sách mượn nhiều nhất
- Báo cáo tình hình mượn/trả
- Thống kê độc giả tích cực
- Báo cáo tồn kho sách

---

## 3. 🗄️ Cơ sở dữ liệu

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

## 5. 📱 Giao diện người dùng

### **🏠 Trang chủ**
- Tìm kiếm sách nhanh
- Sách mới nhất
- Thông báo quan trọng

### **⚙️ Trang quản lý**
- Dashboard tổng quan
- Quản lý danh mục
- Xử lý giao dịch

---


---

*Document last updated: $(date)*
