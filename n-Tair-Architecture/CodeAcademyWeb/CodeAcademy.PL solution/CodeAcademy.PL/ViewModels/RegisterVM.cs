using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.PL.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "First Name is Required")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string Lname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password didn't Match ")]
        public string ConfirmPassword { get; set; }
        public bool isAgree { get; set; }
    }
}
