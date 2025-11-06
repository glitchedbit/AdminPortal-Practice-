using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
public class PostStudentAsync : IRequestHandler<post_student_command, Student>
    {
   private readonly IGenericRepository<Student> repo;

public PostStudentAsync(IGenericRepository<Student> _repo)
     {
   repo = _repo;
   }

   public Task<Student> Handle(post_student_command request, CancellationToken cancellationToken)
        {
    var student = new Student
   {
     Name = request.Name,
    Class = request.Class,
     Age = request.Age,
Active = request.Active,
  TeacherId = request.TeacherId
            };

   return repo.AddAsync(student);
       }
    }
}