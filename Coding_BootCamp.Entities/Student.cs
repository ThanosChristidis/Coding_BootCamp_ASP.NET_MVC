using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Coding_BootCamp.Entities.Custom_Validations;

namespace Coding_BootCamp.Entities
{
    [Table("Student")]
    public class Student : Person
    {
        [Display(Name = "Birthday"), DataType(DataType.Date), CustomValidation(typeof(Validation_Methods), "BirthdayInput")]
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<ProjectStudent> ProjectStudents { get; set; }
    }
}

