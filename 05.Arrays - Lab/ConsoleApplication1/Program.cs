using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
