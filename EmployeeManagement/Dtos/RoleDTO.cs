namespace EmployeeManagement.Dtos
{
    public class RoleDto
    {
        public string Title { get; set; } = "Default";

        public Double? Salary { get; set; }

        public ICollection<SimpleEmployeeDto>? Employees { get; set; } = new List<SimpleEmployeeDto>();
    }
}
