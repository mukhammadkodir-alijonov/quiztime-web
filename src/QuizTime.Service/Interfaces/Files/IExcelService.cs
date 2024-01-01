using QuizTime.Service.Dtos.Students;
using QuizTime.Service.Dtos.Teachers;

namespace QuizTime.Service.Interfaces.Files
{
    public interface IExcelService
    {
        public Task<List<StudentRegisterDto>> ReadStudentFileAsync(FileModeldto filemodel);
        public Task<List<TeacherRegisterDto>> ReadTeacherFileAsync(FileModeldto filemodel);
    }
}
