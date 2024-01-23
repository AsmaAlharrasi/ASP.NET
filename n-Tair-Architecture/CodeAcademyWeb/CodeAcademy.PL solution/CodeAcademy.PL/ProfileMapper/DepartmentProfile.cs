using AutoMapper;
using CodeAcademy.DAL.Models;
using CodeAcademy.PL.ViewModels;

namespace CodeAcademy.PL.ProfileMapper
{
    public class DepartmentProfile :Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentVM, Department>();
        }
    }
}
