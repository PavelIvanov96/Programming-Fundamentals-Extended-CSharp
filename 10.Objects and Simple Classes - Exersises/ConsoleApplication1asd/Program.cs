using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1asd
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivan = new Pesho();
            ivan.Gosho = "pesh";
            var go = new Pesho();
            go.Gosho = "ivan";

            Console.WriteLine(go.Gosho);
        }
    }
    class Pesho
    {
        public string Gosho { get; set; }
    }
}
