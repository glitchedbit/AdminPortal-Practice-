using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class put_emp_command : IRequest<Employee> {
   public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
   public string Qualification { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}