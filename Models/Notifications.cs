using System;
using System.ComponentModel.DataAnnotations;

namespace VLMS.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
