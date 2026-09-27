using System;

namespace StudentManagement
{
    public class Profile
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public void DisplayProfile()
        {
            Console.WriteLine("--- Thông tin hồ sơ sinh viên ---");
            Console.WriteLine($"MSSV: {StudentId}");
            Console.WriteLine($"Họ tên: {FullName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}