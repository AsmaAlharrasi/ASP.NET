using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Registration_and_Management_System.Model
{
    public class Patient
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "First Name must be 20 characters or less"), MinLength(3)]
        public string FName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Last Name must be 20 characters or less"), MinLength(3)]
        public string LName { get; set; }
      
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
      
        [Phone]
        [Required(ErrorMessage = "Phone no. is required")]
        public string Phone { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
