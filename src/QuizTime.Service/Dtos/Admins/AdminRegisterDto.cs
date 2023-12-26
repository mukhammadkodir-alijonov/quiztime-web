using QuizTime.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Service.Dtos.Admins
{
    public class AdminRegisterDto : AccountRegisterDto
    {
        [Required(ErrorMessage = "Please enter the address of the admin.")]
        public string Address { get; set; } = string.Empty;
    }
}
