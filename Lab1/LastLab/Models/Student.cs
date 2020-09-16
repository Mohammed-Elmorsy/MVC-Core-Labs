using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10,MinimumLength =3)]
        public string Name { get; set; }
        [Range(20,40)]
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }
    }
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Student> Students { get; set; }

    }
}
