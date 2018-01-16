using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var cordinates = Console.ReadLine().Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var commands = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
           
            var cordinatesY = 0.0;
            var cordinatesX = 0.0;
            var trueOrFalse = false;

            for (int i = 0; i < commands.Count(); i+= 2)
            {
                var direction = commands[i];
                var degrees = int.Parse(commands[i + 1]);
                

                if (direction == "up") 
                {
                    cordinatesY = cordinatesY + degrees;
                }
                else if (direction == "down") 
                {
                    cordinatesY =cordinatesY - degrees;
                }
                else if (direction == "left") 
                {
                    cordinatesX =cordinatesX - degrees;
                }
                else if (direction == "right")
                {
                    cordinatesX = cordinatesX + degrees;   
                }
                if (cordinatesX == cordinates[0] && cordinatesY == cordinates[1])
                {
                    Console.WriteLine("firing at [{0}, {1}]", cordinatesX, cordinatesY);
                    Console.WriteLine("got 'em!");
                    trueOrFalse = true;
                }
                
            }
            if (trueOrFalse == false)
            {
                Console.WriteLine("firing at [{0}, {1}]", cordinatesX, cordinatesY);
                Console.WriteLine("better luck next time...");
            }
            
        }
    }
}
