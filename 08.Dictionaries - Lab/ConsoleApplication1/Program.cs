using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] wordsInput = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!words.ContainsKey(wordsInput[i]))
                {
                    words.Add(wordsInput[i], 0);
                }
                words[wordsInput[i]]++;
            }
            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> item in words)
            {

            }   
        }
    }
}
