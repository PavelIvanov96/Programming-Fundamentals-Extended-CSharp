using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double length = double.Parse(Console.ReadLine());
           double width = double.Parse(Console.ReadLine());
           double  heigth = double.Parse(Console.ReadLine());
             Console.Write("Length: ");
             Console.Write("Width: ");
             Console.Write("Height: ");

            double  volume = (length * width * heigth) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
