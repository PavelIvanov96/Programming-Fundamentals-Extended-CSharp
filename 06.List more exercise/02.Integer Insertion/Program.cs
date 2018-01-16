using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> numbers = Console.ReadLine().Split(' ').ToList();
                var input = 0 ;
                var num = 0;
                if (numbers[0] == "end")
                {
                    break;
                }
                else
                {
                    input = int.Parse(numbers[0]);
                    num = int.Parse(numbers[0]);
                    for (int i = 0; i < numbers[0].Length -1; i++)
                    {
                        input /= 10;
                    }
                    numberList.Insert(input,num);
                }
            }
            Console.WriteLine(string.Join(" ",numberList));
        }
    }
}
