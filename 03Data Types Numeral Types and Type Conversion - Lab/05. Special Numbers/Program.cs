using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var digit = i % 10;
                var divide = i / 10;
                var sum = digit + divide;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True",i);
                }
               else
                {
                    Console.WriteLine("{0} -> False",i);
                }
            }
        }
    }
}
