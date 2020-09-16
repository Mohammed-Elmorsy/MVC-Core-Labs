using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Repository
{
    public interface IDepartment
    {
        IEnumerable<Department> GetDepartments();
    }
}
