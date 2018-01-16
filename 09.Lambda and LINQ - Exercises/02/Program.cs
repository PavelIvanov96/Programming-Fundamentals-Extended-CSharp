using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
       
        {
            var defaltValue = new Dictionary<string, string>();
            string[] inputLine = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "end")
            {
                string word = inputLine[0];
                string second = inputLine[1];

                if (!defaltValue.ContainsKey(word))
                {
                    defaltValue.Add(word, second);
                }

                inputLine = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            string input = Console.ReadLine();

            var result = defaltValue.Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Count()).ToArray();

            foreach (var kvp in result)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }

            foreach (var kvp in defaltValue.Where(n => n.Value == "null"))
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, input);
            }
        }
        }
}
