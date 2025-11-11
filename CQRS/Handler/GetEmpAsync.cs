using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Data;
using EmployeeAdmnPortal.Models;
using EmployeeAdmnPortal.Models.Entities;
using EmployeeAdmnPortal.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class GetEmpHandler : IRequestHandler<GetEmpQuery, IEnumerable<Employee>>
    {
        private readonly IGenericRepository<Employee> _repo;
        private readonly ILoggerServices _log;

        public GetEmpHandler(IGenericRepository<Employee> repo , ILoggerServices log)
        {
        _repo=repo;
        _log = log;

        }

        public async Task<IEnumerable<Employee>> Handle(GetEmpQuery request, CancellationToken cancellationToken)
{
            _log.LogInfo($"Retrieval started for employee...data ");

            try
            {
                var retrieved = await _repo.GetAllAsync();
                /*if (!retrieved)
                 {
                     _log.LogWarning($"Employee retrieval failling......");
                     //return false;
                 }*/
                _log.LogInfo($"Employee retrieved successfully.");

                _log.LogWarning("Complete database data retrieval.............../{NoPaginatedCall/}");

                return retrieved;
            }
            catch (Exception ex)
            {
                _log.LogError(ex, $"Error retrieving...... employee ");
              
                throw;
                //return false;
            }
        }
    }
}
