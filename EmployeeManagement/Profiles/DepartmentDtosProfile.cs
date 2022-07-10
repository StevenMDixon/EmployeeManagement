using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles
{
    public class DepartmentDtosProfile : AutoMapper.Profile
    {
        public DepartmentDtosProfile()
        {
            CreateMap<Department, DepartmentDto>();
        }
    }
}
