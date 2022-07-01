using Microsoft.AspNetCore.Mvc;
using Firstweb_application.Services.Interfaces;
using Firstweb_application.Models;

namespace Firstweb_application.Controllers
{
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService =  employeeService;
         
        }
        // Create

        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _employeeService.CreateEmployee(employee);
            return new JsonResult("Employee created successfully.");
        }
        
        
        
        // Read
        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployees([FromRoute] int id)
        {
            return new JsonResult(_employeeService.GetEmployee(id));
        }


        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }

        // Update

        [HttpPut("Update")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new JsonResult("Employee updated successfully.");
        }

        // Delete

        [HttpDelete("Delete")]
        public IActionResult DeleteEmployee([FromQuery] int id)
        {
            return new JsonResult(_employeeService.DeleteEmployee(id));
        }
    }
}
