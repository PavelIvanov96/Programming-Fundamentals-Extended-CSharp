using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (profession == "Athlete")
            {
                price = 0.70 * quantity;
                Console.WriteLine("The {0} has to pay {1:f2}.",profession, price);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00 * quantity;
                Console.WriteLine("The {0} has to pay {1:f2}.",profession,price);
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70 * quantity;
                Console.WriteLine("The {0} has to pay {1:f2}.",profession,price);
            }
            else 
            {
                price = 1.20 * quantity;
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, price); ;
            }
        }
    }
}
