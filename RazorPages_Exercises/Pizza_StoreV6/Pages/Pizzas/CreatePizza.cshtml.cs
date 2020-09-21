using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV6.Models;
using Pizza_StoreV6.PizzaCatalogs;

namespace Pizza_StoreV6
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