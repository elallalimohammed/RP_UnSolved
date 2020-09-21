using Newtonsoft.Json;
using Pizza_StoreV9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV9.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Pizza> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int,Pizza>>(jsonString);
        }
    }

}
