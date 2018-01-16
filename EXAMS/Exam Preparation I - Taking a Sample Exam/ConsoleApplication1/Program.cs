using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (var item in input)
            {
                if (item >= 65 && item <= 90 || item >= 97 && item <= 122)
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        }
    }
}
