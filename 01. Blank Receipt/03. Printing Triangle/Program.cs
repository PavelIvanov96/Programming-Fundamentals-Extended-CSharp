using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);
            for (int k = n - 1; k >= 0; k--)
            {
                PrintLine(1, k);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
