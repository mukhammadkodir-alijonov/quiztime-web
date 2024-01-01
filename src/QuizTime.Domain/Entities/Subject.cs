using QuizTime.Domain.Common;

namespace QuizTime.Domain.Entities
{
    public class Subject : Auditable
    {
        public string Name { get; set; } = String.Empty;
    }
}
