using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Book_StoreV10
{
    public class JsonFileReader
    {
        public static List<Book> ReadJsonBook(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<Book>>(jsonString);
        }
    }
}
