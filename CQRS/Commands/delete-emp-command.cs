using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
namespace EmployeeAdmnPortal.CQRS.Commands
{
    public class delete_emp_command : IRequest<bool> {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}
