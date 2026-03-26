using Microsoft.AspNetCore.Mvc;
using FeedbackSystemAPI.Data;
using FeedbackSystemAPI.Models;

namespace FeedbackSystemAPI.Controllers{
    
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly AppDbContext _context;
        public FeedbackController(AppDbContext context)
        {
            _context=context;
        }

        [HttpPost]
        public IActionResult SubmitFeedback(Feedback feedback)
        {
            feedback.CreateAt=DateTime.Now;
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();

            return Ok("Feedback submitted");
        }
        [HttpGet]
        public IActionResult GetAllFeedback()
        {
            return Ok(_context.Feedbacks.ToList());
        }

        [HttpGet("cu/{cuManagerId}")]
        public IActionResult GetFeedbackForCU(int cuManagerId)
        {
            var consultantIds=_context.Consultants
                
                .Where( c=> c.CuManagerId == cuManagerId) 
                .Select(c => c.Id)
                .ToList();
            var feedbacks = _context.Feedbacks
                .Where(f => consultantIds.Contains(f.ConsultantId))
                .ToList();
            
            return Ok(feedbacks);
                
        }
    }
}