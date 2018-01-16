using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());
            int pokePower = (N * 50) / 100;
            int count = 0;
            int n = N;

            while (true)
            {
                N = N - M;
                count++;
                if (pokePower == N)
                {
                    if (Y != 0 && Y != 1)
                    {
                        N = N / Y;
                        continue;
                    }
                    
                }
                
                if (N < M)
                {
                    break;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
