using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_lis___Console.ReadLine__
{
    class Program
    {
        static void Main(string[] args)
        {
            var lis = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
            var bufer = new List<string>();

            var start = 0;
            var count = 0;
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = input[0].Trim();

                if (command == "end")
                {
                    break;
                }
                if (command == "reverse")
                {

                    start = int.Parse(input[2]);
                    count = int.Parse(input[4]);
                    if ((start >= lis.Count || start < 0) || (count >= lis.Count || count < 0))
                    {

                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    else
                    {
                        var lisCnt = lis.Count();
                        var firsth = lis.Take(start).ToArray();
                        var last = lis.Skip(start + count).Reverse().ToArray();
                        lis = lis.Skip(start).Take(count).Reverse().ToList();

                        for (int i = 0; i < firsth.Length; i++)
                        {
                            lis.Insert(i, firsth[i]);
                        }
                        lis.Reverse();
                        var result = lisCnt - lis.Count();

                        for (int i = 0; i < result; i++)
                        {
                            lis.Insert(i, last[i]);
                        }
                        lis.Reverse();
                    }

                }
                else if (command == "sort")
                {

                    start = int.Parse(input[2]);
                    count = int.Parse(input[4]);
                    if (start >= lis.Count || start < 0 || count >= lis.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    else
                    {
                        var lisCnt = lis.Count();
                        var firsth = lis.Take(start).ToArray();
                        var last = lis.Skip(start + count).Reverse().ToArray();
                        lis = lis.Skip(start).Take(count).OrderBy(x => x).ToList();

                        for (int i = 0; i < firsth.Length; i++)
                        {
                            lis.Insert(i, firsth[i]);
                        }
                        lis.Reverse();
                        var result = lisCnt - lis.Count();

                        for (int i = 0; i < result; i++)
                        {
                            lis.Insert(i, last[i]);
                        }
                        lis.Reverse();
                    }

                }
                else if (command == "rollLeft")
                {
                    var counts = (int)(long.Parse(input[1]) % lis.Count);
                    if (counts < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    else
                    {

                        for (int i = 0; i < counts; i++)
                        {

                            var first = lis[0];
                            lis.RemoveAt(0);
                            lis.Insert(lis.Count, first);
                        }
                    }


                }
                else if (command == "rollRight")
                {
                    var counts = (int)(long.Parse(input[1]) % lis.Count);
                    if (counts < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = 0; i < counts; i++)
                        {
                            var first = lis[lis.Count - 1];
                            lis.RemoveAt(lis.Count - 1);
                            lis.Insert(0, first);
                        }
                    }
                }
            }
        }
    }
}
