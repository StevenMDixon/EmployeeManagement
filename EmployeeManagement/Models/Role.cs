using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [Range(0.00, Int32.MaxValue, ErrorMessage = "Value must be a positive number")]
        public Double? Salary { get; set; }

        public Department? Department { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        public ICollection<Employee>? Employees { get; set; } = new List<Employee>();
    }
}
