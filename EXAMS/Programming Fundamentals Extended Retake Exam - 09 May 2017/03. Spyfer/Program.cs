using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                for (int i = 1; i < input.Count - 1; i++)
                {
                    var sum = input[i - 1] + input[i + 1];
                    if (sum == input[i])
                    {
                        Console.WriteLine(input[i]);
                        break;
                    }
                    Console.WriteLine(string.Join(" ",input));
                }
                break;
            }
        }
    }
}
