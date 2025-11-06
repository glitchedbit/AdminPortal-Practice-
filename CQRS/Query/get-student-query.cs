using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Query
{
    public class GetStudentQuery : IRequest<IEnumerable<Student>> { }
}