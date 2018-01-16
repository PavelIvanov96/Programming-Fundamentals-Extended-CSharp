using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbs = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbs.Sort();
            Console.WriteLine(String.Join("<=",numbs));
        }
    }
}
