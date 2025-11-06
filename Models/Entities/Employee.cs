//using EmployeeAdmnPortal.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAdmnPortal.Models.Entities
{
    public class Employee
    {
        [Key]
        public int TableId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }

        //  One-to-One relationship
        public Teacher? Teacher { get; set; }
    }
}
