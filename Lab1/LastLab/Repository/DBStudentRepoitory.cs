using LastLab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Repository
{
    public class DBStudentRepoitory : IStudent
    {
        School _db;
        public DBStudentRepoitory(School db)
        {
            _db = db;
        }
        public void AddStudent(Student std)
        {
            _db.Students.Add(std);
            _db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student st= _db.Students.Include(d => d.Department).FirstOrDefault(a => a.Id == id);
            _db.Students.Remove(st);
            _db.SaveChanges();
        }

        public Student FindStudent(int id)
        {
            return _db.Students.Include(d => d.Department).FirstOrDefault(a => a.Id == id);
        }

    
        public IEnumerable<Student> GetStudents()
        {

         return   _db.Students.Include(a => a.Department).ToList<Student>();
        }

        public void UpdateStudent(Student std)
        {
            Student st= _db.Students.Include(d => d.Department).FirstOrDefault(a => a.Id ==std.Id);
            st.Name = std.Name;
            st.Age = std.Age;
            st.DeptId = std.Id;
            _db.SaveChanges();
        }

    }
}
