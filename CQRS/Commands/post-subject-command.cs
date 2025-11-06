using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class post_subject_command : IRequest<Subject>
    {
        public string CourseName { get; set; } = string.Empty;
    }
}