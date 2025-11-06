using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdmnPortal.Controllers
{
    [Route("api/[controller]")]
  [ApiController]
 public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

   public StudentsController(IMediator mediator)
  {
   _mediator = mediator;
        }

        [HttpGet]
  public async Task<IActionResult> GetAsync()
   {
      var students = await _mediator.Send(new GetStudentQuery());
return Ok(students);
   }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] post_student_command command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] put_student_command command)
        {
          var result = await _mediator.Send(command);
      return result != null ? Ok(result) : NotFound();
       }

        [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
     {
 var result = await _mediator.Send(new delete_student_command { Id = id });
return result ? Ok("Deleted Successfully") : NotFound("Student not found");
       }
    }
}