using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();
            var dicCount = new Dictionary<string, List<int>>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                var name = input[0];
                var camp = input[1];
                var count = int.Parse(input[2]);

                if (!dic.ContainsKey(name))
                {
                    dic[name] = new List<string>();
                }
                dic[name].Add(camp);
                if (!dicCount.ContainsKey(name))
                {
                  dicCount[name] = new List<int>();
                }
                dicCount[name].Add(count);
            }
            
            
                foreach (var kvp in dic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key.Length))
                {
                    var campSimvol = kvp.Value.Select(x => "***" + x);
                    Console.WriteLine("{0}: {1}",kvp.Key,kvp.Value.Count);
                    Console.WriteLine(string.Join(Environment.NewLine ,  campSimvol));
                    var result = dicCount.Where(x => x.Key == kvp.Key);
                    foreach (var item in result)
                    {
                        Console.WriteLine("Total stay: {0} nights", item.Value.Sum());
                    }
                }
        }
    }
}
