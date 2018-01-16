using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal distanceNearestStar = (decimal)4.22 * 9450000000000m;
            decimal distanceCenter = 26000 * 9450000000000m;
            decimal diameter = 100000 * 9450000000000m;
            decimal Earth = 46500000000 * 9450000000000m;

            Console.WriteLine("{0:e2}",distanceNearestStar);
            Console.WriteLine("{0:e2}", distanceCenter);
            Console.WriteLine("{0:e2}",diameter);
            Console.WriteLine("{0:e2}",Earth);
        }
    }
}
