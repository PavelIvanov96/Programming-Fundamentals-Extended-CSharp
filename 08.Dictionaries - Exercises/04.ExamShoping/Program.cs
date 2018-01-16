using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShoping
{
    class Program
    {
        static void Main(string[] args)
        {
            var dicResult = new Dictionary<string, int>();
            var inputList = Console.ReadLine().
                Split(new char[] { (' ') },StringSplitOptions.RemoveEmptyEntries).
                ToList();

            while (inputList[0] != "shopping" && inputList[1] != "time")
            {
                if (inputList[0] == "exam" && inputList[1] == "time")
                {
                    break;
                }
                if (inputList[0] == "stock")
                {
                    var stringToInt = int.Parse(inputList[2]);
                    var keyInput = inputList[1];
                    if (dicResult.ContainsKey(keyInput))
                    {
                        dicResult[keyInput] += stringToInt ;
                    }
                    else
                    {
                        dicResult[keyInput] = stringToInt;
                    }
                }
                inputList = Console.ReadLine().
                Split(new char[] { (' ') }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
            }
          //  foreach (var item in dicResult)
          //  {
          //      Console.WriteLine("{0}, {1}",item.Key,item.Value);
          //  }

            inputList = Console.ReadLine().
                Split(new char[] { (' ') }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
            var newDic = new Dictionary<string, int>();

            while (inputList[0] != "exam" && inputList[1] != "time")
            {
                if (inputList[0] == "buy")
                {
                    var intToString = int.Parse(inputList[2]);
                    var inputKey = inputList[1];
                    if (dicResult.ContainsKey(inputList[1]))
                    {
                        if (dicResult[inputKey] <= 0)
                        {
                            Console.WriteLine("{0} out of stock",inputList[1]);
                        }
                        else
                        {
                            dicResult[inputKey] -= intToString;
                        }
                        
                    }
                    else if(!dicResult.ContainsKey(inputList[1]))
                    {
                        Console.WriteLine("{0} doesn't exist",inputList[1]);
                    }
                }

                inputList = Console.ReadLine().
                Split(new char[] { (' ') }, StringSplitOptions.RemoveEmptyEntries).
                ToList();
            }
            foreach (var  item in dicResult)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
                else
                {

                }
            }
        }
    }
}
