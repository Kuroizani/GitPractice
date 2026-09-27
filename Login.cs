using System;

namespace StudentManagement
{
    public class Login
    {
        public bool AuthenticateUser(string username, string password)
        {
            Console.WriteLine("Đang kiểm tra thông tin đăng nhập...");
            
            if(username == "admin" && password == "123456")
            {
                Console.WriteLine("Đăng nhập thành công!");
                return true;
            }
            
            Console.WriteLine("Sai tài khoản hoặc mật khẩu.");
            return false;
        }
    }
}