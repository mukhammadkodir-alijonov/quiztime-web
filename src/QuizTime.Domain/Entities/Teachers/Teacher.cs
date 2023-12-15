namespace QuizTime.Domain.Entities.Teachers
{
    public class Teacher : Person
    {
        public string Description { get; set; } = String.Empty;
        public string Subject { get; set; } = String.Empty;
    }
}
