﻿using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Accounts
{
    public class AccountRegisterDto : AccountLoginDto
    {
        [Required(ErrorMessage = "Enter a name!")]
        public string FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Enter a surname!")]
        public string LastName { get; set; } = String.Empty;

        public DateTime BirthDate { get; set; }
    }
}
