using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;
            for (int i = 0; i < num.Length; i++)
            {
               num[i] = num[i];
                if (Math.Abs(num[i]) % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
