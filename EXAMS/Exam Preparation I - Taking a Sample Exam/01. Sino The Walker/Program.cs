using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timte = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture); 
            var steps = decimal.Parse(Console.ReadLine());
            var seconds = decimal.Parse(Console.ReadLine());

            var need = 60 * 60 * 24;
            var day = (int)(steps * seconds % need);
            var result =  timte.AddSeconds(day);

            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", result.Hour , result.Minute ,result.Second);
        }
    }
}
