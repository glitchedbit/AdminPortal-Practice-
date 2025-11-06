using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class DeleteEmpAsync : IRequestHandler<delete_emp_command, bool>
    {
        private readonly IGenericRepository<Employee> _repository;

        public DeleteEmpAsync(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(delete_emp_command request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id);
        }
    }
}
