# Nghiệp Vụ Người Dùng - Twicher App

## Tổng Quan
Twicher là một ứng dụng mạng xã hội cho phép người dùng chia sẻ, tương tác và kết nối với nhau. Dưới đây là các nghiệp vụ chính của người dùng.

---

## 1. Quản Lý Tài Khoản (Account Management)

### 1.1 Đăng Ký Tài Khoản (Registration)
**Mục đích:** Người dùng mới tạo tài khoản trên ứng dụng

**Yêu cầu:**
- Email hợp lệ
- Mật khẩu đạt yêu cầu bảo mật:
  - Tối thiểu 6 ký tự
  - Ít nhất 1 ký tự chữ hoa
  - Ít nhất 1 ký tự chữ thường
  - Ít nhất 1 ký tự đặc biệt (!@#$%^&*)
- Họ tên (First Name + Last Name)

**Quy trình:**
```
1. Nhập thông tin (Email, Mật khẩu, Họ tên)
2. Xác thực email
3. Tạo tài khoản
4. Tự động gán vai trò "User"
5. Đăng nhập & chuyển hướng tới trang chủ
```

### 1.2 Đăng Nhập (Login)
**Phương thức:**
- **Email + Mật khẩu** - Đăng nhập cơ bản
- **Google OAuth** - Đăng nhập qua Google
- **GitHub OAuth** - Đăng nhập qua GitHub

### 1.3 Cập Nhật Hồ Sơ (Profile Update)
**Có thể thay đổi:**
- Họ tên
- Ảnh đại diện (Profile Picture)
- Đường dẫn ảnh từ Facebook hoặc tải lên

### 1.4 Quản Lý Mật Khẩu (Password Management)
**Tùy chọn:**
- Thay đổi mật khẩu hiện tại
- Xác thực mật khẩu cũ trước khi thay đổi

---

## 2. Quản Lý Bài Viết (Post Management)

### 2.1 Tạo Bài Viết (Create Post)
**Thông tin có thể bao gồm:**
- Nội dung văn bản
- Hình ảnh (tùy chọn)
- Hashtags tự động phát hiện

**Quy trình:**
```
1. Người dùng nhập nội dung
2. Tùy chọn thêm hình ảnh
3. Nhấn "Đăng"
4. Hệ thống lưu bài viết
5. Bài viết xuất hiện trên timeline
```

**Trạng thái mặc định:**
- Công khai (Public)
- Người dùng có thể thay đổi thành Riêng tư (Private)

### 2.2 Xem Bài Viết (View Posts)
**Chi tiết được hiển thị:**
- Nội dung bài viết
- Hình ảnh (nếu có)
- Tên & ảnh đại diện người đăng
- Thời gian đăng (tương đối: 5m ago, 2h ago, 3d ago)
- Số lượt thích, bình luận, yêu thích
- Trạng thái riêng tư (nếu là bài của chính mình)

### 2.3 Chỉnh Sửa Quyền Riêng Tư (Toggle Post Visibility)
**Tùy chọn:**
- **Public:** Mọi người có thể xem
- **Private:** Chỉ chính người dùng xem được

**Giới hạn:**
- Chỉ chủ nhân bài viết mới có thể thay đổi

### 2.4 Xóa Bài Viết (Delete Post)
**Quy trình:**
```
1. Nhấn vào ba chấm (menu)
2. Chọn "Delete Post"
3. Xác nhận xóa
4. Bài viết bị xóa vĩnh viễn
5. Các like, comment, favorite được xóa
```

**Giới hạn:**
- Chỉ chủ nhân bài viết mới có thể xóa
- Không thể phục hồi sau khi xóa

### 2.5 Báo Cáo Bài Viết (Report Post)
**Lý do báo cáo:**
- Nội dung không phù hợp
- Spam
- Bạo lực
- Vi phạm bản quyền
- Nội dung không thích hợp khác

**Quy trình:**
```
1. Nhấn vào ba chấm (menu)
2. Chọn "Report"
3. Hệ thống ghi lại báo cáo
4. Admin sẽ xem xét
```

**Giới hạn:**
- Mỗi người dùng chỉ báo cáo 1 lần/bài viết
- Không thể báo cáo bài của chính mình

---

## 3. Tương Tác với Bài Viết (Post Interactions)

### 3.1 Thích Bài Viết (Like)
**Chức năng:**
```
1. Nhấn biểu tượng trái tim (♡)
2. Like được lưu
3. Biểu tượng chuyển đỏ (♥)
4. Số lượt thích tăng lên
```

**Giới hạn:**
- Mỗi người chỉ thích 1 lần
- Có thể bỏ thích bằng cách nhấn lại

### 3.2 Yêu Thích Bài Viết (Favorite/Bookmark)
**Chức năng:**
```
1. Nhấn biểu tượng bookmark (📑)
2. Bài viết được lưu vào danh sách yêu thích
3. Xem lại ở trang "Favorites"
```

**Sử dụng:**
- Lưu bài viết quan trọng
- Không ảnh hưởng đến chủ nhân bài

### 3.3 Bình Luận Bài Viết (Comment)
**Tính năng:**
- Thêm bình luận văn bản
- Xem 2 bình luận gần nhất mặc định
- Xem tất cả bình luận nếu cần

**Quy trình:**
```
1. Nhập nội dung bình luận
2. Nhấn "Gửi"
3. Bình luận xuất hiện ngay lập tức
4. Hiển thị tên, ảnh của người bình luận
5. Hiển thị thời gian bình luận
```

### 3.4 Xóa Bình Luận (Remove Comment)
**Quy trình:**
```
1. Chỉ chủ nhân bình luận mới có thể xóa
2. Nhấn "Xóa"
3. Bình luận bị xóa vĩnh viễn
```

---

## 4. Quản Lý Story (Story Management)

### 4.1 Tạo Story
**Đặc điểm:**
- Upload hình ảnh
- Hiển thị trong 24 giờ
- Kiểu Instagram Story

**Quy trình:**
```
1. Chọn hình ảnh
2. Nhấn "Đăng Story"
3. Story được lưu & hiển thị
4. Khác biệt với Post: tồn tại 24h
```

---

## 5. Tìm Kiếm & Khám Phá (Search & Discovery)

### 5.1 Tìm Kiếm Bài Viết
**Tìm kiếm theo:**
- Từ khóa trong nội dung
- Hashtag (#)
- Tên người dùng
- Nội dung bài viết

**Hiển thị kết quả:**
- Bài viết phù hợp
- Người dùng phù hợp
- Hashtag phù hợp

### 5.2 Xem Hồ Sơ Người Dùng (User Profile)
**Thông tin hiển thị:**
- Ảnh đại diện (Avatar)
- Họ tên
- Tên đăng nhập (Username)
- Các bài viết của người dùng
- Danh sách bạn bè (Friends)
- Số bạn bè

**Tính năng:**
- Click vào ảnh bài viết → Xem hồ sơ người đăng
- Xem toàn bộ bài viết của người dùng
- Theo dõi danh sách bạn bè

---

## 6. Thông Báo (Notifications)

### 6.1 Các Loại Thông Báo
```
1. Ai vừa thích bài của bạn
2. Ai vừa bình luận bài của bạn
3. Ai vừa yêu thích bài của bạn
4. Ai vừa theo dõi bạn
5. Bạn bè có bài viết mới
```

### 6.2 Quản Lý Thông Báo
- Xem danh sách thông báo (biểu tượng chuông 🔔)
- Đánh dấu đã đọc
- Xóa thông báo

---

## 7. Danh Sách Bạn Bè (Friends)

### 7.1 Quản Lý Danh Sách Bạn
**Tính năng:**
- Xem danh sách bạn bè (20+ bạn)
- Ảnh đại diện bạn bè
- Tên bạn bè
- Click để xem hồ sơ

### 7.2 Thêm/Xóa Bạn
**Thêm bạn:**
```
1. Truy cập hồ sơ người dùng
2. Nhấn "Add Friend"
3. Yêu cầu được gửi
```

**Xóa bạn:**
```
1. Truy cập danh sách bạn
2. Nhấn "Remove Friend"
3. Bạn được xóa khỏi danh sách
```

---

## 8. Cài Đặt Tài Khoản (Account Settings)

### 8.1 Cài Đặt Chung
**Có sẵn:**
```
- Thay đổi ảnh đại diện
- Cập nhật thông tin hồ sơ
- Thay đổi mật khẩu
- Quản lý quyền riêng tư
- Cài đặt thông báo
```

### 8.2 Quyền Riêng Tư
```
- Ai có thể xem hồ sơ
- Ai có thể bình luận bài viết
- Ai có thể gửi tin nhắn
- Ai có thể xem danh sách bạn bè
```

### 8.3 Đăng Xuất
```
1. Nhấn "Log Out"
2. Phiên đăng nhập kết thúc
3. Chuyển hướng về trang đăng nhập
```

---

## 9. Vai Trò & Quyền Hạn (Roles & Permissions)

### 9.1 Vai Trò User (Người Dùng Thường)
**Quyền:**
- Tạo, xem, chỉnh sửa, xóa bài viết riêng
- Thích, bình luận, yêu thích bài viết
- Tạo Story
- Xem hồ sơ người dùng khác
- Báo cáo bài viết không phù hợp

**Hạn chế:**
- Không thể quản lý người dùng khác
- Không thể xóa bài viết của người khác
- Không thể chỉnh sửa hồ sơ người khác

### 9.2 Vai Trò Admin
**Quyền:**
- Tất cả quyền của User
- Quản lý báo cáo bài viết
- Xóa bài viết vi phạm
- Khóa/mở khóa tài khoản
- Xem thống kê hoạt động

---

## 10. Quy Tắc Kinh Doanh (Business Rules)

### 10.1 Hạn Chế Nội Dung
```
❌ Cấm:
- Nội dung bạo lực, khiêu dâm
- Spam, lừa đảo
- Bình luận chứa từ ngữ tục tĩu
- Vi phạm bản quyền
- Nội dung gây hại

✅ Cho phép:
- Chia sẻ tin tức, ý kiến
- Ảnh/video cá nhân
- Mục đích quảng cáo hợp pháp
```

### 10.2 Hạn Chế Tương Tác
```
- Tối đa 1 like/bài của 1 người
- Tối đa 1 favorite/bài của 1 người
- Tối đa 1 report/bài của 1 người
- Không bình luận vào bài private
- Không thấy bài private của người khác
```

### 10.3 Thời Gian & Dữ Liệu
```
- Story tồn tại 24 giờ, sau đó xóa tự động
- Bài viết tồn tại vĩnh viễn (trừ khi xóa)
- Dữ liệu được lưu trên SQL Server
- Ảnh được lưu trên máy chủ
```

---

## 11. Quy Trình Điển Hình (Typical User Workflow)

### Ngày Thứ Nhất: Đăng Ký & Cài Đặt
```
1. Truy cập trang đăng ký
2. Nhập Email, Mật khẩu, Họ tên
3. Xác thực email
4. Truy cập cài đặt tài khoản
5. Tải lên ảnh đại diện
6. Chỉnh sửa thông tin hồ sơ
```

### Ngày Thứ Hai: Chia Sẻ & Tương Tác
```
1. Đăng nhập
2. Xem timeline (bài viết người khác)
3. Tạo bài viết mới
4. Thích & bình luận bài của người khác
5. Xem hồ sơ bạn bè
6. Thêm bạn mới
7. Xem thông báo
8. Đăng xuất
```

---

## 12. Chỉ Số Hiệu Suất (KPI)

**Theo dõi:**
- Số người dùng hoạt động
- Số bài viết/ ngày
- Số lượt tương tác (like, comment, favorite)
- Tỷ lệ giữ chân người dùng
- Số báo cáo & nội dung bị xóa

---

Tài liệu này mô tả toàn bộ nghiệp vụ và quy tắc kinh doanh cho nền tảng Twicher.
