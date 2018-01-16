using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ').ToArray();

            var trueFalse = false;

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = value[i];
                //Console.WriteLine(value[i]);
                //Console.WriteLine(value[value.Length - 1 - i]);
                if (value[i] == value[value.Length - 1- i])
                {
                    trueFalse = true;
                }
                else
                {
                    trueFalse = false;
                    Console.WriteLine("No");
                    return;
                    
                }
            }
            if (trueFalse == true)
            {
                Console.WriteLine("Yes");
            }
            
        }
    }
}
