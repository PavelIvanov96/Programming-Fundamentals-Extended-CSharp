using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            uint length = uint.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());

            var sm = length * 100;
            if (sm % width == 0 || width == 0)
            {
                Console.WriteLine("{0:f2}",sm * width);
            }
            else
            {
                Console.WriteLine("{0:f2}%",sm / width * 100);
            }
        }
    }
}
