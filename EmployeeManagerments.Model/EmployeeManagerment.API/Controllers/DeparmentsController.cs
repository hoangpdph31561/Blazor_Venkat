using EmployeeManagerment.API.Catalog.Deparment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagerment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentsController : ControllerBase
    {
        private readonly IDeparmentRespository deparmentRespository;
        public DeparmentsController(IDeparmentRespository deparmentRespository)
        {
            this.deparmentRespository = deparmentRespository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDeparments()
        {
            try
            {
                var result = await deparmentRespository.GetDeparments();
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeparmentById(int id)
        {
            try
            {
                var result = await deparmentRespository.GetDeparmentById(id);
                if(result == null)
                {
                    return NotFound($"Cannot find any deparment with id = {id}");
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
