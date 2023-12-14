using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Domain.Entities.Teachers
{
    public class Teacher : Person
    {
        public string Description { get; set; } = String.Empty;
        public string Subject { get; set; } = String.Empty;
    }
}
