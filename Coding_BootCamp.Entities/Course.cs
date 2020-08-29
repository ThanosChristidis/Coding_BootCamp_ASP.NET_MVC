using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Coding_BootCamp.Entities.Custom_Validations;

namespace Coding_BootCamp.Entities
{
    [Table("Course")]
    public class Course
    {
        public int CourseId { get; set; }

        [Required, CustomValidation(typeof(Validation_Methods), "NameInput")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The stream of lesson is required")]
        public string Stream { get; set; }

        [Required(ErrorMessage = "The type of lesson is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "The start of lesson is required"), Display(Name = "Lesson start")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "The start of lesson is required"), Display(Name = "Lesson finish")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Image"), DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<TrainerCourse> TrainerCourses { get; set; }
        public virtual ICollection<ProjectStudent> ProjectStudents { get; set; }
    }

}

