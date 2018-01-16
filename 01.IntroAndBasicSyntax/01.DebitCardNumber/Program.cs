using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirthNumber = int.Parse(Console.ReadLine());
            int fifthNumber = int.Parse(Console.ReadLine());

            Console.Write("{0:d4} ", firstNumber);
            Console.Write("{0:d4} ", secondNumber);
            Console.Write("{0:d4} ", thirthNumber);
            Console.Write("{0:d4} ", fifthNumber);
        }
    }
}
