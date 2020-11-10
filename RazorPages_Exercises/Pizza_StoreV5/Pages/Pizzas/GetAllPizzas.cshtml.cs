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
    public class GetAllPizzasModel : PageModel
    {
        private PizzaCatalog catalog;
        public GetAllPizzasModel()
        {
            catalog = PizzaCatalog.Instance;
        }
        public Dictionary<int, Pizza> Pizzas { get; private set; }

        public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();
            return Page();
        }
    }
}