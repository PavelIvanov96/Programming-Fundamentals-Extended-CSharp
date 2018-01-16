using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var intputNumbers = Console.ReadLine().Split(' ').Select(int.Parse);
            var command = Console.ReadLine().ToLower();
            var average = intputNumbers.Average();
            var listRes = new List<int>();

            foreach (var arr in intputNumbers.Where(x => x >= average))
            {
                listRes.Add(arr);
            }

            if (command == "min")
            {
                Console.WriteLine(listRes.Min());
            }
            else if (command == "max")
            {
                Console.WriteLine(listRes.Max());
            }
            else if (command == "all")
            {
                Console.WriteLine(string.Join(" ",listRes.OrderBy(x => x)));
            }
            
        }
    }
}
