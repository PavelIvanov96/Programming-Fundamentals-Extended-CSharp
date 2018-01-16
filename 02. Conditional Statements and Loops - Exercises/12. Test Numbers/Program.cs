using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            var count = 0;
            var sum = 0;
            var count2 = 0;

            for (int i = n; i >= 1 ; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    sum = sum + 3 * (i * k);
                    count++;
                    if (sum >= boundary)
                    {
                        
                        Console.WriteLine("{0} combinations",count );
                        Console.WriteLine("Sum: {0} >= {1}",sum,boundary);
                        return;
                    }
                    else
                    {
                        
                        if (i == 1 && k == m)
                        {
                            Console.WriteLine("{0} combinations", count );
                            Console.WriteLine("Sum: {0}", sum);
                            return;
                        }
                    }
                    
                    
                }
            }
        }
    }
}
