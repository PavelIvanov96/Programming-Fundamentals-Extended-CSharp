using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            List<int> arr = new List<int>(listNumbers.Count);

            for (int i = listNumbers.Count - 1; i >= 0; i--)
            {
                arr.Add(listNumbers[i]);
            }
            Console.WriteLine(String.Join(" ",arr));

        }
    }
}
