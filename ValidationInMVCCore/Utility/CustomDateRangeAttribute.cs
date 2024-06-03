using Humanizer;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMVCCore.Utility
{
    public class CustomDateRangeAttribute : ValidationAttribute
    {
        int _minDate = 0;
        int _maxDate = 0; 

        public CustomDateRangeAttribute(int minDate, int maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime today = DateTime.Now;

            DateTime minimumDate = today.AddYears(-_minDate);
            DateTime maximumDate = today.AddYears(_maxDate);

            DateTime userInputDate = (DateTime)value;

            if (userInputDate >= minimumDate &&
                userInputDate <= maximumDate)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"Invalid Date Of Birth. Date should be between {minimumDate} and {maximumDate}");
        }
    }
}
