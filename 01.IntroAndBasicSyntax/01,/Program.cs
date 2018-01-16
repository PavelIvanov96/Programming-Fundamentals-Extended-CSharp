using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHelth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string ('|', currentHelth));
            Console.Write(new string ('.',maxHealth - currentHelth ));
            Console.WriteLine("|");
            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string ('|', currentEnergy));
            Console.Write(new string ('.', maxEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
