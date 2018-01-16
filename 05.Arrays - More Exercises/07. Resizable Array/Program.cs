using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                
                if (command[0] == "push")
                {
                    var newInt = int.Parse(command[1]);
                    numbers.Add(newInt);
                }
                else if (command[0] == "removeAt")
                {
                    var newInt = int.Parse(command[1]);
                    numbers.RemoveAt(newInt);
                }
                else if (command[0] == "pop")
                {
                    numbers.Remove(numbers.Last());
                }
                else if (command[0] == "clear")
                {
                    numbers.Clear();
                    
                }
                else if (command[0] == "end")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("empty array");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(String.Join(" ", numbers));
                        return;
                    }
                }
            }
        }
    }
}
