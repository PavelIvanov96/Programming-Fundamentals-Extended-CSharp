using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            ulong minNum = Math.Min(num1,num2);
            ulong maxNum = Math.Max(num1,num2);

            ulong overflowValue = 0;
            string smallerType = String.Empty;
            double digit = 0.0;

            if (byte.MaxValue >= maxNum && maxNum >= 0)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (ushort.MaxValue >= maxNum )
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (uint.MaxValue >= maxNum)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (ulong.MaxValue >= maxNum)
            {
                Console.WriteLine("bigger type: ulong");
            }
            if (minNum <= byte.MaxValue && minNum >= 0)
            {
                overflowValue = byte.MaxValue / minNum;
                digit = Math.Round(maxNum / (double)255);
                Console.WriteLine("smaller type: byte");
                Console.WriteLine("{0} can overflow byte {1} times",maxNum,digit);
            }
            else if (minNum <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue / minNum;
                digit = Math.Round(maxNum / (double)65535);
                Console.WriteLine("smaller type: ushort");
                Console.WriteLine("{0} can overflow ushort {1} times", maxNum,digit);
            }
            else if (minNum <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue / minNum;
                digit = Math.Round(maxNum / (double)4294967295);
                Console.WriteLine("smaller type: uint");
                Console.WriteLine("{0} can overflow byte {1} times", maxNum,digit);
            }
            else if (minNum <= ulong.MaxValue)
            {
                overflowValue = ulong.MaxValue / minNum;
                digit = Math.Round(maxNum / (double)18446744073709551615);
                Console.WriteLine("smaller type: ulong");
                Console.WriteLine("{0} can overflow byte {1} times", maxNum,digit);
            }
            
        }
    }
}
