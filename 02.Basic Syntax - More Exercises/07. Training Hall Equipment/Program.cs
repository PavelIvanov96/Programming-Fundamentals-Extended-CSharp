using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            var check = false;

            var subtotal = budget;
            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                itemPrice = itemPrice * itemCount;
                subtotal = subtotal - itemPrice;
                if (itemCount > 1)
                {
                    if (itemName.EndsWith("y"))
                    {
                        itemName = itemName.Remove(itemName.Length - 1);
                        Console.WriteLine("Adding {0} {1}ies to cart.", itemCount, itemName);
                    }
                    else if (itemName.EndsWith("o") || itemName.EndsWith("ch")|| itemName.EndsWith("s")|| itemName.EndsWith("sh")|| itemName.EndsWith("x")|| itemName.EndsWith("z"))
                    {
                        Console.WriteLine("Adding {0} {1}es to cart.", itemCount, itemName);
                    }
                    else
                    {
                        Console.WriteLine("Adding {0} {1}s to cart.", itemCount, itemName);
                    }
                }
                else
                {
                    Console.WriteLine("Adding {0} {1} to cart.",itemCount,itemName);
                }
                

            }
            Console.WriteLine("Subtotal: ${0:f2}",budget - subtotal);
            if (subtotal < 0)
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.",Math.Abs(subtotal));
            }
            else
            {
                Console.WriteLine("Money left: ${0:F2}",subtotal);
            }
            
        }
    }
}
