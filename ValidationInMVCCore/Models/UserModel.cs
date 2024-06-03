using System.ComponentModel.DataAnnotations;
using ValidationInMVCCore.Utility;

namespace ValidationInMVCCore.Models
{

   // [MetadataType(typeof(UserModel))]
    


    public  class UserModel
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First name should be between 5 to 20 characters long")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        [CustomDateRangeAttribute(1,2)]
        public DateTime? DateOfBirth { get; set; }
    }

}
