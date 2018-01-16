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
            var power = long.Parse(Console.ReadLine());
            var result = new List<long>();
            
           
            while (true)
            {
                var tokens = Console.ReadLine();
                var sum = 0L;
                if (tokens == "All ofboard!")
                {
                    break;
                }
                var weapons = long.Parse(tokens);
                if (weapons >= 0)
                {
                    result.Add(weapons);
                }
                for (int i = 0; i < result.Count; i++)
                {
                    sum += result[i];
                    if (sum > power)
                    {
                       
                        var average = (long)((long)(result.Sum() / (long)result.Count()));
                        var closestLess = result.OrderByDescending(n => n)
                         .FirstOrDefault(n => average > n);
                        var closestGreater = result.OrderBy(n => n)
                                     .FirstOrDefault(n => average < n);
                        var boofer = new List<long>();
                        boofer.Add(closestGreater);
                        boofer.Add(closestLess);
                        long closest = result.OrderBy(item => Math.Abs(average - item)).First();
                        result.Remove(closest);
                    }
                }
            }
            result.Reverse();
            //  Console.WriteLine(string.Join(" ",result) + " " + power);
            Console.WriteLine("{0} {1}",string.Join(" ",result),power);
        }
    }
}
