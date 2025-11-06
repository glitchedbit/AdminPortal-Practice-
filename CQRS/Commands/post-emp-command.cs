using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using EmployeeAdmnPortal.Models.Dtos;
namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class post_emp_command : IRequest<Employee>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
