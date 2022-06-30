namespace EmployeeManagement.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public Double? Salary { get; set; }

        public Department? Department { get; set; }
    }
}
