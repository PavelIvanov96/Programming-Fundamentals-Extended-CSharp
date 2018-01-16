using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var dic = new Dictionary<string, double>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];

                if (name == "end")
                {
                    break;
                }
                var cost = double.Parse(input[1]);
                if (!dic.ContainsKey(name))
                {
                    dic[name] = cost;
                }
                else 
                {
                    if (dic[name] > cost)
                    {
                        dic[name] = cost;
                    }
                }   
            }

            var sum = dic.Sum(x => x.Value);
            var result = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Count());
            if (sum <= budget)
            {
                foreach (var kvp in result)
                {
                    Console.WriteLine("{0} costs {1:f2}",kvp.Key,kvp.Value);
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}
