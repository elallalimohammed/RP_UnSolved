using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_StoreV10.Models;
using Book_StoreV10.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_StoreV10
{
    public class CreateBookModel : PageModel
    {
        private JsonBookRepository catalog;
        [BindProperty]
        public Book Book { get; set; }
        
        public CreateBookModel( JsonBookRepository cat)
        {
            catalog = cat;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }           
            catalog.AddBook(Book);
            return RedirectToPage("AllBooks");         
        }
    }
}