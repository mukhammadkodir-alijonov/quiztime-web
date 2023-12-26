using QuizTime.Domain.Entities.Students;
using QuizTime.Service.Common.Helpers;
using QuizTime.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Service.Dtos.Students
{
    public class StudentRegisterDto : AccountRegisterDto
    {
        [Required(ErrorMessage = "Please select a subject.")]
        public string Subject { get; set; } = string.Empty;

        public static implicit operator Student(StudentRegisterDto studentRegisterDto)
        {
            return new Student()
            {
                FirstName = studentRegisterDto.FirstName,
                LastName = studentRegisterDto.LastName,
                PhoneNumber = studentRegisterDto.PhoneNumber,
                BirthDate = studentRegisterDto.BirthDate,
                CreatedAt = TimeHelper.GetCurrentServerTime(),
                LastUpdatedAt = TimeHelper.GetCurrentServerTime()
            };
        }

    }

}
