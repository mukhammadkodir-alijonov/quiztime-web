using QuizTime.Domain.Entities;

namespace QuizTime.Service.Interfaces.Common
{
    public interface IAuthService
    {
        public string GenerateToken(Person person, string role);
    }
}
