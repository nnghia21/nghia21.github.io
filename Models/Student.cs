namespace MyWebApp.Models
{
    public class Student
    {
        public int Id { get; set; } //Mã sv
        public string? Name { get; set; } //Họ tên
        public string? Email { get; set; } //email
        public string? Password { get; set; } //Mật khẩu
        public Branch? Branch { get; set; } // ngành học
        public Gender? Gender { get; set; } //Giới tính
        public bool IsRegular { get; set; } //hệ: true - chính quy; false- phi chính quy
        public string? Address {get; set; } // địa chỉ
        public DateTime DateOfBirth { get; set; }// ngày sinh

    }
}
