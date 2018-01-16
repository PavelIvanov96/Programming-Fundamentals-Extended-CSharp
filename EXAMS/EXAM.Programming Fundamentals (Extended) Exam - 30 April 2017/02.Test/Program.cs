using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Test
{
    class Program
    {
        



        static void Main(string[] args)
        {

            string words = "downloaded gasdasdaseqweqweasd";
            var te = "downloaded";
            if (words.Contains(te))
            {
                words = words.Replace(te , "bbbbbbbb");
            }
            Console.WriteLine(words);
            
        }
    }
}
