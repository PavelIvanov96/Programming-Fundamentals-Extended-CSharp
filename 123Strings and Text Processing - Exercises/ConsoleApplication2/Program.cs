using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries);

            var letter = pattern[0];
            var cnt = int.Parse(pattern[1]);

            var result = input.IndexOf(letter);
            var count = 1;
            
             while (result != -1)
          {

                result = input.IndexOf(letter, result + 1);
                if (result == -1)
                {
                    break;
                }

                if (result >= 0)
                {
                    count++;
                }
                if (count >= cnt)
                {
                    Console.WriteLine(result);
                    break;
                }
                
          }
            if (count < cnt)
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}   
