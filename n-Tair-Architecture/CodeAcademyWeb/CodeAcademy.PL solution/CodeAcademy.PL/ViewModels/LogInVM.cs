using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.PL.ViewModels
{
	public class LogInVM
	{
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public int Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
