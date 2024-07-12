
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace BTBuoi4.Models
{
    internal class EnoughAgeForJobAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var dateOfBirth = (DateTime?)value;
            if (dateOfBirth.HasValue)
            {
                if (dateOfBirth.Value.AddYears(16) > DateTime.Now)
                {
                    return new ValidationResult("Tuổi phải lớn hơn hoặc bằng 16");
                }
                if (dateOfBirth.Value.AddYears(65) < DateTime.Now)
                {
                    return new ValidationResult("Tuổi phải nhỏ hơn hoặc bằng 65");
                }
            }

            return ValidationResult.Success;
        }
    }
}