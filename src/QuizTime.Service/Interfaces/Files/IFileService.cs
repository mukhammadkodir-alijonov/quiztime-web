using Microsoft.AspNetCore.Http;

namespace QuizTime.Service.Interfaces.Files
{
    public interface IFileService
    {
        public Task<string> CreateFile(FileModeldto filemodel);
        public Task<bool> DeleteFileAsync(string path);

        public Task<string> UploadImageAsync(IFormFile image);
        public Task<bool> DeleteImageAsync(string imagePartPath);
    }
}
