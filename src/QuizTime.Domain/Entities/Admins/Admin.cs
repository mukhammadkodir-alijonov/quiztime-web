using QuizTime.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Domain.Entities.Admins
{
    public class Admin : Person
    {
        public Role AdminRole { get; set; } = Role.admin;
    }
}
