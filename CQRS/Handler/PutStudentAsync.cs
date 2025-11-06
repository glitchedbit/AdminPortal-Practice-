using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class PutStudentAsync : IRequestHandler<put_student_command, Student>
    {
   private readonly IGenericRepository<Student> repo;

    public PutStudentAsync(IGenericRepository<Student> _repo)
 {
     repo = _repo;
        }

        public async Task<Student> Handle(put_student_command request, CancellationToken cancellationToken)
   {
var existingStudent = await repo.GetByIdAsync(request.RollId);
        if (existingStudent == null)
  return null;

       existingStudent.Name = request.Name;
            existingStudent.Class = request.Class;
         existingStudent.Age = request.Age;
            existingStudent.Active = request.Active;
       existingStudent.TeacherId = request.TeacherId;

return await repo.UpdateAsync(existingStudent);
   }
 }
}