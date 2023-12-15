using QuizTime.Domain.Enums;

namespace QuizTime.Domain.Entities.Admins
{
    public class Admin : Person
    {
        public Role AdminRole { get; set; } = Role.admin;
    }
}
