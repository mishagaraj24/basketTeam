using basKet.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basKet.Controllers
{
    public class User: BaseUser
    {

        [Required]
        [DataType(DataType.Password)]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Пароль не соответствует правилам.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match.")]
        [NotMapped]
        public string PasswordConfirmation { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}