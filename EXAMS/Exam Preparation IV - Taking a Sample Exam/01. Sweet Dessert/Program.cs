using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());
            var priceBananas = decimal.Parse(Console.ReadLine());
            var priceEggs = decimal.Parse(Console.ReadLine());
            var priceBerries = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(numberOfGuests / (decimal)6);
            var multypli = portions * (2 * priceBananas) + portions * (4 * priceEggs) + portions *((decimal)0.2 * priceBerries);

            if (multypli <= budget)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",multypli);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",multypli - budget);
            }
        }
    }
}
