using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
 public class PutSubjectAsync : IRequestHandler<put_subject_command, Subject>
    {
        private readonly IGenericRepository<Subject> repo;

        public PutSubjectAsync(IGenericRepository<Subject> _repo)
        {
     repo = _repo;
   }

     public async Task<Subject> Handle(put_subject_command request, CancellationToken cancellationToken)
    {
    var existingSubject = await repo.GetByIdAsync(request.SubjectId);
    if (existingSubject == null)
    return null;

      existingSubject.CourseName = request.CourseName;

        return await repo.UpdateAsync(existingSubject);
        }
    }
}