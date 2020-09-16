using Courses_Lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.AppDBContext;

namespace WebApplication1.Repository
{
    public class DBDepartmentRepository:IDepartment
    {
        private School _db;
        public DBDepartmentRepository(School db)
        {
            _db = db;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _db.Departments.ToList<Department>();
        }
    }
}
}
