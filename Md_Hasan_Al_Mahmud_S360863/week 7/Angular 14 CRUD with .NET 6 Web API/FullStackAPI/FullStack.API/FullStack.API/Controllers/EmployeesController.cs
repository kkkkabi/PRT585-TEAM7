using FullStackAPI.Data;
using FullStackAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Controllers
{
    [ApiController]
    [Route("api / [controller]")]
    public class EmployeesController : Controller
    {
        private readonly FullstackDbcontext _fullstackDbcontext;

        public EmployeesController(FullstackDbcontext fullstackDbcontext)
        {
            _fullstackDbcontext = fullstackDbcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
           var employees = await _fullstackDbcontext.Employees.ToListAsync();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();
            await _fullstackDbcontext.Employees.AddAsync(employeeRequest);
            await _fullstackDbcontext.SaveChangesAsync();

            return Ok(employeeRequest);
        }
    }
}
