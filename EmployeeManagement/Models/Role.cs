using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        public Double? Salary { get; set; }

        public Department? Department { get; set; }

        public int? DepartmentId { get; set; }
    }
}
