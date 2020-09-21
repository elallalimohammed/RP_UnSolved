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
    public class EditPizzaModel : PageModel
    {
        private PizzaCatalog catalog;

        [BindProperty]
        public Pizza Pizza { get; set; }
        public EditPizzaModel()
        {
            catalog = PizzaCatalog.Instance;
        }
        public void OnGet(int id)
        {
            Pizza=catalog.GetPizza(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdatePizza(Pizza);
            return RedirectToPage("GetAllPizzas");
        }
    }
}