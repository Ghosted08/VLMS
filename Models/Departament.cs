using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VLMS.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
