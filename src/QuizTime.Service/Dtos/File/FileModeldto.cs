using Microsoft.AspNetCore.Http;
using QuizTime.Service.Common.Attributes;
using QuizTime.Service.Common.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Service.Dtos.File
{
    public class FileModeldto
    {
        [AllowedFiles(new string[] { ".xlsx" })]
        [Required]
        public IFormFile? File { get; set; }
        public PagedList<TeacherViewDto> Teachers { get; set; }
        public PagedList<StudentBaseViewModel> Students { get; set; }
        public List<TeacherViewDto> TeachersUnsaved { get; set; }
        public List<StudentViewModel> StudentsUnsaved { get; set; }
    }
}
