using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            double price = 0.0;
            double leftMoney = balance;
            double totalSpent = 0.0;

            double priceRoverWatch = 29.99;
            double priceOutFall = 39.99;
            double priceCS = 15.99;
            double priceZplinterZell = 19.99;
            double priceHonored = 59.99;
            double priceRoverWatchOrigins = 39.99;

            
            while (true)
            {
               string gameName = Console.ReadLine();

                leftMoney = leftMoney - price;
                if (leftMoney <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                if (gameName == "OutFall 4")
                {

                    if (leftMoney < priceOutFall)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        price = priceOutFall;
                    }

                }
                else if (gameName == "CS: OG")
                {

                    if (leftMoney < priceCS)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        price = priceCS;
                    }
                }
                else if (gameName == "Zplinter Zell")
                {

                    ;
                    if (leftMoney >= priceZplinterZell)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        price = priceZplinterZell;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {


                    if (leftMoney < priceHonored)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        price = priceHonored;
                    }
                }
                else if (gameName == "RoverWatch")
                {


                    if (leftMoney >= priceRoverWatch)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        price = priceRoverWatch;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {


                    if (leftMoney < priceRoverWatchOrigins)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        price = priceRoverWatchOrigins;
                    }
                }
                else if (gameName == "Game Time")
                {
                    totalSpent = balance - leftMoney;
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalSpent, leftMoney);
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
               
            }
            
        }
    }
}
