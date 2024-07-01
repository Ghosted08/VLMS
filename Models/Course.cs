using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLMS.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public Department Department { get; set; }
    }
}
