using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    count++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}",k,i,magicNumber);
                        return;
                    }
                    else
                    {
                        if (i == m && k == m)
                        {
                            Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
                            
                        }
                        
                    }
                }
            }
        }
    }
}
