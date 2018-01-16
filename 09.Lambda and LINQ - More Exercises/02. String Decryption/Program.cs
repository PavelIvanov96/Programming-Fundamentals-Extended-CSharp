using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var skipTakeElem = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var skip = skipTakeElem[0];
            var take = skipTakeElem[1];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var onlyCappLett = numbers.Where(x => x >= 65 && x <= 90);
            var printElements = onlyCappLett.Skip(skip).Take(take).Select(x => Convert.ToChar(x));
            Console.WriteLine(string.Join("", printElements));
        }
    }
}
