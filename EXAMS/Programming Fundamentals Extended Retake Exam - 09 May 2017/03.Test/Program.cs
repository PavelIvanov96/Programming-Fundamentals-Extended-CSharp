using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                
                if (i != 0 && i != input.Count - 1)
                {
                    var sum = input[i - 1] + input[i + 1];
                    if (input[i] == sum)
                    {
                        input.RemoveAt(i + 1);
                        input.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && input[i] == input[i + 1])
                {
                    input.RemoveAt(i + 1);
                    i = 0;
                }
                 else if (i == input.Count - 1 && input[i] == input[i - 1])
                 {
                     input.RemoveAt(i - 1);
                     i = 0;
                 }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
