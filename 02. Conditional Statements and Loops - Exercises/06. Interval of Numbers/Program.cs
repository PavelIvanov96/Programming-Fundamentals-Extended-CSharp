using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNunber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            
            for (int i = Math.Min(startNunber,endNumber); i <= Math.Max(endNumber,startNunber); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
