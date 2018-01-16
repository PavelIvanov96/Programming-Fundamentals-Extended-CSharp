using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lis = new List<int> { 1 ,2 ,5 ,8 ,7 ,3 ,10, 6, 4 ,9 };
            //var res = lis.Take(3).OrderBy(x => x);
            //var first = lis.Take(2).ToArray();
            //var second = lis.Skip(2 + 4).Reverse().ToArray();
            //Console.WriteLine(string.Join(" ",first));
            //Console.WriteLine(string.Join(" ",second));
            //lis = lis.Skip(2).Take(4).Reverse().ToList();

            //for (int i = 0; i < first.Length; i++)
            //{
            //    lis.Insert(i, first[i]);
            //}
            //lis.Reverse();
            //for (int i = 0; i < 4; i++)
            //{
            //    lis.Insert(i, second[i]);
            //}
            //lis.Reverse();
            //Console.WriteLine(string.Join(" ",lis));

            var lis = new List<int> { 1, 2, 3, 4, 5 };
            var first = lis[0];
            var last = lis[lis.Count - 1];
            lis.RemoveAt(0);
            lis.Insert(0, last);
            lis.RemoveAt(lis.Count - 1);
            lis.Insert(lis.Count , first);

            Console.WriteLine(string.Join(" ",lis));
        

           

        }
    }
}
