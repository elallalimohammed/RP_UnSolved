using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.PizzaCatalogs;

namespace Pizza_StoreV3
{
    public class CreatePizzaModel : PageModel
    {
        private PizzaCatalog catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }
        public CreatePizzaModel()
        {
            catalog = new PizzaCatalog();
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.AddPizza(Pizza);
           return RedirectToPage("GetAllPizzas");
        }
    }
}