using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var maxValue = int.MaxValue;

            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] < maxValue)
                {
                    maxValue = listNumbers[i];
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
