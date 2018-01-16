using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">*<*\(+['\-x]>";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);

            var cnt = 0;
            foreach (Match item in matches)
            {
                var tail = 0;
                var body = 0;
                cnt++;

                var tailTypes = "";
                var bodyTypes = "";
                var status = "";
                Console.WriteLine("Fish {1}: {0}",item,cnt);
                foreach (char @char in item.ToString())
                {
                    if (@char == '>')
                    {
                        tail++;
                    }
                    else if (@char == '(')
                    {
                        body++;
                    }
                    else if (@char == '\'')
                    {
                        status = "Awake";
                    }
                    else if (@char == '-')
                    {
                        status = "Asleep";
                    }
                    else if (@char == 'x')
                    {
                        status = "Dead";
                    }
                }
                tail--;
                if (tail > 5)
                {
                    tailTypes = "Long";
                }
                else if (tail > 1)
                {
                    tailTypes = "Medium";
                }
                else if (tail == 1)
                {
                    tailTypes = "Short";
                }
                else
                {
                    tailTypes = "None";
                }
                if (body > 10)
                {
                    bodyTypes = "Long";
                }
                else if (body > 5)
                {
                    bodyTypes = "Medium";
                }
                else
                {
                    bodyTypes = "Short";
                }

                Console.Write("  Tail type: {0}",tailTypes);
                if (tail > 0)
                {
                    Console.WriteLine(" ({0} cm)",tail* 2);
                }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine("  Body type: {1} ({0} cm)",body * 2,bodyTypes);
                Console.WriteLine("  Status: {0}",status);
            }
            if (cnt == 0)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
