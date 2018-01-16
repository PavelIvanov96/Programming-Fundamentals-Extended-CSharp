using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            Console.WriteLine("It is a number.");
        }
    }
}
