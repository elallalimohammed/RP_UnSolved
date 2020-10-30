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
    public class Edit_StudentModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        IStudentRepository repo;

        public Edit_StudentModel(IStudentRepository repository)
        {
            repo = repository;
            Student = new Student();
        }
        public IActionResult OnGet(string id)
        {
           Student= repo.GetStudent(id);
            if (Student == null)
            {
                return null;
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                repo.UpdateStudent(Student);
            }
            return RedirectToPage("Get_Create_Student");
        }
    }
}