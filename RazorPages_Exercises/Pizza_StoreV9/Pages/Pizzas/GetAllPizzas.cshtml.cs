using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV9.Interfaces;
using Pizza_StoreV9.Models;

namespace Pizza_StoreV9
{
    public class GetAllPizzasModel : PageModel
    {
        private IPizzaRepository catalog;
        public GetAllPizzasModel(IPizzaRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Pizza> Pizzas { get; private set; }
       
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get;  set; }

        public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Pizzas = catalog.FilterPizza(FilterCriteria);
            }
            
            return Page();
        }
    }
}