using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirthNumber = int.Parse(Console.ReadLine());

            GetMinInt(firstNumber, secondNumber, thirthNumber);
        }
        static void GetMinInt(int firstNumber ,int secondNumber,int thirthNumber)
        {
            var getMin = Math.Min(firstNumber, secondNumber);
            getMin = Math.Min(getMin, thirthNumber);
            Console.WriteLine("{0}",getMin);
        }
    }
}
