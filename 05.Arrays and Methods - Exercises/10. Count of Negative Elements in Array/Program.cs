using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var arr = new int[counter];
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
