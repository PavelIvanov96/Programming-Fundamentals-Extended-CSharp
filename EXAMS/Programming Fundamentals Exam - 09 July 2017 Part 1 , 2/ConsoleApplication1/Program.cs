using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asd = new List<int> { 4 , 5, 3 };
            asd.RemoveAt(1);
            //var b = 5;
            for (int i = 0; i < asd.Count; i++)
            {
                if (asd[i] > 5)
                {
                    var diff = asd[i] - 5;
                    asd.RemoveAt(i);
                    asd.Add(diff);
                }
                else
                {
                    var sum = asd[i] + 5;
                    asd.RemoveAt(i);
                    asd.Insert(i, sum);
                }
            }
            for (int i = 0; i < asd.Count; i++)
            {
                if (asd[i] > 8)
                {
                    var diff = asd[i] - 8;
                    asd.RemoveAt(i);
                    asd.Add(diff);
                }
                else
                {
                    var sum = asd[i] + 8;
                    asd.RemoveAt(i);
                    asd.Insert(i, sum);
                }
            }

            Console.WriteLine(string.Join(" ",asd));
        
        }
    }
}
