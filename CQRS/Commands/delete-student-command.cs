using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class delete_student_command : IRequest<bool>
    {
     public int Id { get; set; }
  }
}