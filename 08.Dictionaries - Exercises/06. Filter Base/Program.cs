using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var dicInt = new Dictionary<string, int>();
            var dicDouble = new Dictionary<string, double>();
            var dicString = new Dictionary<string, string>();

            bool inputToInt = false;
            bool inputToDouble = false;

            while (true)
            {
               List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "filter" && input[1] == "base")
                {
                    break;
                }
                int nInt;  
                inputToInt = int.TryParse(input[2], out nInt);
                double nDouble;
                inputToDouble = double.TryParse(input[2], out nDouble);

                if (inputToInt == true)
                {
                    dicInt[input[0]] = nInt;
                }
                else if (inputToDouble == true)
                {
                    dicDouble[input[0]] = nDouble;
                }
                else
                {
                    dicString[input[0]] = input[2];
                }
                
            }
            var command = Console.ReadLine().ToLower();

            if (command == "salary")
            {
                foreach (var item in dicDouble)
                {
                    Console.WriteLine("Name: {0}",item.Key);
                    Console.WriteLine("Salary: {0:f2}",item.Value);
                    Console.WriteLine(new string('=',20));
                }
            }
            else if (command == "position")
            {
                foreach (var item in dicString)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Position: {0}", item.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (command == "age")
            {
                foreach (var item in dicInt)
                {
                    Console.WriteLine("Name: {0}", item.Key);
                    Console.WriteLine("Age: {0}", item.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
