using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 2)
                {
                    Console.Write("a");
                }
                else if (number == 22)
                {
                    Console.Write("b");
                }
                else  
                {
                    Console.Write("c");
                }
                if (number == 3)
                {
                    Console.Write("d");
                }
                else if (number == 33)
                {
                    Console.Write("e");
                }
                else 
                {
                    Console.Write("f");
                }
                if (number == 4)
                {
                    Console.Write("g");
                }
                else if (number == 44)
                {
                    Console.Write("h");
                }
                else 
                {
                    Console.Write("i");
                }
                if (number == 5)
                {
                    Console.Write("j");
                }
                else if (number == 55)
                {
                    Console.Write("k");
                }
                else 
                {
                    Console.Write("l");
                }
                if (number == 6)
                {
                    Console.Write("m");
                }
                else if (number == 66)
                {
                    Console.Write("n");
                }
                else 
                {
                    Console.Write("o");
                }
                if (number == 7)
                {
                    Console.Write("p");
                }
                else if (number == 77)
                {
                    Console.Write("q");
                }
                else if (number == 777)
                {
                    Console.Write("r");
                }
                else 
                {
                    Console.Write("s");
                }
                if (number == 8)
                {
                    Console.Write("t");
                }
                else if (number == 8)
                {
                    Console.Write("u");
                }
                else 
                {
                    Console.Write("v");
                }
                if (number == 9)
                {
                    Console.Write("w");
                }
                else if (number == 99)
                {
                    Console.Write("x");
                }
                else if (number == 999)
                {
                    Console.Write("y");
                }
                else 
                {
                    Console.Write("z");
                }
                if (number == 0)
                {
                    Console.Write(" ");
                }
                else if (number == 00)
                {
                    Console.Write("  ");
                }
                else if (number == 000)
                {
                    Console.Write("   ");
                }
            }
        }
    }
}
