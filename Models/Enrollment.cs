using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLMS.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }

        [Range(0, 4)]
        public int? Grade { get; set; }
    }
}
