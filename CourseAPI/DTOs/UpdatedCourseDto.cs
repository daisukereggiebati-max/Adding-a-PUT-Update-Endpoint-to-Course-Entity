using System.ComponentModel.DataAnnotations;

namespace CourseAPI.DTOs
{
    public class UpdateCourseDto
    {
        [Required]
        public string CourseCode { get; set; } = string.Empty;

        [Required]
        public string CourseTitle { get; set; } = string.Empty;
    }
}