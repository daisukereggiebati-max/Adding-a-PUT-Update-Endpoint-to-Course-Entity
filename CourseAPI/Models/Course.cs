namespace CourseAPI.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseCode { get; set; } = string.Empty;

        public string CourseTitle { get; set; } = string.Empty;
    }
}