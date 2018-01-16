using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();


            int duration = int.Parse(Console.ReadLine());

            for (int i = 1; i <= duration; i++)
            {
                string characters = Console.ReadLine();
                Console.Write(characters);
                if (i <  duration)
                {
                    Console.Write(delimiter);
                }
            }
        }
    }
}
