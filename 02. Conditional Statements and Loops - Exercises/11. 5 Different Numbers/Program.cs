using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            if (numberTwo - numberOne < 4)
                Console.WriteLine("No");
            else
            {
                for (int firstN = numberOne; firstN <= numberTwo; firstN++)
                {
                    for (int secondN = numberOne; secondN <= numberTwo; secondN++)
                    {
                        for (int thirthN = numberOne; thirthN <= numberTwo; thirthN++)
                        {
                            for (int forthN = numberOne; forthN <= numberTwo; forthN++)
                            {
                                for (int fifthN = numberOne; fifthN <= numberTwo; fifthN++)
                                {
                                    if (numberOne <= firstN && firstN <= secondN && secondN <= thirthN && thirthN <= forthN && forthN <= fifthN && fifthN <= numberTwo && firstN != secondN && secondN != thirthN && thirthN != forthN && forthN != fifthN)
                                    {
                                        Console.WriteLine("{0} {1} {2} {3} {4}", firstN, secondN, thirthN, forthN, fifthN);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
