using QuizTime.Domain.Common;
using QuizTime.Domain.Entities.Students;

namespace QuizTime.Domain.Entities.Tests
{
    public class StudentTest : Auditable
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CorrectAnswerCount { get; set; } = String.Empty;

        public int TestId { get; set; }
        public virtual Test Test { get; set; } = default!;

        public int StudentId { get; set; }
        public virtual Student Student { get; set; } = default!;
    }
}
