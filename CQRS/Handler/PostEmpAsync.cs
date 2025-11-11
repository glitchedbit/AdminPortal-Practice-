using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Data;
using EmployeeAdmnPortal.Models;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.Services;
namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class PostEmpAsync : IRequestHandler<post_emp_command, Employee>
    {
        private readonly IGenericRepository<Employee> repo;
        private readonly ILoggerServices _log;

        public PostEmpAsync(IGenericRepository<Employee> _repo,ILoggerServices log)
        {
            repo = _repo;
            _log = log;
        
        }

        public Task<Employee> Handle(post_emp_command request, CancellationToken cancellationToken)
        {

            var employee = new Employee
            {
                Name = request.Name,
                Email = request.Email,
                Qualification = request.Qualification,
                Address = request.Address
            };

            return  repo.AddAsync(employee);


        }


    }
}
