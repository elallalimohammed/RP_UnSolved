using Book_StoreV10.Interfaces;
using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Repositories
{
    public class JsonBookRepository:IBooksRepository
    {
        string JsonFileName = @"C:\Users\EASJ\Desktop\Book_StoreV10\Book_StoreV10\Data\JsonBooksStore.json";

        public List<Book> GetAllBooks()
        {
            return JsonFileReader.ReadJsonBook(JsonFileName);
        }
        public void AddBook(Book book)
        {
            List<Book> books = GetAllBooks().ToList();
            books.Add(book);
            JsonFileWritter.WriteToJsonBook(books, JsonFileName);
        }
        public Book GetBook(string isbn)
        {
            foreach (var b in GetAllBooks())
            {
                if (b.ISBN == isbn)
                    return b;
            }
            return new Book();
        }
    }
}
