using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Interfaces
{
    public interface IBooksRepository
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBook(string isbn);
    }
}
