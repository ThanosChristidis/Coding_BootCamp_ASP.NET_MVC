using System.ComponentModel.DataAnnotations;
using Coding_BootCamp.Entities.Custom_Validations;

namespace Coding_BootCamp.Entities
{
    public abstract class Person
    {
        public int PersonId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Only letters are acceptable and start with capital letter")]
        [Display(Name = "First Name"), CustomValidation(typeof(Validation_Methods), "NameInput", ErrorMessage = "null,letters less than 2 and more than 30 aren't acceptable")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Only letters are acceptable and start with capital letter")]
        [Display(Name = "Surname"), CustomValidation(typeof(Validation_Methods), "NameInput", ErrorMessage = "null,letters less than 2 and more than 30 aren't acceptable")]
        public string LastName { get; set; }

        [Range(0, 81, ErrorMessage = "The age must be between 0 and 80!"), RegularExpression("^[0-9]+$", ErrorMessage = "Please insert only numbers!!")]
        public int? Age { get; set; }

        [Required, Display(Name = "Phone Number"), DataType(DataType.PhoneNumber), RegularExpression("^[0-9]+$", ErrorMessage = "Please insert only numbers!!")]
        public string TelNumber { get; set; }

        [Required, Display(Name = "Email"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Image"), DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }
    }
}