using EmployeeManagement.Dtos;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles
{
    public class RoleDtosProfile : AutoMapper.Profile
    {
        public RoleDtosProfile()
        {
            CreateMap<Role, RoleDto>();
            CreateMap<Role, SimpleRoleDto>();
        }
    }
}
