using Microsoft.AspNetCore.Mvc;

namespace CampsStudentsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampsController : ControllerBase
    {
        private static List<string> camps = new List<string>();

        // GET: api/camps
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(camps);
        }

        // POST: api/camps
        [HttpPost]
        public IActionResult AddCamp([FromBody] string campName)
        {
            camps.Add(campName);
            return Ok($"Added camp: {campName}");
        }

        // DELETE: api/camps/{campName}
        [HttpDelete("{campName}")]
        public IActionResult DeleteCamp(string campName)
        {
            if (camps.Remove(campName))
                return Ok($"Deleted camp: {campName}");

            return NotFound($"Camp not found: {campName}");
        }
    }
}
