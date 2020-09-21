using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV8.Interfaces;
using Pizza_StoreV8.Models;

namespace Pizza_StoreV8
{
    public class CreatePizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        private IPizzaRepository catalog;
        public CreatePizzaModel(IPizzaRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            catalog.AddPizza(Pizza);
                        
           return RedirectToPage("GetAllPizzas");
        }
    }
}