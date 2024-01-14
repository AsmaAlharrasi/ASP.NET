using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;
using SystemClinc.Model;

namespace SystemClinc.BLL.Repository
{
    public class AdminRepository : GenaricRepository<Admin>, IAdmin
    {
<<<<<<< HEAD

=======
        
>>>>>>> 719e7cc36f196e47af5202760c17dcf8b84c4434
        public AdminRepository(ApplicationDbContext context) : base(context)
        {
        
        }
    }
}
