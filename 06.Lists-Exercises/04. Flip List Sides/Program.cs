using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int firstIndex = numbs[0];
            int lastIndex = numbs[numbs.Count - 1];

            numbs.RemoveAt(0);
            numbs.RemoveAt(numbs.Count - 1);
            numbs.Reverse();

            Console.Write("{0} ",firstIndex);
            Console.Write(String.Join(" ",numbs));
            Console.Write(" {0}",lastIndex);
            Console.WriteLine();
        }
    }
}
