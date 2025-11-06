using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
    public class PutTeacherAsync : IRequestHandler<put_teacher_command, Teacher>
    {
        private readonly IGenericRepository<Teacher> repo;

        public PutTeacherAsync(IGenericRepository<Teacher> _repo)
        {
   repo = _repo;
        }

     public async Task<Teacher> Handle(put_teacher_command request, CancellationToken cancellationToken)
        {
    var existingTeacher = await repo.GetByIdAsync(request.TeacherId);
            if (existingTeacher == null)
   return null;

     existingTeacher.Name = request.Name;
   existingTeacher.Qualification = request.Qualification;
            existingTeacher.Class = request.Class;
            existingTeacher.Active = request.Active;
    existingTeacher.TableId = request.TableId;

    return await repo.UpdateAsync(existingTeacher);
   }
    }
}