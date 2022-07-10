using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Name { get; set; }

        [RegularExpression("^(.+)@(.+)$")]
        public string? Email { get; set; }
        
        public Role? Role { get; set; }

        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        public Employee? Manager { get; set; }

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; } 

    }
}
