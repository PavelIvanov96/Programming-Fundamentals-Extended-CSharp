using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            while (input.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                if (input.Count < 0)
                {
                    break;
                }
                if (index <= input.Count)
                {
                    var command = input[index];
                    input.RemoveAt(index);
                    result.Add(command);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] > command)
                        {
                            var diff = input[i] - command;
                            input.RemoveAt(i);
                            input.Insert(i, diff);
                        }
                        else
                        {
                            var sum = input[i] + command;
                            input.RemoveAt(i);
                            input.Insert(i, sum);
                        }
                    }
                }
                else
                {
                    var first = input.First();
                    result.Add(first);
                    var last = input.Last();
                    input.RemoveAt(input.Count  - 1);
                    input.Insert(input.Count , last);

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] > first)
                        {
                            var diff = input[i] - first;
                            input.RemoveAt(i);
                            input.Insert(i, diff);
                        }
                        else
                        {
                            var sum = input[i] + first;
                            input.RemoveAt(i);
                            input.Insert(i, sum);
                        }
                    }
                }
               // Console.WriteLine("------" + string.Join(" ",input));
            }
            // Console.WriteLine(string.Join(" ",result));
            Console.WriteLine(result.Sum());
        }
    }
}
