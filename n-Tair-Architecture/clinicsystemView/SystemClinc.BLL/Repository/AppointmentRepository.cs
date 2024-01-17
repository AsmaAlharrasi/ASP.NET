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

    public class AppointmentRepository : GenaricRepository<Appointment>, IAppointment

    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context) : base(context){
            _context = context;
        }
        public IEnumerable<Appointment> Search(string? name, int? id)
        {
            var fname = _context.Appointments.Where(w => w.PatientID==id).ToList();
            return fname;
        }

        
        
    }
}
