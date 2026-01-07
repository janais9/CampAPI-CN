using Microsoft.AspNetCore.Mvc;

namespace CampsStudentsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<string> students = new List<string>();

        // GET: api/students
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        // POST: api/students
        [HttpPost]
        public IActionResult AddStudent([FromBody] string studentName)
        {
            students.Add(studentName);
            return Ok($"Added student: {studentName}");
        }

        // DELETE: api/students/{studentName}
        [HttpDelete("{studentName}")]
        public IActionResult DeleteStudent(string studentName)
        {
            if (students.Remove(studentName))
                return Ok($"Deleted student: {studentName}");

            return NotFound($"Student not found: {studentName}");
        }
    }
}
