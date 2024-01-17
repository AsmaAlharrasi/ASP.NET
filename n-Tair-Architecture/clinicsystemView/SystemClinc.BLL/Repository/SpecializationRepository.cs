using Clinic_Registration_and_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.BLL.Repository
{
    public class SpecializationRepository : GenaricRepository<Specialization>, ISpecialization
    {
        private readonly ApplicationDbContext _context;

        public SpecializationRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
