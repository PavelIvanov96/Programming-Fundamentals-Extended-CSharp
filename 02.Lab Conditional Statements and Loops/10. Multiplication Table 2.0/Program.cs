using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                var sum = n * times;
                Console.WriteLine("{0} X {1} = {2}",n,times,sum);
                times++;
            } while (times <= 10);
        }
    }
}
