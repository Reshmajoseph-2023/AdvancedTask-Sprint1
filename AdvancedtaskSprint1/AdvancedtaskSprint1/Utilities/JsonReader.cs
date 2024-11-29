using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedtaskSprint1.Utilities
{
    public class LoadJson
    {
        public static List<T> Read<T>(string filePath)
        {
            string text = File.ReadAllText(filePath);
            List<T> testData = JsonConvert.DeserializeObject<List<T>>(text);
            return testData;
        }
    }
}
