using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var counter = new Dictionary<char, int>();
            var inputTochar = input.ToCharArray();

            foreach (var item in inputTochar)
            {
                if (!counter.ContainsKey(item))
                {
                    counter[item] = 0;
                }
                counter[item]++;
            }
            foreach (var item in counter)
            {
                Console.WriteLine("{0} -> {1}", item.Key,item.Value);
            }
        }
    }
}
