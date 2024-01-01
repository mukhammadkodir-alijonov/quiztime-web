using QuizTime.Domain.Common;
using QuizTime.Domain.Entities.Teachers;

namespace QuizTime.Service.Dtos.Teachers
{
    public class TeacherViewDto : BaseEntity
    {
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public string ImagePath { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public DateTime BirthDate { get; set; }

        public string Subject { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; }

        public FileModeldto? FileModel { get; set; }

        public static implicit operator TeacherViewDto(Teacher teacher)
        {
            return new TeacherViewDto()
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                ImagePath = teacher.Image!,
                PhoneNumber = teacher.PhoneNumber,
                BirthDate = teacher.BirthDate,
                Subject = teacher.Subject,
                CreatedAt = teacher.CreatedAt,
                Description = teacher.Description
            };
        }
    }
}
