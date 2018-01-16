using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var ladybugsIndexs = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x > 0 && x < size);
            List<int> field = new List<int>();

            for (int i = 0; i < size; i++)
            {
                if (ladybugsIndexs.Contains(i))
                {
                    field.Add(1);
                }
                else
                {
                    field.Add(0);
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split(' ');

                if (command[0] == "end")
                {
                    break;
                }
               // Console.WriteLine(string.Join(" ", field));
                var index = int.Parse(command[0]);
                var flylength = int.Parse(command[0]);

                if (command[1] == "right")
                {
                    for (int i = 0; i < field.Count; i++)
                    {
                        field[flylength] = 1;
                        field[index] = 0;
                    }
                }
                if (command[1] == "left")
                {
                    for (int i = 0; i < field.Count; i++)
                    {
                        if (flylength >= 0)
                        {
                            field[index -  flylength + 1 ] = 1;
                        }
                        else
                        {
                            field[Math.Abs(flylength)] = 1;
                        }
                        
                        field[index] = 0;
                    }
                    //Console.WriteLine(string.Join(" ",field));
                }
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
