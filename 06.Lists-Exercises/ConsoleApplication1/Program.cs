using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < words.Count; i+= 2)
            {
                Console.Write(words[i]);
            }
            Console.WriteLine();
        }
    }
}
