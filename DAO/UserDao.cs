using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San_2024.DAO
{
    internal class UserDao
    {
        private static UserDao instance;
        public static UserDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDao();
                }
                return instance;
            }
        }

        public User LoggedInUser { get; private set; }

        public bool LoginUser(string username, string password)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Passwords == password);

                if (user != null)
                {
                    LoggedInUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool RegisterUser(string username, string password, string type)
        {
            using (var db = new DeTai_5_DuLichEntities())
            {
                // Kiểm tra xem username đã tồn tại trong cơ sở dữ liệu chưa
                var existingUser = db.Users.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    // Username đã tồn tại, không thể đăng ký
                    return false;
                }

                try
                {
                    // Tạo một đối tượng User mới
                    var newUser = new User
                    {
                        Username = username,
                        Passwords = password, // Lưu ý: Trong thực tế, nên mã hóa mật khẩu trước khi lưu vào cơ sở dữ liệu
                        UserType = type,
                    };

                    // Thêm người dùng mới vào cơ sở dữ liệu
                    db.Users.Add(newUser);
                    db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    return true; // Đăng ký thành công
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    return false;
                }
            }
        }

    }
}
