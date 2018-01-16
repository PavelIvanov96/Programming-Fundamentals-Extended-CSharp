using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            var price = 0.0;
            var pricePackage = 0.0;
            var totalPrice = 0.0;
            var discount = 0.0;
            var pricePerPerson = 0.0;
            if (packageType == "Normal")
            {
                pricePackage = 500;
                discount = 0.95;

                if (groupSize <= 50)
                {
                    price = 2500;
                }
                else if (groupSize <= 100)
                {
                    price = 5000;
                }
                else if (groupSize <= 120)
                {
                    price = 7500;
                }
            }
            else if (packageType == "Gold")
            {
                pricePackage = 750;
                discount = 0.90;

                if (groupSize <= 50)
                {
                    price = 2500;
                }
                else if (groupSize <= 100)
                {
                    price = 5000;
                }
                else if (groupSize <= 120)
                {
                    price = 7500;
                }
            }
            else if (packageType == "Platinum")
            {
                pricePackage = 1000;
                discount = 0.85;

                if (groupSize <= 50)
                {
                    price = 2500;
                }
                else if (groupSize <= 100)
                {
                    price = 5000;
                }
                else if (groupSize <= 120)
                {
                    price = 7500;
                }
            }
            totalPrice = (pricePackage + price) * discount;
            pricePerPerson = totalPrice / groupSize;
            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
            else if (groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
            else if (groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
