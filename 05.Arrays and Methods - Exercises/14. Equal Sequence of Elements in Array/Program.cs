using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minimal = int.MinValue;
            
            for (int i = 0; i < nums.Length - 1 ; i++)
            {
                nums[i] = nums[i];
                if (nums[i] >= minimal)
                {
                    minimal = nums[i];
                    if (i == nums.Length - 2)
                    {
                        Console.WriteLine("Yes");
                    }
                    
                }
                else
                {
                    if (i == nums.Length - 2)
                    {
                        Console.WriteLine("No");
                    }
                }
            }

        }
    }
}
