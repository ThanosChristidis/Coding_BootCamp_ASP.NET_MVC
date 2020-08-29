using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities
{
    [Table("ProjectStudent")]
    public class ProjectStudent
    {
        [Key, Column(Order = 0)]
        public int PersonId { get; set; }
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        [Key, Column(Order = 2)]
        public int ProjectId { get; set; }

        [Range(0, 101, ErrorMessage = "The grade must be between 0 and 100!"), RegularExpression("^[0-9]+$", ErrorMessage = "Please insert only numbers!!")]
        public int? ProjectGrade { get; set; }

        public DateTime EnrollmentDate { get; set; }


        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual Project Project { get; set; }
    }
}