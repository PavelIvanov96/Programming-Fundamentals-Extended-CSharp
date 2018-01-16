using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> "},StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end")
                {
                    break;
                }
                if (!dic.ContainsKey(input[0]))
                {
                    dic[input[0]] = "";
                }
                dic[input[0]] = input[1];
            }
            var command = Console.ReadLine();

            var result = dic.Where(n => n.Value != "null").OrderByDescending(n => n.Value.Count()).ToArray();
           
            foreach (var kvp in result)
            {
                Console.WriteLine("{0} <-> {1}",kvp.Key,kvp.Value);
            }
            foreach (var kvp in dic.Where(s => s.Value == "null"))
            {
                Console.WriteLine("{0} <-> {1}",kvp.Key,command);
            }
        }
    }
}
