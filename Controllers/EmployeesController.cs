//using EmployeeAdmnPortal.Data;
//using EmployeeAdmnPortal.Models;
//using EmployeeAdmnPortal.Models.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace EmployeeAdmnPortal.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmployeesController : ControllerBase
//    {
//        private readonly ApplicationDbContext dbcontext;

//        public EmployeesController(ApplicationDbContext dbcontext)
//        {

//            this.dbcontext = dbcontext;

//        }

//        [HttpGet]
//        public IActionResult GetAllEmployees()
//        {

//            var EMP = dbcontext.Employees.ToList();
//            return Ok(EMP);
//        }

//        [HttpGet]
//        [Route("{id:guid}")]
//        public IActionResult GetEmployeeId(Guid id)
//        {

//            var EMP = dbcontext.Employees.Find(id);

//            if (EMP is null) { return NotFound(); }

//            return Ok(EMP);
//        }

//        [HttpPost]
//        public IActionResult AddEmployee(AddEmployeedto addemployeedto)
//        {
//            var EmpEntity = new Employee()
//            {
//                Name = addemployeedto.Name,
//                Email = addemployeedto.Email,
//                Phone = addemployeedto.Phone,
//                Salary = addemployeedto.Salary
//            };

//            dbcontext.Employees.Add(EmpEntity);
//            dbcontext.SaveChanges();
//            return Ok(EmpEntity);
//        }

//        [HttpPut]
//        [Route("{id:guid}")]
//        public IActionResult UpdateEmployeeId(Guid id, UpdateEmployeeDto updateemployeedto)
//        {

//            var EMP = dbcontext.Employees.Find(id);

//            if (EMP is null) { return NotFound(); }

//            EMP.Name = updateemployeedto.Name;
//            EMP.Phone = updateemployeedto.Phone;
//            EMP.Email = updateemployeedto.Email;
//            EMP.Salary = updateemployeedto.Salary;

//            dbcontext.SaveChanges();
//            return Ok(EMP);

//        }

//        [HttpDelete]
//        [Route("{id:guid}")]
//        public IActionResult DeleteEmployeeId(Guid id)
//        {

//            var EMP = dbcontext.Employees.Find(id);

//            if (EMP is null) { return NotFound(); }

//            dbcontext.Employees.Remove(EMP);
//            dbcontext.SaveChanges();
//            return Ok(EMP);

//        }
//    }
//}
