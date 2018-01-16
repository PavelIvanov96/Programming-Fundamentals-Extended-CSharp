using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitter = Console.ReadLine();

            var result = input.Split(new string[] { splitter }, StringSplitOptions.None);
            Console.WriteLine("[" + string.Join(", ",result) + "]");
        }
    }
}
