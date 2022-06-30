namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public double? Salary { get; set; }

        public Role? Role { get; set; }

        public Employee? Manager { get; set; }
    }
}
