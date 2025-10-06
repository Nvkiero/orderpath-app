# User Management App (Exercise 2.2)

## Thành viên nhóm
- 24520507 Nguyễn Trọng Hiếu  
- 24520506 Nguyễn Minh Hiếu  
- 24522048 Đoàn Lê Xuân Vương  
- 24522022 Nguyễn Tiến Vĩnh  
- 24520535 Huỳnh Như Hoàng  

## Mô tả
Ứng dụng quản lý người dùng cho phép:
1. Đăng ký và đăng nhập bằng C# WinForms + SQL Server
2. Lưu trữ thông tin người dùng trong cơ sở dữ liệu
3. Mã hóa mật khẩu bằng SHA-256
4. Có giao diện thân thiện, kiểm tra dữ liệu đầu vào và xử lý lỗi

## Hướng dẫn cài đặt
1. Clone repo về máy: 
2. Mở file `UserManagementApp.sln` trong Visual Studio 
3. Mở file database.sql trong SQL Server Management Studio và chạy để tạo cơ sở dữ liệu và bảng Users 
4. Cập nhật chuỗi kết nối trong `DatabaseHelper.cs` nếu cần thiết
5. Chạy ứng dụng: Ctrl + F5

## Sử dụng
- Đăng ký tài khoản mới
	+ Mở ứng dụng và chọn "Register"
	+ Nhập username, date, delivery address, country, password confirm password và human captcha
	+ Nhấn Register để lưu tài khoản mới: Ứng dụng kiểm tra trùng username và hợp lệ dữ liệu
- Đăng nhập bằng tài khoản đã tạo  
	+ Mở ứng dụng và chọn "Login"
	+ Nhập username và password
	+ enter để đăng nhập: Ứng dụng kiểm tra thông tin và hiển thị thông báo

## Giao diện
*(Chèn ảnh Form Login & Register ở đây)*

