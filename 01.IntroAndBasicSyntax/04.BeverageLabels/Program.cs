using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BaverageLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double sumKcal = (double)volume * energyContent / 100;
            double sumSugarG = (double)volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{sumKcal}kcal, {sumSugarG}g sugars");
        }
    }
}
