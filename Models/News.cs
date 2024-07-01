using System;
using System.ComponentModel.DataAnnotations;

namespace VLMS.Models
{
    public class News
    {
        public int NewsID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
