using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            char character = char.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            double solution = 0.0;
            if (character == '+')
            {
                solution = firstDigit + secondDigit;
                Console.WriteLine("{0} + {1} = {2}",firstDigit,secondDigit,(int)solution);
            }
            else if (character == '-')
            {
                solution = firstDigit - secondDigit;
                Console.WriteLine("{0} - {1} = {2}", firstDigit, secondDigit, (int)solution);
            }
            else if (character == '*')
            {
                solution = firstDigit * secondDigit;
                Console.WriteLine("{0} * {1} = {2}", firstDigit, secondDigit, (int)solution);
            }
            else if (character == '/')
            {
                solution = firstDigit / secondDigit;
                Console.WriteLine("{0} / {1} = {2}", firstDigit, secondDigit, (int)solution);
            }

        }
    }
}
