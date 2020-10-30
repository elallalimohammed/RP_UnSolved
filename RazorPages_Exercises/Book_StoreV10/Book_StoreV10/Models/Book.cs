using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Models
{
    public class Book
    {
        public double Price { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string ImageName { get; set; }
    }
}
