using Newtonsoft.Json;
using Pizza_StoreV9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV9.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, Pizza> pizzas, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(pizzas, Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }

}
