using QuizTime.Domain.Entities.Teachers;

namespace QuizTime.Service.ViewModels.TeacherViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; } = default!;

        public DateTime CreatedAt { get; set; } = default!;

        public static implicit operator TeacherViewModel(Teacher teacher)
        {
            return new TeacherViewModel
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Description = teacher.Description,
                ImagePath = teacher.Image!,
                PhoneNumber = teacher.PhoneNumber,
                BirthDate = teacher.BirthDate,
                CreatedAt = teacher.CreatedAt
            };
        }
    }
}
