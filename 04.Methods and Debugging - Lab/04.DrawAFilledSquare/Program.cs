using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Head(n);
            Body(n);
            Head(n);
        }
        static void Head(int n)
        {
            Console.Write(new string('-', n * 2));
            Console.WriteLine();
        }
        static void Body(int n)
        {
            for (int k = 0; k < n - 2; k++)
            {
                Console.Write("-");
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
