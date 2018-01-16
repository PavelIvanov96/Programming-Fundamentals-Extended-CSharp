using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, HashSet<int>>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                if (input[0] == "Aggregate")
                {
                    break;
                }
                var town = input[0];
                var number =int.Parse(input[1]);

                if (!dic.ContainsKey(town))
                {
                    dic[town] = new HashSet<int>();
                }
                dic[town].Add(number);

            }
            foreach (var item in dic)
            {
                var sum = item.Value.Sum();
                var count = item.Value.Count();
                var result = sum - sum / count;
                Console.WriteLine("{0} -> {1} ({2})" ,item.Key,string.Join(", ",item.Value),result);
            }
        }
    }
}
