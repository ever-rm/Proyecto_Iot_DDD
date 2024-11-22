using Microsoft.AspNetCore.Mvc;

namespace IoT.Platform.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTransactions()
        {
            return Ok(new { Message = "List of transactions will go here." });
        }

        [HttpPost]
        public IActionResult AddTransaction()
        {
            return Ok(new { Message = "Transaction added successfully." });
        }
    }
}
