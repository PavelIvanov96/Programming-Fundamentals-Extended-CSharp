using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().Split(' ').ToArray();
            var singleLetter = word.Where(s => s.Length == 1);
            int count = 0;
            foreach (var letter in singleLetter)
            {
                var chars = char.Parse(letter);

                if (chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}

