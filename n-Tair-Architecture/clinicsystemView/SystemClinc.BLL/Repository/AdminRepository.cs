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
        public AdminRepository(ApplicationDbContext context) : base(context)
        {
        
        }
    }
}
