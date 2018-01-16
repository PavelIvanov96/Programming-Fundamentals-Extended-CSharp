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
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToList();

           input = input.Take(3).ToList();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
