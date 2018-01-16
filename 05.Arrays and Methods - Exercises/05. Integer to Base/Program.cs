using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = long.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var result = IntToBase(number, toBase);

            Console.WriteLine(result);
        }

        static string IntToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var reminder = number % toBase;

                result = reminder + result;

                number /= toBase;

            }

            return result;
        }
    }
}
