using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Coding_BootCamp.Entities.Custom_Validations
{
    public class Validation_Methods
    {
        public static ValidationResult NameInput(string input, ValidationContext context)
        {

            if (string.IsNullOrWhiteSpace(input))

                return new ValidationResult(string.Format("The field {0} cannot have spaces! Please inserttttt a valid name", context.MemberName), new List<string> { context.MemberName });

            else if (input.Length < 2)

                return new ValidationResult(string.Format("The field {0} cannot be one letter! Please insert a insert nameeeee", context.MemberName), new List<string> { context.MemberName });

            else if (input.Length > 30)

                return new ValidationResult(string.Format("The field {0} cannot have more than 30 letters! Please insert a valid nameeeee!", context.MemberName), new List<string> { context.MemberName });

            else return ValidationResult.Success;
        }


        public static ValidationResult BirthdayInput(DateTime? input, ValidationContext context)

           => (input > DateTime.Now) ? new ValidationResult(string.Format("The field {0} cannot be earlier than today. Please insert the correct date of birth.", context.MemberName),

                new List<string> { context.MemberName }) : ValidationResult.Success;



        //public static ValidationResult StartAndEndDate(DateTime startdate, DateTime finishdate, ValidationContext context)

        //    => (startdate > finishdate) ? new ValidationResult(string.Format("The start date {0} cannot be later than the finish date. Please insert valid start and finish dates!!", context.MemberName),

        //        new List<string> { context.MemberName }) : ValidationResult.Success;




        public static ValidationResult SubmissionDateInput(DateTime input, ValidationContext context)

            => (input > DateTime.Now) ? new ValidationResult(string.Format("The field {0} cannot be earlier than today. Please insert the correct date of submission.", context.MemberName),

                new List<string> { context.MemberName }) : ValidationResult.Success;



        public static ValidationResult TuittionFees(double? tuitionfees, ValidationContext context)


        => (tuitionfees >= 1300 && tuitionfees <= 2900) ? ValidationResult.Success : new ValidationResult(string.Format("The salary {0} must be between 1300 and 2900 euros", context.MemberName), new List<string> { context.MemberName });





        public static ValidationResult Salary(double salary, ValidationContext context)
        {
            bool isValid = true;

            if (salary <= 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("The Field {0} must be greater than or equal to 0", context.MemberName), new List<string> { context.MemberName });
            }

        }







        public static ValidationResult Grade(int? grade, ValidationContext context)

        => (grade >= 0 && grade <= 100) ? ValidationResult.Success :

          new ValidationResult(string.Format("The grade {0} must be between 0 and 100", context.MemberName), new List<string> { context.MemberName });

    }
}

