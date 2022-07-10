namespace EmployeeManagement.Dtos
{
    public class DepartmentDto
    {
        public string Name { get; set; } = "Default";

        public ICollection<SimpleRoleDto> roles { get; set; } = new List<SimpleRoleDto>();
    }
}
