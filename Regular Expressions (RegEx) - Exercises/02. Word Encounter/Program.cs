using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = Console.ReadLine();
            var regex = @"(?<!.)[A-Z](.*)[.!?](?!.)";
            var result = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                var isMatch = Regex.IsMatch(input, regex);
                if (input == "end")
                {
                    break;
                }
                if (isMatch)
                {
                    var matches = Regex.Matches(input, @"\w+");

                    var simvol = token[0];
                    var cnt = int.Parse(token[1].ToString());

                    foreach (Match item in matches)
                    {
                      var cntSimvol = 0;

                        foreach (var @char in item.ToString())
                        {
                            if (@char == simvol)
                            {
                                cntSimvol++;
                            }
                        }
                        if (cntSimvol >= cnt)
                        {
                            result.Add(item.ToString());
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
