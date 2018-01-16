using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger asd = 1;
            for (int i = 1; i <= n; i++)
            {
                asd *= i;
                 Console.WriteLine(asd);
            }
        }
    }
}
