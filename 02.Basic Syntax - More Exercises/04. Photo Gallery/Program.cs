using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int weigh = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            
            var type = "";
            if (weigh == height)
            {
                type = "square";
            }
            else if (weigh > height)
            {
                type = "landscape";
            }
            else
            {
                type = "portrait";
            }

            Console.WriteLine("Name: DSC_{0:d4}.jpg",photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d4} {3:d2}:{4:d2}",day,month,year,hours,minutes);
            if (size < 10000)
            {
                Console.WriteLine("Size: {0}B",size);
            }
            else if (size < 1000000)
            {
                size = size / 1000;
                Console.WriteLine("Size: {0}KB",size);
            }
            else  
            {
                size = size / 1000000;
                Console.WriteLine("Size: {0}MB", size);
            }
            Console.WriteLine("Resolution: {0}x{1} ({2})",weigh,height,type);

        }
    }
}
