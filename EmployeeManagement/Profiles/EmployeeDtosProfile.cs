using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles
{
    public class EmployeeDtosProfile : AutoMapper.Profile
    {
        public EmployeeDtosProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Employee, SimpleEmployeeDto>();
        }
    }
}
