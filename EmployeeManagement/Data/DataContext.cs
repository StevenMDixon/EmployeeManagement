using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }
        public DbSet<Role> Role { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        Id = 1,
                        Name = "Sales"
                    }
                );


            modelBuilder.Entity<Role>().HasData(
                    new Role
                    {
                        Id = 1,
                        Title = "Sales Associate",
                        Salary = 20000,
                        DepartmentId = 1

                    },
                    new Role
                    {
                        Id = 2,
                        Title = "Sales Team Lead",
                        Salary = 30000,
                        DepartmentId = 1
                    }
                );


            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Amanda Lima",
                        RoleId = 2
                    },
                     new Employee
                     {
                         Id = 2,
                         Name = "Mark Lima",
                         RoleId = 1,
                         ManagerId = 1
                     },
                     new Employee
                     {
                         Id = 3,
                         Name = "Shawn Hawkins",
                         RoleId = 1,
                         ManagerId = 1
                     }

                );

            base.OnModelCreating(modelBuilder);
        }
     }
}

