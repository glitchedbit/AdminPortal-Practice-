using AutoMapper;
using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Query;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class GetStudentHandler : IRequestHandler<GetStudentQuery, IEnumerable<Student>>
    {
   private readonly IGenericRepository<Student> _repo;

    public GetStudentHandler(IGenericRepository<Student> repo)
     {
    _repo = repo;
    }

   public async Task<IEnumerable<Student>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
 {
        return await _repo.GetAllAsync();
     }
    }
}