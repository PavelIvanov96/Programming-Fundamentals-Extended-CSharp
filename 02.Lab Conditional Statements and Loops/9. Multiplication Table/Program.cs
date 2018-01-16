using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                var sum = n * i;
                Console.WriteLine("{0} X {1} = {2}",n,i,sum);
            }
        }
    }
}
