using CodeAcademy.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.BLL.Interface
{
    public interface IEmployeeRepository : IGenaricRepository<Employee>
    {
        IEnumerable<Employee> Search(string name);
    }
}
