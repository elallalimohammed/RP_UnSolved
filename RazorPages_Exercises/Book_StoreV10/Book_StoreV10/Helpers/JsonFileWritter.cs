using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Book_StoreV10.Models;

namespace Book_StoreV10
{
    public class JsonFileWritter
    {
        public static void WriteToJsonBook(List<Book> books, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
