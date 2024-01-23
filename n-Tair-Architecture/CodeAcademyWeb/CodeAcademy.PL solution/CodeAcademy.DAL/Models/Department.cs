using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.DAL.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Code { get; set; }
        [MaxLength(50)] 
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
