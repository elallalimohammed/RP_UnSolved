using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV9.Models;
using Pizza_StoreV9.Interfaces;

namespace Pizza_StoreV9
{
    public class EditPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        private IPizzaRepository catalog;
        public EditPizzaModel(IPizzaRepository repository)
        {
            catalog = repository;
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