using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities
{
    [Table("Trainer")]
    public class Trainer : Person
    {
        [Required, RegularExpression("^[0-9A-Za-z ]+$", ErrorMessage = "Please insert only letters and spaces!")]
        public string Subject { get; set; }

        public virtual ICollection<TrainerCourse> TrainerCourses { get; set; }
    }
}