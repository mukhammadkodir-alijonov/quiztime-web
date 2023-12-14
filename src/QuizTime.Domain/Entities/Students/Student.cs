using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Domain.Entities.Students
{
    public class Student : Person
    {
        public int TestCount { get; set; }
    }
}
