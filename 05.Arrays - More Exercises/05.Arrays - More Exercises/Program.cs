using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Arrays___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var readArr = Console.ReadLine().Split(' ').ToArray();


            for (int i = readArr.Length - 1; i > 0; i--)
            {
                if (readArr[i] == readArr[i - 1])
                {
                    {
                        if (readArr[i - 1] == readArr[i - 2])
                        {
                            Console.WriteLine("{0} {1} {2}", readArr[i], readArr[i], readArr[i]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
