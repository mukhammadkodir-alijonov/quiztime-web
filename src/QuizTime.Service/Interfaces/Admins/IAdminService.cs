using Microsoft.AspNetCore.Http;
using QuizTime.Service.Dtos.Admins;
using QuizTime.Service.ViewModels.AdminViewModels;

namespace QuizTime.Service.Interfaces.Admins
{
    public interface IAdminService
    {
        public Task<AdminViewModel> GetByPhoneNumberAsync(string phoneNumber);

        public Task<List<AdminViewModel>> GetAllAsync(string search);

        public Task<List<AdminViewModel>> GetAllAsync();

        public Task<AdminViewModel> GetByIdAsync(int id);

        public Task<bool> UpdateAsync(int id, AdminUpdateDto adminUpdatedDto);

        public Task<bool> UpdateImageAsync(int id, IFormFile formFile);

        public Task<bool> DeleteAsync(int id);

        public Task<bool> DeleteImageAsync(int adminId);

        public Task<bool> UpdatePasswordAsync(int id, PasswordUpdateDto dto);
    }
}
