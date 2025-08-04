using Microsoft.AspNetCore.Mvc;

namespace PracticalDotNetInterviewGuide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Sample")]
        public async Task<IActionResult> Sample()
        {
            return Ok();
        }
    }
}
