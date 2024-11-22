using Microsoft.AspNetCore.Mvc;

namespace IoT.Platform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllNotifications()
        {
            return Ok(new { Message = "List of notifications will go here." });
        }

        [HttpPost]
        public IActionResult AddNotification()
        {
            return Ok(new { Message = "Notification added successfully." });
        }
    }
}
