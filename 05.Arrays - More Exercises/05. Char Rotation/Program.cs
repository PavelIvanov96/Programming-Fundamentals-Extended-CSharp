using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = Console.ReadLine().ToCharArray();
            var numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < characters.Length; i++)
            {
                
                if (numbs[i] % 2 == 0)
                {
                    int n = Math.Abs(numbs[i] - characters[i]);
                    Console.Write((char)n);
                }
                else
                {
                    int n = numbs[i] + characters[i];
                    Console.Write((char)n);
                }
            }
        }
    }
}
