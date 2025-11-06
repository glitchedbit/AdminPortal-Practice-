using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class GetTeacherHandler : IRequestHandler<GetTeacherQuery, IEnumerable<Teacher>>
    {
      private readonly IGenericRepository<Teacher> _repo;

    public GetTeacherHandler(IGenericRepository<Teacher> repo)
{
    _repo = repo;
        }

        public async Task<IEnumerable<Teacher>> Handle(GetTeacherQuery request, CancellationToken cancellationToken)
     {
  return await _repo.GetAllAsync();
    }
    }
}