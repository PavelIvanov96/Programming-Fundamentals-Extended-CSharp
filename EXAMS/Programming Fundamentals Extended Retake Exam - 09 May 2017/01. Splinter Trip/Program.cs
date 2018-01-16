using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double fuelTank = double.Parse(Console.ReadLine());
            double windsDistance = double.Parse(Console.ReadLine());

            var milesNonWind = Math.Abs(distance - windsDistance);
            var milesNonWindRes = milesNonWind * 25;
            var milesWind = windsDistance * (25 * 1.5);
            var fuelConsumation = (milesNonWindRes + milesWind) * 1.05;
            var diff = fuelTank - fuelConsumation;

            Console.WriteLine("Fuel needed: {0:f2}L",fuelConsumation);
            if (diff >= 0)
            {
                Console.WriteLine("Enough with {0:f2}L to spare!",diff);
            }
            else
            {
                Console.WriteLine("We need {0:f2}L more fuel.",Math.Abs(diff));
            }
        }
    }
}
