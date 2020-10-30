using Newtonsoft.Json;
using StudentRazorPages.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages.Helpers
{
    public class JsonFileReader
    {
        public static  Dictionary<string, Student> ReadJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string,Student>>(jsonString);  
        }
    }
}
