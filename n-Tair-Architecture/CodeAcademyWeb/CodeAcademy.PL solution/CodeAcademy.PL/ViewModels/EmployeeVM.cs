using CodeAcademy.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.PL.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        
        [MinLength(5)]
        public string Name { get; set; }

        [Range(18, 33)]
        public int age { get; set; }
       
        [MinLength(4)]
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        public int? DepartmentId { get; set; }
        public Department Departments { get; set; }
    }
}
