using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities
{
    [Table("StudentCourse")]
    public class StudentCourse
    {
        [Key, Column(Order = 0)]
        public int PersonId { get; set; }
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }

        [Range(0, 101, ErrorMessage = "The grade must be between 0 and 100!"), RegularExpression("^[0-9]+$", ErrorMessage = "Please insert only integers!!")]
        public int? CourseGrade { get; set; }

        [Range(1500, 3501, ErrorMessage = "The fees must be between 1500  and 3500!")]
        public double? TuittionFees { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

