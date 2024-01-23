using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int age { get; set; }
        [MaxLength(50)]
       
        public string City { get; set; }

        public string Email { get; set; }


        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        public int? DepartmentId { get; set; }
        public Department Departments { get; set; }
    }
}
