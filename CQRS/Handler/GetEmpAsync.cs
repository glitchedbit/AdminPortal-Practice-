using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Data;
using EmployeeAdmnPortal.Models;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class GetEmpHandler : IRequestHandler<GetEmpQuery, IEnumerable<Employee>>
    {
        private readonly IGenericRepository<Employee> _repo;

        public GetEmpHandler(IGenericRepository<Employee> repo)
        {
        _repo=repo;
        }

        public async Task<IEnumerable<Employee>> Handle(GetEmpQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
