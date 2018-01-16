using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var firstNames = Console.ReadLine().Split(' ').ToArray();


            while (true)
            {
                string command = Console.ReadLine();

                for (int i = 0; i < firstNames.Length; i++)
                {
                    if (firstNames[i] == command)
                    {
                        Console.WriteLine("{0} -> {1}", firstNames[i], phoneNumbers[i]);
                        break;
                    }
                }
                if (command == "done")
                {
                    return;
                }
            }
        }
    }
}
