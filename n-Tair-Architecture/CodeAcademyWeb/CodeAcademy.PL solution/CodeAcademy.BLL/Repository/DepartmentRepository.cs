using CodeAcademy.BLL.Interface;
using CodeAcademy.DAL.Data;
using CodeAcademy.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.BLL.Repository
{
    public class DepartmentRepository : GenaricRepository<Department> , IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
           _context = context;
        }
    }
}
