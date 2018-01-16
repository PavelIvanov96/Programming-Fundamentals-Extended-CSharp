using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            long P = long.Parse(Console.ReadLine());

            var wingFlaps = (N / 1000.0) * M;
            var sec = (N / P) * 5 ;
            var d = N / 100;
            var res = sec + d;

            Console.WriteLine("{0:f2} m.",wingFlaps);
            Console.WriteLine("{0} s.", res);
        }
    }
}
