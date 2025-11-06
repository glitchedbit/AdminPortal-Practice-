using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class post_teacher_command : IRequest<Teacher>
    {
        public string Name { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public bool Active { get; set; }
        public int TableId { get; set; }
    }
}