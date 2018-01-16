using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int lengthTrack = int.Parse(Console.ReadLine());
            int trackCapicity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            var runners = 0; ;
            if (trackCapicity * lengthDays >= numberOfRunners)
            {
                runners = numberOfRunners;
            }
            else
            {
                runners = trackCapicity * lengthDays;
            }

            var totalMetar = (double)runners * averageLaps * lengthTrack;
            var totalKm = totalMetar / 1000.00;
            var moneyRaised = moneyPerKilometer;
            var result = totalKm * moneyRaised;

            Console.WriteLine("Money raised: {0:f2}",result);

        }
    }
}
