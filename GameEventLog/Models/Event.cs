using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameEventLog.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Situation { get; set; }
        
        [Required(ErrorMessage = "Specify what you're going to try.")]
        public string Effort { get; set; }

        //Roll will go here if we need it

        [Required(ErrorMessage = "Did it work?")]
        public bool Success { get; set; }

        [Required(ErrorMessage = "What was the result?")]
        public string Result { get; set; }

        //public DateTime DateAdded { get; set; } //App will set this for user

    }
}
