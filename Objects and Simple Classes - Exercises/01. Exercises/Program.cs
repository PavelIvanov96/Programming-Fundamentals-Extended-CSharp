using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "go go go")
                {
                    break;
                }

                var topic = input[0];
                var courseName = input[1];
                var judgeContestLink = input[2];
                var problems = input[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var problem in problems)
                {

                }
                Console.WriteLine();
            }
        }
        class Exercises
        {
            public string topics { get; set; }
            public string courseName { get; set; }
            public string judge { get; set; }
            public List<string> problems { get; set; }
        }
    }
}
