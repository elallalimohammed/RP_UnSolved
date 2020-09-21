using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}