//using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Data;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdmnPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        public readonly ApplicationDbContext ctx;
        public TestingController(ApplicationDbContext _ctx)
        {
            ctx = _ctx;
        }
        //private readonly IMediator _mediator;

        //public TestingController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        [HttpGet("EMPLOYEE")]
        public IActionResult get()
        {
            var emp = ctx.Employees.ToList();
            return Ok(emp);
            
        }
        [HttpGet("{TableId}")]
        public IActionResult get_id(int TableId)
        {
            var emp = ctx.Employees.Find(TableId);

            if (emp == null) return NotFound();
            return Ok(emp);
        }
        [HttpPost("Add-Employee")]
        public IActionResult create([FromBody] Employee emp)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ctx.Employees.Add(emp);
            ctx.SaveChanges();
            return Ok(emp);
        }
        [HttpPut("Update-Employee/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee emp)
        {
            var existing = ctx.Employees.Find(id);if (existing == null)
                return NotFound();

            existing.Name = emp.Name;
            existing.Email = emp.Email;
            existing.Address = emp.Address;
            existing.Qualification = emp.Qualification;

            ctx.SaveChanges();
            return NoContent();
        }
        [HttpDelete("Delete-Employee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var existing = ctx.Employees.Find(id);
            if (existing == null)
            { return NotFound(); }
            else
            {
                ctx.Employees.Remove(existing);
            }

                ctx.SaveChanges();
            return Ok($"{id} deleted successfully");
        }


    }
}
