using CodeAcademy.BLL.Interface;
using CodeAcademy.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.BLL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            EmployeeRepository = new EmployeeRepository(context);
            DepartmentRepository = new DepartmentRepository(context);

        }
    }
}
