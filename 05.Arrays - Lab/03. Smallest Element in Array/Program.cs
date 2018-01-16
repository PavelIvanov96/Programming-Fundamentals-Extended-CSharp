using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').ToArray();

            int[] arr = new int[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                arr[i] = int.Parse(value[i]);
            }
            var min = int.MaxValue;
            //var minimum = 0;

            for (int i = 0; i < value.Length ; i++)
            {
               arr[i] = arr[i];
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (i == value.Length - 1)
                {
                    Console.WriteLine(min);
                }
            }
        }
    }
}
