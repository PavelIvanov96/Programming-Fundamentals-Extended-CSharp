using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Methods___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
