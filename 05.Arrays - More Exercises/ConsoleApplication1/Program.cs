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
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(i + " ");
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();


            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i % 3 == 0)
            //    {
            //        Console.Write(i);
            //    }
            //}
            List<int> test = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> newtest = new List<int>();
            if (newtest.Count == 0)
            {
                Console.WriteLine("emty");
            }
        }
    }
}
