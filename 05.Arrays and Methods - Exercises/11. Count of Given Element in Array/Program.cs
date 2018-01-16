using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                  n[i] = n[i];
                if (n[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
