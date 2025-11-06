using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EmployeeAdmnPortal.Models.Entities

//namespace EmployeeAdmnPortal.Entities
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string CourseName { get; set; }

        //  Many-to-Many relationship
        public ICollection<Student>? Students { get; set; }
    }
}
