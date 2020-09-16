using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Repository
{
    public class MockStudentRepository : IStudent
    {
         List<Student> Students = new List<Student>()
        {
            new Student(){Id=1,Name="Mina",Age=25},
            new Student(){Id=2,Name="Ali",Age=20},
            new Student(){Id=3,Name="Fady",Age=30},

        };
        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }
        public void AddStudent(Student std)
        {
            Students.Add(std);
        }
        public void DeleteStudent(int id)
        {
            Student st = Students.FirstOrDefault(a => a.Id == id);
            if (st != null)
            {
                Students.Remove(st);
            }
        }
        public Student FindStudent(int id)
        {
            Student st = Students.FirstOrDefault(a => a.Id == id);
            if (st != null)
            {
                return st;
            }
            return null;

        }
        public void UpdateStudent(Student std)
        {
            Student st = Students.FirstOrDefault(a => a.Id == std.Id);
            st.Name = std.Name;
            st.Age = std.Age;
        }

    }
}
