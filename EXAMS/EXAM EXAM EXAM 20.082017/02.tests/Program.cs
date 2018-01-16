using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = new List<int> { 11,20,25 };
            var tested = 20;

            var closestLess = re.OrderByDescending(n => n)
                      .FirstOrDefault(n => tested > n);
            var closestGreater = re.OrderBy(n => n)
                         .FirstOrDefault(n => tested < n);
            var boofer = new List<int>();
            boofer.Add(closestGreater);
            boofer.Add(closestLess);
            var clo = boofer.OrderBy(n => n)
                         .FirstOrDefault(n => tested < n);
            Console.WriteLine(clo);

            Console.WriteLine(closestLess);
            Console.WriteLine(closestGreater);

        }
    }
}
