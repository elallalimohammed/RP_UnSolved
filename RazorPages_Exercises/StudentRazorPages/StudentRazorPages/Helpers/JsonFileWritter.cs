using Newtonsoft.Json;
using StudentRazorPages.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages.Helpers
{
    public class JsonFileWritter
    {
        public  static void WriteToJson(Dictionary<string, Student> students , string filePath)
        {
            string output = System.Text.Json.JsonSerializer.Serialize(students);

            File.WriteAllText(filePath, output);
        }
    }
}
