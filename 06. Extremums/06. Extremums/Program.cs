using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 255;
            //List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //sdstring command = Console.ReadLine();
            var last = 0;

            for (int i = 0; i < 3; i++)
            {
                last = input % 10;
                Console.WriteLine(last);
            }
        }
    }
}
