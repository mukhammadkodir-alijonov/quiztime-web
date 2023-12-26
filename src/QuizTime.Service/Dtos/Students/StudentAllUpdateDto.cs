using Microsoft.AspNetCore.Http;
using QuizTime.Domain.Entities.Students;
using QuizTime.Service.Common.Attributes;
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
    public class StudentAllUpdateDto : AccountRegisterDto
    {
        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" }), MaxFile(2)]
        public IFormFile? Image { get; set; }

        public string ImagePath { get; set; }

        public string Subject { get; set; } = String.Empty;

        public static implicit operator Student(StudentAllUpdateDto studentAllUpdateDto)
        {
            return new Student()
            {
                FirstName = studentAllUpdateDto.FirstName,
                LastName = studentAllUpdateDto.LastName,
                PhoneNumber = studentAllUpdateDto.PhoneNumber,
                BirthDate = studentAllUpdateDto.BirthDate,
                CreatedAt = TimeHelper.GetCurrentServerTime(),
                LastUpdatedAt = TimeHelper.GetCurrentServerTime(),
                Image = studentAllUpdateDto.Image?.ToString()
            };
        }
    }
}
