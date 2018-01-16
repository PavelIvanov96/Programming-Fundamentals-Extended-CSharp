using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Select(i => (char)i).ToArray();
            var cases = Console.ReadLine().ToLower();

            var sum = 0;
            if (cases == "lowercase")
            {
                foreach (var item in text)
                {
                    if ((int)item >= 97 && (int)item <= 122)
                    {
                        sum += (int)item;
                    }
                }
            }
            if (cases == "uppercase")
            {
                foreach (var item in text)
                {
                    if (item >= 65 && item <= 90)
                    {
                        sum += (int)item;
                    }
                }
            }

            Console.WriteLine("The total sum is: {0}",sum);
        }
    }
}
