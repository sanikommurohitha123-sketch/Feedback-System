using System.ComponentModel.DataAnnotations;

namespace FeedbackSystemAPI.Models
{
    public class Feedback
    {
        public int Id{get; set;} 
        public int ConsultantId{ get; set;}
        public int GtmManagerId{ get; set;}
        [Range(1,5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set;}
        public string Comments {get; set;} 


        public DateTime CreateAt {get; set;}
        
    }
}