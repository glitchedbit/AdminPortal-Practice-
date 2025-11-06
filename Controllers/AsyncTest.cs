using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Data;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
//using EmployeeAdmnPortal.Data;
//using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace EmployeeAdmnPortal.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AsyncTest : ControllerBase
    {
        private readonly IMediator _mediator;

        public AsyncTest(IMediator mediator)
        {
            _mediator = mediator;
        } 

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var emp = await _mediator.Send(new GetEmpQuery());
            return Ok(emp);
        }





        [HttpGet("id")]
        public async Task<IActionResult> GetAsync(int id)
        {
            //var emp = await _mediator.Send(new );
            return Ok();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] post_emp_command command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] put_emp_command command)
        {
            var result = await _mediator.Send(command);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new delete_emp_command { Id = id });
            return result ? Ok("Deleted Successfully") : NotFound("Employee not found");
        }



    }
}
