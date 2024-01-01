using Microsoft.AspNetCore.Http;
using QuizTime.Service.Common.Attributes;
using QuizTime.Service.Common.Utils;
using QuizTime.Service.Dtos.Teachers;
using QuizTime.Service.ViewModels.StudentBaseViewModel;
using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.File
{
    public class FileModelDto
    {
        [AllowedFiles(new string[] { ".xlsx" })]
        [Required]
        public IFormFile? File { get; set; }
        public PagedList<TeacherViewDto> Teachers { get; set; }
        public PagedList<StudentBaseViewModel> Students { get; set; }
        public List<StudentViewModel> StudentsUnsaved { get; set; }
        public List<TeacherViewDto> TeachersUnsaved { get; set; }
    }
}
