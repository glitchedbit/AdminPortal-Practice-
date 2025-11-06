using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.CQRS.Commands;
using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Handler
{
   public class DeleteStudentAsync : IRequestHandler<delete_student_command, bool>
    {
        private readonly IGenericRepository<Student> repo;

     public DeleteStudentAsync(IGenericRepository<Student> _repo)
        {
     
            
            repo = _repo;
          
        
        }

     public async Task<bool> Handle(delete_student_command request, CancellationToken cancellationToken)
   {
     return await repo.DeleteAsync(request.Id);
  }
    }
}