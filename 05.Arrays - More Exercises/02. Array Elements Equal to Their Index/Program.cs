using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var readElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < readElements.Length; i++)
            {
                if (i == readElements[i])
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
