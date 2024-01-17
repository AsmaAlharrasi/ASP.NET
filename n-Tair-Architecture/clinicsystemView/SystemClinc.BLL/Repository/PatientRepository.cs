using Clinic_Registration_and_Management_System.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.BLL.Repository
{

    public class PatientRepository:GenaricRepository<Patient>,IPatient
    {
        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext context) : base(context) {
            _context = context;

        }
       

    }
}
