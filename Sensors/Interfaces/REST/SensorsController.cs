using Microsoft.AspNetCore.Mvc;

namespace IoT.Platform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllSensors()
        {
            return Ok(new { Message = "List of sensors will go here." });
        }

        [HttpPost]
        public IActionResult AddSensor()
        {
            return Ok(new { Message = "Sensor added successfully." });
        }
    }
}
