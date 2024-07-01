using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VLMS.Models
{
    public class Group
    {
        public int GroupID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
