using Clinic_Registration_and_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.Model;

namespace SystemClinc.BLL.Interface
{

    public interface IAppointment : IGeneric<Appointment>
    {
        IEnumerable<Appointment> Search(string? name, int? id);
        // 
    }

}
