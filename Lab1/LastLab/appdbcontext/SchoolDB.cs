using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LastLab.Models;
using Microsoft.EntityFrameworkCore;
namespace LastLab
{
    public class SchoolDB:DbContext
    {
        public SchoolDB(DbContextOptions<SchoolDB> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
