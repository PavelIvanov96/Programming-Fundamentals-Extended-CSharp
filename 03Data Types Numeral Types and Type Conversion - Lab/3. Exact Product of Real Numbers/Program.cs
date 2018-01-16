using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal multiply = 1;

            for (int i = 0; i < n; i++)
            {
                decimal exactNumber = decimal.Parse(Console.ReadLine());

                exactNumber = multiply * exactNumber;
                multiply = exactNumber;   
            }
            Console.WriteLine(multiply);
        }
    }
}
