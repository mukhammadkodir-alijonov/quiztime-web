using QuizTime.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Admins
{
    public class PasswordUpdateDto
    {

        [Required(ErrorMessage = "Enter a password!")]
        [StrongPassword]
        public string OldPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a password!")]
        [StrongPassword]
        public string NewPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a password!")]
        [StrongPassword]
        public string VerifyPassword { get; set; } = string.Empty;
    }
}
