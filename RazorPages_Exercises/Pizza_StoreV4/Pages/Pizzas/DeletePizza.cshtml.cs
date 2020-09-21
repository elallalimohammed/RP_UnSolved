using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV4.Models;
using Pizza_StoreV4.PizzaCatalogs;

namespace Pizza_StoreV4
{
    public class DeletePizzaModel : PageModel
    {
        private PizzaCatalog catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }
        public DeletePizzaModel()
        {
            catalog = PizzaCatalog.Instance;
        }
        public IActionResult OnGet(int id)
        {
            Pizza = catalog.GetPizza(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeletePizza(Pizza);
            return  RedirectToPage("GetAllPizzas");
        }
    }
}