//using EmployeeAdmnPortal.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAdmnPortal.Models.Entities

{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string Name { get; set; }
        public string Qualification { get; set; }
        public string Class { get; set; }
        public bool Active { get; set; }

        //  Foreign Key for Employee (1:1)
        public int TableId { get; set; }
        [ForeignKey("TableId")]
        public Employee Employee { get; set; }

        //  One-to-Many relationship with Students
        public ICollection<Student>? Students { get; set; }
    }
}
