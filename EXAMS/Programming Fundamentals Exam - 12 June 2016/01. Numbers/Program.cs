using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var average = input.Average();
           var  result = input.Where(x => x > average).OrderByDescending(x => x).Take(5).ToArray();
            //Console.WriteLine(average);
            if (result.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
