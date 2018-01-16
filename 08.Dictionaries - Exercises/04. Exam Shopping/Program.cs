using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stocks = new Dictionary<string, int>();

            var input = Console.ReadLine()
                    .Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


            while (input[0] != "shopping" && input[1] != "time")
            {
                if (input.Equals("exam time"))
                {
                    break;
                }

                var product = input[1];
                int quantity = int.Parse(input[2]);

                if (!stocks.ContainsKey(product))
                {
                    stocks.Add(product, quantity);
                }
                else
                {
                    stocks[product] += quantity;

                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "exam")
            {
                var product = input[1];

                if (!stocks.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");

                    input = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    continue;
                }
                //int num = int.Parse(input[2]);
                //stocks[input[1]] = stocks[input[1]] - num;

                if (stocks.ContainsKey(product))
                {
                    if (product[1] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }

                    if (stocks[product] < 0)
                    {
                        stocks[product] = 0;
                    }
                    else
                    {
                        stocks[product] -= int.Parse(input[2]);
                    }
                }
                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            foreach (var kvp in stocks)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                if (value <= 0)
                {
                    continue;
                }
                Console.WriteLine($"{key} -> {value}");

            }
        }
    }
}
