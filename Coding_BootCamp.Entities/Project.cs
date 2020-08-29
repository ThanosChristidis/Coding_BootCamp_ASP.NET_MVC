using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities
{
    [Table("Project")]
    public class Project
    {
        public int ProjectId { get; set; }

        [Required, RegularExpression("^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$")]
        public string Title { get; set; }

        [Display(Name = "Lesson Description")]
        public string Description { get; set; }

        [Display(Name = "Submission Day")]
        public DateTime SubDate { get; set; }

        [Display(Name = "Image"), DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }


        public virtual ICollection<ProjectStudent> ProjectStudents { get; set; }
    }
}
