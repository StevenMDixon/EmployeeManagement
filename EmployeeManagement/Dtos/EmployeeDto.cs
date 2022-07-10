namespace EmployeeManagement.Dtos
{
    public class EmployeeDto
    {
        public string Name { get; set; } = "Default";

        public SimpleRoleDto? Role { get; set; } = null;

        public SimpleEmployeeDto? Manager { get; set; } = null;
    }
}
