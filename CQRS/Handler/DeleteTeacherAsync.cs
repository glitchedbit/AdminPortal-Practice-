using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class DeleteTeacherAsync : IRequestHandler<delete_teacher_command, bool>
 {
      private readonly IGenericRepository<Teacher> repo;

   public DeleteTeacherAsync(IGenericRepository<Teacher> _repo)
     {
   repo = _repo;
        }

public async Task<bool> Handle(delete_teacher_command request, CancellationToken cancellationToken)
{
     return await repo.DeleteAsync(request.Id);
 }
    }
}