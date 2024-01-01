using QuizTime.Service.Dtos.Accounts;
using QuizTime.Service.Dtos.Admins;

namespace QuizTime.Service.Interfaces.Accounts
{
    public interface IAccountService
    {
        public Task<bool> AdminRegisterAsync(AdminRegisterDto adminRegisterDto);
        public Task<string> LoginAsync(AccountLoginDto accountLoginDto);
    }
}
