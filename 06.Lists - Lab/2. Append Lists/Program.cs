using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
             List<string> reverse = new List<string>();

            for (int i = input.Count -1; i >= 0; i--)
            {
               string result = input[i].Trim();
               
                reverse = result.Split(' ').ToList();
                
                for (int k = 0; k < reverse.Count ; k++)
                {
                     Console.Write("{0} ",reverse[k]);
                }
            }
            Console.WriteLine();
        }
    }
}
