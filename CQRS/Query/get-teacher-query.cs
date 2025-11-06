using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Query
{
    public class GetTeacherQuery : IRequest<IEnumerable<Teacher>> { }
}