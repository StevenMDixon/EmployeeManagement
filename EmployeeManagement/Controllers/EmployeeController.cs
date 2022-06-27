using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private Data.DataContext _context;

        public EmployeeController(Data.DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);
            if (employee == null)
            {
                return BadRequest("Employee Not Found");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee request)
        {
            var employee = await _context.Employees.FindAsync(request.Id);
            if (employee == null)
            {
                return BadRequest("Employee Not Found");
            }

            employee.Name = request.Name;
            employee.Salary = request.Salary;

            await _context.SaveChangesAsync();

            return Ok(employee);
        }
    }
}
