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
            List<string> inputNumbers = Console.ReadLine().Split(' ').ToList();

            List<string> newList = new List<string>();
            newList = inputNumbers.Distinct().ToList();
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
