using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputDoubleList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> powerPerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double hours = double.Parse(Console.ReadLine());

            var multiplyPower = 0.0;
            var diff = 0.0;
            var procent = 0.0;

            for (int i = 0; i < inputDoubleList.Count; i++)
            {

                multiplyPower = inputDoubleList[i] - (hours * powerPerHour[i]);
                
                if (multiplyPower < 0)
                {
                    diff = Math.Ceiling(inputDoubleList[i] / powerPerHour[i]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)",i + 1, diff);
                }
                else
                {
                    procent = multiplyPower * 100 / inputDoubleList[i];
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, multiplyPower,procent);
                }
            }
        }
    }
}
