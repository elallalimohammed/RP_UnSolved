using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorPages.Interfaces;
using StudentRazorPages.Models;
using StudentRazorPages.Services;

namespace StudentRazorPages
{
    public class Get_Create_StudentModel : PageModel
    {
        public Dictionary<string, Student> Students { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        IStudentRepository repo;
        public Get_Create_StudentModel(IStudentRepository repository)
        {
            repo = repository;
            Students = repo.GetAllStudent();
        }
        public IActionResult OnGet()
        {
            ViewData["Message"] = "Hello world, Welcome to Zealand academy";
            if (!String.IsNullOrEmpty(Criteria))
            {
                Students = repo.FilterStudents(Criteria);
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                repo.AddStudent(Student);
                Students = repo.GetAllStudent();
            }         
            return Page();
        }
        
    }
}