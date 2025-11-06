using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Query
{
    public class GetSubjectQuery : IRequest<IEnumerable<Subject>> { }
}