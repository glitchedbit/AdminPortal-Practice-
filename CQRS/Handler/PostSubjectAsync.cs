using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
   public class PostSubjectAsync : IRequestHandler<post_subject_command, Subject>
    {
      private readonly IGenericRepository<Subject> repo;

    public PostSubjectAsync(IGenericRepository<Subject> _repo)
        {
    repo = _repo;
   }

public Task<Subject> Handle(post_subject_command request, CancellationToken cancellationToken)
        {
    var subject = new Subject
 {
   CourseName = request.CourseName
 };

     return repo.AddAsync(subject);
    }
    }
}