using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            List<int> asd = new List<int>();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < a; i++)
            {
                if (input.Contains(i))
                {
                    asd.Add(1);
                }
                else
                {
                    asd.Add(0);
                }
            }
            
            Console.WriteLine(string.Join(" ",asd));
        }
    }
}
