using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_06
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string firstLine = Console.ReadLine();

                while (firstLine != "collapse")
                {
                    string secondLine = Console.ReadLine();

                    while (secondLine.Length > 0)
                    {
                        bool contains = firstLine.Contains(secondLine);

                        if (contains)
                        {
                            firstLine = firstLine.Replace(secondLine, "");
                            contains = false;
                        }
                        else
                        {
                            secondLine = secondLine.Remove(0, 1);
                            if (secondLine.Length > 0)
                            {
                                secondLine = secondLine.Remove((secondLine.Length - 1), 1);
                            }
                        }
                    }

                    if (firstLine.Length > 0)
                    {
                        Console.WriteLine(firstLine.Trim());
                    }
                    else
                    {
                        Console.WriteLine("(void)");
                    }


                    firstLine = Console.ReadLine();
                }
            }
        }
    }
}
