using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char magicChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char k = firstChar; k <= secondChar; k++)
                {
                    for (char g = firstChar; g <= secondChar; g++)
                    {
                        string word = "" + i + k + g;
                        if (!word.Contains(magicChar))
                        {
                            Console.Write(word + " ");
                        }
                        
                    }
                }
            }
        }
    }
}
