using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.REal
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var pattern = @"^(<\[[^a-zA-Z0-9]*\]\.{1}){1}(\.\[[a-zA-Z0-9]*\]\.{1})*$";
           
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Traincode!")
                {
                    break;
                }
                var isTrue = false;
                var result = Regex.Matches(input, pattern);
                foreach (var item in result)
                {
                    Console.Write(item.ToString().Trim());
                    isTrue = true;
                }
                if (isTrue)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
