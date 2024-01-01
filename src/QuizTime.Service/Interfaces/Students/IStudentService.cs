using Microsoft.AspNetCore.Http;
using QuizTime.Service.Dtos.Accounts;
using QuizTime.Service.ViewModels.StudentBaseViewModel;

namespace QuizTime.Service.Interfaces.Students
{
    public interface IStudentService
    {
        public Task<bool> ImageUpdateAsync(int id, IFormFile file);

        public Task<int> GetLimitStudentAsync(int id);

        public Task<bool> DeleteImageAsync(int id);

        public Task<string> LoginAsync(AccountLoginDto accountLoginDto);

        public Task<StudentViewModel> GetByIdAsync(int id);

        public Task<StudentViewModel> GetByTokenAsync();
    }

}
