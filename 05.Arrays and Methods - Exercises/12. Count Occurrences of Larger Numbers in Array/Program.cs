using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double n = double.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i];
                if (n < numbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
