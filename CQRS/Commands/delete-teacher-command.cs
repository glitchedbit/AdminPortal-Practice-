using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class delete_teacher_command : IRequest<bool>
    {
        public int Id { get; set; }
    }
}