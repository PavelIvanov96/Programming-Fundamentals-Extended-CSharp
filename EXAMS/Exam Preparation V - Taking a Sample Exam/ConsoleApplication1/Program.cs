using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var listPrivate = new List<int>();

            var message = new List<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Hornet is Green")
                {
                    break;
                }

                var first = input[0];
                var second = input[1];

                if (first.All(char.IsDigit) && second.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(first.ToCharArray().Reverse().ToArray());

                    message.Add($"{reversed} -> {second}");
                }
                else if (first.All(c => !char.IsDigit(c) && second.All(char.IsDigit)))
                {
                    string reversedC = ReversedCaases(second);
                }
                
            }
            Console.WriteLine("Messages:");
            Console.Write(string.Join("\r\n",listPrivate));
        }

        private static string ReversedCaases(string second)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < second.Length; i++)
            {
                if (char.IsUpper(second[i]))
                {
                    result.Append(char.ToLower(second[i]));
                }
                else if (char.IsLower(second[i]))
                {
                    result.Append(char.ToLower(second[i]));
                }
                else
                {
                    result.Append(second[i]);
                }
            }
            return result.ToString();
        }
    }
}
