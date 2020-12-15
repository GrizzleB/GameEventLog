using System.ComponentModel.DataAnnotations;

namespace GameEventLog.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Situation { get; set; }
        
        [Required(ErrorMessage = "What was your action?")]
        public string Effort { get; set; }

        //Roll will go here if we need it

        [Required]//Bool is always valid so no ErrorMessage needed
        public bool Success { get; set; }

        [Required(ErrorMessage = "What was the result?")]
        public string Result { get; set; }
    }
}
