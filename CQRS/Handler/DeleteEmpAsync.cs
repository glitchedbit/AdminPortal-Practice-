using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using EmployeeAdmnPortal.Services;
using MediatR;
//using Exception;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class DeleteEmpAsync : IRequestHandler<delete_emp_command, bool>
    {
        private readonly IGenericRepository<Employee> _repository;
        private readonly ILoggerServices _log;
        public DeleteEmpAsync(IGenericRepository<Employee> repository , ILoggerServices log)
        {
            _repository = repository;
            _log = log;
        }

        public async Task<bool> Handle(delete_emp_command request, CancellationToken cancellationToken)
        {
            _log.LogInfo($"Deletion started for employee {request.Id}");

            try
            {
                var deleted = await _repository.DeleteAsync(request.Id);

                if (!deleted)
                {
                    _log.LogWarning($"Employee {request.Id} not found, nothing deleted.");
                    return false;
                }

                _log.LogInfo($"Employee {request.Id} deleted successfully.");
                return true;
            }
            catch (Exception ex)
            {
                _log.LogError(ex, $"Error deleting employee {request.Id}");
                throw;
            }

        }
    }
}
