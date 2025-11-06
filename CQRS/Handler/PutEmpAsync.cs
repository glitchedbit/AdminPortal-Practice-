using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class PutEmpAsync : IRequestHandler<put_emp_command, Employee>
    {
        private readonly IGenericRepository<Employee> _repository;

        public PutEmpAsync(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<Employee> Handle(put_emp_command request, CancellationToken cancellationToken)
        {
            var existing = await _repository.GetByIdAsync(request.Id);
            if (existing == null)
                return null!;

            existing.Name = request.Name;
            existing.Email = request.Email;
            existing.Qualification = request.Qualification;
            existing.Address = request.Address;

            return await _repository.UpdateAsync(existing);
        }
    }
}
