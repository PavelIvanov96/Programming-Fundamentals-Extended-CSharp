using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = decimal.Parse(Console.ReadLine());
            var sum = (decimal)0.0;
            for (int i = 0; i < count; i++)
            {
                var priceCapsule = decimal.Parse(Console.ReadLine());
                var data = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsules = decimal.Parse(Console.ReadLine());
                var dayInMont = DateTime.DaysInMonth(data.Year, data.Month);

                var price = (dayInMont * capsules) * priceCapsule;
                sum += price;
                Console.WriteLine("The price for the coffee is: ${0:f2}",price);
            }
            Console.WriteLine("Total: ${0:f2}",sum);
        }
    }
}
