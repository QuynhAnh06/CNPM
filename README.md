<p align="center">
  <a href="https://hcmue.edu.vn/" title="Trường Đại học Sư Phạm TP.HCM" style="border: none;">
    <img src="./GUI/images/Logo_Trường_Đại_học_Sư_phạm_Thành_phố_Hồ_Chí_Minh.svg.png" alt="Trường Đại học Sư Phạm TP.HCM | Ho Chi Minh City University of Education">
  </a>
</p>

# Phần mềm Quản lý Thư viện

## Giới thiệu

- Đây là ứng dụng được sử dụng làm đồ án cuối kì cho môn Nhập môn Công nghệ phần mềm.
- Ứng dụng được xây dựng theo mô hình 3 lớp, sử dụng Entity Framework, cài đặt giao diện bằng C# Winforms.
- Thông tin chi tiết về project có thể tìm đọc trong file Report.docx

### Giảng viên hướng dẫn

- TS Trần Sơn Hải giảng viên khoa CNTT_Trường ĐHSP TP.HCM

### Sinh viên thực hiện

| **STT** | **MSSV**      |  **Họ và tên**        |
| ------- | ------------- | --------------------- |
|   1     | 49.01.103.004 | Nguyễn Thúy Quỳnh Anh |
|   2     | 49.01.103.009 | Lê Nguyễn Xuyến Chi   |
|   3     | 49.01.103.013 | Nguyễn Lâm Hoàng Dung |
|   4     | 49.01.103.016 | Đặng Ánh Dương        |
|   5     | 49.01.103.081 | Nguyễn Thị Cẩm Tiên   |
|   6     | 49.01.103.098 | Huỳnh Thị Ái Xuân     |

**-	Giới thiệu chức năng chính:**
Quản lý sách, quản lý độc giả qua việc quản lý cấp thẻ, quản lý việc cho độc giả mượn sách, việc nhận sách trả của độc giả, việc tìm kiếm sách của độc giả và thống kê báo cáo.

•	Quản lý trả sách làm nhiệm vụ quản lý việc trả sách của độc giả

•	Quản lý độc giả là chức năng quản lý việc cấp thẻ cho độc giả

•	Quản lý sách làm nhiệm vụ quản lý sách có tại thư viện

•	Quản lý mượn sách làm nhiệm vụ quản lý việc mượn sách của độc giả, công việc chính là lập phiếu mượn sách và cho mượn sách

•	Thống kê sách lấy thông tin từ hồ sơ quản lý sách, thống kê mượn trả sách bằng cách lấy các thông tin cần thiết từ phiếu mượn. Thống kê độc giả vi phạm từ hồ sơ xử lý vi phạm.

**-	Kiến trúc hệ thống**
[ GUI ] ⇄ [ BUS ] ⇄ [ DAL ] ⇄ [ Database ]
↑ ↑ ↑
Giao diện Logic Truy vấn SQL

-	Công nghệ sử dụng
Thành phần	         Công nghệ
Ngôn ngữ	        C# (.NET Framework)
Giao diện	         Windows Forms
Cơ sở dữ liệu	         SQL Server
Mô hình	        3 lớp (GUI – BUS – DAL)
IDE	                       Visual Studio 2022

**-	Cấu trúc thư mục chính**
📁 GUI
 ┣ 📂 Forms
 ┃ ┣ fLogin.cs
 ┃ ┣ fMain.cs
 ┃ ┗ fMainDG.cs
 ┣ 📂 UserControls
 ┃ ┣ ucTuaSach.cs
 ┃ ┣ ucSach.cs
 ┃ ┣ ucMuonTra.cs
 ┃ ┣ ucQLND.cs
 ┃ ┗ ucTraCuuSach.cs
 ┗ 📂 Properties
     ┗ Settings.settings

📁 BUS
 ┣ BUSNguoiDung.cs
 ┣ BUSSach.cs
 ┣ BUSMuonTra.cs
 ┗ BUSTuaSach.cs

📁 DAO
 ┣ DAONguoiDung.cs
 ┣ DAOSach.cs
 ┣ DAOMuonTra.cs
 ┗ DAOTuaSach.cs

📁 DTO
 ┣ NguoiDung.cs
 ┣ Sach.cs
 ┣ TuaSach.cs
 ┗ MuonTra.cs

📁 Database
 ┗ QLThuVien.sql  → Script tạo database & dữ liệu mẫu

**-	Phân lớp**
Thành phần	
_ Frontend:Giao diện người dùng (UI);  công nghệ sử dụng là C# WinForms (.NET Framework)	GUI/
- Backend: (BUS)	Xử lý logic, kiểm tra nghiệp vụ; công nghệ sử dụng là	C# Class Library	BUS/
- Backend:  (DAL)	Truy xuất dữ liệu từ SQL Server; công nghệ sử dụng làADO.NET, SQL Server	DAL/
- DTO: 	Truyền dữ liệu giữa các tầng; công nghệ sử dụng là	C# Class	DTO/

Bước 1: Khởi tạo database
•	Thực thi file QLTV.sql để khởi tạo database
Bước 2: Thực thi chương trình
•	Mở solution trong Visual Studio
•	Tải về bằng Nuget nếu VS không tự động tải: Entity Framework 6.4.4, Siticone UI/UX Framework
•	Debug
Release
•	Chương trình đã có bản release. Có thể download file installer về cài đặt và dùng thử
