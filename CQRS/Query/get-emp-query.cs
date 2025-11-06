using EmployeeAdmnPortal.Models.Entities;
using MediatR;

namespace EmployeeAdmnPortal.CQRS.Query
{
    public class GetEmpQuery : IRequest<IEnumerable<Employee>> { }
}

















//using AutoMapper;
//using EmployeeAdmnPortal.Data;
//using EmployeeAdmnPortal.Models;
//using EmployeeAdmnPortal.Models.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace EmployeeAdmnPortal.CQRS.Query
//{
//    public class GetEmpQuery
//    {
//        private readonly ApplicationDbContext _ctx;
//        private readonly IMapper _mapper;

//        public GetEmpQuery(ApplicationDbContext ctx, IMapper mapper)
//        {
//            _ctx = ctx;
//            _mapper = mapper;
//        }

//        public IActionResult GetEmployeeById(Guid id)
//        {
//            var emp = _ctx.Employees.Find(id);

//            if (emp == null)
//            {
//                return new NotFoundResult(); 
//            }
//            var testdto = _mapper.Map<TestDto>(emp);
//            return new OkObjectResult(testdto); 
//        }
//    }
//}
