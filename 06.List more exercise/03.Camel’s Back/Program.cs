using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cammelBack = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> cammelBackRemove = new List<int>();
            int cammelBackSize = int.Parse(Console.ReadLine());

            var diff = cammelBack.Count - cammelBackSize;
            var asd = cammelBack.Count - diff / 2;

            if (diff > 0)
            {
                for (int i = 0; i < cammelBack.Count ; i++)
               {
                var num = cammelBack[i];
                if (i >= diff / 2 && i < asd)
                {
                    cammelBackRemove.Add(cammelBack[i]);
                }
               }
                Console.WriteLine("{0} rounds",diff/2);
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", cammelBackRemove));
            }
            else
            {
                Console.WriteLine("already stable: {0}" ,string.Join(" ",cammelBack));
            }
        }
    }
}
