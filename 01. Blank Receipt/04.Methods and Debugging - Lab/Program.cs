using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Methods_and_Debugging___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Head();
            Body();
            Footer();
        }        
        static void Head()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.Write("©");
            Console.WriteLine(" SoftUni");
        }
    }
}
