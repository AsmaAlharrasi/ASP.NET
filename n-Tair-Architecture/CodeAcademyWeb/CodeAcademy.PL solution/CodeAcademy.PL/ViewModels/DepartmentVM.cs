using CodeAcademy.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.PL.ViewModels
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required for the Department")]
        
        public string Name { get; set; }
        ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
