using Microsoft.AspNetCore.Mvc;

namespace IoT.Platform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevicesController : ControllerBase
    {
        // GET: api/devices
        [HttpGet]
        public IActionResult GetAllDevices()
        {
            return Ok(new { Message = "List of devices will go here." });
        }

        // POST: api/devices
        [HttpPost]
        public IActionResult AddDevice()
        {
            return Ok(new { Message = "Device added successfully." });
        }
    }
}
