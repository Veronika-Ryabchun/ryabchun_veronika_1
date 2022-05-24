using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Лабораторна_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputJson = "[{'V':'S001'}, {'V': 'S002'}, {'VI': 'S001'}, {'VI': 'S005'}, {'VII':'S005'}, {'V':'S009'},{'VIII':'S007'}]";
            Dictionary<string, string>[] A = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(inputJson);
            HashSet<string> hash_set = new HashSet<string>();
            foreach (var dict in A)
            {
                foreach (var el in dict)
                {
                    hash_set.Add(el.Value);
                }
            }
            Dictionary<string, HashSet<string>> Final = new Dictionary<string, HashSet<string>>()
            { 
                ["UniqueValues"] = hash_set
            };
            string json = JsonConvert.SerializeObject(Final);
            Console.WriteLine(json);
        }
    }
}
