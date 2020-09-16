using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Repository
{

    public class DBDepartmentRepository : IDepartment
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
