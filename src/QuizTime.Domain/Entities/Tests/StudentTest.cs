using QuizTime.Domain.Common;
using QuizTime.Domain.Entities.Students;
using QuizTime.Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
