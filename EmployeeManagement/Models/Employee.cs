namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        
        public Role? Role { get; set; }

        public int? RoleId { get; set; }

        public Employee? Manager { get; set; }
        public int? ManagerId { get; set; } 

    }
}
