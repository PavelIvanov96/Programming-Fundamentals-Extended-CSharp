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
                .Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            var REsult = new List<int>();

            while (commands != "end")
            {
                var token = commands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string comand = token[0];
                if (comand == "exchange")
                {
                    int index = int.Parse(token[1]);
                    if (index > inputLine.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        commands = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var firstHawf = inputLine.Take(index + 1);
                        var seconHawf = inputLine.Skip(index + 1);
                        inputLine = seconHawf.Concat(firstHawf).ToList();
                    }
                    Console.WriteLine(string.Join(" ", inputLine));
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
                        if (inputLine.Any(x => x % 2 != 0))
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
                    List<int> collectedNumbers = new List<int>();
                    int count = int.Parse(token[1]);
                    int counted = 0;
                    inputLine.Reverse();
                    if (count > inputLine.Count || count <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        commands = Console.ReadLine();
                        continue;

                    }
                    else
                    {
                        string thurdCommand = token[2];

                        if (thurdCommand == "even")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                int index = inputLine[i];

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
                                int index = inputLine[i];

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

                    Console.WriteLine($"[{string.Join(", ", collectedNumbers)}]");
                }
                else if (comand == "first")
                {
                    List<int> collectedNumbers = new List<int>();
                    int count = int.Parse(token[1]);
                    if (count > inputLine.Count || count <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        commands = Console.ReadLine();
                        continue;

                    }
                    else
                    {
                        string thurdCommand = token[2];
                        int counted = 0;
                        if (thurdCommand == "even")
                        {
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                int index = inputLine[i];

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
                                int index = inputLine[i];
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
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", inputLine)}]");
        }
    }
}