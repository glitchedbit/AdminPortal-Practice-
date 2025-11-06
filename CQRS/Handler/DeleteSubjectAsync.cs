using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class DeleteSubjectAsync : IRequestHandler<delete_subject_command, bool>
    {
     private readonly IGenericRepository<Subject> repo;

     public DeleteSubjectAsync(IGenericRepository<Subject> _repo)
        {
    repo = _repo;
      }

   public async Task<bool> Handle(delete_subject_command request, CancellationToken cancellationToken)
   {
       return await repo.DeleteAsync(request.Id);
        }
    }
}