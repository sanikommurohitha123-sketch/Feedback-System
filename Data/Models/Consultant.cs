namespace FeedbackSystemAPI.Models
{
    public class Consultant
    {
        public int Id {get; set;}
        public string Name { get; set;} 
        public string Country { get; set;}
        public int CuManagerId {get; set;}
    }
}