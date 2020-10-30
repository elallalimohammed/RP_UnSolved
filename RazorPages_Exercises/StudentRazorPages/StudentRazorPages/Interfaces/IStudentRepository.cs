using StudentRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages.Interfaces
{
   public interface IStudentRepository
    {
        void UpdateStudent(Student student);
        Student GetStudent(string id);
        Dictionary<string, Student> GetAllStudent();

        void AddStudent(Student student);
        Dictionary<string, Student> FilterStudents(string Criteria);
    }
}
