using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses_Lab5.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }

        [Required]
        [StringLength(30,MinimumLength = 2)]
        public string Dept_Name { get; set; }

        [Range(0,100)]
        public int Capacity { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}