using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (true)
            {
                string ingredient2 = Console.ReadLine();
                if (ingredient2 == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.",count);
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.",ingredient2);
                count++;
                
            }
        }
    }
}
