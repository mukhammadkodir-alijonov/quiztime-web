using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Tests
{
    public class StudentTestDto
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string CorrectAnswerCount { get; set; } = String.Empty;
    }
}
