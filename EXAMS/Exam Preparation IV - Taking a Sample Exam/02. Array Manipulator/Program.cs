using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
           
            while (true)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                if (command == "end")
                {
                    break;
                }
                else if (command == "exchange")
                {
                    var count = int.Parse(tokens[1]);
                    if (count >= 0 && count < input.Count)
                    {
                       var booferFirst = input.Take(count + 1).ToList();
                       var booferSecond = input.Skip(count + 1).ToList();
                       var concat = booferSecond.Concat(booferFirst).ToList();
                       input = concat;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "max")
                {
                    var type = tokens[1];
                    if (type == "odd")
                    {
                        if (input.Any(x => x % 2 != 0))
                        {
                            var maxOdd = input.Where(x => x % 2 != 0).Max();
                            var re = input.LastIndexOf(maxOdd);
                            Console.WriteLine(re);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (type == "even")
                    {
                        if (input.Any(x => x % 2 == 0))
                        {
                            var maxEven = input.Where(x => x % 2 == 0).Max();
                            var re = input.LastIndexOf(maxEven);
                            Console.WriteLine(re);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "min")
                {
                    var type = tokens[1];
                    if (type == "odd")
                    {
                        if (input.Any(x => x % 2 != 0))
                        {
                            var maxOdd = input.Where(x => x % 2 != 0).Min();
                            var re = input.LastIndexOf(maxOdd);
                            Console.WriteLine(re);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (type == "even")
                    {
                        if (input.Any(x => x % 2 == 0))
                        {
                            var maxEven = input.Where(x => x % 2 == 0).Min();
                            var re = input.LastIndexOf(maxEven);
                            Console.WriteLine(re);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "first")
                {
                    var type = tokens[2];
                    var count = int.Parse(tokens[1]);
                    if (count >= 0 && count <= input.Count)
                    {
                        if (type == "odd")
                        {
                            var firstTake = input.Where(x => x % 2 != 0).Take(count).ToList();
                            Console.WriteLine("[{0}]", string.Join(", ", firstTake));
                        }
                        else if (type == "even")
                        {
                            var firstTake = input.Where(x => x % 2 == 0).Take(count).ToList();
                            Console.WriteLine("[{0}]", string.Join(", ", firstTake));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                else if (command == "last")
                {
                    var type = tokens[2];
                    var count = int.Parse(tokens[1]);

                    if (count >= 0 && count <= input.Count)
                    {
                        if (type == "odd")
                        {
                            var firstTake = input.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();

                            Console.WriteLine("[{0}]", string.Join(", ", firstTake));
                        }
                        else if (type == "even")
                        {
                            var firstTake = input.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
                            Console.WriteLine("[{0}]", string.Join(", ", firstTake));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
            }
            Console.WriteLine("[{0}]",string.Join(", ",input));
        }
    }
}
