using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
             var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.None);
                if (input[0] == "end")
                {
                    break;
                }

             var words = input[0];
             var place = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < place.Length; i++)
                {

                    if (words.Contains($"{{{i}}}" ))
                    {
                        words = words.Replace($"{{{i}}}", place[i]);
                    } 
                }
                Console.WriteLine(words);
            }

        }
    }
}
