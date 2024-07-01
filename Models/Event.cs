using System;
using System.ComponentModel.DataAnnotations;

namespace VLMS.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }
    }
}
