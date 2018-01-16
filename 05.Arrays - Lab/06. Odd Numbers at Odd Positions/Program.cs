using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
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
                
                if (Math.Abs(num[i]) % 2 == 1 && count % 2 == 1)
                {
                    Console.WriteLine("Index {0} -> {1}",count,num[i]);
                }
                count++;
            }
           
        }
    }
}
