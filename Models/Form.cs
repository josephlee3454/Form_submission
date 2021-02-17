
using System.ComponentModel.DataAnnotations;
namespace form_sub.Models
{
    
    public class Form
    {

        [Required]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters!")]
  
        public string FName {get; set;}
        
        [Required]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters!")]
  
        public string LName {get; set;}
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        public string Email {get; set;}
        
        [Required]
        [EmailAddress(ErrorMessage="Please enter in a valid email address!")]
        public string Age {get; set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters!")]
        public string Password {get; set;}
    }
}
