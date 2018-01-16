using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            
            int sumMin = minutes + 30;
            var decreaseMin = sumMin - 60;
            var sumHour = 0.0;
            if (sumMin > 59 )
            {
                sumHour = hours + 1;
                
                if (sumHour > 23)
                {
                    Console.WriteLine("0:{0:d2}", decreaseMin);
                }
                else
                {
                    Console.WriteLine("{0}:{1:d2}", sumHour, decreaseMin);
                }
            }
          
            else
            {
                Console.WriteLine("{0}:{1:d2}",hours,sumMin);
            }
            
        }
    }
}
