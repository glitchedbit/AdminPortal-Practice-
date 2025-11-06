using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class post_student_command : IRequest<Student>
    {
     public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Age { get; set; }
        public bool Active { get; set; }
        public int TeacherId { get; set; }
    }
}