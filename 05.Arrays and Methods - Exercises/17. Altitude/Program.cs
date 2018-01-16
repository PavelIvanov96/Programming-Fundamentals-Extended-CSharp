using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').ToArray();

            var initialAltitude = double.Parse(value[0]);
            
            for (int i = 1; i < value.Count(); i+=2)
            {
                var command = value[i];
                var number = double.Parse(value[i + 1]);

                if (command == "up" )
                {
                    initialAltitude = initialAltitude + number;
                }
                else if (command == "down")
                {
                    initialAltitude = initialAltitude - number;
                }
                if (initialAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    break;
                }
            }
            if (initialAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", initialAltitude);
            }
            
        }
    }
}
