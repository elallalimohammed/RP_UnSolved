using StudentRazorPages.Helpers;
using StudentRazorPages.Interfaces;
using StudentRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages.Services
{
    public class JsonStudentRepository:IStudentRepository
    {
        string filePath = @"C:\Users\EASJ\Desktop\StudentRazorPages\StudentRazorPages\Data\JsonStudents.json";
        public Dictionary<string, Student> GetAllStudent()
        {
           return  JsonFileReader.ReadJson(filePath);
        }
        public void AddStudent(Student student)
        {
            Dictionary<string, Student> allStudents = GetAllStudent();
            allStudents.Add(student.Id, student);
            JsonFileWritter.WriteToJson(allStudents, filePath);
        }
        public Student GetStudent(string id)
        {
            return GetAllStudent()[id];
        }
        public void UpdateStudent(Student student)
        {
            if (student != null)
            {
                Dictionary<string, Student> Students = GetAllStudent();
                Students[student.Id].Id = student.Id;
                Students[student.Id].Name = student.Name;
                Students[student.Id].ImagePath = student.ImagePath;
                Students[student.Id].Section = student.Section;
            }
        }

        public Dictionary<string, Student> FilterStudents(string Criteria)
        {
            Dictionary<string, Student> filteredDictionary = new Dictionary<string, Student>();
            foreach (var s in GetAllStudent().Values)
            {
                if (s.Name.StartsWith(Criteria))
                {
                    filteredDictionary.Add(s.Id, s);
                }
            }
            return filteredDictionary;
        }

        
        
    }
}
