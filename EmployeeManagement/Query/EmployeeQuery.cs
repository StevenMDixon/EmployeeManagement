namespace EmployeeManagement.Query
{
    public class EmployeeQuery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int RoleId { get; set; }

        public int ManagerId { get; set; }

        public int DepartmentId { get; set; }

        public double Salary { get; set; }
    }
}
