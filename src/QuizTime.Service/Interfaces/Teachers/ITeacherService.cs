using Microsoft.AspNetCore.Http;
using QuizTime.Service.Common.Utils;
using QuizTime.Service.Dtos.Teachers;
using QuizTime.Service.ViewModels.TeacherViewModels;

namespace QuizTime.Service.Interfaces.Teachers
{
    public interface ITeacherService
    {
        public Task<bool> ImageUpdateAsync(int id, IFormFile file);

        public Task<bool> ImageDeleteAsync(int id);

        public Task<List<string>>? GetFreeTimeAsync(int id, string time);
        public Task<int> GetTeachersCountAsync(string subject, PaginationParams @params);
        public Task<PagedList<TeacherViewDto>> GetTeachersBySubjectAsync(string subject, PaginationParams @params);
        public Task<TeacherRankViewModel> GetRankAsync(int id);
    }

}
