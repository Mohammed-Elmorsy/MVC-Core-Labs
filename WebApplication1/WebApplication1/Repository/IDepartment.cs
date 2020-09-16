using Courses_Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    interface IDepartment
    {
        IEnumerable<Department> GetDepartments();
    }
}
