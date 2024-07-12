using System.ComponentModel.DataAnnotations;

namespace BTBuoi4.Models
{
    public class Employee
    {   
        public int Id { get; set; }
        [Display(Name = "Mã Nhân viên")]
        [RegularExpression(@"[a-z]{6}", ErrorMessage = "Mã nhân viên phải có 6 ký tự")]
        public string EmplyeeNo { get; set; }
        [Display(Name = "Họ và tên")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên phải từ 5 đến 100 ký tự")]
        public string FullName { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]    
        public string ConfirmPassword { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [EnoughAgeForJob]
        public DateTime DateOfBirth { get; set; }
       [EmailAddress]
        public string? Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [RegularExpression("0[3789][0-9]{8}")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z 0-9]*")]
        public string? Address { get; set; }
        public bool Gender { get; set; }
        public string? Website { get; set; }
        [Display(Name = "Lương")]
        [Range(0, 10000000)]
        public double Salary { get; set; }
        public bool IsPartTime { get; set; }
        [Display(Name = "Thông tin thẻ")]
        [DataType(DataType.CreditCard)]
        public string? CreditCard { get; set; }
        [Display(Name = "Mô tả")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}
