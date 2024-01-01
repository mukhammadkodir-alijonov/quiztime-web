using QuizTime.Domain.Entities;

namespace QuizTime.Service.ViewModels.StudentBaseViewModel
{
    public class StudentViewModel : StudentBaseViewModel
    {
        public Subject? Subject { get; set; }
        public byte WeeklyLimit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
