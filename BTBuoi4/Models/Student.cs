using System.ComponentModel.DataAnnotations;

namespace BTBuoi4.Models
{
    public class Student
    {
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Có nhập vào hay không thì bảo")]
        [MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự nhooo")]
        public string FullName { get; set; }
        [Display(Name = "Tuổi")]
        [Required(ErrorMessage = "Có nhập vào hay không thì bảo")]
        [Range(16, 65, ErrorMessage = "Tuổi phải từ 16 đến 65")]
        public int Age { get; set; }
    }
}
