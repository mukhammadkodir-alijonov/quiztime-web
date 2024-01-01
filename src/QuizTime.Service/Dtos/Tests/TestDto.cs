using System.ComponentModel.DataAnnotations;

namespace QuizTime.Service.Dtos.Tests
{
    public class TestDto
    {
        [Required]
        public string TestName { get; set; } = String.Empty;
        [Required]
        public string FilePath { get; set; } = String.Empty;
        [Required]
        public string Description { get; set; } = String.Empty;
        [Required]
        public string SpendingTime { get; set; } = String.Empty;

        [Required]
        public int TeacherId { get; set; }
    }
}
