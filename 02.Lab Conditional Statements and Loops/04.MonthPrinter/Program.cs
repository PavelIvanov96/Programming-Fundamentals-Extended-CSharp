using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            if (day<=0 || day > 12)
            {
                Console.WriteLine("Error!");
            }
            if (day == 1)
            {
                Console.WriteLine("January");
            }
            else if (day == 2)
            {
                Console.WriteLine("February");
            }
            else if (day == 3)
            {
                Console.WriteLine("March");
            }
            else if (day == 4)
            {
                Console.WriteLine("April");
            }
            else if (day == 5)
            {
                Console.WriteLine("May");
            }
            else if (day == 6)
            {
                Console.WriteLine("June");
            }
            else if (day == 7)
            {
                Console.WriteLine("July");
            }
            else if (day == 8)
            {
                Console.WriteLine("August");
            }
            else if (day == 9)
            {
                Console.WriteLine("September");
            }
            else if (day == 10)
            {
                Console.WriteLine("October");
            }
            else if (day ==11)
            {
                Console.WriteLine("November");
            }
            else if (day ==12)
            {
                Console.WriteLine("December");
            }

        }
    }
}
