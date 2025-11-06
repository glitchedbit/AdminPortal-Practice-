using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class PostTeacherAsync : IRequestHandler<post_teacher_command, Teacher>
{
      private readonly IGenericRepository<Teacher> repo;

        public PostTeacherAsync(IGenericRepository<Teacher> _repo)
        {
   repo = _repo;
        }

      public Task<Teacher> Handle(post_teacher_command request, CancellationToken cancellationToken)
{
       var teacher = new Teacher
    {
  Name = request.Name,
             Qualification = request.Qualification,
Class = request.Class,
      Active = request.Active,
        TableId = request.TableId
          };

    return repo.AddAsync(teacher);
        }
    }
}