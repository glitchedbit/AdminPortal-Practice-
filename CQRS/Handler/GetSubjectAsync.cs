using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class GetSubjectHandler : IRequestHandler<GetSubjectQuery, IEnumerable<Subject>>
    {
 private readonly IGenericRepository<Subject> _repo;

        public GetSubjectHandler(IGenericRepository<Subject> repo)
    {
  _repo = repo;
   }

  public async Task<IEnumerable<Subject>> Handle(GetSubjectQuery request, CancellationToken cancellationToken)
    {
      return await _repo.GetAllAsync();
        }
    }
}