using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.Model;

namespace Clinic_Registration_and_Management_System.Model
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentID { get; set; }

        [Required]
        public string Appointment_Day { get; set; }

        [Required]
        public string Appointment_Time { get; set; }

        public string Appointment_Status { get; set; }

        [ForeignKey("PatientID")]
        public int? PatientID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("SpecializationID")]
        public int? SpecializationID { get; set; }
        public Specialization Specialization { get; set; }

        [ForeignKey("AdminID")]
        public int? AdminID { get; set; }
        public Admin Admin { get; set; }
    }
}
