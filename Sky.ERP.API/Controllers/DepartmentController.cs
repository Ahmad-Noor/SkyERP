using Microsoft.AspNetCore.Mvc;
using Sky.ERP.Domain.Entities.HR;
using Sky.ERP.Domain.Entities.Inventory;
using Sky.ERP.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sky.ERP.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;

    public DepartmentController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    // GET: api/<DepartmentController>
    [HttpGet]
    public IEnumerable<Department> Get()
    {
        return unitOfWork.DepartmentRepository.GetAll();
    }

    // GET api/<DepartmentController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<DepartmentController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DepartmentController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DepartmentController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
