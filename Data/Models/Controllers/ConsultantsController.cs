using Microsoft.AspNetCore.Mvc;
using FeedbackSystemAPI.Data;

namespace FeedbackSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultantsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ConsultantsController (AppDbContext context)
        {
            _context=context;

        }
        [HttpGet]
        public IActionResult GetConsultants()
        {
            return Ok(_context.Consultants.ToList());
        }
        
    }
}