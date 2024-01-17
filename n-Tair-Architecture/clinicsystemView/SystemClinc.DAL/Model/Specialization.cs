using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Registration_and_Management_System.Model
{
    public class Specialization
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecializationID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name must be 50 characters or less"), MinLength(3)]
        public string SpecializationName { get; set;}
        public string Description { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
