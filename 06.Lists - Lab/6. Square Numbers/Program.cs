using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbs = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> squareNumbs = new List<double>();

            for (int i = 0; i < numbs.Count; i++)
            {
                if (Math.Sqrt(numbs[i]) == (int)Math.Sqrt(numbs[i]) )
                {
                    squareNumbs.Add(numbs[i]);
                }
            }
            squareNumbs.Sort();
            squareNumbs.Reverse();
            Console.WriteLine(string.Join(" ",squareNumbs));
        }
    }
}
