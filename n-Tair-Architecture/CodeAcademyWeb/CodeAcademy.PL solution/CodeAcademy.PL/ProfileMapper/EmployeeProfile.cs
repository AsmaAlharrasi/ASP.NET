using AutoMapper;
using CodeAcademy.DAL.Models;
using CodeAcademy.PL.ViewModels;

namespace CodeAcademy.PL.ProfileMapper
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeVM, Employee>();
        }
    }
}
