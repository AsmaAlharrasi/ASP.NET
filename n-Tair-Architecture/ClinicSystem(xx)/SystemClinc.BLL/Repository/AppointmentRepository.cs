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
    internal class AppointmentRepository : GenaricRepository<Appointment>, IAppointment
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
=======
    public class AppointmentRepository : GenaricRepository<Appointment>, IAppointment
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context) : base(context){
            _context = context;
        }

>>>>>>> 719e7cc36f196e47af5202760c17dcf8b84c4434
    }
}
