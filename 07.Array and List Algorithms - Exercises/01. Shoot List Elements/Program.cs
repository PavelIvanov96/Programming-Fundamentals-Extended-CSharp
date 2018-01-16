using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> avarageList = new List<int>();
            int lastShotNumer = 0;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "bang")
                {

                    if (avarageList.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastShotNumer);
                        break;
                    }
                    double avarage = avarageList.Average();
                    for (int i = 0; i < avarageList.Count; i++)
                    {
                        if (avarageList[i] < avarage)
                        {
                            lastShotNumer = avarageList[i];
                            avarageList.RemoveAt(i);
                            Console.WriteLine("shot " + lastShotNumer);
                            break;
                        }
                        else if(avarageList.Count == 1)
                        {
                            lastShotNumer = avarageList[0];
                            avarageList.RemoveAt(0);
                            Console.WriteLine("shot " + lastShotNumer);
                            break;
                        }
                    }
                    for (int i = 0; i < avarageList.Count; i++)
                    {
                        avarageList[i]--;
                    }
                }
                else if (input == "stop")
                {
                    if (avarageList.Count == 0)
                    {
                        Console.WriteLine("you shot them all. last one was " + lastShotNumer);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}",string.Join(" ",avarageList));
                        break;
                    }
                }
                else
                {
                    int number = int.Parse(input);
                    avarageList.Insert( 0,number);
                }
            }
        }
    }
}
