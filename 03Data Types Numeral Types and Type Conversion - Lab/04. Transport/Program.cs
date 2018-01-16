using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int courses = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}",(int)Math.Ceiling((double)courses / 24));
        }
    }
}
