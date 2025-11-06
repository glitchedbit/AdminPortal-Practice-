using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAdmnPortal.Models.Entities

{
    public class Student
    {
        [Key]
        public int RollId { get; set; }

        public string Name { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }

        //  Foreign Key for Teacher (1:N)
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        //  Many-to-Many relationship
        public ICollection<Subject>? Subjects { get; set; }
    }
}
