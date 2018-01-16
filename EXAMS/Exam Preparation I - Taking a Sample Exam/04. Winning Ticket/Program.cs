using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',',}, StringSplitOptions.RemoveEmptyEntries).
                Select(x => x.Trim()).ToArray();

            foreach (var item in input)
            {
                var symbolCnt = 0;
                var chechCnt = 0;

                var symbol = 0;
                var chech = 0;

                var symb = "";
                if (item.Length == 20)
                {
                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        if (item[i] == '@')
                        {
                            symb = "@";
                            symbolCnt++;
                            chechCnt++;
                        }
                        else if (item[i] == '#')
                        {
                            symb = "#";
                            symbolCnt++;
                            chechCnt++;
                        }
                        else if (item[i] == '$')
                        {
                            symb = "$";
                            symbolCnt++;
                            chechCnt++;
                        }
                        else if (item[i] == '^')
                        {
                            symb = "^";
                            symbolCnt++;
                            chechCnt++;
                        }
                    }
                    for (int i = item.Length / 2 ; i < item.Length ; i++)
                    {
                        if (item[i] == '@')
                        {
                            symbol++;
                            chech++;
                        }
                        else if (item[i] == '#')
                        {
                            symbol++;
                            chech++;
                        }
                        else if (item[i] == '$')
                        {
                            symbol++;
                            chech++;
                        }
                        else if (item[i] == '^')
                        {
                            symbol++;
                            chech++;
                        }
                    }
                    if (symbolCnt == chechCnt && chech == symbol)
                    {
                        if (Math.Min(chech,chechCnt) == 10)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", item, Math.Max(chechCnt, chech), symb);
                        }
                        else if ((chechCnt >= 6) && (chech >= 6))
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", item, Math.Max(chechCnt, chech), symb);
                        }
                        else
                        {
                            Console.WriteLine("ticket \"{0}\" - no match",item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", item);
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}