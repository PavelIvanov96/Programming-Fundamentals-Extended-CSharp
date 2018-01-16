using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Tesats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "13234";
            var word = "TO: ARCHER; MESSAGE: sneak around it;";
            var to = new string(word.ToCharArray());
            var boofer = new List<string>();

            while (true)
            {
                a += a;
                if (a.Length > to.Length)
                {
                    break;
                }
            }
            var concat = new string(a.ToCharArray());

            StringBuilder res = new StringBuilder();
            for (int i = 0; i < to.Length -1; i++)
            {
               var  cript =(char)((int)to[i] + int.Parse(concat[i].ToString()));
                Console.Write(cript);
            }
            Console.WriteLine();
        }
    }
}
