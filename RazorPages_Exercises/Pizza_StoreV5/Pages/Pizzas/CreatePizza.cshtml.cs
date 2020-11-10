using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV5.Catalogs;
using Pizza_StoreV5.Models;

namespace Pizza_StoreV5
{
    public class CreatePizzaModel : PageModel
    {
        private PizzaCatalog catalog;
        
        [BindProperty]
        public Pizza Pizza { get; set; }
        public CreatePizzaModel()
        {
            catalog = PizzaCatalog.Instance;
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