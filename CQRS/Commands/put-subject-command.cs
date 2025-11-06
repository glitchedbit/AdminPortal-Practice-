using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class put_subject_command : IRequest<Subject>
    {
   public int SubjectId { get; set; }
        public string CourseName { get; set; } = string.Empty;
    }
}