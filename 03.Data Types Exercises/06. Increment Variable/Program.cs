using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 256)
            {
                Console.WriteLine(n);
            }
            else
            {
                double result = n / 256;
                double total = n - result * 256;
                Console.WriteLine(total);
                Console.WriteLine("Overflowed {0} times",result);
            }
        }
    }
}
