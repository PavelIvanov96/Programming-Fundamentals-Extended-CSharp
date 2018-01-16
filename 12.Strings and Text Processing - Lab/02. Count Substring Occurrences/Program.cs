using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var result = input.IndexOf(pattern);
            var count = 0;

            while (result != -1)
            {
                count++;
                result = input.IndexOf(pattern, result + 1);
            }
            Console.WriteLine(count);
        }
    }
}
