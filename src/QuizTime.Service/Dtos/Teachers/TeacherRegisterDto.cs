using QuizTime.Domain.Entities.Teachers;
using QuizTime.Service.Common.Helpers;
using QuizTime.Service.Dtos.Accounts;
using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Teachers
{
    public class TeacherRegisterDto : AccountRegisterDto
    {
        [Required(ErrorMessage = "Please enter the subject of the teacher!")]
        public string Subject { get; set; } = String.Empty;

        public static implicit operator Teacher(TeacherRegisterDto teacherRegisterDto)
        {
            return new Teacher()
            {
                FirstName = teacherRegisterDto.FirstName,
                LastName = teacherRegisterDto.LastName,
                PhoneNumber = teacherRegisterDto.PhoneNumber,
                CreatedAt = TimeHelper.GetCurrentServerTime(),
                LastUpdatedAt = TimeHelper.GetCurrentServerTime(),
                Subject = teacherRegisterDto.Subject,
                BirthDate = teacherRegisterDto.BirthDate
            };
        }
    }

}
