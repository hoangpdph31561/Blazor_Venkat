using EmployeeManagerment.API.Catalog.Employee;
using EmployeeManagerment.API.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagerment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            try
            {
                var result = await employeeRepository.GetEmployees();
                if(result == null || result.Count == 0)
                {
                    return NotFound("There are not any employee");
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var result = await employeeRepository.GetEmployeeById(id);
                if(result == null)
                {
                    return NotFound($"There is not an employee with {id}");
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreatNewEmployee([FromForm]EmployeeRequest request)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await employeeRepository.AddNewEmployee(request);
                if(result == null)
                {
                    return BadRequest("Cannot create a new employee");
                }
                return Created("New employee", result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromForm]EmployeeRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await employeeRepository.UpdateEmployee(id, request);
                if (result == null)
                {
                    return NotFound($"Cannot found employee with {id}");
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                await employeeRepository.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Could not delete {id}");
            }
        }
    }
}
