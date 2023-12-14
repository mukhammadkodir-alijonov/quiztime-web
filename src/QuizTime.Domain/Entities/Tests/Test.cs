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
    public class Test : Auditable
    {
        public string TestName { get; set; } = String.Empty;
        public string FilePath { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string SpendingTime { get; set; } = String.Empty;

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; } = default!;
    }
}
