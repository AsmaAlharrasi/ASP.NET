using Clinic_Registration_and_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.BLL.Repository
{
<<<<<<< HEAD
    internal class PatientRepository  
=======
    public class PatientRepository:GenaricRepository<Patient>,IPatient
>>>>>>> 719e7cc36f196e47af5202760c17dcf8b84c4434
    {
        public PatientRepository(ApplicationDbContext context) : base(context) { }
    }
}
