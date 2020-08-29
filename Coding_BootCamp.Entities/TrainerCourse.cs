using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities
{
    [Table("TrainerCourse")]
    public class TrainerCourse
    {
        [Key, Column(Order = 0)]
        public int PersonId { get; set; }
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }

        [Range(800, 3001, ErrorMessage = "The salary must be between 800 and 3000!")]
        public double? Salary { get; set; }

        public DateTime EnrollmentDate { get; set; }


        public virtual Course Course { get; set; }

        public virtual Trainer Trainer { get; set; }

    }
}
