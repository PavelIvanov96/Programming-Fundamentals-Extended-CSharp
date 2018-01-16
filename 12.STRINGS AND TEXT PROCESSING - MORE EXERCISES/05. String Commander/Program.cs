using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Commander
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = "";
            while (true)
            {
                var commands = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "end") 
                {
                    break;
                }
                if (commands[0] == "Left")
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        result = input.Remove(0, 1).Insert(input.Length - 1, input.First().ToString());
                        input = result;
                    }
                }
                 else if (commands[0] == "Delete")
                {
                    result = input.Remove(int.Parse(commands[1]),int.Parse(commands[2]) + 1);
                    input = result;
                }
                else if (commands[0] == "Right")
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        result = input.Remove(input.Length - 1, 1).Insert(0, input.Last().ToString());
                        input = result;
                    }
                }
                else if (commands[0] == "Insert")
                {
                    result = input.Insert(int.Parse(commands[1]), commands[2]);
                    input = result;
                }
            }
            Console.WriteLine(input);
        }
    }
}
