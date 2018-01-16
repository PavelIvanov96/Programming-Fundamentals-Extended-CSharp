using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var minValue = int.MinValue;
            

            for (int i = 0; i < count; i++)
            {
                var n = int.Parse(Console.ReadLine());
                if (n >= minValue)
                {
                    minValue = n;
                }

            }
            Console.WriteLine(minValue);
        }
    }
}
