using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').ToArray();
            double multyNum = double.Parse(Console.ReadLine());

            double[] arr = new double[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                arr[i] = double.Parse(num[i]);
            }
            for (int i = 0; i < num.Length; i++)
            {
                arr[i] *=  multyNum;
                Console.Write(arr[i] + " ");
            }
        }
    }
}
