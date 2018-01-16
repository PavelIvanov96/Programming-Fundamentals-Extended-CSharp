using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double nights = double.Parse(Console.ReadLine());

            var studio = 0.0;
            var doubles = 0.0;
            var suite = 0.0;
           

            if (month == "may" || month =="october")
            {
                
                if (nights > 7)
                {
                    studio = 50 * 0.95;
                }
                else
                {
                    studio = 50;
                }
                
                doubles = 65;
                suite = 75;
            }
            else if (month == "june" || month == "september")
            {
                
                if (nights > 14)
                {
                    doubles = 72 * 0.90;
                }
                  else
                {
                    doubles = 72;
                }
                
                studio = 60;
                suite = 82;
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                if (nights > 7)
                {
                    suite = 89 * 0.85;
                }
                else
                {
                    suite = 89;
                }
                studio = 68;
                doubles = 77;
            }
            
            
            doubles = doubles * nights;
            suite = suite * nights;

            if (nights > 7 && month == "september")
            {
                nights = nights - 1;
            }
           else if (nights > 7 && month == "october")
            {
                nights = nights - 1;
            }
            
            
                studio = studio * nights;
            
           
            Console.WriteLine("Studio: {0:f2} lv.",studio);
            Console.WriteLine("Double: {0:f2} lv.",doubles);
            Console.WriteLine("Suite: {0:f2} lv.",suite);
        }
    }
}
