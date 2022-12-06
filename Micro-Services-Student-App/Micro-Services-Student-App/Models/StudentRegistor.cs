using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Micro_Services_Student_App.Models
{
    public class StudentRegistor
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        public string? StudentId { get; set; }
      

        [Required(ErrorMessage = "Please enter FirstName")]
        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter LastName")]
        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string? Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Please enter confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [DataType(DataType.Password)]
        public string? Confirmpwd { get; set; }
        //public Nullable<bool> Is_Deleted { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string? Email { get; set; }

        public string? CasteCategory { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }

        public string? Photo { get; set; }
        public string? Signature { get; set; }






    }
}
