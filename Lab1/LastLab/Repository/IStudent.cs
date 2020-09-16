using LastLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastLab.Repository
{
   public  interface IStudent
    {
        IEnumerable<Student> GetStudents();
        void AddStudent(Student std);
        void DeleteStudent(int id);
        Student FindStudent(int id);
        void UpdateStudent(Student std);

    }
}
