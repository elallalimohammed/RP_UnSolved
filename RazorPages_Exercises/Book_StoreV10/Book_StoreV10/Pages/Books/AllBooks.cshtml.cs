using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_StoreV10.Models;
using Book_StoreV10.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_StoreV10
{
    public class AllBooksModel : PageModel
    {
        //private FakeBookRepository catalog;
        private JsonBookRepository catalog;

        //private ShoppingCartService Chart;

        public AllBooksModel(JsonBookRepository repository)
        {
            catalog = repository;
            //Chart = chart;
            List<Book> Books  = new List<Book>();
        }
        public List<Book> Books { get; private set; } 
       
        [BindProperty]
        public Book Book { get; set; }


        //[BindProperty(SupportsGet = true)]
        //public Pizza Pizza { get; set; }

        public IActionResult OnGet()
        {
            Books= catalog.GetAllBooks();
            //if (!string.IsNullOrEmpty(FilterCriteria))
            //{
            //    Pizzas = catalog.FilterPizza(FilterCriteria);
            //}          
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                catalog.AddBook(Book);
                Books = catalog.GetAllBooks();
            }
            return Page();
        }

    }
}