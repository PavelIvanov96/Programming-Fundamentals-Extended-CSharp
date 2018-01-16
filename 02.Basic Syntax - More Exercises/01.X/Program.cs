using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var count = 2;
            var count2 = 1;

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new string (' ',i));
                Console.Write("x");
                Console.Write(new string (' ', n - count));
                Console.Write("x");
                Console.WriteLine(new string (' ', i));
                count += 2;
            }
            Console.Write(new string (' ',n / 2 ));
            Console.Write("x");
            Console.WriteLine(new string (' ', n /2));

            for (int k = 1; k <= n / 2 ; k++)
            {
                Console.Write(new string (' ',n / 2 - k));
                Console.Write("x");
                Console.Write(new string (' ',count2 ));
                Console.Write("x");
                Console.WriteLine(new string (' ', n / 2 - k ));

                count2 += 2;
            }
        }
    }
}
