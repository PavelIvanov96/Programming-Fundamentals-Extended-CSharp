using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04__Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                var num = int.Parse(Console.ReadLine());
                var matches = regex.Match(input).Groups;

                var first = matches[1].Value;
                var middle = matches[2].Value;
                var second = matches[3].Value;
                var concat = first + second;
                if (middle.Length == num)
                {
                    StringBuilder result = new StringBuilder();
                    foreach (var item in concat)
                    {
                        if (char.IsDigit(item))
                        {
                            var cnt = int.Parse(item.ToString());
                            if (cnt < middle.Length)
                            {
                                result.Append(middle[cnt]);
                            }
                            else
                            {
                                result.Append(' ');
                            }
                        }
                    }
                    Console.WriteLine("{1} == {0}",result.ToString(),middle);
                }
            }
        }
    }
}
