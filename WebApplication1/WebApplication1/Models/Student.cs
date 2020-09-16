using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses_Lab5.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(50, MinimumLength = 2)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "*"), Range(18,30)]
        public int Age { get; set; }


        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }

        public virtual Department Department { get; set; }

    }
}