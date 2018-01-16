using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ')
                .Select(long.Parse).ToList();
            string commands = Console.ReadLine();
            var REsult = new List<long>();

            while (commands != "end")
            {
                var token = commands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string comand = token[0];
                if (comand == "exchange")
                {
                    int index = int.Parse(token[1]);
                    if (index >= 0 && index < inputLine.Count)
                    {
                        var firstHawf = inputLine.Take(index + 1);
                        var seconHawf = inputLine.Skip(index + 1);

                        inputLine = seconHawf.Concat(firstHawf).ToList();
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        commands = Console.ReadLine();
                        continue;
                    }
                }

                else if (comand == "max")
                {
                    string type = token[1];

                    if (type == "odd")
                    {
                        if (inputLine.Any(x => x % 2 != 0))
                        {
                            var oddMax = inputLine.Where(x => x % 2 != 0).Max();
                            var index = inputLine.LastIndexOf(oddMax);

                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (type == "even")
                    {
                        if (inputLine.Any(x => x % 2 == 0))
                        {
                            var evenMax = inputLine.Where(x => x % 2 == 0).Max();
                            var index = inputLine.LastIndexOf(evenMax);

                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }

                }

                else if (comand == "min")
                {
                    string type = token[1];

                    if (type == "odd")
                    {
                        if (inputLine.Any(x => x % 2 != 0))
                        {
                            var oddMin = inputLine.Where(x => x % 2 != 0).Min();
                            var index = inputLine.LastIndexOf(oddMin);

                            Console.WriteLine(index);
                        }
                        else
                        {

                            Console.WriteLine("No matches");
                        }

                    }
                    else if (type == "even")
                    {
                        if (inputLine.Any(x => x % 2 == 0))
                        {
                            var evenMin = inputLine.Where(x => x % 2 == 0).Min();
                            var index = inputLine.LastIndexOf(evenMin);

                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }

                else if (comand == "last")
                {
                    List<long> collectedNumbers = new List<long>();
                    long count = long.Parse(token[1]);
                    int counted = 0;
                    inputLine.Reverse();
                    if (count >= 0 && count <= inputLine.Count )
                    {
                        string thurdCommand = token[2];

                        if (thurdCommand == "even")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                long index = inputLine[i];

                                if (index % 2 == 0)
                                {
                                    collectedNumbers.Add(index);
                                    counted++;
                                    if (counted == count)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else if (thurdCommand == "odd")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                long index = inputLine[i];

                                if (index % 2 != 0)
                                {
                                    collectedNumbers.Add(index);
                                    counted++;

                                    if (counted == count)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        inputLine.Reverse();
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                        commands = Console.ReadLine();
                        inputLine.Reverse();
                        continue;
                    }

                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                }
                else if (comand == "first")
                {
                    List<long> collectedNumbers = new List<long>();
                    long count = long.Parse(token[1]);
                    if (count >= 0 && count <= inputLine.Count )
                    {
                        string thurdCommand = token[2];
                        int counted = 0;
                        if (thurdCommand == "even")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                long index = inputLine[i];

                                if (index % 2 == 0)
                                {
                                    collectedNumbers.Add(index);
                                    counted++;

                                    if (counted == count)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else if (thurdCommand == "odd")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                long index = inputLine[i];
                                if (index % 2 != 0)
                                {
                                    collectedNumbers.Add(index);
                                    counted++;
                                    if (counted == count)
                                    {
                                        break;
                                    }
                                }
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                        commands = Console.ReadLine();
                        continue;
                    }
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputLine)}]");
        }
    }
}