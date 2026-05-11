using Microsoft.AspNetCore.Mvc;
using CourseAPI.Models;
using CourseAPI.DTOs;

namespace CourseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        // Temporary in-memory data
        private static List<Course> courses = new List<Course>
        {
            new Course
            {
                Id = 1,
                CourseCode = "IT101",
                CourseTitle = "Introduction to IT"
            }
        };

        // PUT: api/Courses/1
        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, UpdateCourseDto updatedCourse)
        {
            // Validate input
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Find course
            var course = courses.FirstOrDefault(c => c.Id == id);

            // If course does not exist
            if (course == null)
            {
                return NotFound($"Course with Id {id} not found.");
            }

            // Update values
            course.CourseCode = updatedCourse.CourseCode;
            course.CourseTitle = updatedCourse.CourseTitle;

            // Return updated course
            return Ok(course);
        }
    }
}