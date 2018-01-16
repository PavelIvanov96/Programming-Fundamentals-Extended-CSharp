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
            var word = Console.ReadLine().Split(' ').Select(Double.Parse).ToArray();

            var result = new SortedDictionary<double, int>();

            foreach (var numb in word)
            {
                if (!result.ContainsKey(numb))
                {
                    result[numb] = 0;
                }
                result[numb]++;
            }
            foreach (var item in result)
            {
                var timeString = item.Value == 1 ? "time" : "times";
                Console.WriteLine("{0} -> {1} {2}",item.Key,item.Value,timeString);
            }
        }
    }
}
